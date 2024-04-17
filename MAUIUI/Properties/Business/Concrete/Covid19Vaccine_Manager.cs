using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Concrete
{
    public class Covid19Vaccine_Manager : ICovid19Vaccine_Service
        {
            ICovid19Vaccine_Dal _vaccine_Dal;
            public Covid19Vaccine_Manager(ICovid19Vaccine_Dal vaccine_Dal)
            {
                _vaccine_Dal = vaccine_Dal;
            }
            public IResult Add(Covid19Vaccine vaccine_)
            {
            _vaccine_Dal.Add(vaccine_);
                return new SuccessResult();
            }

            public IResult Delete(Covid19Vaccine vaccine_)
            {
            _vaccine_Dal.Delete(vaccine_);
                return new SuccessResult();
            }

            public IDataResult<Covid19Vaccine> Get(int id)
            {
                return new SuccessDataResult<Covid19Vaccine>(_vaccine_Dal.Get(p => p.Id == id));
            }

            public IDataResult<List<Covid19Vaccine>> GetAll()
            {
                return new SuccessDataResult<List<Covid19Vaccine>>(_vaccine_Dal.GetAll());
            }

            public IDataResult<List<Covid19Vaccine>> GetAllByPatientId(string patientId)
            {
                return new SuccessDataResult<List<Covid19Vaccine>>(_vaccine_Dal.GetAll(p => p.PatientCode == patientId));
            }

            public IDataResult<Covid19Vaccine> GetByPatientId(string patientId)
            {
                return new SuccessDataResult<Covid19Vaccine>(_vaccine_Dal.Get(p => p.PatientCode == patientId));
            }

            public IResult Update(Covid19Vaccine vaccine_)
            {
            _vaccine_Dal.Update(vaccine_);
                return new SuccessResult();
            }

            public IResult importRecords(string dataFile, string tableName)
            {
                this._vaccine_Dal.importRecords(dataFile, tableName);
                return new SuccessResult();
            }
        }
    }


