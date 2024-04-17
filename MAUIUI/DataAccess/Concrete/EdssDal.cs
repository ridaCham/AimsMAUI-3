using MAUIUI.Core.DataAccess.EntityFrameworkDal;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.DataAccess.Concrete
{
    public class EdssDal : EfEntityRepositoryBase<Edss, DatabaseContext>, IEdssDal
    {
    }
}