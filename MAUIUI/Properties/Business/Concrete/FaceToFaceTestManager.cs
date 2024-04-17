using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Concrete
{
    public class FaceToFaceTestManager : IFaceToFaceTestService
        {
            IFaceToFaceTestDal _QMGDal;
            public FaceToFaceTestManager(IFaceToFaceTestDal QMG_Dal)
            {
                _QMGDal = QMG_Dal;
            }

            IResult IFaceToFaceTestService.Add(FaceToFaceTest FatigueTest)
            {
                _QMGDal.Add(FatigueTest);
                return new SuccessResult();
            }

            IResult IFaceToFaceTestService.Update(FaceToFaceTest FatigueTest)
            {
                _QMGDal.Update(FatigueTest);
                return new SuccessResult();
            }

            IResult IFaceToFaceTestService.Delete(FaceToFaceTest FatigueTest)
            {
                _QMGDal.Delete(FatigueTest);
                return new SuccessResult();
            }
            IDataResult<FaceToFaceTest> IFaceToFaceTestService.GetByDate(DateTime date)
            {
                return new SuccessDataResult<FaceToFaceTest>(_QMGDal.Get(p => p.Date == date));
            }
            IDataResult<List<FaceToFaceTest>> IFaceToFaceTestService.GetAll()
            {
                return new SuccessDataResult<List<FaceToFaceTest>>(_QMGDal.GetAll());
            }

            IDataResult<List<FaceToFaceTest>> IFaceToFaceTestService.GetAllByPatientId(string patientId)
            {
                return new SuccessDataResult<List<FaceToFaceTest>>(_QMGDal.GetAll(p => p.PatientCode == patientId));
            }

            IDataResult<FaceToFaceTest> IFaceToFaceTestService.Get(int id)
            {
                return new SuccessDataResult<FaceToFaceTest>(_QMGDal.Get(p => p.Id == id));
            }

            IDataResult<FaceToFaceTest> IFaceToFaceTestService.GetByPatientId(string patientId, DateTime? dateTime)
            {
                return new SuccessDataResult<FaceToFaceTest>(_QMGDal.Get(p => p.PatientCode == patientId && p.Date == dateTime));
            }

            public IResult importRecords(string dataFile, string tableName)
            {
                this._QMGDal.importRecords(dataFile, tableName);
                return new SuccessResult();
            }
        }
    }


