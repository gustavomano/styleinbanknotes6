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



        private void telacc_Load(object sender, EventArgs e)
        {
           
            try
            {
                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=sqlexpress;Initial Catalog=sbn;User ID=aluno;Password=aluno";
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
        private void btn2(object sender, EventArgs e)
        {

            string email = txtEmail.Text.Trim();

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();

                string sql = "SELECT COUNT(*) FROM Usuarios WHERE Email = @Email";

                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Cadastro já existe com esse email!");
                    }
                    else
                    {
                        MessageBox.Show("Email disponível para cadastro.");
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

