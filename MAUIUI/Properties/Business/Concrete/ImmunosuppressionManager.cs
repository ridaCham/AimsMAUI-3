using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Concrete
{
    public class ImmunosuppressionManager : IImmunosuppressionService
        {
            IImmunosuppressionDal _immunosuppressionDal;

            public ImmunosuppressionManager(IImmunosuppressionDal immunosuppressionDal)
            {
                _immunosuppressionDal = immunosuppressionDal;
            }

            public IResult Add(Immunosuppression immunosuppression)
            {
                _immunosuppressionDal.Add(immunosuppression);
                return new SuccessResult();
            }

            public IResult Delete(Immunosuppression immunosuppression)
            {
                _immunosuppressionDal.Delete(immunosuppression);
                return new SuccessResult();
            }

            public IDataResult<Immunosuppression> Get(string id)
            {
                return new SuccessDataResult<Immunosuppression>(_immunosuppressionDal.Get(p => p.PatientCode == id));
            }

            public IDataResult<List<Immunosuppression>> GetAll()
            {
                return new SuccessDataResult<List<Immunosuppression>>(_immunosuppressionDal.GetAll());
            }

            public IDataResult<List<Immunosuppression>> GetAllByPatientId(string patientId)
            {
                return new SuccessDataResult<List<Immunosuppression>>(_immunosuppressionDal.
                    GetAll(p => p.PatientCode == patientId));
            }

            public IDataResult<Immunosuppression> GetByPatientId(string patientId)
            {
                return new SuccessDataResult<Immunosuppression>(_immunosuppressionDal.Get(p => p.PatientCode == patientId));
            }

            public IResult Update(Immunosuppression immunosuppression)
            {
                _immunosuppressionDal.Update(immunosuppression);
                return new SuccessResult();
            }

            public IResult importRecords(string dataFile, string tableName)
            {
                this._immunosuppressionDal.importRecords(dataFile, tableName);
                return new SuccessResult();
            }

            public IDataResult<Immunosuppression> GetBydateOfDiagnosis(string recivedPatientId, DateTime? dateOfDiagnosis)
            {
                return new SuccessDataResult<Immunosuppression>(_immunosuppressionDal.Get(p => p.PatientCode == recivedPatientId
                && p.dateOfDiagnosis == dateOfDiagnosis));
            }
        }
    }


