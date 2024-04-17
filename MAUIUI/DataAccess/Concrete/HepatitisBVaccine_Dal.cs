using MAUIUI.Core.DataAccess.EntityFrameworkDal;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.DataAccess.Concrete
{
    public class HepatitisBVaccine_Dal : EfEntityRepositoryBase<HepatitisBVaccine, DatabaseContext>, IHepatitisBVaccine_Dal
    {
    }
}