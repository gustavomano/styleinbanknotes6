namespace styleinbanknotes
{
    partial class FormAtualizarEndereco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAtualizarEndereco));
            pictureBox1 = new PictureBox();
            txtEndereco = new TextBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtNumero = new TextBox();
            label3 = new Label();
            txtCidade = new TextBox();
            label4 = new Label();
            txtCEP = new TextBox();
            label5 = new Label();
            txtBairro = new TextBox();
            cmbEstado = new ComboBox();
            button1 = new Button();
            chkSemNumero = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1240, 595);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtEndereco
            // 
            txtEndereco.BackColor = SystemColors.MenuText;
            txtEndereco.BorderStyle = BorderStyle.None;
            txtEndereco.ForeColor = SystemColors.Window;
            txtEndereco.Location = new Point(249, 209);
            txtEndereco.Multiline = true;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(141, 26);
            txtEndereco.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(492, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(523, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(171, 0, 8);
            label1.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(236, 180);
            label1.Name = "label1";
            label1.Size = new Size(49, 26);
            label1.TabIndex = 3;
            label1.Text = "RUA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(171, 0, 8);
            label2.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(238, 244);
            label2.Name = "label2";
            label2.Size = new Size(74, 26);
            label2.TabIndex = 4;
            label2.Text = "NÚMERO";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNumero
            // 
            txtNumero.BackColor = SystemColors.Desktop;
            txtNumero.BorderStyle = BorderStyle.None;
            txtNumero.ForeColor = SystemColors.Window;
            txtNumero.Location = new Point(249, 273);
            txtNumero.Multiline = true;
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(141, 26);
            txtNumero.TabIndex = 5;
            txtNumero.TextChanged += txtNumero_TextChanged;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(171, 0, 8);
            label3.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(236, 302);
            label3.Name = "label3";
            label3.Size = new Size(66, 26);
            label3.TabIndex = 6;
            label3.Text = "BAIRRO";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // txtCidade
            // 
            txtCidade.BackColor = SystemColors.Desktop;
            txtCidade.BorderStyle = BorderStyle.None;
            txtCidade.ForeColor = SystemColors.Window;
            txtCidade.Location = new Point(249, 389);
            txtCidade.Multiline = true;
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(141, 28);
            txtCidade.TabIndex = 7;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(171, 0, 8);
            label4.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(238, 423);
            label4.Name = "label4";
            label4.Size = new Size(39, 26);
            label4.TabIndex = 8;
            label4.Text = "CEP";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCEP
            // 
            txtCEP.BackColor = SystemColors.Desktop;
            txtCEP.BorderStyle = BorderStyle.None;
            txtCEP.ForeColor = SystemColors.Window;
            txtCEP.Location = new Point(249, 452);
            txtCEP.Multiline = true;
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(141, 26);
            txtCEP.TabIndex = 9;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(171, 0, 8);
            label5.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(238, 360);
            label5.Name = "label5";
            label5.Size = new Size(66, 26);
            label5.TabIndex = 10;
            label5.Text = "CIDADE";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBairro
            // 
            txtBairro.BackColor = SystemColors.Desktop;
            txtBairro.BorderStyle = BorderStyle.None;
            txtBairro.ForeColor = SystemColors.Window;
            txtBairro.Location = new Point(249, 331);
            txtBairro.Multiline = true;
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(141, 26);
            txtBairro.TabIndex = 11;
            // 
            // cmbEstado
            // 
            cmbEstado.BackColor = Color.White;
            cmbEstado.FlatStyle = FlatStyle.Popup;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cmbEstado.Location = new Point(405, 394);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(73, 23);
            cmbEstado.TabIndex = 12;
            cmbEstado.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(171, 0, 8);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(526, 525);
            button1.Name = "button1";
            button1.Size = new Size(141, 48);
            button1.TabIndex = 13;
            button1.Text = "SALVAR ENDEREÇO";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // chkSemNumero
            // 
            chkSemNumero.BackColor = Color.FromArgb(171, 0, 8);
            chkSemNumero.Location = new Point(396, 273);
            chkSemNumero.Name = "chkSemNumero";
            chkSemNumero.Size = new Size(102, 26);
            chkSemNumero.TabIndex = 14;
            chkSemNumero.Text = "SEM NÚMERO";
            chkSemNumero.UseVisualStyleBackColor = false;
            chkSemNumero.CheckedChanged += chkSemNumero_CheckedChanged;
            // 
            // FormAtualizarEndereco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 595);
            Controls.Add(chkSemNumero);
            Controls.Add(button1);
            Controls.Add(cmbEstado);
            Controls.Add(txtBairro);
            Controls.Add(label5);
            Controls.Add(txtCEP);
            Controls.Add(label4);
            Controls.Add(txtCidade);
            Controls.Add(label3);
            Controls.Add(txtNumero);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(txtEndereco);
            Controls.Add(pictureBox1);
            Name = "FormAtualizarEndereco";
            Text = "FormAtualizarEndereco";
            Load += FormAtualizarEndereco_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtEndereco;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private TextBox txtNumero;
        private Label label3;
        private TextBox txtCidade;
        private Label label4;
        private TextBox txtCEP;
        private Label label5;
        private TextBox txtBairro;
        private ComboBox cmbEstado;
        private Button button1;
        private CheckBox chkSemNumero;
    }
}