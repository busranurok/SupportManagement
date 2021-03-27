using System;
namespace Core.Utilities.Security.Jwt
{
    public class TokenOptions
    {
        //token oluşturulur iken kullanılacak seçenekler
        public TokenOptions()
        {
        }

        //tokenımızın kullanıcı kitlesi
        public string Audience { get; set; }
        //imzalayan
        public string Issuer { get; set; }
        //dk cinsinden veriyoruz
        public int AccessTokenExpiration{ get; set; }
        public string SecurityKey { get; set; }

    }
}
