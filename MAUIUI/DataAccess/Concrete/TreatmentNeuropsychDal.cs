using MAUIUI.Core.DataAccess.EntityFrameworkDal;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.DataAccess.Concrete
{
    public class TreatmentNeuropsychDal : EfEntityRepositoryBase<TreatmentNeuropsych, DatabaseContext>, ITreatmentNeuropsychDal
    {
    }
}