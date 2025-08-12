namespace WinFormsApp1
{
    partial class Telalogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Telalogin));
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.MenuText;
            txtNome.ForeColor = SystemColors.Window;
            txtNome.Location = new Point(897, 427);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(185, 23);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += textBox1_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.MenuText;
            txtEmail.ForeColor = SystemColors.Window;
            txtEmail.Location = new Point(897, 483);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(185, 23);
            txtEmail.TabIndex = 2;
            txtEmail.TextChanged += textBox2_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.MenuText;
            txtSenha.ForeColor = SystemColors.Window;
            txtSenha.Location = new Point(897, 534);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(185, 23);
            txtSenha.TabIndex = 3;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1099, 630);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(319, 188);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1454, 801);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(24, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(148, 141);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // Telalogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1454, 801);
            Controls.Add(pictureBox3);
            Controls.Add(txtEmail);
            Controls.Add(pictureBox2);
            Controls.Add(txtSenha);
            Controls.Add(txtNome);
            Controls.Add(pictureBox1);
            Name = "Telalogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Telalogin";
            Load += Telalogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
    }
}