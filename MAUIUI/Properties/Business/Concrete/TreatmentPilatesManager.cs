using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Concrete
{
    public class TreatmentPilatesManager : ITreatmentPilatesService
        {

            ITreatmentPilatesDal _treatmentDal;
            public TreatmentPilatesManager(ITreatmentPilatesDal treatmentDal)
            {
                _treatmentDal = treatmentDal;
            }

            public IResult Add(TreatmentPilates treatment)
            {
                _treatmentDal.Add(treatment);
                return new SuccessResult();
            }



            public IResult Delete(TreatmentPilates treatment)
            {
                _treatmentDal.Delete(treatment);
                return new SuccessResult();
            }

            public IDataResult<TreatmentPilates> Get(int id)
            {
                return new SuccessDataResult<TreatmentPilates>(_treatmentDal.Get(p => p.Id == id));
            }

            public IDataResult<List<TreatmentPilates>> GetAll(string patientId)
            {
                return new SuccessDataResult<List<TreatmentPilates>>(_treatmentDal.GetAll(t => t.PatientCode == patientId));
            }

            public IDataResult<List<TreatmentPilates>> GetAllByPatientId(string patientId)
            {
                return new SuccessDataResult<List<TreatmentPilates>>(_treatmentDal.GetAll(p => p.PatientCode == patientId));
            }

            public IDataResult<TreatmentPilates> GetByPatientId(string patientId)
            {
                return new SuccessDataResult<TreatmentPilates>(_treatmentDal.Get(p => p.PatientCode == patientId));
            }

            public IResult Update(TreatmentPilates treatment)
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


