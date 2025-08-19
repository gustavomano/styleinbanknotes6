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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            txtPreco.Location = new Point(515, 312);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(198, 23);
            txtPreco.TabIndex = 1;
            txtPreco.TextChanged += txtPRECO_TextChanged;
            // 
            // txtEstoque
            // 
            txtEstoque.Location = new Point(515, 360);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.Size = new Size(198, 23);
            txtEstoque.TabIndex = 2;
            txtEstoque.TextChanged += txtESTOQUE_TextChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(515, 260);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(198, 23);
            txtNome.TabIndex = 3;
            txtNome.TextChanged += textBox3_TextChanged;
            // 
            // btnSalvar
            // 
            btnSalvar.FlatStyle = FlatStyle.Popup;
            btnSalvar.Location = new Point(908, 311);
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
            label1.Location = new Point(515, 242);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 5;
            label1.Text = "NOME";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(515, 294);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 6;
            label2.Text = "PREÇO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(515, 342);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 7;
            label3.Text = "ESTOQUE";
            // 
            // tlRegis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1803, 851);
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
    }
}