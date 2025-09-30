
using BCrypt.Net;
using System.Data.SqlClient;

using System;
using System.Windows.Forms;
using WinFormsApp1;


namespace styleinbanknotes
{
    public partial class telacc : Form
    {
        public telacc()
        {
            InitializeComponent();
        }

        string connectionString = "Server=sqlexpress;Database=cj3022129pr2;User Id=aluno;Password=aluno;";

        private void telacc_Load(object sender, EventArgs e)
        {
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text.Trim();
            if (email == "adm" || senha == "adm") {
                MessageBox.Show("Bem vindo adm!");
                adm frm = new adm();
                frm.ShowDialog();
                this.Close();

            }
            else if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    string hashDoBanco = null;


                    int codCliente = 0;
                    string nomeUsuario = "";
                    string emailUsuario = "";

                    string sqlQuery = "SELECT cod_cliente, Nome, Email, Senha FROM cadastro WHERE Email = @Email";
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, cnn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                codCliente = (int)reader["cod_cliente"];
                                nomeUsuario = reader["Nome"].ToString();
                                emailUsuario = reader["Email"].ToString();
                                hashDoBanco = reader["Senha"].ToString();
                            }
                        }
                    }


                    if (hashDoBanco == null)
                    {
                        MessageBox.Show("Email ou senha inválidos.");
                        return;
                    }


                    bool senhaCorreta = BCrypt.Net.BCrypt.Verify(senha, hashDoBanco);

                    if (senhaCorreta)
                    {


                        UsuarioLogado.CodCliente = codCliente;
                        UsuarioLogado.Nome = nomeUsuario;
                        UsuarioLogado.Email = emailUsuario;

                        MessageBox.Show("Login realizado com sucesso!");

                        TelaPrincipal frm = new TelaPrincipal();
                        this.Visible = false;
                        frm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Email ou senha inválidos.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao conectar com o banco de dados: " + ex.Message);
                }
            }
        }
        private void mostrar_Click(object sender, EventArgs e)
        {
            ocultar.BringToFront();
            txtSenha.PasswordChar = '\0';
        }

        private void ocultar_Click(object sender, EventArgs e)
        {
            mostrar.BringToFront();
            txtSenha.PasswordChar = '*';
        }

        private void ptbx(object sender, EventArgs e)
        {
            Telalogin frm = new Telalogin();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }
        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            FormRecuperarSenha frm = new FormRecuperarSenha();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            adm frm = new adm();
            frm.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}