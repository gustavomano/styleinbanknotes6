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

        string connectionString = "Server=sqlexpress;Database=cj3022129pr2;User Id=aluno;Password=aluno;";

        private void telacc_Load(object sender, EventArgs e)
        {


        }
        private void btn2(object sender, EventArgs e)
        {

            string email = txtEmail.Text.Trim();


            string senha = txtSenha.Text.Trim();

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();

                // Verifica se existe usuário com email e senha combinando
                string sqlLogin = "SELECT COUNT(*) FROM cadastro WHERE Email = @Email AND Senha = @Senha";

                using (SqlCommand cmd = new SqlCommand(sqlLogin, cnn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Login realizado com sucesso!");
                        TelaPrincipal frm = new TelaPrincipal();
                        this.Visible = false;
                        frm.ShowDialog();
                        frm.Close();
                    }
                    else
                    {
                        MessageBox.Show("E-mail ou senha incorretos.");
                    }
                }
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

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();

                // Verifica se existe usuário com email e senha combinando
                string sqlLogin = "SELECT COUNT(*) FROM cadastro WHERE Email = @Email AND Senha = @Senha";

                using (SqlCommand cmd = new SqlCommand(sqlLogin, cnn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Login realizado com sucesso!");
                        TelaPrincipal frm = new TelaPrincipal();
                        this.Visible = false;
                        frm.ShowDialog();
                        frm.Close();
                    }
                    else
                    {
                        MessageBox.Show("E-mail ou senha incorretos.");
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
            tlRegis frm = new tlRegis();
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

