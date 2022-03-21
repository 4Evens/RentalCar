using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntitiyFramework;
using DataAccess.Abstrack;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarwindContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarwindContext context = new CarwindContext())
            {
                // return CarDetailDtos(context);
                return CarDetails2(context);
            }
        }

        private static List<CarDetailDto> CarDetails2(CarwindContext context)
        {
            var result = from p in context.Cars
                         join c in context.Cars
                             on p.CarId equals c.CarId
                         //join b in context.Brands on c.BrandId equals b.BrandId
                         //join co in context.Colors on c.ColorId equals co.ColorId
                         select new CarDetailDto
                         {
                             CarId = p.CarId,
                             CarName = p.CarName,
                             DailyPrice = p.DailyPrice,
                             Description = p.Description,
                             ModelYear = p.ModelYear
                         };

            return result.ToList();
        }

        private static List<CarDetailDto> CarDetailDtos(CarwindContext context)
        {
            var result = from c in context.Cars
                         join b in context.Brands on c.BrandId equals b.BrandId
                         join co in context.Colors on c.ColorId equals co.ColorId
                         select new CarDetailDto()
                         {
                             CarName = c.CarName,
                             BrandName = b.BrandName,
                             ColorName = co.ColorName,
                             Description = c.Description,
                             //ModelYear = c.ModelYear,
                             DailyPrice = c.DailyPrice
                         };
            return result.ToList();
        }
    }
}
