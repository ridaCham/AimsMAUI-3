using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Concrete
{
    public class TreatmentSymptomaticManager : ITreatmentSymptomaticService
        {

            ITreatmentSymptomaticDal _treatmentDal;
            public TreatmentSymptomaticManager(ITreatmentSymptomaticDal treatmentDal)
            {
                _treatmentDal = treatmentDal;
            }

            public IResult Add(TreatmentSymptomatic treatment)
            {
                _treatmentDal.Add(treatment);
                return new SuccessResult();
            }
            public IResult Delete(TreatmentSymptomatic treatment)
            {
                _treatmentDal.Delete(treatment);
                return new SuccessResult();
            }

            public IDataResult<TreatmentSymptomatic> Get(int id)
            {
                return new SuccessDataResult<TreatmentSymptomatic>(_treatmentDal.Get(p => p.Id == id));
            }

            public IDataResult<List<TreatmentSymptomatic>> GetAll(string patientId)
            {
                return new SuccessDataResult<List<TreatmentSymptomatic>>(_treatmentDal.GetAll(t => t.PatientCode == patientId));
            }

            public IDataResult<List<TreatmentSymptomatic>> GetAllByPatientId(string patientId)
            {
                return new SuccessDataResult<List<TreatmentSymptomatic>>(_treatmentDal.GetAll(p => p.PatientCode == patientId));
            }

            public IDataResult<TreatmentSymptomatic> GetByPatientId(string patientId)
            {
                return new SuccessDataResult<TreatmentSymptomatic>(_treatmentDal.Get(p => p.PatientCode == patientId));
            }

            public IResult Update(TreatmentSymptomatic treatment)
            {
                _treatmentDal.Update(treatment);
                return new SuccessResult();
            }

            public IResult importRecords(string dataFile, string tableName)
            {
                this._treatmentDal.importRecords(dataFile, tableName);
                return new SuccessResult();
            }
        }
    }


