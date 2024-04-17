using MAUIUI.Core.DataAccess.EntityFrameworkDal;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;
using MAUIUI.Entities.DTOs;

namespace MAUIUI.DataAccess.Concrete
{
    public class TreatmentMSSpecificDal : EfEntityRepositoryBase<TreatmentMSSpecific, DatabaseContext>, ITreatmentMSSpecificDal
    {
        public List<MsSpecifikTreatmentChart> GetAllDiagnosisMGClassificationCount()
        {
            using (DatabaseContext context = new DatabaseContext())
            {

                var genderCount = context.TreatmentMSSpecifics.Select(t => new TreatmentMSSpecific()).ToList();
                foreach (var item in genderCount)
                {
                    if (true)
                    {

                    }
                }
                var genderCounts = genderCount.GroupBy(i => i.MSSpecificTreatment)
               .Select(g => new MsSpecifikTreatmentChart
               {
                   DiagnosisMSClassification = g.Key,
                   DiagnosisMSClassificationConut = g.Count()
               })
               .ToList();

                return genderCounts;
            }
        }

    }
}