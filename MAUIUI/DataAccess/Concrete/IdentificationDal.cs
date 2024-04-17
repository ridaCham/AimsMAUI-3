using MAUIUI.Core.DataAccess.EntityFrameworkDal;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;
using MAUIUI.Entities.DTOs;

namespace MAUIUI.DataAccess.Concrete
{
    public class IdentificationDal : EfEntityRepositoryBase<Identifications, DatabaseContext>, IIdentificationDal
    {


        //
        public List<IdentificationStatistics> GetAllStatisticsInit()
        {


            List<IdentificationStatistics> statisticsList = new List<IdentificationStatistics>();

            using (DatabaseContext _dbContext = new DatabaseContext())
            {
                DateTime today = DateTime.Today;
                var query = from i in _dbContext.Identifications

                            select new IdentificationStatistics
                            {
                                Name = i.Name,
                                SurName = i.SurName,
                                Gender = i.Gender,
                                Education = i.Education,
                                Weight = i.Weight,
                                Height = i.Height,
                                City = i.BirthCity,
                                BirthDate = i.BirthDate
                            };

                return query.ToList();
            }
            return statisticsList;




        }

        public List<IdentificationStatistics> GetAllStatistics(params string[] selectedFields)
        {


            List<IdentificationStatistics> statisticsList = new List<IdentificationStatistics>();

            using (DatabaseContext _dbContext = new DatabaseContext())
            {
                DateTime today = DateTime.Today;
                var query = from i in _dbContext.Identifications
                            join d in _dbContext.Diagnosisses on i.PatientCode equals d.PatientCode
                            join t in _dbContext.TreatmentMSSpecifics on i.PatientCode equals t.PatientCode
                            join s in _dbContext.TreatmentSymptomatics on i.PatientCode equals s.PatientCode
                            join m in _dbContext.MedicalHistories on i.PatientCode equals m.PatientCode
                            let age = today.Year - i.BirthDate.Year - (i.BirthDate > today.AddYears(-1) ? 1 : 0)
                            where (string.IsNullOrEmpty(selectedFields[0]) || i.BirthCity.Contains(selectedFields[0])) &&
                                  (string.IsNullOrEmpty(selectedFields[1]) || i.Gender == selectedFields[1]) &&
                                  (string.IsNullOrEmpty(selectedFields[3]) || i.Education == selectedFields[3]) &&
                                  (string.IsNullOrEmpty(selectedFields[6]) || m.SmookingHistory == selectedFields[6]) &&
                                  (string.IsNullOrEmpty(selectedFields[7]) || m.AlcoholUse == selectedFields[7]) &&
                                  (string.IsNullOrEmpty(selectedFields[8]) || t.MSSpecificTreatment == selectedFields[8]) &&
                                  (string.IsNullOrEmpty(selectedFields[9]) || s.SymptomaticTreatment == selectedFields[9]) &&
                                  (string.IsNullOrEmpty(selectedFields[10]) || d.DiagnosisMcDonaldClassification == selectedFields[10]) &&
                                  (string.IsNullOrEmpty(selectedFields[11]) || d.DiagnosisNmoClassification == selectedFields[11]) &&
                                  (selectedFields[2] == "0-10" ? age >= 0 && age <= 10 :
                                   selectedFields[2] == "10-20" ? age > 10 && age <= 20 :
                                   selectedFields[2] == "20-30" ? age > 20 && age <= 30 :
                                   selectedFields[2] == "30-40" ? age > 30 && age <= 40 :
                                   selectedFields[2] == "40-50" ? age > 40 && age <= 50 :
                                   selectedFields[2] == "50-60" ? age > 50 && age <= 60 :
                                   selectedFields[2] == "70+" ? age >= 70 : age >= 0) &&
                                  (selectedFields[4] == "0-50 cm" ? i.Height >= 0 && i.Height <= 50 :
                                   selectedFields[4] == "50-100 cm" ? i.Height >= 50 && i.Height <= 100 :
                                   selectedFields[4] == "100-150 cm" ? i.Height >= 100 && i.Height <= 150 :
                                   selectedFields[4] == "150-200 cm" ? i.Height >= 150 && i.Height <= 200 :
                                   selectedFields[4] == "200+" ? i.Height > 200 :
                                   i.Height == null || i.Height > 0) &&
                                  (selectedFields[5] == "0-20 kg" ? i.Weight >= 0 && i.Weight <= 20 :
                                   selectedFields[5] == "20-40 kg" ? i.Weight >= 20 && i.Weight <= 40 :
                                   selectedFields[5] == "40-60 kg" ? i.Weight >= 40 && i.Weight <= 60 :
                                   selectedFields[5] == "60-80 kg" ? i.Weight >= 60 && i.Weight <= 80 :
                                   selectedFields[5] == "80-100 kg" ? i.Weight >= 80 && i.Weight <= 100 :
                                   selectedFields[5] == "100+" ? i.Weight >= 100 : i.Weight == null || i.Weight > 0)
                            select new IdentificationStatistics
                            {
                                Name = i.Name,
                                SurName = i.SurName,
                                Gender = i.Gender,
                                Education = i.Education,
                                Weight = i.Weight,
                                Height = i.Height,
                                City = i.BirthCity,
                                SmookingHistory = m.SmookingHistory,
                                AlcoholUse = m.AlcoholUse,
                                McDonaldClassification = d.DiagnosisMcDonaldClassification,
                                NMOClassification = d.DiagnosisNmoClassification,
                                SymptomaticTreatment = s.SymptomaticTreatment,
                                MSSpecificTreatment = t.MSSpecificTreatment,
                                BirthDate = i.BirthDate
                            };

                return query.ToList();
            }
            return statisticsList;




        }

        public List<DiagnosisStatistic> GetAllConfirmedDiagnosisCount()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var genderCounts = context.Identifications.Where(p => p.Deleted == 0)
               .GroupBy(i => i.MSClassification)
               .Select(g => new DiagnosisStatistic
               {
                   ConfirmedDiagnosis = g.Key,
                   ConfirmedDiagnosisCount = g.Count()
               })
               .ToList();
                return genderCounts;
            }

        }
        public List<IdentificationDetails> GetAllGenderCount()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var genderCounts = context.Identifications.Where(p => p.Deleted == 0)
               .GroupBy(i => i.Gender)
               .Select(g => new IdentificationDetails
               {
                   Gender = g.Key,
                   Count = g.Count()
               })
               .Where(i => i.Gender == "Male" || i.Gender == "Female").ToList();
                return genderCounts;
            }
        }



        public List<IdentificationDataGirdviewDetails> GetAllToGirdView(int deleted)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var genderCounts = from p in context.Identifications
                                   where p.Deleted == deleted
                                   select new IdentificationDataGirdviewDetails
                                   {
                                       Id = p.Id,
                                       Name = p.Name,
                                       SurName = p.SurName,
                                       BirthDate = p.BirthDate.ToString(),
                                       Gender = p.Gender,
                                   };
                return genderCounts.ToList();
            }
        }
    }
}