using System;
namespace Core.Utilities.Security.Jwt
{
    public class AccessToken
    {
        //oluşturulan token
        public AccessToken()
        {
        }

        public string Token { get; set; }
        //Tokenımız ne kadar geçerli
        public DateTime Expiration { get; set; }
    }
}
