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
using QuestPDF.Infrastructure;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using BCrypt.Net;

namespace styleinbanknotes
{


    public partial class frmcliente : Form
    {
        public frmcliente()
        {
            InitializeComponent();
        }
        string connectionString = "Server=sqlexpress;Database=cj3022129pr2;User Id=aluno;Password=aluno;";
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imagens|*.jpg;*.png;*.jpeg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picFotoPerfil.Image = System.Drawing.Image.FromFile(ofd.FileName);
            }
        }
        public bool SalvarFotoPerfilNoBanco(int codCliente, byte[] fotoEmBytes)
        {
            string query = "UPDATE cadastro SET FotoPerfil = @foto WHERE cod_cliente = @id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Se o array de bytes for nulo, precisamos enviar DBNull.Value para o banco
                    // para que a coluna fique efetivamente nula.
                    if (fotoEmBytes == null)
                    {
                        cmd.Parameters.AddWithValue("@foto", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@foto", fotoEmBytes);
                    }

                    cmd.Parameters.AddWithValue("@id", codCliente);

                    try
                    {
                        conn.Open();
                        // ExecuteNonQuery é usado para comandos que não retornam resultados (UPDATE, INSERT, DELETE)
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; // Retorna true se pelo menos uma linha foi afetada
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao salvar a foto no banco de dados: " + ex.Message);
                        return false;
                    }
                }
            }
        }
        public DataTable ObterHistoricoDeComprasDoBanco(int codCliente)
        {
            // Cria um DataTable vazio para guardar os resultados
            DataTable dt = new DataTable();

            // TODO: Adapte esta query para a sua estrutura de tabelas e colunas.
            // - Selecione o ID da compra (sua chave primária).
            // - A data da compra.
            // - O valor total.
            // - Ordene por data para mostrar as mais recentes primeiro (ORDER BY ... DESC).
            string query = @"
        SELECT 
            PedidoId, 
            DataCompra, 
            ValorTotal 
        FROM Compras 
        WHERE CodCliente = @id 
        ORDER BY DataCompra DESC";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", codCliente);

                    try
                    {
                        conn.Open();

                        // SqlDataAdapter é a ferramenta perfeita para preencher um DataTable
                        // a partir de uma consulta SQL.
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt); // Preenche o nosso DataTable 'dt' com os resultados da query
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao buscar o histórico de compras: " + ex.Message);
                    }
                }
            }

            return dt; // Retorna o DataTable preenchido (ou vazio se não houver compras)
        }
        private void CarregarDadosPessoais()
        {
            try
            {
                // Preenche os campos de texto com os dados do usuário logado
                txtNome.Text = UsuarioLogado.Nome;
                txtEmail.Text = UsuarioLogado.Email;

                // *** AQUI É A MUDANÇA IMPORTANTE ***
                // Agora nós apenas CHAMAMOS o outro método para buscar a foto
                byte[] fotoEmBytes = ObterFotoPerfilDoBanco(UsuarioLogado.CodCliente);

                // Converte os bytes recebidos em uma imagem
                System.Drawing.Image foto = BytesParaImagem(fotoEmBytes);

                // Exibe a imagem no PictureBox
                if (foto != null)
                {
                    picFotoPerfil.Image = foto;
                }
                else
                {
                    // Se não houver foto, usa a imagem padrão dos Recursos.
                    picFotoPerfil.Image = Properties.Resources.avatar_padrao;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados do perfil: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public byte[] ObterFotoPerfilDoBanco(int codCliente)
        {
            byte[] fotoEmBytes = null;
            string query = "SELECT FotoPerfil FROM cadastro WHERE cod_cliente = @id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", codCliente);
                    try
                    {
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            fotoEmBytes = (byte[])result;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao buscar a foto no banco de dados: " + ex.Message);
                    }
                }
            }
            return fotoEmBytes;
        }
        private System.Drawing.Image BytesParaImagem(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0)
                return null;

            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return System.Drawing.Image.FromStream(ms);
            }
        }
        private void CarregarHistoricoCompras()
        {
            DataTable dt = new DataTable();
            // Esta query busca todos os pedidos do cliente e já calcula o valor total
            // somando os itens de cada pedido.
            string query = @"
        SELECT 
            p.PedidoId, 
            p.DataPedido, 
            p.Status,
            SUM(ip.Quantidade * ip.PrecoUnitario) AS ValorTotal
        FROM 
            Pedidos p
        JOIN 
            ItensPedido ip ON p.PedidoId = ip.PedidoId
        WHERE 
            p.cod_cliente = @id
        GROUP BY 
            p.PedidoId, p.DataPedido, p.Status
        ORDER BY 
            p.DataPedido DESC";

            using (SqlConnection conn = new SqlConnection(connectionString)) // Use sua string de conexão
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", UsuarioLogado.CodCliente);
                    try
                    {
                        conn.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);
                        dgvHistorico.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao carregar histórico: " + ex.Message);
                    }
                }
            }
        }




        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvHistorico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmcliente_Load(object sender, EventArgs e)
        {
            CarregarHistoricoCompras();
            // Define a licença do QuestPDF
            QuestPDF.Settings.License = LicenseType.Community;

            // Verifica se há um usuário logado antes de carregar os dados
            if (UsuarioLogado.CodCliente == 0) // Assumindo que 0 significa que ninguém está logado
            {
                MessageBox.Show("Nenhum usuário logado. Por favor, faça login.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Fecha o formulário se não houver usuário logado
                return;
            }

            CarregarDadosPessoais();
            CarregarHistoricoCompras();
        }
        public bool AtualizarDadosCliente(int codCliente, string novoNome, string novoEmail)
        {

            string query = "UPDATE cadastro SET Nome = @nome, Email = @email WHERE cod_cliente = @id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@nome", novoNome);
                    cmd.Parameters.AddWithValue("@email", novoEmail);
                    cmd.Parameters.AddWithValue("@id", codCliente);

                    try
                    {

                        conn.Open();


                        int rowsAffected = cmd.ExecuteNonQuery();


                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao atualizar os dados no banco: " + ex.Message);
                        return false;
                    }
                }
            }
        }
        private byte[] ImagemParaBytes(System.Drawing.Image imagem)
        {
            // Se a imagem for nula, retorna nulo.
            if (imagem == null)
            {
                return null;
            }

            // Se a imagem for a padrão dos recursos, não salvamos ela de volta no banco.
            // Isso evita que a foto padrão seja salva para cada usuário que não tem foto.
            if (imagem == Properties.Resources.avatar_padrao)
            {
                return null;
            }

            // Usa um MemoryStream para salvar a imagem em memória e depois pegar os bytes.
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                // Salva a imagem no stream. Usamos o formato PNG por ser um bom padrão sem perdas.
                imagem.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        private void btnSalvarDados_Click(object sender, EventArgs e)
        {

            // Validações básicas
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Nome e E-mail não podem estar vazios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Pega os novos dados dos TextBoxes
            string novoNome = txtNome.Text;
            string novoEmail = txtEmail.Text;

            // Chama a função de UPDATE que criamos
            bool sucessoDados = AtualizarDadosCliente(UsuarioLogado.CodCliente, novoNome, novoEmail);

            // Converte e salva a foto (usando a função que já tínhamos)
            byte[] novaFotoEmBytes = ImagemParaBytes(picFotoPerfil.Image);
            bool sucessoFoto = SalvarFotoPerfilNoBanco(UsuarioLogado.CodCliente, novaFotoEmBytes);

            // Dá um feedback para o usuário
            if (sucessoDados || sucessoFoto)
            {
                // Atualiza os dados na classe estática para refletir a mudança imediatamente
                UsuarioLogado.Nome = novoNome;
                UsuarioLogado.Email = novoEmail;

                MessageBox.Show("Dados atualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Este 'else' pode ser ativado se não houve erro, mas nada mudou (ex: os dados eram os mesmos).
                // Você pode ajustar a lógica se precisar de uma mensagem de erro mais específica.
                MessageBox.Show("Nenhuma alteração foi salva.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnGerarPDF_Click(object sender, EventArgs e)
        {
            if (dgvHistorico.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecione um pedido na lista para gerar o recibo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 2. Pega o ID do pedido selecionado
            int pedidoId = Convert.ToInt32(dgvHistorico.CurrentRow.Cells["PedidoId"].Value);

            // 3. Pergunta onde salvar o arquivo
            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "Arquivo PDF (*.pdf)|*.pdf",
                FileName = $"Recibo_Pedido_{pedidoId}.pdf",
                Title = "Salvar Recibo em PDF"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // 4. Busca os dados completos do pedido
                    var dadosRecibo = BuscarDadosCompletosPedido(pedidoId);

                    // 5. Gera o documento PDF
                    Document.Create(container =>
                    {
                        container.Page(page =>
                        {
                            page.Size(PageSizes.A4);
                            page.Margin(2, Unit.Centimetre);
                            page.DefaultTextStyle(x => x.FontSize(12).FontFamily("Arial"));

                            // Cabeçalho
                            page.Header()
                                .AlignCenter()
                                .Text($"Recibo do Pedido Nº {pedidoId}")
                                .SemiBold().FontSize(20).FontColor(Colors.Grey.Darken3);

                            // Conteúdo
                            page.Content()
                                .PaddingVertical(1, Unit.Centimetre)
                                .Column(col =>
                                {
                                    col.Spacing(20);

                                    // Dados do Cliente e Pedido
                                    col.Item().Row(row =>
                                    {
                                        row.RelativeItem().Column(c =>
                                        {
                                            c.Item().Text("Dados do Cliente").SemiBold();
                                            c.Item().Text(dadosRecibo.NomeCliente);
                                            c.Item().Text(dadosRecibo.EmailCliente);
                                            c.Item().Text(dadosRecibo.EnderecoCliente);
                                        });
                                        row.RelativeItem().Column(c =>
                                        {
                                            c.Item().AlignRight().Text("Data do Pedido").SemiBold();
                                            c.Item().AlignRight().Text($"{dadosRecibo.DataPedido:dd/MM/yyyy}");
                                            c.Item().AlignRight().Text("Status").SemiBold();
                                            c.Item().AlignRight().Text(dadosRecibo.Status);
                                        });
                                    });

                                    // Linha divisória
                                    col.Item().LineHorizontal(1).LineColor(Colors.Grey.Lighten2);

                                    // Tabela de Itens
                                    col.Item().Table(table =>
                                    {
                                        table.ColumnsDefinition(columns =>
                                        {
                                            columns.RelativeColumn(3); // Nome do produto
                                            columns.RelativeColumn(1); // Qtd
                                            columns.RelativeColumn(1); // Preço Unit.
                                            columns.RelativeColumn(1); // Subtotal
                                        });

                                        table.Header(header =>
                                        {
                                            header.Cell().Background(Colors.Grey.Lighten3).Padding(5).Text("Produto");
                                            header.Cell().Background(Colors.Grey.Lighten3).Padding(5).AlignCenter().Text("Qtd.");
                                            header.Cell().Background(Colors.Grey.Lighten3).Padding(5).AlignRight().Text("Preço Unit.");
                                            header.Cell().Background(Colors.Grey.Lighten3).Padding(5).AlignRight().Text("Subtotal");
                                        });

                                        foreach (var item in dadosRecibo.Itens)
                                        {

                                            table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten3).Padding(5).Text(item.NomeProduto);
                                            table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten3).Padding(5).AlignCenter().Text(item.Quantidade.ToString());
                                            table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten3).Padding(5).AlignRight().Text($"{item.PrecoUnitario:C}");
                                            table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten3).Padding(5).AlignRight().Text($"{item.Subtotal:C}");
                                        }
                                    });

                                    // Total
                                    col.Item().AlignRight().PaddingTop(10).Text($"Valor Total: {dadosRecibo.ValorTotal:C}").SemiBold().FontSize(16);
                                });

                            // Rodapé
                            page.Footer()
                                .AlignCenter()
                                .Text("Este não é um documento fiscal. Válido apenas como comprovante.");
                        });
                    })
                    .GeneratePdf(saveDialog.FileName); // Salva o arquivo

                    MessageBox.Show("Recibo em PDF gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao gerar PDF: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public class ItemRecibo
        {
            public string NomeProduto { get; set; }
            public int Quantidade { get; set; }
            public decimal PrecoUnitario { get; set; }
            public decimal Subtotal => Quantidade * PrecoUnitario;
        }

        // Armazena todos os dados do recibo
        public class DadosRecibo
        {
            public int PedidoId { get; set; }
            public DateTime DataPedido { get; set; }
            public string Status { get; set; }
            public string NomeCliente { get; set; }
            public string EmailCliente { get; set; }
            public string EnderecoCliente { get; set; }
            public List<ItemRecibo> Itens { get; set; } = new List<ItemRecibo>();
            public decimal ValorTotal => Itens.Sum(item => item.Subtotal);
        }

        // Função que busca TODOS os dados de um pedido no banco
        private DadosRecibo BuscarDadosCompletosPedido(int pedidoId)
        {
            var recibo = new DadosRecibo();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Query 1: Busca dados do Pedido e do Cliente
                string queryPedido = @"
            SELECT 
                p.PedidoId, p.DataPedido, p.Status,
                c.Nome, c.Email, 
                c.endereco + ', ' + c.num + ' - ' + c.bairro + ', ' + c.cidad + ' - ' + c.sigla_estado AS Endereco
            FROM Pedidos p
            JOIN cadastro c ON p.cod_cliente = c.cod_cliente
            WHERE p.PedidoId = @id";

                using (SqlCommand cmd = new SqlCommand(queryPedido, conn))
                {
                    cmd.Parameters.AddWithValue("@id", pedidoId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            recibo.PedidoId = (int)reader["PedidoId"];
                            recibo.DataPedido = (DateTime)reader["DataPedido"];
                            recibo.Status = reader["Status"].ToString();
                            recibo.NomeCliente = reader["Nome"].ToString();
                            recibo.EmailCliente = reader["Email"].ToString();
                            // Verifica se o endereço é nulo para não dar erro
                            recibo.EnderecoCliente = reader["Endereco"] == DBNull.Value ? "Endereço não cadastrado" : reader["Endereco"].ToString();
                        }
                    }
                }

                // Query 2: Busca os Itens do Pedido
                string queryItens = @"
            SELECT 
                Produto, Quantidade, PrecoUnitario 
            FROM ItensPedido 
            WHERE PedidoId = @id";

                using (SqlCommand cmdItens = new SqlCommand(queryItens, conn))
                {
                    cmdItens.Parameters.AddWithValue("@id", pedidoId);
                    using (SqlDataReader reader = cmdItens.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // --- AQUI ESTÁ A CORREÇÃO PRINCIPAL ---
                            // Verificamos se os valores são DBNull antes de convertê-los
                            recibo.Itens.Add(new ItemRecibo
                            {
                                NomeProduto = reader["Produto"] == DBNull.Value ? "Produto indisponível" : reader["Produto"].ToString(),
                                Quantidade = reader["Quantidade"] == DBNull.Value ? 0 : (int)reader["Quantidade"],
                                PrecoUnitario = reader["PrecoUnitario"] == DBNull.Value ? 0m : (decimal)reader["PrecoUnitario"]
                            });
                        }
                    }
                }
            }
            return recibo;
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSenhaAtual.Text) ||
        string.IsNullOrWhiteSpace(txtNovaSenha.Text) ||
        string.IsNullOrWhiteSpace(txtConfirmarSenha.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNovaSenha.Text != txtConfirmarSenha.Text)
            {
                MessageBox.Show("A nova senha e a confirmação não são iguais.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string hashSenhaAtualDoBanco = "";
                // 2. Busca o hash da senha atual no banco de dados
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // TODO: Confirme se o nome da sua coluna de senha é 'Senha'
                    string query = "SELECT Senha FROM cadastro WHERE cod_cliente = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", UsuarioLogado.CodCliente);
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            hashSenhaAtualDoBanco = result.ToString();
                        }
                    }
                }

                // 3. Verifica se a senha atual informada está correta
                if (string.IsNullOrEmpty(hashSenhaAtualDoBanco) || !BCrypt.Net.BCrypt.Verify(txtSenhaAtual.Text, hashSenhaAtualDoBanco))
                {
                    MessageBox.Show("A senha atual informada está incorreta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 4. Se chegou aqui, a senha atual está correta. Gera o novo hash.
                string novoHash = BCrypt.Net.BCrypt.HashPassword(txtNovaSenha.Text);
                // 5. Salva o novo hash no banco
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE cadastro SET Senha = @novoHash WHERE cod_cliente = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@novoHash", novoHash);
                        cmd.Parameters.AddWithValue("@id", UsuarioLogado.CodCliente);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Senha alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpa os campos
                txtSenhaAtual.Clear();
                txtNovaSenha.Clear();
                txtConfirmarSenha.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar a senha: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}






