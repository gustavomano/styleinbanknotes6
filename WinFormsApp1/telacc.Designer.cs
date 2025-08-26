namespace styleinbanknotes
{
    partial class telacc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telacc));
            pictureBox1 = new PictureBox();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            ocultar = new PictureBox();
            mostrar = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ocultar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mostrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1920, 1080);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.MenuText;
            txtEmail.ForeColor = SystemColors.Window;
            txtEmail.Location = new Point(900, 439);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(185, 23);
            txtEmail.TabIndex = 7;
            txtEmail.TextChanged += textBox3_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.MenuText;
            txtSenha.ForeColor = SystemColors.Window;
            txtSenha.Location = new Point(900, 481);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(185, 23);
            txtSenha.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(430, 716);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(545, 165);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(791, 757);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(125, 124);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            pictureBox4.Click += ptbx;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = Properties.Resources._32;
            pictureBox3.Location = new Point(1137, 562);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(256, 187);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // ocultar
            // 
            ocultar.Cursor = Cursors.Hand;
            ocultar.Image = (Image)resources.GetObject("ocultar.Image");
            ocultar.Location = new Point(1091, 459);
            ocultar.Name = "ocultar";
            ocultar.Size = new Size(42, 66);
            ocultar.SizeMode = PictureBoxSizeMode.CenterImage;
            ocultar.TabIndex = 13;
            ocultar.TabStop = false;
            ocultar.Click += ocultar_Click;
            // 
            // mostrar
            // 
            mostrar.Cursor = Cursors.Hand;
            mostrar.Image = (Image)resources.GetObject("mostrar.Image");
            mostrar.Location = new Point(1091, 459);
            mostrar.Name = "mostrar";
            mostrar.Size = new Size(46, 55);
            mostrar.SizeMode = PictureBoxSizeMode.CenterImage;
            mostrar.TabIndex = 14;
            mostrar.TabStop = false;
            mostrar.Click += mostrar_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.projeto__4_;
            pictureBox5.Location = new Point(12, 42);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(188, 54);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 15;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // telacc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1733, 1061);
            Controls.Add(pictureBox5);
            Controls.Add(ocultar);
            Controls.Add(txtEmail);
            Controls.Add(txtSenha);
            Controls.Add(mostrar);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "telacc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "telacc";
            Load += telacc_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)ocultar).EndInit();
            ((System.ComponentModel.ISupportInitialize)mostrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox ocultar;
        private PictureBox mostrar;
        private PictureBox pictureBox5;
    }
}