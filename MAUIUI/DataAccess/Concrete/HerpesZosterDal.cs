using System;
using MAUIUI.Core.DataAccess.EntityFrameworkDal;
using MAUIUI.Core.Entities;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;
using MAUIUI.Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace MAUIUI.DataAccess.Concrete
{
    public class HerpesZosterDal : EfEntityRepositoryBase<HerpesZoster, DatabaseContext>, IHerpesZosterDal
    {
    }
}