using MAUIUI.Core.DataAccess;
using MAUIUI.Entities.Concrete;
using MAUIUI.Entities.DTOs;

namespace MAUIUI.DataAccess.Abstract
{
    public interface IIdentificationDal : IEntityRepository<Identifications>
    {
        public List<IdentificationDetails> GetAllGenderCount();
        public List<IdentificationDataGirdviewDetails> GetAllToGirdView(int deleted);
        public List<IdentificationStatistics> GetAllStatistics(params string[] selectedFields);
        public List<IdentificationStatistics> GetAllStatisticsInit();
        public List<DiagnosisStatistic> GetAllConfirmedDiagnosisCount();
    }
   /*public interface IOutcomeDal : IEntityRepository<Outcome>
    {
    }*/
}

