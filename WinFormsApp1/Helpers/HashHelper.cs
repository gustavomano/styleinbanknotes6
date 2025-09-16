using BCrypt.Net;

namespace WinFormsApp1.Helpers
{
    public static class HashHelper
    {
        public static string Hash(string senha) =>
            BCrypt.Net.BCrypt.HashPassword(senha);

        public static bool Verificar(string senha, string hash) =>
            BCrypt.Net.BCrypt.Verify(senha, hash);
    }
}
