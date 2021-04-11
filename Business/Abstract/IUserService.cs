using System;
using System.Collections.Generic;
using Core.Utilities.Results.Abstract;
using Core.Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<User> GetById(int userId);
        IDataResult<List<User>> GetAllUsers();
        IDataResult<User> GetUserByEmail(string email);
        IDataResult<User> GetUserByEmailAndPassword(string email, string password);
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
    }
}
