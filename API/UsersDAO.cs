using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace API
{
    /// <summary>
    /// a classe UsersDAO acessará a base ExemploJWT e fará uso do Dapper, 
    /// retornando através do método Find instâncias do tipo User que conterão o ID de um usuário e sua respectiva chave de acesso:
    /// </summary>
    public class UsersDAO
    {
        private IConfiguration _configuration;

        public UsersDAO(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public User Find(string userID)
        {
            using (SqlConnection conexao = new SqlConnection(
                _configuration.GetConnectionString("ExemploJWT")))
            {
                return conexao.QueryFirstOrDefault<User>(
                    "SELECT UserID, AccessKey " +
                    "FROM dbo.Users " +
                    "WHERE UserID = @UserID", new { UserID = userID });
            }
        }
    }
}
