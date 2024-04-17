using MAUIUI.Core.DataAccess.EntityFrameworkDal;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.DataAccess.Concrete
{
    public class ParatestMRIDal : EfEntityRepositoryBase<ParatestMRI, DatabaseContext>, IParatestMRIDal
    {
    }
}