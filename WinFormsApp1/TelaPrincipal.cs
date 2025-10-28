﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Pqc.Crypto.Frodo;

namespace styleinbanknotes
{

    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();

        }
        //ATUALIZA GIT
        private List<ItemCarrinho> meuCarrinho = new List<ItemCarrinho>();
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
        string conexao = @"Data Source=sqlexpress;Initial Catalog=cj3022129pr2;User ID=aluno;Password=aluno";

        //ATUALIZA GIT

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string termo = txtPesquisa.Text.Trim();

            if (string.IsNullOrEmpty(termo))
            {
                MessageBox.Show("Digite um produto para pesquisar.");
                return;
            }
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Id, Nome, Preco, Estoque FROM produtos WHERE Nome LIKE @nome";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add("@nome", SqlDbType.NVarChar, 100).Value = "%" + termo + "%";

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvProdutos.DataSource = dt;
                    if (!dgvProdutos.Columns.Contains("Adicionar"))
                    {
                        DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
                        btnCol.Name = "Adicionar";
                        btnCol.HeaderText = "Carrinho";
                        btnCol.Text = "Adicionar";
                        btnCol.UseColumnTextForButtonValue = true;
                        dgvProdutos.Columns.Add(btnCol);

                    }
                }
                

                //if (!dgvProdutos.Columns.Contains("Ver carrinho"))
                //{
                //    DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
                //    btnCol.Name = "Ver carrinho";
                //    btnCol.HeaderText = "Carrinho";
                //    btnCol.Text = "ver carrinho";
                //    btnCol.UseColumnTextForButtonValue = true;
                //    dgvProdutos.Columns.Add(btnCol);

                //}

                catch (Exception ex)
                {
                MessageBox.Show("Erro ao buscar produto: " + ex.Message);
            }
        }
    }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmcliente frmcliente = new frmcliente();
            frmcliente.ShowDialog();
            this.Close();

        }
        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            // 1. Verifica se o clique foi em uma linha válida E na coluna "Adicionar"
            if (e.RowIndex >= 0 && dgvProdutos.Columns[e.ColumnIndex].Name == "Adicionar")
            {
                // 2. Pega os dados do produto da linha que foi clicada
                int id = Convert.ToInt32(dgvProdutos.Rows[e.RowIndex].Cells["Id"].Value);
                string nome = dgvProdutos.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                decimal preco = Convert.ToDecimal(dgvProdutos.Rows[e.RowIndex].Cells["Preco"].Value);

                // 3. Verifique se o item JÁ ESTÁ no carrinho "meuCarrinho"
                var itemExistente = meuCarrinho.FirstOrDefault(item => item.IdProduto == id);

                if (itemExistente != null)
                {
                    // Se já existe, apenas aumenta a quantidade
                    itemExistente.Quantidade++;
                    MessageBox.Show($"{nome} teve a quantidade aumentada!");
                }
                else
                {
                    // Se não existe, cria um novo item e adiciona à lista "meuCarrinho"
                    ItemCarrinho novoItem = new ItemCarrinho
                    {
                        IdProduto = id,
                        Nome = nome,
                        PrecoUnitario = preco,
                        Quantidade = 1 // Começa com quantidade 1
                    };
                    meuCarrinho.Add(novoItem);
                    MessageBox.Show($"{nome} foi adicionado ao carrinho!");
                }

                // APAGAMOS O CÓDIGO ANTIGO QUE ADICIONAVA O DataRow!
            }
        }
        private void btnCarrinho_Click(object sender, EventArgs e)
        {
            if (meuCarrinho.Count == 0)
            {
                MessageBox.Show("Carrinho vazio!");
                return;
            }
            //    frmCarrinho f = new frmCarrinho(itensCarrinho);
            //    f.ShowDialog();
            //    f.Close();
            //}
            //private void carrinho_Click(object sender, EventArgs e)
            //{
            //    if (itensCarrinho.Count == 0)
            //    {
            //        MessageBox.Show("Carrinho vazio!");
            //        return;
            //    }
            //    frmCarrinho f = new frmCarrinho(itensCarrinho);
            //    f.ShowDialog();
            //    f.Close();
            //}
            //  }
            //}

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmCarrinho frm = new frmCarrinho(meuCarrinho);
            frm.ShowDialog();


        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}