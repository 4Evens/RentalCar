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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }

        public IDataResult<Color> GetColorById(int id)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(c=>c.ColorId==id));
        }

        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult();
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult();
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult();
        }
    }
}
