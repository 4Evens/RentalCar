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
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalsDal;

        public RentalManager(IRentalDal rentalsDal)
        {
            _rentalsDal = rentalsDal;
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalsDal.GetAll());
        }

        public IDataResult<Rental> GetRentalById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalsDal.Get(r => r.CarId == id));
        }

        public IDataResult<List<Rental>> GetRentalByCarId(int id)
        {
            return new SuccessDataResult<List<Rental>>(_rentalsDal.GetAll(r => r.CarId == id));
        }

        public IDataResult<List<Rental>> GetRentalByCustomerId(int id)
        {
            return new SuccessDataResult<List<Rental>>(_rentalsDal.GetAll(r => r.CustomerId == id));
        }

        public IResult Add(Rental rental)
        {
            var result = _rentalsDal.GetAll(r => r.CarId == rental.CarId && r.ReturnDate != null);
            if (result.Count == 0)
            {
                return new ErrorResult("Araç Teslim edilmemiş");
            }
            else
            {
                _rentalsDal.Add(rental);
                return new SuccessResult("Araba Kayıt Edildi");
            }
        }

        public IResult Update(Rental rental)
        {
            _rentalsDal.Update(rental);
            return new SuccessResult();
        }

        public IResult Delete(Rental rental)
        {
            _rentalsDal.Delete(rental);
            return new SuccessResult();
        }
    }
}
