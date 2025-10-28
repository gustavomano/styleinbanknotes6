

using System;
using System.Net;
using System.Net.Mail;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;

public class EmailService
{
  
    public async Task<(bool, string)> EnviarEmailAsync(string destinatario, string assunto, string corpo)
    {
        try
        {
            string remetenteEmail = "sbn55226@gmail.com";
            string remetenteSenha = "cbbhhhbkqgcomhhm"; // Sua senha SEM espaços

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(remetenteEmail, remetenteSenha),
                EnableSsl = true,
            };

            MailMessage mailMessage = new MailMessage
            {
                From = new MailAddress(remetenteEmail, "SN"),
                Subject = assunto,
                Body = corpo,
                IsBodyHtml = false,
            };
            mailMessage.To.Add(destinatario);

            await smtpClient.SendMailAsync(mailMessage);

            // Sucesso! Retorna true e nenhuma mensagem de erro (null)
            return (true, null);
        }
        catch (Exception ex)
        {
            // Falha! Retorna false e a MENSAGEM DE ERRO REAL
            return (false, ex.Message);
        }
    }
}