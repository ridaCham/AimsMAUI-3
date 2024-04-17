using MAUIUI.Business.Abstract;
using MAUIUI.Business.DependencyResoulver.AutofacResoulver;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;
using MAUIUI.Entities.DTOs;

namespace MAUIUI.Business.Concrete
{
    public class TreatmentMSSpecificManager : ITreatmentMSSpecificService
        {

            ITreatmentMSSpecificDal _treatmentDal;
            public TreatmentMSSpecificManager(ITreatmentMSSpecificDal treatmentDal)
            {
                _treatmentDal = treatmentDal;
            }



            public IResult Add(TreatmentMSSpecific treatment)
            {
                _treatmentDal.Add(treatment);
                return new SuccessResult();
            }

            public IResult Delete(TreatmentMSSpecific treatment)
            {
                _treatmentDal.Delete(treatment);
                return new SuccessResult();
            }

            public IDataResult<TreatmentMSSpecific> Get(int id)
            {
                return new SuccessDataResult<TreatmentMSSpecific>(_treatmentDal.Get(p => p.Id == id));
            }

            public IDataResult<List<TreatmentMSSpecific>> GetAll(string patientId)
            {
                return new SuccessDataResult<List<TreatmentMSSpecific>>(_treatmentDal.GetAll(t => t.PatientCode == patientId));
            }

            public IDataResult<List<TreatmentMSSpecific>> GetAllByPatientId(string patientId)
            {
                return new SuccessDataResult<List<TreatmentMSSpecific>>(_treatmentDal.GetAll(p => p.PatientCode == patientId));
            }

            public IDataResult<TreatmentMSSpecific> GetByPatientId(string patientId)
            {
                return new SuccessDataResult<TreatmentMSSpecific>(_treatmentDal.Get(p => p.PatientCode == patientId));
            }

            public IResult Update(TreatmentMSSpecific treatment)
            {
                _treatmentDal.Update(treatment);
                return new SuccessResult();
            }
            public IDataResult<List<MsSpecifikTreatmentChart>> GetAllDiagnosisMGClassificationCount()
            {
                IIdentificationService identificationService = InstanceFactory.GetInstance<IIdentificationService>();
                List<TreatmentMSSpecific> nsd = new List<TreatmentMSSpecific>();
                foreach (var treatment in _treatmentDal.GetAll())
                {
                    if (identificationService.GetByPatientId(treatment.PatientCode).Data.Deleted == 0)
                    {
                        nsd.Add(treatment);
                    }
                }
                var genderCounts = nsd.GroupBy(i => i.MSSpecificTreatment)
                   .Select(g => new MsSpecifikTreatmentChart
                   {
                       DiagnosisMSClassification = g.Key,
                       DiagnosisMSClassificationConut = g.Count()
                   })
                   .ToList();
                return new SuccessDataResult<List<MsSpecifikTreatmentChart>>(genderCounts);
            }

            public IResult importRecords(string dataFile, string tableName)
            {
                this._treatmentDal.importRecords(dataFile, tableName);
                return new SuccessResult();
            }
        }
    }


