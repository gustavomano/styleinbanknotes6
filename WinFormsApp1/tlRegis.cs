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
        private void CarregarProdutos()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Id, Nome, Preco, Estoque, Descricao FROM Produtos", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProdutos.DataSource = dt;
            }
        }
        public tlRegis()
        {

            InitializeComponent();
            CarregarProdutos();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        string connString = @"Server=sqlexpress;Initial Catalog=cj3022129pr2;User ID=aluno;Password=aluno";

        string conexao = @"Data Source=sqlexpress;Initial Catalog=cj3022129pr2;User ID=aluno;Password=aluno";

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtPreco.Text) || string.IsNullOrEmpty(txtEstoque.Text))
                {
                    MessageBox.Show("Preencha todos os campos!");
                    return;
                }

                if (!decimal.TryParse(txtPreco.Text, out decimal preco))
                {
                    MessageBox.Show("Preço inválido!");
                    return;
                }

                if (!int.TryParse(txtEstoque.Text, out int estoque))
                {
                    MessageBox.Show("Estoque inválido!");
                    return;
                }
                conn.Open();
                string query = "INSERT INTO Produtos (Nome, Preco, Estoque, Descricao) VALUES (@nome, @preco, @estoque, @descricao)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@preco", decimal.Parse(txtPreco.Text));
                    cmd.Parameters.AddWithValue("@estoque", int.Parse(txtEstoque.Text));
                    cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);

                   
                    //byte[] imagemBytes = null;
                    //if (picProduto.Image != null)
                    //{
                    //    using (MemoryStream ms = new MemoryStream())
                    //    {
                    //        picProduto.Image.Save(ms, picProduto.Image.RawFormat);
                    //        imagemBytes = ms.ToArray();
                    //    }
                    //}
                    //cmd.Parameters.AddWithValue("@imagem", (object)imagemBytes ?? DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Produto cadastrado com sucesso!");
            CarregarProdutos();
        }
        //ATUALIZA GIT

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvProdutos.Columns[e.ColumnIndex].Name == "EX")
            {
                DataRowView rowView = (DataRowView)dgvProdutos.Rows[e.RowIndex].DataBoundItem;
                DataRow row = rowView.Row;
                int id = int.Parse(dgvProdutos.CurrentRow.Cells["Id"].Value.ToString());

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Produtos WHERE Id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Produto excluído!");
                CarregarProdutos();

            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imagens|*.jpg;*.png;*.jpeg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picProduto.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void picProduto_Click(object sender, EventArgs e)
        {

        }
    }
}


