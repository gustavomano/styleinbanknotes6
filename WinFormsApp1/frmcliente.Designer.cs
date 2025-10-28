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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            picFotoPerfil = new PictureBox();
            btnAlterarFoto = new Button();
            Dados_Pessoais = new TabControl();
            tabPage1 = new TabPage();
            label2 = new Label();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            btnSalvarDados = new Label();
            label1 = new Label();
            Histórico = new TabPage();
            label3 = new Label();
            btnGerarPDF = new Button();
            dgvHistorico = new DataGridView();
            PedidoId = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            DATA = new DataGridViewTextBoxColumn();
            ValorTotal = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            btnAlterarSenha = new Button();
            txtConfirmarSenha = new TextBox();
            txtNovaSenha = new TextBox();
            txtSenhaAtual = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)picFotoPerfil).BeginInit();
            Dados_Pessoais.SuspendLayout();
            tabPage1.SuspendLayout();
            Histórico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // picFotoPerfil
            // 
            picFotoPerfil.BorderStyle = BorderStyle.FixedSingle;
            picFotoPerfil.Image = Properties.Resources.avatar_padrao;
            picFotoPerfil.Location = new Point(65, 85);
            picFotoPerfil.Name = "picFotoPerfil";
            picFotoPerfil.Size = new Size(125, 125);
            picFotoPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            picFotoPerfil.TabIndex = 0;
            picFotoPerfil.TabStop = false;
            // 
            // btnAlterarFoto
            // 
            btnAlterarFoto.BackColor = Color.FromArgb(171, 0, 8);
            btnAlterarFoto.FlatStyle = FlatStyle.Popup;
            btnAlterarFoto.Font = new Font("Impact", 11F);
            btnAlterarFoto.Location = new Point(65, 216);
            btnAlterarFoto.Name = "btnAlterarFoto";
            btnAlterarFoto.Size = new Size(125, 27);
            btnAlterarFoto.TabIndex = 2;
            btnAlterarFoto.Text = "ALTERAR FOTO";
            btnAlterarFoto.UseVisualStyleBackColor = false;
            btnAlterarFoto.Click += button1_Click;
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
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(txtNome);
            tabPage1.Controls.Add(btnSalvarDados);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(picFotoPerfil);
            tabPage1.Controls.Add(btnAlterarFoto);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 434);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados Pessoais";
            tabPage1.Click += tabPage1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(299, 152);
            label2.Name = "label2";
            label2.Size = new Size(53, 23);
            label2.TabIndex = 8;
            label2.Text = "EMAIL";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(299, 178);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 23);
            txtEmail.TabIndex = 7;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(299, 120);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 23);
            txtNome.TabIndex = 6;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // btnSalvarDados
            // 
            btnSalvarDados.AutoSize = true;
            btnSalvarDados.Cursor = Cursors.Hand;
            btnSalvarDados.Font = new Font("Impact", 14F, FontStyle.Underline);
            btnSalvarDados.ForeColor = SystemColors.ButtonHighlight;
            btnSalvarDados.Location = new Point(127, 362);
            btnSalvarDados.Name = "btnSalvarDados";
            btnSalvarDados.Size = new Size(156, 23);
            btnSalvarDados.TabIndex = 4;
            btnSalvarDados.Text = "SALVAR ALTERAÇÕES";
            btnSalvarDados.Click += btnSalvarDados_Click;
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
            Histórico.Controls.Add(label3);
            Histórico.Controls.Add(btnGerarPDF);
            Histórico.Controls.Add(dgvHistorico);
            Histórico.Location = new Point(4, 24);
            Histórico.Name = "Histórico";
            Histórico.Padding = new Padding(3);
            Histórico.Size = new Size(792, 434);
            Histórico.TabIndex = 1;
            Histórico.Text = "Histórico de compra";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(265, 66);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 4;
            // 
            // btnGerarPDF
            // 
            btnGerarPDF.Location = new Point(345, 301);
            btnGerarPDF.Name = "btnGerarPDF";
            btnGerarPDF.Size = new Size(168, 24);
            btnGerarPDF.TabIndex = 4;
            btnGerarPDF.Text = "VER DETALHES/GERAR PDF";
            btnGerarPDF.UseVisualStyleBackColor = true;
            btnGerarPDF.Click += btnGerarPDF_Click;
            // 
            // dgvHistorico
            // 
            dgvHistorico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorico.Columns.AddRange(new DataGridViewColumn[] { PedidoId, Status, DATA, ValorTotal });
            dgvHistorico.Location = new Point(86, 106);
            dgvHistorico.Name = "dgvHistorico";
            dgvHistorico.ReadOnly = true;
            dgvHistorico.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorico.Size = new Size(427, 150);
            dgvHistorico.TabIndex = 0;
            dgvHistorico.CellContentClick += dgvHistorico_CellContentClick;
            // 
            // PedidoId
            // 
            PedidoId.DataPropertyName = "PedidoId";
            PedidoId.FillWeight = 25F;
            PedidoId.HeaderText = "ID DA COMPRA";
            PedidoId.Name = "PedidoId";
            PedidoId.ReadOnly = true;
            PedidoId.Width = 125;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // DATA
            // 
            DATA.DataPropertyName = "DataPedido";
            DATA.HeaderText = "DATA";
            DATA.Name = "DATA";
            DATA.ReadOnly = true;
            // 
            // ValorTotal
            // 
            ValorTotal.DataPropertyName = "ValorTotal";
            dataGridViewCellStyle2.Format = "c";
            ValorTotal.DefaultCellStyle = dataGridViewCellStyle2;
            ValorTotal.FillWeight = 25F;
            ValorTotal.HeaderText = "VALOR TOTAL";
            ValorTotal.Name = "ValorTotal";
            ValorTotal.ReadOnly = true;
            ValorTotal.Width = 125;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.WindowFrame;
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label4);
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
            btnAlterarSenha.Location = new Point(261, 212);
            btnAlterarSenha.Name = "btnAlterarSenha";
            btnAlterarSenha.Size = new Size(109, 23);
            btnAlterarSenha.TabIndex = 3;
            btnAlterarSenha.Text = "ALTERAR SENHA";
            btnAlterarSenha.UseVisualStyleBackColor = true;
            btnAlterarSenha.Click += btnAlterarSenha_Click;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(203, 120);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Size = new Size(100, 23);
            txtConfirmarSenha.TabIndex = 2;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Location = new Point(203, 87);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(100, 23);
            txtNovaSenha.TabIndex = 1;
            // 
            // txtSenhaAtual
            // 
            txtSenhaAtual.Location = new Point(203, 55);
            txtSenhaAtual.Name = "txtSenhaAtual";
            txtSenhaAtual.Size = new Size(100, 23);
            txtSenhaAtual.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(113, 58);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 4;
            label4.Text = "SENHA ATUAL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(113, 90);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 4;
            label5.Text = "SENHA NOVA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(77, 123);
            label6.Name = "label6";
            label6.Size = new Size(116, 15);
            label6.TabIndex = 4;
            label6.Text = "CONFIRMAR SENHA";
            // 
            // frmcliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 457);
            Controls.Add(Dados_Pessoais);
            Name = "frmcliente";
            Text = "frmcliente";
            Load += frmcliente_Load;
            ((System.ComponentModel.ISupportInitialize)picFotoPerfil).EndInit();
            Dados_Pessoais.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            Histórico.ResumeLayout(false);
            Histórico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picFotoPerfil;
        private Button btnAlterarFoto;
        private TabControl Dados_Pessoais;
        private TabPage tabPage1;
        private TabPage Histórico;
        private TabPage tabPage3;
        private TextBox txtEmail;
        private TextBox txtNome;
        private Label btnSalvarDados;
        private Label label1;
        private DataGridView dgvHistorico;
        private Button btnGerarPDF;
        private Button btnAlterarSenha;
        private TextBox txtConfirmarSenha;
        private TextBox txtNovaSenha;
        private TextBox txtSenhaAtual;
        private Label label2;
        private Label label3;
        private DataGridViewTextBoxColumn PedidoId;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn DATA;
        private DataGridViewTextBoxColumn ValorTotal;
        private Label label5;
        private Label label4;
        private Label label6;
    }
}