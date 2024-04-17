using MAUIUI.Core.DataAccess.EntityFrameworkDal;
using MAUIUI.Core.Entities;
using MAUIUI.DataAccess.Abstract;

namespace MAUIUI.DataAccess.Concrete
{
    public class UserDal : EfEntityRepositoryBase<User, DatabaseContext>, IuserDal
    {
    }
}