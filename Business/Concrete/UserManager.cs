using System;
using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Hashing;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IDataResult<List<User>> GetAllUsers()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(filter : null));
        }

        public IDataResult<User> GetById(int userId)
        {
            return new SuccessDataResult<User>(_userDal.Get(filter: u=> u.Id == userId, true));
        }

        public IDataResult<User> GetUserByEmail(string email)
        {
            return new SuccessDataResult<User>(_userDal.Get(filter: u=> u.Email == email, true));
        }

        public IDataResult<User> GetUserByEmailAndPassword(string email, string password)
        {
            var userToCheck = _userDal.Get(x=> x.Email == email,true);

            if (userToCheck == null)
            {
                return new ErrorDataResult<User>(Messages.UserNotFound);
            }

            if (!HashingHelper.VerifyPasswordHash(password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<User>(Messages.PasswordError);
            }

            return new SuccessDataResult<User>(userToCheck, Messages.SuccessfullLogin);

        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }

        //validation
        //yapısal durum
        //username boş geçilmemeli
        //bunu  urada yazmamamızın sebebi web api kullandık ui kullandığımızda 2 defa yazmamak adına
        //business ın bir girdisidir ama business değildir.
        //propertylerde requi.. diyer yazar isek business a ait alan şeyleri entity de yazmış oluruz ki bu da solid e ters

    }
}