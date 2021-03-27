using System;
using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Security.Jwt;
using Entities.DTOs;

namespace Business.Abstract
{
    //bu servis ile register ya da login olacağız
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);

        IResult UserExits(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
