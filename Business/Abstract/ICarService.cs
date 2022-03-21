using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstrack
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetAllByCarId(int Id);
        IDataResult<List<Car>> GetCarsByBrandId(int BrandId);
        IDataResult<List<Car>> GetCarsByColorId(int ColorId);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
    }
}
