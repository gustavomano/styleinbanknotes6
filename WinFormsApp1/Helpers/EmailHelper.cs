using System.Net;
using System.Net.Mail;

namespace WinFormsApp1.Helpers
{
    public static class EmailHelper
    {
        public static void Enviar(string destinatario, string assunto, string corpo)
        {
            using (var client = new SmtpClient("smtp.seuservidor.com", 587)) // ajuste
            {
                client.Credentials = new NetworkCredential("seuemail@dominio.com", "suasenha");
                client.EnableSsl = true;

                var mail = new MailMessage("seuemail@dominio.com", destinatario, assunto, corpo);
                client.Send(mail);
            }
        }
    }
}
