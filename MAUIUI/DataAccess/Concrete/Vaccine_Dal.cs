using MAUIUI.Core.DataAccess.EntityFrameworkDal;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.DataAccess.Concrete
{
    public class Vaccine_Dal : EfEntityRepositoryBase<Vaccine_, DatabaseContext>, IVaccine_Dal
    {
    }
}