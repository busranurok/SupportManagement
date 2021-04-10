using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Core.Entities.Concrete;
using Core.Utilities.Security.Encyption;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Core.Utilities.Security.Jwt
{
    public class JwtHelper : ITokenHelper
    {
        //token oluşturma işlemleri
        public IConfiguration Configuration { get; }
        public TokenOptions _tokenOptions;
        public DateTime _accesTokenExpiration;

        //web api deki appsettingdeki ilgiyi bunun aracılığı ile okuyacağız
        public JwtHelper(IConfiguration configuration)
        {
            Configuration = configuration;
            //.net core tokenoptions bilgilerini alıp bu nesneye bind ediyor.
            _tokenOptions = Configuration.GetSection(key: "TokenOptions").Get<TokenOptions>();
            
        }

        public AccessToken CreateToken(User user)
        {
            //şimdi ye 50 dk olarak ekle bunu diyoruz. 50 dk sonra tarihim geçecek.
            _accesTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration);
            var securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey);
            var signingCredentials = SigningCredentialsHelper.CreateSigningCredentials(securityKey);
            var jwt = CreateJwtSecurityToken(_tokenOptions, user, signingCredentials);
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var token = jwtSecurityTokenHandler.WriteToken(jwt);


            return new AccessToken
            {
                Token = token,
                Expiration = _accesTokenExpiration
            };

        }

        //token nesnesini oluşturuyoruz.
        //
        public JwtSecurityToken CreateJwtSecurityToken(TokenOptions tokenOptions, User user,
            SigningCredentials signingCredentials)
        {
            var jwt = new JwtSecurityToken(
                issuer: tokenOptions.Issuer,
                audience: tokenOptions.Audience,
                expires: _accesTokenExpiration,
                notBefore: DateTime.Now,
                signingCredentials: signingCredentials
                );
            return jwt;
        }
    }
}