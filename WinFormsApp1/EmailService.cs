

using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

public class EmailService
{
    public async Task<bool> EnviarEmailAsync(string destinatario, string assunto, string corpo)
    {
        try
        {
            
            string remetenteEmail = "guhalves552266@gmail.com";
            string remetenteSenha = "spnb pgti eboz quuq"; // MUITO IMPORTANTE!

            
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
                IsBodyHtml = false, // Defina como true se o corpo do e-mail for HTML
            };
            mailMessage.To.Add(destinatario);

            
            await smtpClient.SendMailAsync(mailMessage);

            return true; 
        }
        catch (Exception ex)
        {
           
            Console.WriteLine("Erro ao enviar e-mail: " + ex.Message);
            return false;
        }
    }
}