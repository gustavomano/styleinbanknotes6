namespace styleinbanknotes
{
    partial class tlcad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tlcad));
            lblNome = new Label();
            lblEmail = new Label();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(297, 180);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(38, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "label1";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(297, 211);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(38, 15);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "label2";
            // 
            // tlcad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(lblEmail);
            Controls.Add(lblNome);
            Name = "tlcad";
            Text = "tlcliente";
            Load += tlcliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblEmail;
    }
}