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

        private void button1_Click(object sender, EventArgs e)
        {
            Telalogin frm = new Telalogin();
            this.Visible = false;
            frm.ShowDialog();
            this.Visible = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
