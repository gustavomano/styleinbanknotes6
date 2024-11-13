using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
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

        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(textBox3.Text + "\n" + textBox4.Text + "\n" + "\n", "Atenção, confirma os dados digitados?",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Exibe o próximo formulário
                TelaPrincipal frm = new TelaPrincipal();
                this.Visible = false;
                frm.ShowDialog();
                this.Visible = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
