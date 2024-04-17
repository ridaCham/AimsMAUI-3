using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Concrete
{
    public class TreatmentYogaManager : ITreatmentYogaService
        {

            ITreatmentYogaDal _treatmentDal;
            public TreatmentYogaManager(ITreatmentYogaDal treatmentDal)
            {
                _treatmentDal = treatmentDal;
            }

            public IResult Add(TreatmentYoga treatment)
            {
                _treatmentDal.Add(treatment);
                return new SuccessResult();
            }

            public IResult Delete(TreatmentYoga treatment)
            {
                _treatmentDal.Delete(treatment);
                return new SuccessResult();
            }

            public IDataResult<TreatmentYoga> Get(int id)
            {
                return new SuccessDataResult<TreatmentYoga>(_treatmentDal.Get(p => p.Id == id));
            }

            public IDataResult<List<TreatmentYoga>> GetAll(string patientId)
            {
                return new SuccessDataResult<List<TreatmentYoga>>(_treatmentDal.GetAll(t => t.PatientCode.Contains(patientId)));
            }

            public IDataResult<List<TreatmentYoga>> GetAllByPatientId(string patientId)
            {
                return new SuccessDataResult<List<TreatmentYoga>>(_treatmentDal.GetAll(p => p.PatientCode.Contains(patientId)));
            }

            public IDataResult<TreatmentYoga> GetByPatientId(string patientId)
            {
                return new SuccessDataResult<TreatmentYoga>(_treatmentDal.Get(p => p.PatientCode.Contains(patientId)));
            }

            public IResult importRecords(string dataFile, string tableName)
            {
                this._treatmentDal.importRecords(dataFile, tableName);
                return new SuccessResult();
            }


            public IResult Update(TreatmentYoga treatment)
            {
                _treatmentDal.Update(treatment);
                return new SuccessResult();
            }

        }
    }


