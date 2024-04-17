using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Concrete
{
    public class EdssManager : IEdssService
        {
            IEdssDal _QMGDal;
            public EdssManager(IEdssDal QMG_Dal)
            {
                _QMGDal = QMG_Dal;
            }

            IResult IEdssService.Add(Edss FatigueTest)
            {
                _QMGDal.Add(FatigueTest);
                return new SuccessResult();
            }

            IResult IEdssService.Update(Edss FatigueTest)
            {
                _QMGDal.Update(FatigueTest);
                return new SuccessResult();
            }

            IResult IEdssService.Delete(Edss FatigueTest)
            {
                _QMGDal.Delete(FatigueTest);
                return new SuccessResult();
            }

            IDataResult<List<Edss>> IEdssService.GetAll()
            {
                return new SuccessDataResult<List<Edss>>(_QMGDal.GetAll());
            }

            IDataResult<List<Edss>> IEdssService.GetAllByPatientId(string patientId)
            {
                return new SuccessDataResult<List<Edss>>(_QMGDal.GetAll(p => p.PatientCode == patientId));
            }

            IDataResult<Edss> IEdssService.Get(int id)
            {
                return new SuccessDataResult<Edss>(_QMGDal.Get(p => p.Id == id));
            }

            IDataResult<Edss> IEdssService.GetByPatientId(string patientId, DateTime? dateTime)
            {
                return new SuccessDataResult<Edss>(_QMGDal.Get(p => p.PatientCode == patientId && p.Date == dateTime));
            }

            public IResult importRecords(string dataFile, string tableName)
            {
                this._QMGDal.importRecords(dataFile, tableName);
                return new SuccessResult();
            }
        }
    }


