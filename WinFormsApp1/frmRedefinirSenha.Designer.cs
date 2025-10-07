namespace styleinbanknotes
{
    partial class frmRedefinirSenha
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
            btnRedefinir = new Button();
            txtEmail = new TextBox();
            txtToken = new TextBox();
            txtNovaSenha = new TextBox();
            txtConfirmarSenha = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnRedefinir
            // 
            btnRedefinir.BackColor = Color.FromArgb(171, 0, 8);
            btnRedefinir.FlatStyle = FlatStyle.Popup;
            btnRedefinir.Location = new Point(470, 358);
            btnRedefinir.Name = "btnRedefinir";
            btnRedefinir.Size = new Size(116, 23);
            btnRedefinir.TabIndex = 0;
            btnRedefinir.Text = "REDEFINIR SENHA";
            btnRedefinir.UseVisualStyleBackColor = false;
            btnRedefinir.Click += btnRedefinir_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(423, 116);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 1;
            txtEmail.Visible = false;
            // 
            // txtToken
            // 
            txtToken.BackColor = SystemColors.InfoText;
            txtToken.BorderStyle = BorderStyle.FixedSingle;
            txtToken.ForeColor = SystemColors.Window;
            txtToken.Location = new Point(294, 187);
            txtToken.Multiline = true;
            txtToken.Name = "txtToken";
            txtToken.Size = new Size(135, 23);
            txtToken.TabIndex = 2;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.BackColor = SystemColors.InfoText;
            txtNovaSenha.BorderStyle = BorderStyle.FixedSingle;
            txtNovaSenha.ForeColor = SystemColors.Window;
            txtNovaSenha.Location = new Point(294, 235);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(135, 23);
            txtNovaSenha.TabIndex = 3;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.BackColor = SystemColors.InfoText;
            txtConfirmarSenha.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmarSenha.ForeColor = SystemColors.Window;
            txtConfirmarSenha.Location = new Point(294, 284);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Size = new Size(135, 23);
            txtConfirmarSenha.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.telavermelha;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(171, 0, 8);
            label1.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(294, 164);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 6;
            label1.Text = "TOKEN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(171, 0, 8);
            label2.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(294, 213);
            label2.Name = "label2";
            label2.Size = new Size(79, 19);
            label2.TabIndex = 7;
            label2.Text = "SENHA NOVA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(171, 0, 8);
            label3.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(294, 261);
            label3.Name = "label3";
            label3.Size = new Size(118, 19);
            label3.TabIndex = 8;
            label3.Text = "CONFIRME A SENHA";
            // 
            // frmRedefinirSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(txtNovaSenha);
            Controls.Add(txtToken);
            Controls.Add(txtEmail);
            Controls.Add(btnRedefinir);
            Controls.Add(pictureBox1);
            Name = "frmRedefinirSenha";
            Text = "frmRedefinirSenha";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRedefinir;
        private TextBox txtEmail;
        private TextBox txtToken;
        private TextBox txtNovaSenha;
        private TextBox txtConfirmarSenha;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}