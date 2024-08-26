using styleinbanknotes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Telalogin : Form
    {

        public Telalogin()
        {
            InitializeComponent();
        }

        private void Telalogin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(textBox1.Text + "\n" + textBox2.Text + "\n" + textBox3.Text + "\n", "Atenção, confirma os dados digitados?",
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
    }
}