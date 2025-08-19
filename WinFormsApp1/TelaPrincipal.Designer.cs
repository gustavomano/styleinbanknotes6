namespace styleinbanknotes
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            txtPesquisa = new TextBox();
            btnBuscar = new PictureBox();
            dgvProdutos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBuscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1899, 704);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1705, 33);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(77, 63);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.projeto__2_;
            pictureBox3.Location = new Point(1800, 27);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(87, 69);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // txtPesquisa
            // 
            txtPesquisa.AccessibleRole = AccessibleRole.TitleBar;
            txtPesquisa.BackColor = Color.FromArgb(200, 31, 23);
            txtPesquisa.ForeColor = SystemColors.Window;
            txtPesquisa.Location = new Point(889, 70);
            txtPesquisa.Multiline = true;
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(175, 26);
            txtPesquisa.TabIndex = 3;
            txtPesquisa.Text = "          ";
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(1070, 64);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(33, 32);
            btnBuscar.SizeMode = PictureBoxSizeMode.CenterImage;
            btnBuscar.TabIndex = 4;
            btnBuscar.TabStop = false;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // dgvProdutos
            // 
            dgvProdutos.BackgroundColor = Color.FromArgb(171, 0, 8);
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(814, 117);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.Size = new Size(381, 136);
            dgvProdutos.TabIndex = 5;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1899, 704);
            Controls.Add(dgvProdutos);
            Controls.Add(btnBuscar);
            Controls.Add(txtPesquisa);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "TelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaPrincipal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox txtPesquisa;
        private PictureBox btnBuscar;
        private DataGridView dgvProdutos;
    }
}