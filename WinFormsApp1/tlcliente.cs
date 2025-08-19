using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI;

namespace styleinbanknotes
{
    public partial class tlcad : Form
    {
        private Cliente cliente;

        public tlcad(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
        }

        private void tlcliente_Load(object sender, EventArgs e)
        {
            lblNome.Text = cliente.Nome;
            lblEmail.Text = cliente.Email;
            
        }
    }
}
