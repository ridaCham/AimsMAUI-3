using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Concrete
{
    public class VisitManager : IVisitService
        {
            IVisitDal _visitDal;
            public VisitManager(IVisitDal visitDal)
            {
                _visitDal = visitDal;
            }

            public IResult Add(Visit visit)
            {
                _visitDal.Add(visit);
                return new SuccessResult();
            }

            public IResult Delete(Visit visit)
            {
                _visitDal.Delete(visit);
                return new SuccessResult();
            }

            public IDataResult<Visit> Get(int id)
            {
                return new SuccessDataResult<Visit>(_visitDal.Get(p => p.Id == id));
            }

            public IDataResult<List<Visit>> GetAll()
            {
                return new SuccessDataResult<List<Visit>>(_visitDal.GetAll());
            }

            public IDataResult<List<Visit>> GetAllByPatientId(string patientId)
            {
                return new SuccessDataResult<List<Visit>>(_visitDal.GetAll(p => p.PatientCode == patientId));
            }

            public IDataResult<Visit> GetByPatientId(string patientId)
            {
                return new SuccessDataResult<Visit>(_visitDal.Get(p => p.PatientCode == patientId));
            }

            public IResult Update(Visit visit)
            {
                _visitDal.Update(visit);
                return new SuccessResult();
            }

            public IResult importRecords(string dataFile, string tableName)
            {
                this._visitDal.importRecords(dataFile, tableName);
                return new SuccessResult();
            }
        }
    }


