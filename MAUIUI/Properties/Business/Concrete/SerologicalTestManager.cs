using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Concrete
{
    public class SerologicalTestManager : ISerologicalTestService
        {
            ISerologicalTestDal _serologicalTestDal;
            public SerologicalTestManager(ISerologicalTestDal serologicalTestDal)
            {
                _serologicalTestDal = serologicalTestDal;
            }

            IResult ISerologicalTestService.Add(SerologicalTest serologicalTest)
            {
                _serologicalTestDal.Add(serologicalTest);
                return new SuccessResult();

            }

            IResult ISerologicalTestService.Update(SerologicalTest serologicalTest)
            {
                _serologicalTestDal.Update(serologicalTest);
                return new SuccessResult();
            }

            IResult ISerologicalTestService.Delete(SerologicalTest serologicalTest)
            {
                _serologicalTestDal.Delete(serologicalTest);
                return new SuccessResult();
            }

            IDataResult<List<SerologicalTest>> ISerologicalTestService.GetAll()
            {
                return new SuccessDataResult<List<SerologicalTest>>(_serologicalTestDal.GetAll());
            }

            IDataResult<List<SerologicalTest>> ISerologicalTestService.GetAllByPatientId(string patientId)
            {
                return new SuccessDataResult<List<SerologicalTest>>(_serologicalTestDal.GetAll(p => p.PatientCode == patientId));
            }

            IDataResult<SerologicalTest> ISerologicalTestService.Get(int id)
            {
                return new SuccessDataResult<SerologicalTest>(_serologicalTestDal.Get(p => p.Id == id));
            }

            IDataResult<SerologicalTest> ISerologicalTestService.GetByPatientId(string patientId)
            {
                return new SuccessDataResult<SerologicalTest>(_serologicalTestDal.Get(p => p.PatientCode == patientId));
            }

            public IResult importRecords(string dataFile, string tableName)
            {
                this._serologicalTestDal.importRecords(dataFile, tableName);
                return new SuccessResult();
            }
        }
    }


