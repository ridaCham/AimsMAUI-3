using MAUIUI.Core.DataAccess.EntityFrameworkDal;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.DataAccess.Concrete
{
    public class HepatitisAVaccine_Dal : EfEntityRepositoryBase<HepatitisAVaccine, DatabaseContext>, IHepatitisAVaccine_Dal
    {
    }
}