﻿using MAUIUI.Core.DataAccess.EntityFrameworkDal;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.DataAccess.Concrete
{
    public class SerologicalTestDal : EfEntityRepositoryBase<SerologicalTest, DatabaseContext>, ISerologicalTestDal
    {
    }
}