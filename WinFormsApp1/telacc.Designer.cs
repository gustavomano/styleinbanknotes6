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
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // 
            // BTMCONFIRM
            // 
            BTMCONFIRM.BackColor = Color.Red;
            BTMCONFIRM.BackgroundImageLayout = ImageLayout.None;
            BTMCONFIRM.Cursor = Cursors.Hand;
            BTMCONFIRM.FlatStyle = FlatStyle.Popup;
            BTMCONFIRM.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTMCONFIRM.ForeColor = Color.Black;
            BTMCONFIRM.Location = new Point(821, 524);
            BTMCONFIRM.Name = "BTMCONFIRM";
            BTMCONFIRM.Size = new Size(91, 23);
            BTMCONFIRM.TabIndex = 6;
            BTMCONFIRM.Text = "CONFIRMAR";
            BTMCONFIRM.UseVisualStyleBackColor = false;
            BTMCONFIRM.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.MenuText;
            textBox3.ForeColor = SystemColors.Window;
            textBox3.Location = new Point(656, 383);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(185, 23);
            textBox3.TabIndex = 7;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.MenuText;
            textBox4.ForeColor = SystemColors.Window;
            textBox4.Location = new Point(656, 430);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(185, 23);
            textBox4.TabIndex = 8;
            // 
            // telacc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1733, 1061);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(BTMCONFIRM);
            Controls.Add(pictureBox1);
            Name = "telacc";
            Text = "telacc";
            Load += telacc_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BTMCONFIRM;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}