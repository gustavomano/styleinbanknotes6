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
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using WinFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


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
            try
            {
                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=sqlexpress;Initial Catalog=cj3022129pr2;User ID=aluno;Password=aluno";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                MessageBox.Show("Connection Open !");
                cnn.Close();
            }
            catch (SqlException erro)
            {
                MessageBox.Show("Erro ao se conectar no banco de dados \n" +
                "Verifique os dados informados" + erro);
            }

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ptbx(object sender, EventArgs e)
        {
            Telalogin frm = new Telalogin();
            this.Visible = false;
            frm.ShowDialog();
            frm.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (email == "adm" && senha == "adm")
            {
                MessageBox.Show("Bem vindo admmm");
                adm frm = new adm();
                this.Visible = false;
                frm.ShowDialog();
                this.Close();
                return;
            }

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();

                string sqlLogin = "SELECT cod_cliente, Nome, Email FROM cadastro WHERE Email = @Email AND Senha = @Senha";

                using (SqlCommand cmd = new SqlCommand(sqlLogin, cnn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            UsuarioLogado.CodCliente = (int)reader["cod_cliente"];
                            UsuarioLogado.Nome = reader["Nome"].ToString();
                            UsuarioLogado.Email = reader["Email"].ToString();

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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            adm frm = new adm();
            this.Visible = false;
            frm.ShowDialog();
            frm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindo ao sistema!");
            adm frm = new adm();
            this.Visible = false;
            frm.ShowDialog();
            frm.Close();
        }

        //private void test_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string connetionString;
        //        SqlConnection cnn;
        //        connetionString = @"Data Source=sqlexpress;Initial Catalog=sbn;User ID=aluno;Password=aluno";
        //        cnn = new SqlConnection(connetionString);
        //        cnn.Open();
        //        MessageBox.Show("Connection Open !");
        //        cnn.Close();
        //    }
        //    catch (SqlException erro)
        //    {
        //        MessageBox.Show("Erro ao se conectar no banco de dados \n" +
        //        "Verifique os dados informados" + erro);
        //    }

    }
}

