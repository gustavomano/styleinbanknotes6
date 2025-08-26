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
            carrinho = new PictureBox();
            pictureBox3 = new PictureBox();
            txtPesquisa = new TextBox();
            btnBuscar = new PictureBox();
            dgvProdutos = new DataGridView();
            btnCarrinho = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carrinho).BeginInit();
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
            // carrinho
            // 
            carrinho.Cursor = Cursors.Hand;
            carrinho.Image = (Image)resources.GetObject("carrinho.Image");
            carrinho.Location = new Point(1705, 33);
            carrinho.Name = "carrinho";
            carrinho.Size = new Size(77, 63);
            carrinho.SizeMode = PictureBoxSizeMode.CenterImage;
            carrinho.TabIndex = 1;
            carrinho.TabStop = false;
            carrinho.Click += carrinho_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.projeto__2_;
            pictureBox3.Location = new Point(1799, 33);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(76, 69);
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
            dgvProdutos.Location = new Point(698, 117);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.Size = new Size(603, 136);
            dgvProdutos.TabIndex = 5;
            dgvProdutos.CellContentClick += dgvProdutos_CellContentClick;
            // 
            // btnCarrinho
            // 
            btnCarrinho.BackColor = Color.FromArgb(200, 31, 23);
            btnCarrinho.FlatStyle = FlatStyle.Popup;
            btnCarrinho.Location = new Point(1228, 286);
            btnCarrinho.Name = "btnCarrinho";
            btnCarrinho.Size = new Size(99, 23);
            btnCarrinho.TabIndex = 6;
            btnCarrinho.Text = "VER CARRINHO";
            btnCarrinho.UseVisualStyleBackColor = false;
            btnCarrinho.Click += btnCarrinho_Click;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1899, 704);
            Controls.Add(btnCarrinho);
            Controls.Add(dgvProdutos);
            Controls.Add(btnBuscar);
            Controls.Add(txtPesquisa);
            Controls.Add(pictureBox3);
            Controls.Add(carrinho);
            Controls.Add(pictureBox1);
            Name = "TelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaPrincipal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)carrinho).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox carrinho;
        private PictureBox pictureBox3;
        private TextBox txtPesquisa;
        private PictureBox btnBuscar;
        private DataGridView dgvProdutos;
        private Button btnCarrinho;
    }
}