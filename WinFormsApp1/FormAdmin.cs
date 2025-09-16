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

                dataGridViewPedidos.DataSource = dt;
            }

            dataGridViewPedidos.Columns["PedidoId"].HeaderText = "ID";
            dataGridViewPedidos.Columns["Cliente"].Width = 200;
            dataGridViewPedidos.Columns["Email"].Width = 200;
            dataGridViewPedidos.Columns["Status"].Width = 150;
            dataGridViewPedidos.Columns["DataPedido"].Width = 180;
            dataGridViewPedidos.Columns["Endereco"].Width = 180;
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

        private void buttonAtualizar_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewPedidos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um pedido.");
                return;
            }

            int pedidoId = (int)dataGridViewPedidos.SelectedRows[0].Cells["PedidoId"].Value;
            string novoStatus = comboBoxStatus.SelectedItem?.ToString();
            string emailCliente = dataGridViewPedidos.SelectedRows[0].Cells["Email"].Value.ToString();
            string nomeCliente = dataGridViewPedidos.SelectedRows[0].Cells["Cliente"].Value.ToString();

            if (string.IsNullOrEmpty(novoStatus))
            {
                MessageBox.Show("Selecione um status.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "UPDATE Pedidos SET Status = @Status WHERE PedidoId = @PedidoId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Status", novoStatus);
                cmd.Parameters.AddWithValue("@PedidoId", pedidoId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Status atualizado!");
            CarregarPedidos();
            if (string.IsNullOrWhiteSpace(emailCliente) || !emailCliente.Contains("@"))
            {
                MessageBox.Show("E-mail do cliente inválido.");
                return;
            }
            if (novoStatus == "Saiu para entrega")
            {
                if (!string.IsNullOrWhiteSpace(emailCliente) && emailCliente.Contains("@"))
                {
                    EnviarEmail(emailCliente, $"Olá {nomeCliente}, seu pedido saiu para entrega 🚚");
                }
            }
            else if (novoStatus == "Entregue")
            {
                if (!string.IsNullOrWhiteSpace(emailCliente) && emailCliente.Contains("@"))
                {
                    EnviarEmail(emailCliente, $"Olá {nomeCliente}, seu pedido já foi entregue 📦");
                }
            }
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
    }
}


