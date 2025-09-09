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
            dataGridViewPedidos = new DataGridView();
            label1 = new Label();
            comboBoxStatus = new ComboBox();
            buttonAtualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPedidos).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPedidos
            // 
            dataGridViewPedidos.AllowUserToAddRows = false;
            dataGridViewPedidos.AllowUserToDeleteRows = false;
            dataGridViewPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPedidos.Location = new Point(12, 12);
            dataGridViewPedidos.MultiSelect = false;
            dataGridViewPedidos.Name = "dataGridViewPedidos";
            dataGridViewPedidos.ReadOnly = true;
            dataGridViewPedidos.RowHeadersWidth = 51;
            dataGridViewPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPedidos.Size = new Size(760, 300);
            dataGridViewPedidos.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 330);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 1;
            label1.Text = "Novo Status:";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(133, 327);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(250, 23);
            comboBoxStatus.TabIndex = 2;
            // 
            // buttonAtualizar
            // 
            buttonAtualizar.FlatStyle = FlatStyle.Popup;
            buttonAtualizar.Location = new Point(409, 346);
            buttonAtualizar.Name = "buttonAtualizar";
            buttonAtualizar.Size = new Size(106, 23);
            buttonAtualizar.TabIndex = 0;
            buttonAtualizar.Text = "ATUALIZAR STATUS";
            buttonAtualizar.Click += buttonAtualizar_Click_1;
            // 
            // FormAdmin
            // 
            ClientSize = new Size(784, 381);
            Controls.Add(buttonAtualizar);
            Controls.Add(comboBoxStatus);
            Controls.Add(label1);
            Controls.Add(dataGridViewPedidos);
            Name = "FormAdmin";
            Text = "Administração de Pedidos";
            Load += FormAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPedidos;
            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.ComboBox comboBoxStatus;
            private System.Windows.Forms.Button buttonAtualizar;
        }
    }

