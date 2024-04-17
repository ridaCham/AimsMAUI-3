using MAUIUI.Core.DataAccess.EntityFrameworkDal;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;
using MAUIUI.Entities.DTOs;

namespace MAUIUI.DataAccess.Concrete
{
    public class DiagnosisDal : EfEntityRepositoryBase<Diagnosis, DatabaseContext>, IDiagnosisDal
    {
        public List<DiagnosisStatistic> GetAllConfirmedDiagnosisCount()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var genderCounts = context.Diagnosisses
               .GroupBy(i => i.DiagnosisMcDonaldClassification)
               .Select(g => new DiagnosisStatistic
               {
                   ConfirmedDiagnosis = g.Key,
                   ConfirmedDiagnosisCount = g.Count()
               })
               .ToList();
                return genderCounts;
            }

        }
    }
}