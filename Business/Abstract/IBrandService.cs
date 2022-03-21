using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstrack
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        IDataResult<Brand> GetBrandById(int id);
        IResult Add(Brand brand);
        IResult Update(Brand brand);
        IResult Delete(Brand brand);
    }
}
