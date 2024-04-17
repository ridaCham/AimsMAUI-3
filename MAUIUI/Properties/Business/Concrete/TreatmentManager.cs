using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Concrete
{
    public class TreatmentManager : ITreatmentService
        {

            ITreatmentDal _treatmentDal;
            public TreatmentManager(ITreatmentDal treatmentDal)
            {
                _treatmentDal = treatmentDal;
            }



            public IResult Add(Treatment treatment)
            {
                _treatmentDal.Add(treatment);
                return new SuccessResult();
            }

            public IResult Delete(Treatment treatment)
            {
                _treatmentDal.Delete(treatment);
                return new SuccessResult();
            }

            public IDataResult<Treatment> Get(int id)
            {
                return new SuccessDataResult<Treatment>(_treatmentDal.Get(p => p.Id == id));
            }

            public IDataResult<List<Treatment>> GetAll()
            {
                return new SuccessDataResult<List<Treatment>>(_treatmentDal.GetAll());
            }

            public IDataResult<List<Treatment>> GetAllByPatientId(string patientId)
            {
                return new SuccessDataResult<List<Treatment>>(_treatmentDal.GetAll(p => p.PatientCode.Contains(patientId)));
            }

            public IDataResult<Treatment> GetByPatientId(string patientId)
            {
                return new SuccessDataResult<Treatment>(_treatmentDal.Get(p => p.PatientCode.Contains(patientId) || p.PatientCode == patientId));
            }

            public IResult Update(Treatment treatment)
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


