using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Concrete
{
    public class MalignancyManager : IMalignancyService
        {
            IMalignancyDal _malignancyDal;
            public MalignancyManager(IMalignancyDal malignancyDal)
            {
                _malignancyDal = malignancyDal;
            }
            IResult IMalignancyService.Add(Malignancy malignancy)
            {
                _malignancyDal.Add(malignancy);
                return new SuccessResult();
            }

            IResult IMalignancyService.Update(Malignancy malignancy)
            {
                _malignancyDal.Update(malignancy);
                return new SuccessResult();
            }

            IResult IMalignancyService.Delete(Malignancy malignancy)
            {
                _malignancyDal.Delete(malignancy);
                return new SuccessResult();
            }

            IDataResult<List<Malignancy>> IMalignancyService.GetAll()
            {
                return new SuccessDataResult<List<Malignancy>>(_malignancyDal.GetAll());
            }

            IDataResult<List<Malignancy>> IMalignancyService.GetAllByPatientId(string patientId)
            {
                return new SuccessDataResult<List<Malignancy>>(_malignancyDal.GetAll(p => p.PatientCode == patientId));
            }

            IDataResult<Malignancy> IMalignancyService.Get(int id)
            {
                return new SuccessDataResult<Malignancy>(_malignancyDal.Get(p => p.Id == id));
            }

            IDataResult<Malignancy> IMalignancyService.GetByPatientId(string patientId)
            {
                return new SuccessDataResult<Malignancy>(_malignancyDal.Get(p => p.PatientCode == patientId));
            }

            public IResult importRecords(string dataFile, string tableName)
            {
                this._malignancyDal.importRecords(dataFile, tableName);
                return new SuccessResult();
            }

            public IDataResult<Malignancy> GetByMalignancydate(string recivedId, DateTime? dateOfDiagnosis)
            {
                return new SuccessDataResult<Malignancy>(_malignancyDal.Get(p => p.PatientCode == recivedId && p.DateOfDiagnosis == dateOfDiagnosis));
            }
        }
    }


