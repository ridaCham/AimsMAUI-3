using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Concrete
{
    public class PregnancyManager : IPregnancyService
        {
            IPregnancyDal _pregnancyDal;
            public PregnancyManager(IPregnancyDal pregnancyDal)
            {
                _pregnancyDal = pregnancyDal;
            }

            public IResult Add(Pregnancy pregnancy)
            {
                _pregnancyDal.Add(pregnancy);
                return new SuccessResult();
            }

            public IResult Delete(Pregnancy pregnancy)
            {
                _pregnancyDal.Delete(pregnancy);
                return new SuccessResult();
            }

            public IDataResult<Pregnancy> Get(int id)
            {
                return new SuccessDataResult<Pregnancy>(_pregnancyDal.Get(p => p.Id == id));
            }

            public IDataResult<List<Pregnancy>> GetAll()
            {
                return new SuccessDataResult<List<Pregnancy>>(_pregnancyDal.GetAll());
            }

            public IDataResult<List<Pregnancy>> GetAllByPatientId(string patientId)
            {
                return new SuccessDataResult<List<Pregnancy>>(_pregnancyDal.GetAll(p => p.PatientCode == patientId));
            }

            public IDataResult<Pregnancy> GetByPatientId(string patientId)
            {
                return new SuccessDataResult<Pregnancy>(_pregnancyDal.Get(p => p.PatientCode == patientId));
            }

            public IResult Update(Pregnancy pregnancy)
            {
                _pregnancyDal.Update(pregnancy);
                return new SuccessResult();
            }

            public IResult importRecords(string dataFile, string tableName)
            {
                this._pregnancyDal.importRecords(dataFile, tableName);
                return new SuccessResult(); ;
            }
        }
    }


