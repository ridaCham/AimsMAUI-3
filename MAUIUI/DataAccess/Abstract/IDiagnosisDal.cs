using MAUIUI.Core.DataAccess;
using MAUIUI.Entities.Concrete;
using MAUIUI.Entities.DTOs;

namespace MAUIUI.DataAccess.Abstract
{
    public interface IDiagnosisDal : IEntityRepository<Diagnosis>
    {

        public List<DiagnosisStatistic> GetAllConfirmedDiagnosisCount();
    }
   /*public interface IOutcomeDal : IEntityRepository<Outcome>
    {
    }*/
}

