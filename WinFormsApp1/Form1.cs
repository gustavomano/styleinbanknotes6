using styleinbanknotes;
using System.Security.Cryptography;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn1(object sender, EventArgs e)
        {
            telacc frm = new telacc();
            this.Visible = false;
            frm.ShowDialog();
            frm.Close();

        }

        private void lbl(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
