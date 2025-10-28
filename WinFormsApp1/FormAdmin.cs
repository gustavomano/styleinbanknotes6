using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace styleinbanknotes
{
    public partial class FormAdmin : Form
    {
        string connectionString = "Server=sqlexpress;Database=cj3022129pr2;User Id=aluno;Password=aluno;";

        public FormAdmin()
        {
            InitializeComponent();
            CarregarPedidos();
            comboBoxStatus.Items.Add("Em preparação");
            comboBoxStatus.Items.Add("Saiu para entrega");
            comboBoxStatus.Items.Add("Entregue");
        }

        private void CarregarPedidos()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"SELECT p.PedidoId, c.Nome AS Cliente, c.Email, p.Status, p.DataPedido, c.Endereco
                               FROM Pedidos p
                               INNER JOIN cadastro c ON p.cod_cliente = c.cod_cliente";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvPedidos.DataSource = dt;
            }

            dgvPedidos.Columns["PedidoId"].HeaderText = "ID";
            dgvPedidos.Columns["Cliente"].Width = 200;
            dgvPedidos.Columns["Email"].Width = 200;
            dgvPedidos.Columns["Status"].Width = 150;
            dgvPedidos.Columns["DataPedido"].Width = 180;
            dgvPedidos.Columns["Endereco"].Width = 180;
        }

        private void EnviarEmail(string destinatario, string mensagem)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("guhalves552266@gmail.com");
                mail.To.Add(destinatario);
                mail.Subject = "Atualização do pedido";
                mail.Body = mensagem;


                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("guhalves552266@gmail.com", "spnb pgti eboz quuq");
                smtp.EnableSsl = true;

                smtp.Send(mail);

                MessageBox.Show("E-mail enviado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar e-mail: " + ex.Message);
            }
        }

        private async void buttonAtualizar_Click_1(object sender, EventArgs e)
        {
            if (dgvPedidos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um pedido.");
                return;
            }

            DataGridViewRow linhaSelecionada = dgvPedidos.SelectedRows[0];
            int pedidoId = (int)linhaSelecionada.Cells["PedidoId"].Value;
            string novoStatus = comboBoxStatus.SelectedItem?.ToString();
            string emailCliente = linhaSelecionada.Cells["Email"].Value.ToString();
            string nomeCliente = linhaSelecionada.Cells["Cliente"].Value.ToString();

            if (string.IsNullOrEmpty(novoStatus))
            {
                MessageBox.Show("Selecione um status.");
                return;
            }

            // --- 2. Atualização do Banco de Dados ---
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "UPDATE Pedidos SET Status = @Status WHERE PedidoId = @PedidoId";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Status", novoStatus);
                    cmd.Parameters.AddWithValue("@PedidoId", pedidoId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o banco de dados: " + ex.Message);
                return;
            }

            // --- 3. Envio do E-mail ---
            bool emailFoiEnviado = false; // Controla se o e-mail foi enviado
            if (string.IsNullOrWhiteSpace(emailCliente) || !emailCliente.Contains("@"))
            {
                MessageBox.Show("Status atualizado no banco, mas o e-mail do cliente é INVÁLIDO. E-mail não enviado.");
            }
            else
            {
                string assunto = "";
                string corpo = "";

                if (novoStatus == "Saiu para entrega")
                {
                    assunto = "Seu pedido saiu para entrega 🚚";
                    corpo = $"Olá {nomeCliente},\n\nBoas notícias! Seu pedido nº {pedidoId} da StyleInBanknotes saiu para entrega e deve chegar em breve!";
                }
                else if (novoStatus == "Entregue")
                {
                    assunto = "Seu pedido foi entregue 📦";
                    corpo = $"Olá {nomeCliente},\n\nSeu pedido nº {pedidoId} da StyleInBanknotes foi entregue. Esperamos que você goste!";
                }

                if (!string.IsNullOrEmpty(assunto))
                {
                    EmailService emailService = new EmailService();

                    // *** MUDANÇA AQUI ***
                    // Agora recebemos a tupla (enviado, erroMsg)
                    var (enviado, erroMsg) = await emailService.EnviarEmailAsync(emailCliente, assunto, corpo);
                    emailFoiEnviado = enviado; // Armazena o resultado

                    if (!enviado)
                    {
                        // *** MUDANÇA AQUI ***
                        // Exibe a MENSAGEM DE ERRO REAL que veio do SmtpClient
                        MessageBox.Show("Status atualizado, mas houve uma falha ao enviar o e-mail:\n\n" + erroMsg, "Erro de E-mail");
                    }
                }
            }

            // --- 4. Finalização ---
            if (emailFoiEnviado)
            {
                MessageBox.Show("Status atualizado e e-mail enviado com sucesso!");
            }
            else
            {
                MessageBox.Show("Status atualizado com sucesso (e-mail não enviado).");
            }
            CarregarPedidos(); // Recarrega o grid
        }
        private void dataGridViewPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewPedidos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CarregarItensDoPedido(int idDoPedido)
        {
            // Query para buscar os itens da tabela ItensPedido
            string query = @"
        SELECT 
            Produto, 
            Quantidade 
        FROM 
            ItensPedido 
        WHERE 
            PedidoId = @id";

            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idDoPedido);

                    try
                    {
                        conn.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao carregar itens do pedido: " + ex.Message);
                    }
                }
            }

            dgvItensPedido.DataSource = dt;
        }
        private void dgvPedidos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentRow != null)
            {
                int pedidoId = Convert.ToInt32(dgvPedidos.CurrentRow.Cells["PedidoId"].Value);
               
                CarregarItensDoPedido(pedidoId);
            }
        }
    }
}


