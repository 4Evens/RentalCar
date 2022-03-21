using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstrack
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetails();
    }
}
