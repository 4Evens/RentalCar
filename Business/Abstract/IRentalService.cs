using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstrack
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetRentalById(int id);
        IDataResult<List<Rental>> GetRentalByCarId(int id);
        IDataResult<List<Rental>> GetRentalByCustomerId(int id);
        IResult Add(Rental rental);
        IResult Update(Rental rental);
        IResult Delete(Rental rental);
    }
}
