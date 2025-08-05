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
            BTMCONFIRM = new Button();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1920, 1080);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // BTMCONFIRM
            // 
            BTMCONFIRM.BackColor = Color.Red;
            BTMCONFIRM.BackgroundImageLayout = ImageLayout.None;
            BTMCONFIRM.Cursor = Cursors.Hand;
            BTMCONFIRM.FlatStyle = FlatStyle.Popup;
            BTMCONFIRM.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTMCONFIRM.ForeColor = Color.Black;
            BTMCONFIRM.Location = new Point(792, 547);
            BTMCONFIRM.Name = "BTMCONFIRM";
            BTMCONFIRM.Size = new Size(91, 23);
            BTMCONFIRM.TabIndex = 6;
            BTMCONFIRM.Text = "ENTRAR";
            BTMCONFIRM.UseVisualStyleBackColor = false;
            BTMCONFIRM.Click += btn2;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.MenuText;
            txtEmail.ForeColor = SystemColors.Window;
            txtEmail.Location = new Point(656, 383);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(185, 23);
            txtEmail.TabIndex = 7;
            txtEmail.TextChanged += textBox3_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.MenuText;
            txtSenha.ForeColor = SystemColors.Window;
            txtSenha.Location = new Point(656, 430);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(185, 23);
            txtSenha.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(484, 647);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(545, 132);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(484, 274);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(439, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(880, 729);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(125, 61);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            pictureBox4.Click += ptbx;
            // 
            // telacc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1733, 1061);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(BTMCONFIRM);
            Controls.Add(pictureBox1);
            Name = "telacc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "telacc";
            Load += telacc_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BTMCONFIRM;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}