using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace styleinbanknotes
{
    public partial class frmRedefinirSenha : Form
    {
        public frmRedefinirSenha(string email)
        {
            InitializeComponent();

            txtEmail.Text = email;
            txtEmail.ReadOnly = true;

        }

        private async void btnRedefinir_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string token = txtToken.Text.Trim();
            string novaSenha = txtNovaSenha.Text;
            string confirmarSenha = txtConfirmarSenha.Text;

            // 1. Validações
            if (string.IsNullOrWhiteSpace(token) || string.IsNullOrWhiteSpace(novaSenha))
            {
                MessageBox.Show("Preencha o token e a nova senha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (novaSenha != confirmarSenha)
            {
                MessageBox.Show("As senhas não coincidem.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnRedefinir.Enabled = false;

            try
            {
               
                string novoHash = BCrypt.Net.BCrypt.HashPassword(novaSenha);

               
                var dbHelper = new DatabaseHelper("Server=sqlexpress;Database=cj3022129pr2;User Id=aluno;Password=aluno;");
                bool senhaRedefinida = await dbHelper.RedefinirSenhaComTokenAsync(email, token, novoHash);

                if (senhaRedefinida)
                {
                    MessageBox.Show("Senha redefinida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    telacc frm = new telacc();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Token inválido ou expirado. Por favor, solicite um novo código.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnRedefinir.Enabled = true;
            }
        }
    }
}

