using System;
using System.Data.SqlClient;
using System.Threading.Tasks;



public class DatabaseHelper
{
    
    


    string _connectionString = "Server=sqlexpress;Database=cj3022129pr2;User Id=aluno;Password=aluno;";
    public DatabaseHelper(string connectionString)
    {
        _connectionString = connectionString;
    }

    /// <summary>
    /// Salva um token de redefinição e sua data de expiração no registro do usuário.
    /// </summary>
    /// <param name="email">O e-mail do usuário que solicitou a redefinição.</param>
    /// <param name="token">O token gerado para a redefinição.</param>
    /// <param name="expiracao">A data e hora em que o token irá expirar.</param>
    /// <returns>Retorna 'true' se o token foi salvo com sucesso (usuário encontrado), e 'false' caso contrário.</returns>
    public async Task<bool> SalvarTokenRedefinicaoAsync(string email, string token, DateTime expiracao)
    {
        
        string query = @"
            UPDATE cadastro 
            SET ResetToken = @Token, ResetTokenExpiration = @Expiracao 
            WHERE Email = @Email";

   
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                
                command.Parameters.AddWithValue("@Token", token);
                command.Parameters.AddWithValue("@Expiracao", expiracao);
                command.Parameters.AddWithValue("@Email", email);

                await connection.OpenAsync();

     
                int linhasAfetadas = await command.ExecuteNonQueryAsync();

                
                return linhasAfetadas > 0;
            }
        }
    }

  
    /// <param name="email">O e-mail do usuário.</param>
    /// <param name="token">O token que o usuário informou.</param>
    /// <param name="novoHashSenha">O novo hash da nova senha do usuário.</param>
    /// <returns>Retorna 'true' se a senha foi redefinida, e 'false' se o token for inválido ou expirado.</returns>
    public async Task<bool> RedefinirSenhaComTokenAsync(string email, string token, string novoHashSenha)
    {
        string query = @"
            UPDATE cadastro 
            SET Senha = @NovoHash, ResetToken = NULL, ResetTokenExpiration = NULL 
            WHERE Email = @Email 
              AND ResetToken = @Token 
              AND ResetTokenExpiration > GETUTCDATE()";

        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@NovoHash", novoHashSenha);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Token", token);

                await connection.OpenAsync();

                int linhasAfetadas = await command.ExecuteNonQueryAsync();

                return linhasAfetadas > 0;
            }
        }
    }
}