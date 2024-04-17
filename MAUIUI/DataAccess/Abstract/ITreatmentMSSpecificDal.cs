using MAUIUI.Core.DataAccess;
using MAUIUI.Entities.Concrete;
using MAUIUI.Entities.DTOs;

namespace MAUIUI.DataAccess.Abstract
{
    public interface ITreatmentMSSpecificDal : IEntityRepository<TreatmentMSSpecific>
    {

        public List<MsSpecifikTreatmentChart> GetAllDiagnosisMGClassificationCount();
    }
}

