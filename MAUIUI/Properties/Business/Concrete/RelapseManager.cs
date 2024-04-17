using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Concrete
{
    public class RelapseManager : IRelapseService
        {
            IRelapseDal _relapseDal;
            public RelapseManager(IRelapseDal relapseDal)
            {
                _relapseDal = relapseDal;
            }
            public IResult Add(Relapse relapse)
            {
                _relapseDal.Add(relapse);
                return new SuccessResult();
            }

            public IResult Delete(Relapse relapse)
            {
                _relapseDal.Delete(relapse);
                return new SuccessResult();
            }

            public IDataResult<Relapse> Get(string id)
            {
                return new SuccessDataResult<Relapse>(_relapseDal.Get(p => p.PatientCode == id));
            }

            public IDataResult<List<Relapse>> GetAll()
            {
                return new SuccessDataResult<List<Relapse>>(_relapseDal.GetAll());
            }

            public IDataResult<List<Relapse>> GetAllByPatientId(string patientId)
            {
                return new SuccessDataResult<List<Relapse>>(_relapseDal.GetAll(p => p.PatientCode == patientId));
            }

            public IDataResult<Relapse> GetByPatientId(string patientId)
            {
                return new SuccessDataResult<Relapse>(_relapseDal.Get(p => p.PatientCode == patientId));
            }

            public IResult Update(Relapse relapse)
            {
                _relapseDal.Update(relapse);
                return new SuccessResult();
            }

            public IResult importRecords(string dataFile, string tableName)
            {
                this._relapseDal.importRecords(dataFile, tableName);
                return new SuccessResult(); ;
            }
        }
    }


