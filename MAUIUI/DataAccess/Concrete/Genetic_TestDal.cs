using MAUIUI.Core.DataAccess.EntityFrameworkDal;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.DataAccess.Concrete
{
    public class Genetic_TestDal : EfEntityRepositoryBase<Genetic_Test, DatabaseContext>, IGenetic_TestDal
    {
    }
}