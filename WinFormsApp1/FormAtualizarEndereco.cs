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
        bool enderecoSalvo = false;
        string connString = "Data Source=sqlexpress;Database=cj3022129pr2;User Id=aluno;Password=aluno;";
        public FormAtualizarEndereco()
        {
            InitializeComponent();
        }
        private void FormAtualizarEndereco_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!enderecoSalvo) 
            {
                MessageBox.Show("Você precisa salvar o endereço antes de fechar!");
                e.Cancel = true;
            }
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
                    if (cmbEstado.SelectedItem == null)
                    {
                        MessageBox.Show("Selecione um estado antes de salvar!");
                        return;
                    }
                    cmd.Parameters.AddWithValue("@id", UsuarioLogado.CodCliente);
                    
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Endereço atualizado!");
            enderecoSalvo = true;
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

        private async void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCEP.Text))
            {
                // Remove tudo que não for número
                string cep = new string(txtCEP.Text.Where(char.IsDigit).ToArray());

                if (cep.Length == 8) // CEP válido tem 8 dígitos
                {
                    await BuscarCEP(cep);
                }
                else
                {
                    MessageBox.Show("CEP inválido! Digite um CEP com 8 dígitos.");
                }
            }
        }


    }
}


