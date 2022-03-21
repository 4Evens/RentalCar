using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstrack
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetUserById(int id);
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
    }
}
