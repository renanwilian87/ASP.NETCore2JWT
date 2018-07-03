
namespace API
{
    /// <summary>
    /// User: tipo empregado na manipulação de credenciais de usuários;
    /// </summary>
    public class User
    {
        public string UserID { get; set; }
        public string AccessKey { get; set; }
    }

    /// <summary>
    /// TokenConfigurations: classe que conterá configurações (Audience, Issuer - emissor, Seconds - tempo de validade em segundos) empregadas na geração de tokens. 
    /// Estas definições serão obtidas a partir do arquivo appsettings.json.
    /// </summary>
    public class TokenConfigurations
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int Seconds { get; set; }
    }
}
