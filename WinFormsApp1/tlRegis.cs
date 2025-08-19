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
    public partial class tlRegis : Form
    {
        public tlRegis()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        string conexao = @"Data Source=sqlexpress;Initial Catalog=cj3022129pr2;User ID=aluno;Password=aluno";

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string precoStr = txtPreco.Text.Trim();
            string estoqueStr = txtEstoque.Text.Trim();


            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(precoStr) || string.IsNullOrEmpty(estoqueStr))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            if (!decimal.TryParse(precoStr, out decimal preco))
            {
                MessageBox.Show("Preço inválido!");
                return;
            }

            if (!int.TryParse(estoqueStr, out int estoque))
            {
                MessageBox.Show("Estoque inválido!");
                return;
            }


            using (SqlConnection conn = new SqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Produtos (Nome, Preco, Estoque) VALUES (@nome, @preco, @estoque)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@preco", preco);
                    cmd.Parameters.AddWithValue("@estoque", estoque);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Produto cadastrado com sucesso!");


                    txtNome.Clear();
                    txtPreco.Clear();
                    txtEstoque.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar produto: " + ex.Message);
                }
            }
        }
            
            
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPRECO_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtESTOQUE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

