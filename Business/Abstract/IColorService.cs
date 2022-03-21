﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstrack
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        IDataResult<Color> GetColorById(int id);
        IResult Add(Color color);
        IResult Update(Color color);
        IResult Delete(Color color);
    }
}
