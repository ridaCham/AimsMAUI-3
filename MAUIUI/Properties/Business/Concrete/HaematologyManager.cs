using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Concrete
{
    public class HaematologyManager : IHaematologyService
        {
            IHaematologyDal _haematologyDal;
            public HaematologyManager(IHaematologyDal haematologyDal)
            {
                _haematologyDal = haematologyDal;
            }

            public IResult Add(Haematology haematology)
            {
                _haematologyDal.Add(haematology);
                return new SuccessResult();
            }

            public IResult Delete(Haematology haematology)
            {
                _haematologyDal.Delete(haematology);
                return new SuccessResult();
            }

            public IDataResult<Haematology> Get(int id)
            {
                return new SuccessDataResult<Haematology>(_haematologyDal.Get(p => p.Id == id));
            }

            public IDataResult<List<Haematology>> GetAll()
            {
                return new SuccessDataResult<List<Haematology>>(_haematologyDal.GetAll());
            }

            public IDataResult<List<Haematology>> GetAllByPatientId(string patientId)
            {
                return new SuccessDataResult<List<Haematology>>(_haematologyDal.GetAll(p => p.PatientCode == patientId));
            }

            public IDataResult<Haematology> GetByPatientId(string patientId)
            {
                return new SuccessDataResult<Haematology>(_haematologyDal.Get(p => p.PatientCode == patientId));
            }

            public IResult Update(Haematology haematology)
            {
                _haematologyDal.Update(haematology);
                return new SuccessResult();
            }

            public IResult importRecords(string dataFile, string tableName)
            {
                this._haematologyDal.importRecords(dataFile, tableName);
                return new SuccessResult();
            }
        }
    }


