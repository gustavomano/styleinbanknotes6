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
            try
            {
                // TODO: Substitua esta simulação pela sua busca real no banco de dados, usando UsuarioLogado.CodCliente
                // Exemplo: var historico = seuRepositorioDeCompras.ListarPorCliente(UsuarioLogado.CodCliente);
                var historico = new[] {
                new { CompraId = 101, Data = new DateTime(2025, 10, 1), ValorTotal = 150.75m },
                new { CompraId = 105, Data = new DateTime(2025, 10, 5), ValorTotal = 89.90m },
                new { CompraId = 112, Data = new DateTime(2025, 10, 7), ValorTotal = 240.00m }
            }.ToList();

                dgvHistorico.DataSource = historico;
                dgvHistorico.Columns["CompraId"].HeaderText = "ID da Compra";
                dgvHistorico.Columns["Data"].HeaderText = "Data";
                dgvHistorico.Columns["ValorTotal"].HeaderText = "Valor Total";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar histórico de compras: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}



