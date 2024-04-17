using MAUIUI.Core.DataAccess.EntityFrameworkDal;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.DataAccess.Concrete
{
    public class HaematologyDal : EfEntityRepositoryBase<Haematology, DatabaseContext>, IHaematologyDal
    {
    }
}