using WinFormsApp1.Helpers;
using WinFormsApp1.Models;
using WinFormsApp1.Repositories;
using System;

namespace WinFormsApp1.Services
{
    public static class RecuperacaoSenhaService
    {
        public static bool EnviarCodigo(string email)
        {
            var usuario = UsuarioRepositorio.ObterPorEmail(email);
            if (usuario == null) return true;

            var rnd = new Random();
            string codigo = rnd.Next(100000, 999999).ToString();

            usuario.CodigoRecuperacao = codigo;
            usuario.CodigoExpiracao = DateTime.UtcNow.AddMinutes(10);
            UsuarioRepositorio.Atualizar(usuario);

            string assunto = "Código de recuperação de senha";
            string corpo = $"Seu código de recuperação é: {codigo} (válido por 10 minutos).";

            EmailHelper.Enviar(email, assunto, corpo);
            return true;
        }

        public static bool ValidarCodigo(string email, string codigo)
        {
            var usuario = UsuarioRepositorio.ObterPorEmail(email);
            if (usuario == null) return false;

            return usuario.CodigoRecuperacao == codigo &&
                   usuario.CodigoExpiracao > DateTime.UtcNow;
        }

        public static bool RedefinirSenha(string email, string novaSenha)
        {
            var usuario = UsuarioRepositorio.ObterPorEmail(email);
            if (usuario == null) return false;

            usuario.SenhaHash = HashHelper.Hash(novaSenha);
            usuario.CodigoRecuperacao = null;
            usuario.CodigoExpiracao = null;
            UsuarioRepositorio.Atualizar(usuario);

            return true;
        }
    }
}
