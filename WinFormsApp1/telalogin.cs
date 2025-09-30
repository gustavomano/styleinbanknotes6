using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BCrypt.Net;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using WinFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using styleinbanknotes;

namespace WinFormsApp1
{
    public partial class Telalogin : Form
    {
        public Telalogin()
        {
            InitializeComponent();
        }

        string connectionString = "Server=sqlexpress;Database=cj3022129pr2;User Id=aluno;Password=aluno;";

        private void CadastrarUsuario()
        {
            string nome = txtNome.Text.Trim();
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text.Trim();


            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }


            DialogResult result = MessageBox.Show("Confirma os dados digitados?\n\nNome: " + nome + "\nEmail: " + email,
                                                "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                MessageBox.Show("Cadastro cancelado.");
                return;
            }


            string senhaComHash = BCrypt.Net.BCrypt.HashPassword(senha);

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
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

                        cmdInsert.Parameters.AddWithValue("@Senha", senhaComHash);

                        int linhasAfetadas = cmdInsert.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Cadastro realizado com sucesso!");
                            txtNome.Clear();
                            txtEmail.Clear();
                            txtSenha.Clear();


                            telacc frm = new telacc();
                            this.Close();
                            frm.ShowDialog();

                        }
                        else
                        {
                            MessageBox.Show("Erro ao cadastrar.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarUsuario();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CadastrarUsuario();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            telacc frm = new telacc();

            frm.ShowDialog();
            frm.Close();

        }
        private void Telalogin_Load(object sender, EventArgs e) { }
        private void txbsenha_TextChanged(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void txtSenha_TextChanged(object sender, EventArgs e) { }
    }
}