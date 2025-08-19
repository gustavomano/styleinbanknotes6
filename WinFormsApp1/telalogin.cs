using styleinbanknotes;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Telalogin : Form
    {

        public Telalogin()
        {
            InitializeComponent();
        }
        string connectionString = "Server=sqlexpress;Database=cj3022129pr2;User Id=aluno;Password=aluno;";

        private void Telalogin_Load(object sender, EventArgs e)
        {

        }
        private void txbsenha_TextChanged(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Nome: " + txtNome.Text + "\n" + "Email: " + txtEmail.Text + "\n" + "Senha: " + txtSenha.Text + "\n", "Atenção, confirma os dados digitados?",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            string nome = txtNome.Text.Trim();
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();

                string sqlVerifica = "SELECT COUNT(*) FROM cadastro WHERE Email = @Email";

                using (SqlCommand cmdVerifica = new SqlCommand(sqlVerifica, cnn))
                {
                    cmdVerifica.Parameters.AddWithValue("@Email", email);
                    int count = (int)cmdVerifica.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Já existe um cadastro com esse email.");
                        return;
                    }
                }

                string sqlInsert = "INSERT INTO cadastro (Nome, Email, Senha) VALUES (@Nome, @Email, @Senha)";

                using (SqlCommand cmdInsert = new SqlCommand(sqlInsert, cnn))
                {
                    cmdInsert.Parameters.AddWithValue("@Nome", nome);
                    cmdInsert.Parameters.AddWithValue("@Email", email);
                    cmdInsert.Parameters.AddWithValue("@Senha", senha);

                    int linhasAfetadas = cmdInsert.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Cadastro realizado com sucesso!");
                    
                        Cliente cliente = new Cliente();
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtSenha.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar.");
                    }
                }
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Conta criada com sucesso!");
              
                    TelaPrincipal frm = new TelaPrincipal();
                    this.Visible = false;
                    frm.ShowDialog();
                    this.Visible = true;
                }
            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Nome: " + txtNome.Text + "\n" + "Email: " + txtEmail.Text + "\n" + "Senha: " + txtSenha.Text + "\n", "Atenção, confirma os dados digitados?",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            string nome = txtNome.Text.Trim();
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text.Trim();

           
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();

               
                string sqlVerifica = "SELECT COUNT(*) FROM cadastro WHERE Email = @Email";

                using (SqlCommand cmdVerifica = new SqlCommand(sqlVerifica, cnn))
                {
                    cmdVerifica.Parameters.AddWithValue("@Email", email);
                    int count = (int)cmdVerifica.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Já existe um cadastro com esse email.");
                        return;
                    }
                }

             
                string sqlInsert = "INSERT INTO cadastro (Nome, Email, Senha) VALUES (@Nome, @Email, @Senha)";

                using (SqlCommand cmdInsert = new SqlCommand(sqlInsert, cnn))
                {
                    cmdInsert.Parameters.AddWithValue("@Nome", nome);
                    cmdInsert.Parameters.AddWithValue("@Email", email);
                    cmdInsert.Parameters.AddWithValue("@Senha", senha);

                    int linhasAfetadas = cmdInsert.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Cadastro realizado com sucesso!");
                       
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtSenha.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar.");
                    }
                }
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Conta criada com sucesso!");
                   
                    TelaPrincipal frm = new TelaPrincipal();
                    this.Visible = false;
                    frm.ShowDialog();
                    this.Visible = true;
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            telacc frm = new telacc();
            this.Visible = false;
            frm.ShowDialog();
            frm.Close();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}