namespace styleinbanknotes
{
    partial class tlRegis
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
            pictureBox1 = new PictureBox();
            txtPreco = new TextBox();
            txtEstoque = new TextBox();
            txtNome = new TextBox();
            btnSalvar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtDescricao = new TextBox();
            dgvProdutos = new DataGridView();
            EX = new DataGridViewButtonColumn();
            label6 = new Label();
            button1 = new Button();
            picProduto = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picProduto).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.projeto1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1803, 851);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(163, 312);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(198, 23);
            txtPreco.TabIndex = 1;
            txtPreco.TextChanged += txtPRECO_TextChanged;
            // 
            // txtEstoque
            // 
            txtEstoque.Location = new Point(163, 362);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.Size = new Size(198, 23);
            txtEstoque.TabIndex = 2;
            txtEstoque.TextChanged += txtESTOQUE_TextChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(163, 257);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(198, 23);
            txtNome.TabIndex = 3;
            txtNome.TextChanged += textBox3_TextChanged;
            // 
            // btnSalvar
            // 
            btnSalvar.FlatStyle = FlatStyle.Popup;
            btnSalvar.Location = new Point(267, 455);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 23);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "CONFIRMAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 239);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 5;
            label1.Text = "NOME";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 294);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 6;
            label2.Text = "PREÇO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(163, 344);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 7;
            label3.Text = "ESTOQUE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(163, 388);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 8;
            label4.Text = "DESCRIÇÃO";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(163, 406);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(198, 23);
            txtDescricao.TabIndex = 9;
            txtDescricao.TextChanged += textBox1_TextChanged;
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.AllowUserToOrderColumns = true;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { EX });
            dgvProdutos.Location = new Point(744, 239);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.Size = new Size(522, 210);
            dgvProdutos.TabIndex = 10;
            dgvProdutos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // EX
            // 
            EX.FillWeight = 125F;
            EX.FlatStyle = FlatStyle.Popup;
            EX.HeaderText = "EX";
            EX.Name = "EX";
            EX.Text = "EXCLUIR PROD";
            EX.ToolTipText = "EXCLUIR PROD";
            EX.UseColumnTextForButtonValue = true;
            EX.Width = 125;
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(171, 0, 8);
            label6.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(163, 191);
            label6.Name = "label6";
            label6.Size = new Size(218, 26);
            label6.TabIndex = 12;
            label6.Text = "CADASTRAR PRODUTO";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(961, 592);
            button1.Name = "button1";
            button1.Size = new Size(121, 23);
            button1.TabIndex = 13;
            button1.Text = "atualizar imagem";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click_1;
            // 
            // picProduto
            // 
            picProduto.Location = new Point(843, 570);
            picProduto.Name = "picProduto";
            picProduto.Size = new Size(95, 45);
            picProduto.TabIndex = 14;
            picProduto.TabStop = false;
            picProduto.Visible = false;
            picProduto.Click += picProduto_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(171, 0, 8);
            label5.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(726, 200);
            label5.Name = "label5";
            label5.Size = new Size(252, 26);
            label5.TabIndex = 15;
            label5.Text = "PRODUTOS JÁ CADASTRADOS";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlRegis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1803, 851);
            Controls.Add(label5);
            Controls.Add(picProduto);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(dgvProdutos);
            Controls.Add(txtDescricao);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSalvar);
            Controls.Add(txtNome);
            Controls.Add(txtEstoque);
            Controls.Add(txtPreco);
            Controls.Add(pictureBox1);
            Name = "tlRegis";
            Text = "tlRegis";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)picProduto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtPreco;
        private TextBox txtEstoque;
        private TextBox txtNome;
        private Button btnSalvar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtDescricao;
        private DataGridView dgvProdutos;
        private Label label6;
        private Button button1;
        private PictureBox picProduto;
        private Label label5;
        private DataGridViewButtonColumn EX;
    }
}