﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstrack
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetAll();

        IDataResult<Category> GetById(int categoryId);
    }
}
