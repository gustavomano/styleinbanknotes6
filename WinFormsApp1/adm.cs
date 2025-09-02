using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace styleinbanknotes
{
    public partial class adm : Form
    {
        public adm()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Telalogin frm = new Telalogin();

            frm.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            telacc frm = new telacc();

            frm.ShowDialog();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            TelaPrincipal frm = new TelaPrincipal();

            frm.ShowDialog();

        }



        private void pictureBox6_Click(object sender, EventArgs e)
        {
            tlRegis frm = new tlRegis();

            frm.ShowDialog();


        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FormAdmin frm = new FormAdmin();

            frm.ShowDialog();
        }
    }
}
