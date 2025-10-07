namespace styleinbanknotes
{
    partial class FormRecuperarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecuperarSenha));
            label1 = new Label();
            txtEmail = new TextBox();
            btnEnviarCodigo = new Button();
            label2 = new Label();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.IndianRed;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(252, 169);
            label1.Name = "label1";
            label1.Size = new Size(295, 15);
            label1.TabIndex = 0;
            label1.Text = "DIGITE SEU EMAIL PARA RECUPERAR A SUA SENHA:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(296, 202);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(193, 23);
            txtEmail.TabIndex = 1;
            // 
            // btnEnviarCodigo
            // 
            btnEnviarCodigo.Location = new Point(561, 259);
            btnEnviarCodigo.Name = "btnEnviarCodigo";
            btnEnviarCodigo.Size = new Size(131, 23);
            btnEnviarCodigo.TabIndex = 2;
            btnEnviarCodigo.Text = "RECUPERAR SENHA";
            btnEnviarCodigo.UseVisualStyleBackColor = true;
            btnEnviarCodigo.Click += btnRecuperar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.IndianRed;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(252, 47);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Swis721 BlkEx BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(296, 240);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 15);
            lblStatus.TabIndex = 4;
            // 
            // FormRecuperarSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(lblStatus);
            Controls.Add(label2);
            Controls.Add(btnEnviarCodigo);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Name = "FormRecuperarSenha";
            Text = "FormRecuperarSenha";
            Load += FormRecuperarSenha_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private Button btnEnviarCodigo;
        private Label label2;
        private Label lblStatus;
    }
}