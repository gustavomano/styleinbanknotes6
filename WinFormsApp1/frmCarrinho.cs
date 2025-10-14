using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace styleinbanknotes
{


    public partial class frmCarrinho : Form
    {
        public frmCarrinho(List<ItemCarrinho> carrinho)
        {
            InitializeComponent();
            this.itensNoCarrinho = carrinho;
        }
        private List<ItemCarrinho> itensNoCarrinho;
        string connectionString = "Server=sqlexpress;Database=cj3022129pr2;User Id=aluno;Password=aluno;";
        string connString = "Data Source=sqlexpress;Database=cj3022129pr2;User Id=aluno;Password=aluno;";
        
        private void FormCarrinho_Load(object sender, EventArgs e)
        {
            dgvCarrinho.AutoGenerateColumns = false;
            AtualizarGridECalcularTotal();
        }
       
        private void AtualizarGridECalcularTotal()
        {
            // Limpa o grid e o preenche novamente com os dados atualizados
            dgvCarrinho.DataSource = null;
            dgvCarrinho.DataSource = itensNoCarrinho;

            // Calcula o valor total
            decimal total = 0;
            foreach (var item in itensNoCarrinho)
            {
                total += item.Subtotal;
            }

            // Atualiza o Label do valor total
           // lblValorTotal.Text = $"Total: {total:C}"; // O formato "C" é para moeda (R$)
        }
        private void dgvCarrinho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o clique foi na coluna de botão "Remover"
            // (Supondo que o nome da sua coluna de botão é 'colRemover')
            if (e.ColumnIndex == dgvCarrinho.Columns["colRemover"].Index && e.RowIndex >= 0)
            {
                // Pega o ID do produto da linha que foi clicada
                int idProdutoParaRemover = (int)dgvCarrinho.Rows[e.RowIndex].Cells["colIdProduto"].Value;

                // Encontra e remove o item da lista
                var itemParaRemover = itensNoCarrinho.FirstOrDefault(item => item.IdProduto == idProdutoParaRemover);
                if (itemParaRemover != null)
                {
                    itensNoCarrinho.Remove(itemParaRemover);
                    AtualizarGridECalcularTotal(); // Atualiza a tela
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            TelaPrincipal frm = new TelaPrincipal();
            this.Visible = false;
            frm.ShowDialog();
            frm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = @"SELECT endereco, num, bairro, cep, cidad, sigla_estado 
                 FROM cadastro 
                 WHERE cod_cliente = @id";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", UsuarioLogado.CodCliente);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {

                        if (reader["endereco"] == DBNull.Value || string.IsNullOrWhiteSpace(reader["endereco"].ToString()))
                        {

                            FormAtualizarEndereco frmEndereco = new FormAtualizarEndereco();
                            frmEndereco.ShowDialog();
                        }
                        else
                        {

                        }
                    }
                }
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {

                    string sqlPedido = "INSERT INTO Pedidos (cod_cliente, Status) OUTPUT INSERTED.PedidoId VALUES (@cod_cliente, 'Em preparação')";
                    SqlCommand cmdPedido = new SqlCommand(sqlPedido, conn, tran);


                    cmdPedido.Parameters.AddWithValue("@cod_cliente", UsuarioLogado.CodCliente);

                    int pedidoId = (int)cmdPedido.ExecuteScalar();

                    foreach (DataGridViewRow row in dgvCarrinho.SelectedRows)
                    {
                        int produtoId = (int)row.Cells["Id"].Value;
                        string nome = row.Cells["Nome"].Value.ToString();
                        decimal preco = (decimal)row.Cells["Preco"].Value;

                        string sqlItem = "INSERT INTO ItensPedido (PedidoId, Produto, Quantidade) VALUES (@PedidoId, @Produto, 1)";
                        SqlCommand cmdItem = new SqlCommand(sqlItem, conn, tran);
                        cmdItem.Parameters.AddWithValue("@PedidoId", pedidoId);
                        cmdItem.Parameters.AddWithValue("@Produto", nome);
                        cmdItem.ExecuteNonQuery();

                        string sqlEstoque = "UPDATE Produtos SET Estoque = Estoque - 1 WHERE Id = @Id";
                        SqlCommand cmdEstoque = new SqlCommand(sqlEstoque, conn, tran);
                        cmdEstoque.Parameters.AddWithValue("@Id", produtoId);
                        cmdEstoque.ExecuteNonQuery();
                    }

                    tran.Commit();
                    MessageBox.Show("Pedido finalizado com sucesso!");
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Erro ao salvar pedido: " + ex.Message);
                }
            }
        }
    }
}


