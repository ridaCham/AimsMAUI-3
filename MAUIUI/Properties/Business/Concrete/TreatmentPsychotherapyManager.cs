using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Concrete
{
    public class TreatmentPsychotherapyManager : ITreatmentPsychotherapyService
        {

            ITreatmentPsychotherapyDal _treatmentDal;
            public TreatmentPsychotherapyManager(ITreatmentPsychotherapyDal treatmentDal)
            {
                _treatmentDal = treatmentDal;
            }

            public IResult Add(TreatmentPsychotherapy treatment)
            {
                _treatmentDal.Add(treatment);
                return new SuccessResult();
            }



            public IResult Delete(TreatmentPsychotherapy treatment)
            {
                _treatmentDal.Delete(treatment);
                return new SuccessResult();
            }

            public IDataResult<TreatmentPsychotherapy> Get(int id)
            {
                return new SuccessDataResult<TreatmentPsychotherapy>(_treatmentDal.Get(p => p.Id == id));
            }

            public IDataResult<List<TreatmentPsychotherapy>> GetAll(string patientId)
            {
                return new SuccessDataResult<List<TreatmentPsychotherapy>>(_treatmentDal.GetAll(t => t.PatientCode == patientId));
            }

            public IDataResult<List<TreatmentPsychotherapy>> GetAllByPatientId(string patientId)
            {
                return new SuccessDataResult<List<TreatmentPsychotherapy>>(_treatmentDal.GetAll(p => p.PatientCode == patientId));
            }

            public IDataResult<TreatmentPsychotherapy> GetByPatientId(string patientId)
            {
                return new SuccessDataResult<TreatmentPsychotherapy>(_treatmentDal.Get(p => p.PatientCode == patientId));
            }

            public IResult Update(TreatmentPsychotherapy treatment)
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


