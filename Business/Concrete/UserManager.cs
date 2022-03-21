using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstrack;
using Core.Utilities.Results;
using DataAccess.Abstrack;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _usersDal;

        public UserManager(IUserDal usersDal)
        {
            _usersDal = usersDal;
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_usersDal.GetAll());
        }

        public IDataResult<User> GetUserById(int id)
        {
            return new SuccessDataResult<User>(_usersDal.Get(u => u.UserId == id));
        }

        public IResult Add(User user)
        {
            _usersDal.Add(user);
            return new SuccessResult();
        }

        public IResult Update(User user)
        {
            _usersDal.Update(user);
            return new SuccessResult();
        }

        public IResult Delete(User user)
        {
            _usersDal.Delete(user);
            return new SuccessResult();
        }
    }
}
