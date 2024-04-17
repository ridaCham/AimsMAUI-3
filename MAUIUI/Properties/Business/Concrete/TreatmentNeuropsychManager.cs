using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Concrete
{
    public class TreatmentNeuropsychManager : ITreatmentNeuropsychService
        {

            ITreatmentNeuropsychDal _treatmentDal;
            public TreatmentNeuropsychManager(ITreatmentNeuropsychDal treatmentDal)
            {
                _treatmentDal = treatmentDal;
            }


            public IResult Add(TreatmentNeuropsych treatment)
            {
                _treatmentDal.Add(treatment);
                return new SuccessResult();
            }

            public IResult Delete(TreatmentNeuropsych treatment)
            {
                _treatmentDal.Delete(treatment);
                return new SuccessResult();
            }

            public IDataResult<TreatmentNeuropsych> Get(int id)
            {
                return new SuccessDataResult<TreatmentNeuropsych>(_treatmentDal.Get(p => p.Id == id));
            }

            public IDataResult<List<TreatmentNeuropsych>> GetAll(string patientId)
            {
                return new SuccessDataResult<List<TreatmentNeuropsych>>(_treatmentDal.GetAll(t => t.PatientCode == patientId));
            }

            public IDataResult<List<TreatmentNeuropsych>> GetAllByPatientId(string patientId)
            {
                return new SuccessDataResult<List<TreatmentNeuropsych>>(_treatmentDal.GetAll(p => p.PatientCode == patientId));
            }

            public IDataResult<TreatmentNeuropsych> GetByPatientId(string patientId)
            {
                return new SuccessDataResult<TreatmentNeuropsych>(_treatmentDal.Get(p => p.PatientCode == patientId));
            }

            public IResult Update(TreatmentNeuropsych treatment)
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


