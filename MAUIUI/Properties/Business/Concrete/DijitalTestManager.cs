using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Concrete
{
    public class DijitalTestManager : IDijitalTestService
        {
            IDijitalTestDal _QMGDal;
            public DijitalTestManager(IDijitalTestDal QMG_Dal)
            {
                _QMGDal = QMG_Dal;
            }
            IResult IDijitalTestService.Add(DijitalTest FatigueTest)
            {
                _QMGDal.Add(FatigueTest);
                return new SuccessResult();
            }

            IResult IDijitalTestService.Update(DijitalTest FatigueTest)
            {
                _QMGDal.Update(FatigueTest);
                return new SuccessResult();
            }

            IResult IDijitalTestService.Delete(DijitalTest FatigueTest)
            {
                _QMGDal.Delete(FatigueTest);
                return new SuccessResult();
            }
            IDataResult<DijitalTest> IDijitalTestService.GetByDate(DateTime date)
            {
                return new SuccessDataResult<DijitalTest>(_QMGDal.Get(p => p.Date == date));
            }
            IDataResult<List<DijitalTest>> IDijitalTestService.GetAll()
            {
                return new SuccessDataResult<List<DijitalTest>>(_QMGDal.GetAll());
            }

            IDataResult<List<DijitalTest>> IDijitalTestService.GetAllByPatientId(string patientId)
            {
                return new SuccessDataResult<List<DijitalTest>>(_QMGDal.GetAll(p => p.PatientCode == patientId));
            }

            IDataResult<DijitalTest> IDijitalTestService.Get(int id)
            {
                return new SuccessDataResult<DijitalTest>(_QMGDal.Get(p => p.Id == id));
            }

            IDataResult<DijitalTest> IDijitalTestService.GetByPatientId(string patientId, DateTime? dateTime)
            {
                return new SuccessDataResult<DijitalTest>(_QMGDal.Get(p => p.PatientCode == patientId && p.Date == dateTime));
            }

            public IResult importRecords(string dataFile, string tableName)
            {
                this._QMGDal.importRecords(dataFile, tableName);
                return new SuccessResult();
            }
        }
    }


