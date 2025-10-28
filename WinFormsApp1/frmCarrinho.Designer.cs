namespace styleinbanknotes
{
    partial class frmCarrinho
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarrinho));
            dgvCarrinho = new DataGridView();
            Nome = new DataGridViewTextBoxColumn();
            PrecoUnitario = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            colRemover = new DataGridViewButtonColumn();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            buttonFinalizar = new Button();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvCarrinho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // dgvCarrinho
            // 
            dgvCarrinho.BackgroundColor = Color.FromArgb(171, 0, 8);
            dgvCarrinho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrinho.Columns.AddRange(new DataGridViewColumn[] { Nome, PrecoUnitario, Quantidade, Subtotal, colRemover });
            dgvCarrinho.Location = new Point(311, 201);
            dgvCarrinho.Name = "dgvCarrinho";
            dgvCarrinho.Size = new Size(310, 170);
            dgvCarrinho.TabIndex = 0;
            dgvCarrinho.CellContentClick += dgvCarrinho_CellContentClick;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // PrecoUnitario
            // 
            PrecoUnitario.DataPropertyName = "PrecoUnitario";
            dataGridViewCellStyle1.Format = "c";
            PrecoUnitario.DefaultCellStyle = dataGridViewCellStyle1;
            PrecoUnitario.HeaderText = "Preço";
            PrecoUnitario.Name = "PrecoUnitario";
            // 
            // Quantidade
            // 
            Quantidade.DataPropertyName = "Quantidade";
            Quantidade.HeaderText = "Qtd.";
            Quantidade.Name = "Quantidade";
            // 
            // Subtotal
            // 
            Subtotal.DataPropertyName = "Subtotal";
            dataGridViewCellStyle2.Format = "c";
            Subtotal.DefaultCellStyle = dataGridViewCellStyle2;
            Subtotal.HeaderText = "Subtotal";
            Subtotal.Name = "Subtotal";
            // 
            // colRemover
            // 
            colRemover.DataPropertyName = "colRemover";
            colRemover.HeaderText = "Remover";
            colRemover.Name = "colRemover";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(311, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(310, 160);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // buttonFinalizar
            // 
            buttonFinalizar.BackColor = Color.FromArgb(189, 0, 8);
            buttonFinalizar.FlatStyle = FlatStyle.Popup;
            buttonFinalizar.Location = new Point(390, 417);
            buttonFinalizar.Name = "buttonFinalizar";
            buttonFinalizar.Size = new Size(148, 30);
            buttonFinalizar.TabIndex = 3;
            buttonFinalizar.Text = "FINALIZAR PEDIDO";
            buttonFinalizar.UseVisualStyleBackColor = false;
            buttonFinalizar.Click += button1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = Properties.Resources.telavermelha;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(947, 507);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // frmCarrinho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 507);
            Controls.Add(buttonFinalizar);
            Controls.Add(dgvCarrinho);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Name = "frmCarrinho";
            Text = "FormCarrinho";
            Load += FormCarrinho_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarrinho).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCarrinho;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button buttonFinalizar;
        private PictureBox pictureBox3;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn PrecoUnitario;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewButtonColumn colRemover;
    }
}