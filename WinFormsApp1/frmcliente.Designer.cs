namespace styleinbanknotes
{
    partial class frmcliente
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
            fotoPerfil = new PictureBox();
            button1 = new Button();
            Dados_Pessoais = new TabControl();
            tabPage1 = new TabPage();
            btnSalvarDados = new Button();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Histórico = new TabPage();
            btnGerarPdf = new Button();
            dgvHistorico = new DataGridView();
            IDcompra = new DataGridViewTextBoxColumn();
            DATA = new DataGridViewTextBoxColumn();
            VALOR = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            btnAlterarSenha = new Button();
            txtConfirmarSenha = new TextBox();
            txtNovaSenha = new TextBox();
            txtSenhaAtual = new TextBox();
            ((System.ComponentModel.ISupportInitialize)fotoPerfil).BeginInit();
            Dados_Pessoais.SuspendLayout();
            tabPage1.SuspendLayout();
            Histórico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // fotoPerfil
            // 
            fotoPerfil.BorderStyle = BorderStyle.FixedSingle;
            fotoPerfil.Image = Properties.Resources.avatar_padrao;
            fotoPerfil.Location = new Point(52, 35);
            fotoPerfil.Name = "fotoPerfil";
            fotoPerfil.Size = new Size(125, 125);
            fotoPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            fotoPerfil.TabIndex = 0;
            fotoPerfil.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(171, 0, 8);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 7F);
            button1.Location = new Point(96, 179);
            button1.Name = "button1";
            button1.Size = new Size(81, 22);
            button1.TabIndex = 2;
            button1.Text = "ALTERAR FOTO";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Dados_Pessoais
            // 
            Dados_Pessoais.Controls.Add(tabPage1);
            Dados_Pessoais.Controls.Add(Histórico);
            Dados_Pessoais.Controls.Add(tabPage3);
            Dados_Pessoais.Location = new Point(0, 0);
            Dados_Pessoais.Name = "Dados_Pessoais";
            Dados_Pessoais.SelectedIndex = 0;
            Dados_Pessoais.Size = new Size(800, 462);
            Dados_Pessoais.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(171, 0, 8);
            tabPage1.Controls.Add(btnSalvarDados);
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(txtNome);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(fotoPerfil);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 434);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados Pessoais";
            // 
            // btnSalvarDados
            // 
            btnSalvarDados.Location = new Point(491, 327);
            btnSalvarDados.Name = "btnSalvarDados";
            btnSalvarDados.Size = new Size(75, 23);
            btnSalvarDados.TabIndex = 4;
            btnSalvarDados.Text = "button3";
            btnSalvarDados.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(299, 178);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 23);
            txtEmail.TabIndex = 7;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(299, 120);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 23);
            txtNome.TabIndex = 6;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(453, 276);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(427, 158);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(299, 85);
            label1.Name = "label1";
            label1.Size = new Size(52, 23);
            label1.TabIndex = 3;
            label1.Text = "NOME";
            // 
            // Histórico
            // 
            Histórico.BackColor = SystemColors.WindowFrame;
            Histórico.Controls.Add(btnGerarPdf);
            Histórico.Controls.Add(dgvHistorico);
            Histórico.Location = new Point(4, 24);
            Histórico.Name = "Histórico";
            Histórico.Padding = new Padding(3);
            Histórico.Size = new Size(792, 434);
            Histórico.TabIndex = 1;
            Histórico.Text = "Histórico de compra";
            // 
            // btnGerarPdf
            // 
            btnGerarPdf.Location = new Point(528, 311);
            btnGerarPdf.Name = "btnGerarPdf";
            btnGerarPdf.Size = new Size(168, 24);
            btnGerarPdf.TabIndex = 4;
            btnGerarPdf.Text = "VER DETALHES/GERAR PDF";
            btnGerarPdf.UseVisualStyleBackColor = true;
            // 
            // dgvHistorico
            // 
            dgvHistorico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorico.Columns.AddRange(new DataGridViewColumn[] { IDcompra, DATA, VALOR });
            dgvHistorico.Location = new Point(134, 113);
            dgvHistorico.Name = "dgvHistorico";
            dgvHistorico.Size = new Size(427, 150);
            dgvHistorico.TabIndex = 0;
            // 
            // IDcompra
            // 
            IDcompra.FillWeight = 25F;
            IDcompra.HeaderText = "ID DA COMPRA";
            IDcompra.Name = "IDcompra";
            IDcompra.Width = 125;
            // 
            // DATA
            // 
            DATA.HeaderText = "DATA";
            DATA.Name = "DATA";
            // 
            // VALOR
            // 
            VALOR.FillWeight = 25F;
            VALOR.HeaderText = "VALOR TOTAL";
            VALOR.Name = "VALOR";
            VALOR.Width = 125;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.WindowFrame;
            tabPage3.Controls.Add(btnAlterarSenha);
            tabPage3.Controls.Add(txtConfirmarSenha);
            tabPage3.Controls.Add(txtNovaSenha);
            tabPage3.Controls.Add(txtSenhaAtual);
            tabPage3.ForeColor = SystemColors.ControlDark;
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 434);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Segurança";
            // 
            // btnAlterarSenha
            // 
            btnAlterarSenha.Location = new Point(580, 277);
            btnAlterarSenha.Name = "btnAlterarSenha";
            btnAlterarSenha.Size = new Size(75, 23);
            btnAlterarSenha.TabIndex = 3;
            btnAlterarSenha.Text = "button2";
            btnAlterarSenha.UseVisualStyleBackColor = true;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(357, 194);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Size = new Size(100, 23);
            txtConfirmarSenha.TabIndex = 2;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Location = new Point(314, 119);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(100, 23);
            txtNovaSenha.TabIndex = 1;
            // 
            // txtSenhaAtual
            // 
            txtSenhaAtual.Location = new Point(353, 64);
            txtSenhaAtual.Name = "txtSenhaAtual";
            txtSenhaAtual.Size = new Size(100, 23);
            txtSenhaAtual.TabIndex = 0;
            // 
            // frmcliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 457);
            Controls.Add(Dados_Pessoais);
            Name = "frmcliente";
            Text = "frmcliente";
            ((System.ComponentModel.ISupportInitialize)fotoPerfil).EndInit();
            Dados_Pessoais.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            Histórico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox fotoPerfil;
        private Button button1;
        private TabControl Dados_Pessoais;
        private TabPage tabPage1;
        private TabPage Histórico;
        private TabPage tabPage3;
        private TextBox txtEmail;
        private TextBox txtNome;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvHistorico;
        private Button btnGerarPdf;
        private DataGridViewTextBoxColumn IDcompra;
        private DataGridViewTextBoxColumn DATA;
        private DataGridViewTextBoxColumn VALOR;
        private Button btnAlterarSenha;
        private TextBox txtConfirmarSenha;
        private TextBox txtNovaSenha;
        private TextBox txtSenhaAtual;
        private Button btnSalvarDados;
    }
}