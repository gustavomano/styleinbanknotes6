using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.Cmp;

namespace styleinbanknotes
{
    public partial class FormRecuperarSenha : Form
    {
        public FormRecuperarSenha()
        {
            InitializeComponent();
        }

        private void FormRecuperarSenha_Load(object sender, EventArgs e)
        {

        }

        private async void btnRecuperar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Por favor, digite um e-mail.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnEnviarCodigo.Enabled = false;
            lblStatus.Text = "Gerando código...";

            try
            {
                
                var random = new Random();
                string token = random.Next(100000, 999999).ToString();

               
                DateTime expiracao = DateTime.UtcNow.AddMinutes(15);

               
                var dbHelper = new DatabaseHelper("Server=sqlexpress;Database=cj3022129pr2;User Id=aluno;Password=aluno;");
                bool tokenSalvo = await dbHelper.SalvarTokenRedefinicaoAsync(email, token, expiracao);

                if (tokenSalvo)
                {
                    EmailService emailService = new EmailService();
                    string assunto = "Código de Redefinição de Senha";
                    string corpo = $"Olá!\n\nSeu código para redefinir a senha é: {token}\n\nEste código é válido por 15 minutos. Ignore este e-mail se você não solicitou.";

                    // --- AQUI ESTÁ A CORREÇÃO ---
                    // Recebemos os dois valores (a tupla) que o método retorna
                    var (emailEnviado, erroMsg) = await emailService.EnviarEmailAsync(email, assunto, corpo);

                    if (emailEnviado)
                    {
                        MessageBox.Show("Um código de verificação foi enviado para o seu e-mail.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Supondo que você precise passar o e-mail para a próxima tela
                        frmRedefinirSenha frm = new frmRedefinirSenha(email);
                        frm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        // Agora podemos mostrar o erro real que o EmailService nos deu!
                        MessageBox.Show("Erro ao enviar o e-mail. Tente novamente.\n\nDetalhe do erro: " + erroMsg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Erro ao salvar o token de recuperação no banco.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnEnviarCodigo.Enabled = true;
            }
        }
    }
}
