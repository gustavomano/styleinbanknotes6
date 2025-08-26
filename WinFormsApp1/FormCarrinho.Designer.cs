namespace styleinbanknotes
{
    partial class FormCarrinho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCarrinho));
            dgvCarrinho = new DataGridView();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvCarrinho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dgvCarrinho
            // 
            dgvCarrinho.BackgroundColor = Color.FromArgb(171, 0, 8);
            dgvCarrinho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrinho.Location = new Point(244, 188);
            dgvCarrinho.Name = "dgvCarrinho";
            dgvCarrinho.Size = new Size(310, 170);
            dgvCarrinho.TabIndex = 0;
            dgvCarrinho.CellContentClick += dgvCarrinho_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(244, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(310, 160);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // FormCarrinho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCarrinho);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "FormCarrinho";
            Text = "FormCarrinho";
            Load += FormCarrinho_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarrinho).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCarrinho;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}