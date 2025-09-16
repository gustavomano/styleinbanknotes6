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
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace styleinbanknotes
{
    public partial class FormAtualizarEndereco : Form
    {
        string connString = "Data Source=sqlexpress;Database=cj3022129pr2;User Id=aluno;Password=aluno;";
        public FormAtualizarEndereco()
        {
            InitializeComponent();
        }
        private async Task BuscarCEP(string cep)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"https://viacep.com.br/ws/{cep}/json/";
                var response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var endereco = JsonConvert.DeserializeObject<Endereco>(json);

                    if (endereco != null)
                    {
                        txtEndereco.Text = endereco.logradouro;
                        txtBairro.Text = endereco.bairro;
                        txtCidade.Text = endereco.localidade;
                        cmbEstado.Text = endereco.uf;
                    }
                }
                else
                {
                    MessageBox.Show("CEP não encontrado!");
                }
            }
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

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
