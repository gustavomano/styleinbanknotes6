using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace styleinbanknotes
{
    public partial class FormCarrinho : Form
    {
        public FormCarrinho(List<DataRow> itens)
        {
            InitializeComponent();

            
            DataTable dt = itens[0].Table.Clone();
            foreach (DataRow r in itens)
            {
                dt.ImportRow(r);
            }

            dgvCarrinho.DataSource = dt;
        }
        private void FormCarrinho_Load(object sender, EventArgs e)
        {

        }

        private void dgvCarrinho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
