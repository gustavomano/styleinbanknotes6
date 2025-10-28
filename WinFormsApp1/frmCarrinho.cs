using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace styleinbanknotes
{
    public partial class frmCarrinho : Form
    {
        // Use apenas uma string de conexão
        private readonly string connString = "Data Source=sqlexpress;Database=cj3022129pr2;User Id=aluno;Password=aluno;";
        private List<ItemCarrinho> itensNoCarrinho;

        // Construtor padrão (NECESSÁRIO para o Designer)
        public frmCarrinho()
        {
            InitializeComponent();
            // Inicializa a lista para o designer não travar
            this.itensNoCarrinho = new List<ItemCarrinho>();
        }

        // Seu construtor que recebe os itens
        public frmCarrinho(List<ItemCarrinho> carrinho)
        {
            InitializeComponent();
            this.itensNoCarrinho = carrinho;
        }

        private void FormCarrinho_Load(object sender, EventArgs e)
        {
            dgvCarrinho.AutoGenerateColumns = false; // Isso está CORRETO
            AtualizarGridECalcularTotal();
        }

        private void AtualizarGridECalcularTotal()
        {
            dgvCarrinho.DataSource = null;
            if (itensNoCarrinho != null && itensNoCarrinho.Any())
            {
                dgvCarrinho.DataSource = itensNoCarrinho;
            }

            // Calcula o total usando LINQ (mais limpo)
            decimal total = itensNoCarrinho?.Sum(item => item.Subtotal) ?? 0;

            // TODO: Descomente esta linha quando você tiver um Label chamado lblValorTotal
            // lblValorTotal.Text = $"Total: {total:C}";
        }

        private void dgvCarrinho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o clique foi em uma linha válida E na coluna "colRemover"
            if (e.RowIndex >= 0 && dgvCarrinho.Columns[e.ColumnIndex].Name == "colRemover")
            {
                // Pega o item diretamente da lista, que é mais seguro
                var itemParaRemover = itensNoCarrinho[e.RowIndex];

                if (itemParaRemover != null)
                {
                    itensNoCarrinho.Remove(itemParaRemover);
                    AtualizarGridECalcularTotal(); // Atualiza a tela
                }
            }
        }

        // Botão Voltar (pictureBox4)
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Apenas fecha este formulário. Não crie uma nova TelaPrincipal.
            this.Close();
        }

        // Botão Finalizar Pedido (button1)
        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Verificação inicial: o carrinho não pode estar vazio
            if (itensNoCarrinho == null || !itensNoCarrinho.Any())
            {
                MessageBox.Show("Seu carrinho está vazio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Para a execução
            }

            // 2. Verificar se o cliente tem endereço cadastrado
            if (!VerificarEnderecoCliente())
            {
                MessageBox.Show("Por favor, cadastre seu endereço antes de finalizar o pedido.", "Endereço Pendente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormAtualizarEndereco frmEndereco = new FormAtualizarEndereco();
                frmEndereco.ShowDialog();
                // Para a execução. O usuário deve tentar finalizar novamente após cadastrar.
                return;
            }

            // 3. Se tudo estiver OK, prossegue para salvar o pedido
            SalvarPedido();
        }

        private bool VerificarEnderecoCliente()
        {
            // TODO: Verifique se o nome da sua tabela é "cadastro" ou "Clientes"
            string query = "SELECT endereco FROM cadastro WHERE cod_cliente = @id";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", UsuarioLogado.CodCliente);
                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    // Retorna true se o endereço existir e não for vazio
                    return result != null && result != DBNull.Value && !string.IsNullOrWhiteSpace(result.ToString());
                }
            }
        }

        private void SalvarPedido()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction(); // Inicia a transação

                try
                {
                    // Etapa A: Inserir o pedido principal e obter o ID gerado
                    // TODO: Verifique se sua tabela Pedidos tem a coluna DataPedido
                    string sqlPedido = "INSERT INTO Pedidos (cod_cliente, Status, DataPedido) OUTPUT INSERTED.PedidoId VALUES (@cod_cliente, 'Em preparação', GETDATE());";
                    SqlCommand cmdPedido = new SqlCommand(sqlPedido, conn, tran);
                    cmdPedido.Parameters.AddWithValue("@cod_cliente", UsuarioLogado.CodCliente);
                    int pedidoId = (int)cmdPedido.ExecuteScalar();

                    // Etapa B: Iterar sobre a LISTA de itens (e não sobre o DataGridView)
                    foreach (var item in itensNoCarrinho)
                    {
                        string sqlItem = "INSERT INTO ItensPedido (PedidoId, Produto, Quantidade, PrecoUnitario) VALUES (@PedidoId, @Produto, @Quantidade, @PrecoUnitario);";

                        SqlCommand cmdItem = new SqlCommand(sqlItem, conn, tran);
                        cmdItem.Parameters.AddWithValue("@PedidoId", pedidoId);
                        cmdItem.Parameters.AddWithValue("@Produto", item.Nome);       // Envia o Nome para a coluna "Produto"
                        cmdItem.Parameters.AddWithValue("@Quantidade", item.Quantidade); // Envia a Quantidade para a coluna "Quantidade"
                        cmdItem.Parameters.AddWithValue("@PrecoUnitario", item.PrecoUnitario);
                        cmdItem.ExecuteNonQuery();
                      

                        string sqlEstoque = "UPDATE Produtos SET Estoque = Estoque - @Quantidade WHERE Id = @Id;";
                        SqlCommand cmdEstoque = new SqlCommand(sqlEstoque, conn, tran);
                        cmdEstoque.Parameters.AddWithValue("@Quantidade", item.Quantidade);
                        cmdEstoque.Parameters.AddWithValue("@Id", item.IdProduto);
                        cmdEstoque.ExecuteNonQuery();
                    }
                

                    tran.Commit();
                    MessageBox.Show("Pedido finalizado com sucesso! ID do Pedido: " + pedidoId, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    itensNoCarrinho.Clear(); // Limpa o carrinho
                    AtualizarGridECalcularTotal(); // Atualiza a tela
                    this.Close(); // Fecha o formulário do carrinho
                }
                catch (Exception ex)
                {
                    // Se algo deu errado, desfaz tudo
                    tran.Rollback();
                    // Linha corrigida:
                    MessageBox.Show("Erro ao salvar pedido: " + ex.Message, "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}