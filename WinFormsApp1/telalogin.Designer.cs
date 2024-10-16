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
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            bTConfirmar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = styleinbanknotes.Properties.Resources.telalogin1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1094, 801);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuText;
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(539, 429);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.MenuText;
            textBox2.ForeColor = SystemColors.Window;
            textBox2.Location = new Point(555, 495);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(185, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.MenuText;
            textBox3.ForeColor = SystemColors.Window;
            textBox3.Location = new Point(555, 562);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(185, 23);
            textBox3.TabIndex = 3;
            // 
            // bTConfirmar
            // 
            bTConfirmar.AccessibleRole = AccessibleRole.None;
            bTConfirmar.Anchor = AnchorStyles.None;
            bTConfirmar.BackColor = Color.FromArgb(255, 128, 0);
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
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "Telalogin";
            Text = "Telalogin";
            Load += Telalogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button bTConfirmar;
    }
}