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

namespace styleinbanknotes
{
    public partial class FormAtualizarEndereco : Form
    {
        string connString = "Data Source=sqlexpress;Database=cj3022129pr2;User Id=aluno;Password=aluno;";
        public FormAtualizarEndereco()
        {
            InitializeComponent();
        }

        private void FormAtualizarEndereco_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string update = @"UPDATE cadastro 
                  SET endereco = @endereco,
                      num = @num,
                      bairro = @bairro,
                      cep = @cep,
                      cidad = @cidade,
                      sigla_estado = @estado
                  WHERE cod_cliente = @id";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(update, conn))
                {
                    cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                    cmd.Parameters.AddWithValue("@num", txtNumero.Text);
                    cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);
                    cmd.Parameters.AddWithValue("@cep", txtCEP.Text);
                    cmd.Parameters.AddWithValue("@cidade", txtCidade.Text);
                    cmd.Parameters.AddWithValue("@estado", cmbEstado.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@id", UsuarioLogado.CodCliente);

                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Endereço atualizado!");
            this.Close();
        }

        private void chkSemNumero_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSemNumero.Checked)
            {
                txtNumero.Text = "SN";
                txtNumero.Enabled = false; // bloqueia edição
            }
            else
            {
                txtNumero.Text = "";
                txtNumero.Enabled = true;  // libera edição
            }
        }
    }
}
