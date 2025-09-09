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


    public partial class FormCarrinho : Form
    {

        string connectionString = "Server=sqlexpress;Database=cj3022129pr2;User Id=aluno;Password=aluno;";
        public FormCarrinho(List<DataRow> itens)
        {
            InitializeComponent();


            DataTable dt = itens[0].Table.Clone();
            foreach (DataRow r in itens)
            {
                dt.ImportRow(r);
            }

            dgvCarrinho.DataSource = dt;
            dgvCarrinho.Columns["Id"].Visible = false;
            dgvCarrinho.Columns["Nome"].Width = 200;
            dgvCarrinho.Columns["Preco"].DefaultCellStyle.Format = "C2";
        }
        private void FormCarrinho_Load(object sender, EventArgs e)
        {

        }

        private void dgvCarrinho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            TelaPrincipal frm = new TelaPrincipal();
            this.Visible = false;
            frm.ShowDialog();
            frm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {

                    string sqlPedido = "INSERT INTO Pedidos (cod_cliente, Status) OUTPUT INSERTED.PedidoId VALUES (@cod_cliente, 'Em preparação')";
                    SqlCommand cmdPedido = new SqlCommand(sqlPedido, conn, tran);


                    cmdPedido.Parameters.AddWithValue("@cod_cliente", UsuarioLogado.CodCliente);

                    int pedidoId = (int)cmdPedido.ExecuteScalar();

                    foreach (DataGridViewRow row in dgvCarrinho.SelectedRows)
                    {
                        int produtoId = (int)row.Cells["Id"].Value;
                        string nome = row.Cells["Nome"].Value.ToString();
                        decimal preco = (decimal)row.Cells["Preco"].Value;

                        string sqlItem = "INSERT INTO ItensPedido (PedidoId, Produto, Quantidade) VALUES (@PedidoId, @Produto, 1)";
                        SqlCommand cmdItem = new SqlCommand(sqlItem, conn, tran);
                        cmdItem.Parameters.AddWithValue("@PedidoId", pedidoId);
                        cmdItem.Parameters.AddWithValue("@Produto", nome);
                        cmdItem.ExecuteNonQuery();

                        string sqlEstoque = "UPDATE Produtos SET Estoque = Estoque - 1 WHERE Id = @Id";
                        SqlCommand cmdEstoque = new SqlCommand(sqlEstoque, conn, tran);
                        cmdEstoque.Parameters.AddWithValue("@Id", produtoId);
                        cmdEstoque.ExecuteNonQuery();
                    }

                    tran.Commit();
                    MessageBox.Show("Pedido finalizado com sucesso!");
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Erro ao salvar pedido: " + ex.Message);
                }
            }
        }
    }
}

