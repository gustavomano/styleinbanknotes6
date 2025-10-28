namespace styleinbanknotes
{
    
    
        partial class FormAdmin
        {
            private System.ComponentModel.IContainer components = null;

            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

        #region Código gerado pelo Designer

        private void InitializeComponent()
        {
            dgvPedidos = new DataGridView();
            label1 = new Label();
            comboBoxStatus = new ComboBox();
            buttonAtualizar = new Button();
            label2 = new Label();
            dgvItensPedido = new DataGridView();
            Produto = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).BeginInit();
            SuspendLayout();
            // 
            // dgvPedidos
            // 
            dgvPedidos.AllowUserToAddRows = false;
            dgvPedidos.AllowUserToDeleteRows = false;
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new Point(-1, 0);
            dgvPedidos.MultiSelect = false;
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.ReadOnly = true;
            dgvPedidos.RowHeadersWidth = 51;
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.Size = new Size(786, 240);
            dgvPedidos.TabIndex = 0;
            dgvPedidos.CellContentClick += dataGridViewPedidos_CellContentClick_1;
            dgvPedidos.SelectionChanged += dgvPedidos_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 283);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 1;
            label1.Text = "Novo Status:";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(92, 283);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(250, 23);
            comboBoxStatus.TabIndex = 2;
            comboBoxStatus.SelectedIndexChanged += comboBoxStatus_SelectedIndexChanged;
            // 
            // buttonAtualizar
            // 
            buttonAtualizar.FlatStyle = FlatStyle.Popup;
            buttonAtualizar.Location = new Point(366, 282);
            buttonAtualizar.Name = "buttonAtualizar";
            buttonAtualizar.Size = new Size(106, 23);
            buttonAtualizar.TabIndex = 0;
            buttonAtualizar.Text = "ATUALIZAR STATUS";
            buttonAtualizar.Click += buttonAtualizar_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(-1, 361);
            label2.Name = "label2";
            label2.Size = new Size(183, 19);
            label2.TabIndex = 3;
            label2.Text = "Itens do Pedido Selecionado:";
            // 
            // dgvItensPedido
            // 
            dgvItensPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensPedido.Columns.AddRange(new DataGridViewColumn[] { Produto, Quantidade });
            dgvItensPedido.Location = new Point(-1, 390);
            dgvItensPedido.Name = "dgvItensPedido";
            dgvItensPedido.Size = new Size(786, 150);
            dgvItensPedido.TabIndex = 4;
            // 
            // Produto
            // 
            Produto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Produto.DataPropertyName = "Produto";
            Produto.HeaderText = "Produto";
            Produto.Name = "Produto";
            // 
            // Quantidade
            // 
            Quantidade.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Quantidade.DataPropertyName = "Quantidade";
            Quantidade.HeaderText = "Qtd.";
            Quantidade.Name = "Quantidade";
            // 
            // FormAdmin
            // 
            ClientSize = new Size(784, 649);
            Controls.Add(dgvItensPedido);
            Controls.Add(label2);
            Controls.Add(buttonAtualizar);
            Controls.Add(comboBoxStatus);
            Controls.Add(label1);
            Controls.Add(dgvPedidos);
            Name = "FormAdmin";
            Text = "Administração de Pedidos";
            Load += FormAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedidos;
            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.ComboBox comboBoxStatus;
            private System.Windows.Forms.Button buttonAtualizar;
        private Label label2;
        private DataGridView dgvItensPedido;
        private DataGridViewTextBoxColumn Produto;
        private DataGridViewTextBoxColumn Quantidade;
    }
    }

