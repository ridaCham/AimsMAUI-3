using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Concrete
{
    public class TreatmentPhysiotherapyManager : ITreatmentPhysiotherapyService
        {

            ITreatmentPhysiotherapyDal _treatmentDal;
            public TreatmentPhysiotherapyManager(ITreatmentPhysiotherapyDal treatmentDal)
            {
                _treatmentDal = treatmentDal;
            }



            public IResult Add(TreatmentPhysiotherapy treatment)
            {
                _treatmentDal.Add(treatment);
                return new SuccessResult();
            }

            public IResult Delete(TreatmentPhysiotherapy treatment)
            {
                _treatmentDal.Delete(treatment);
                return new SuccessResult();
            }

            public IDataResult<TreatmentPhysiotherapy> Get(int id)
            {
                return new SuccessDataResult<TreatmentPhysiotherapy>(_treatmentDal.Get(p => p.Id == id));
            }

            public IDataResult<List<TreatmentPhysiotherapy>> GetAll(string patientId)
            {
                return new SuccessDataResult<List<TreatmentPhysiotherapy>>(_treatmentDal.GetAll(t => t.PatientCode == patientId));
            }

            public IDataResult<List<TreatmentPhysiotherapy>> GetAllByPatientId(string patientId)
            {
                return new SuccessDataResult<List<TreatmentPhysiotherapy>>(_treatmentDal.GetAll(p => p.PatientCode == patientId));
            }

            public IDataResult<TreatmentPhysiotherapy> GetByPatientId(string patientId)
            {
                return new SuccessDataResult<TreatmentPhysiotherapy>(_treatmentDal.Get(p => p.PatientCode == patientId));
            }

            public IResult Update(TreatmentPhysiotherapy treatment)
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


