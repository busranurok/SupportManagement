﻿using System;
using Core.Entities.Concrete;

namespace Core.Utilities.Security.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user);
        //AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
