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
            pictureBox1 = new PictureBox();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            bTConfirmar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1094, 801);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.MenuText;
            txtNome.ForeColor = SystemColors.Window;
            txtNome.Location = new Point(518, 402);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(185, 23);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += textBox1_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.MenuText;
            txtEmail.ForeColor = SystemColors.Window;
            txtEmail.Location = new Point(540, 462);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(185, 23);
            txtEmail.TabIndex = 2;
            txtEmail.TextChanged += textBox2_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.MenuText;
            txtSenha.ForeColor = SystemColors.Window;
            txtSenha.Location = new Point(540, 528);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(185, 23);
            txtSenha.TabIndex = 3;
            // 
            // bTConfirmar
            // 
            bTConfirmar.AccessibleRole = AccessibleRole.None;
            bTConfirmar.Anchor = AnchorStyles.None;
            bTConfirmar.BackColor = Color.Red;
            bTConfirmar.Cursor = Cursors.Hand;
            bTConfirmar.FlatStyle = FlatStyle.Popup;
            bTConfirmar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bTConfirmar.ForeColor = SystemColors.ControlText;
            bTConfirmar.Location = new Point(843, 691);
            bTConfirmar.Name = "bTConfirmar";
            bTConfirmar.Size = new Size(91, 25);
            bTConfirmar.TabIndex = 4;
            bTConfirmar.Text = "CONFIRMAR\r\n";
            bTConfirmar.UseVisualStyleBackColor = false;
            bTConfirmar.Click += button1_Click;
            // 
            // Telalogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 801);
            Controls.Add(bTConfirmar);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(pictureBox1);
            Name = "Telalogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Telalogin";
            Load += Telalogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Button bTConfirmar;
    }
}