using MAUIUI.Core.DataAccess.EntityFrameworkDal;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.DataAccess.Concrete
{
    public class Covid19Dal : EfEntityRepositoryBase<Covid19, DatabaseContext>, ICovid19Dal
    {
    }
}