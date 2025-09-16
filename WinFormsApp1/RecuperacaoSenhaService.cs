using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace styleinbanknotes
{
    internal class RecuperacaoSenhaService
    {
        public static bool EnviarCodigo(string email)
        {
            var usuario = UsuarioRepositorio.ObterPorEmail(email);
            if (usuario == null)
                return true; 

           
            var random = new Random();
            string codigo = random.Next(100000, 999999).ToString();

           
            usuario.CodigoRecuperacao = codigo;
            usuario.CodigoExpiracao = DateTime.UtcNow.AddMinutes(10);
            UsuarioRepositorio.Atualizar(usuario);

         
            string assunto = "Código de recuperação de senha";
            string corpo = $"Seu código de recuperação é: {codigo} (válido por 10 minutos).";

            try
            {
                EmailHelper.Enviar(email, assunto, corpo);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
