using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Concrete
{
    public class AutoAntiBodyTestManager : IAutoAntiBodyTestService
        {
            IAutoAntiBodyTestDal _autoAntiBodyTestDal;
            public AutoAntiBodyTestManager(IAutoAntiBodyTestDal autoAntiBodyTestDal)
            {
                _autoAntiBodyTestDal = autoAntiBodyTestDal;
            }



            public IResult Add(AutoAntiBodyTest autoAntiBodyTest)
            {
                _autoAntiBodyTestDal.Add(autoAntiBodyTest);
                return new SuccessResult();
            }

            public IResult Delete(AutoAntiBodyTest autoAntiBodyTest)
            {
                _autoAntiBodyTestDal.Delete(autoAntiBodyTest);
                return new SuccessResult();
            }

            public IDataResult<AutoAntiBodyTest> Get(int id)
            {
                return new SuccessDataResult<AutoAntiBodyTest>(_autoAntiBodyTestDal.Get(p => p.Id == id));
            }

            public IDataResult<List<AutoAntiBodyTest>> GetAll()
            {
                return new SuccessDataResult<List<AutoAntiBodyTest>>(_autoAntiBodyTestDal.GetAll());
            }

            public IDataResult<List<AutoAntiBodyTest>> GetAllByPatientId(string patientId)
            {
                return new SuccessDataResult<List<AutoAntiBodyTest>>(_autoAntiBodyTestDal.GetAll(p => p.PatientCode == patientId));
            }

            public IDataResult<AutoAntiBodyTest> GetByPatientId(string patientId)
            {
                return new SuccessDataResult<AutoAntiBodyTest>(_autoAntiBodyTestDal.Get(p => p.PatientCode == patientId));
            }

            public IResult Update(AutoAntiBodyTest autoAntiBodyTest)
            {
                _autoAntiBodyTestDal.Update(autoAntiBodyTest);
                return new SuccessResult();
            }

            public IResult importRecords(string dataFile, string tableName)
            {
                this._autoAntiBodyTestDal.importRecords(dataFile, tableName);
                return new SuccessResult();
            }
        }
    }


