using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Concrete
{
    public class ThyroidFunctionManager : IThyroidFunctionService
        {
            IThyroidFunctionDal _thyroidFunctionDal;
            public ThyroidFunctionManager(IThyroidFunctionDal thyroidFunctionDal)
            {
                _thyroidFunctionDal = thyroidFunctionDal;
            }

            public IResult Add(ThyroidFunction thyroidFunction)
            {
                _thyroidFunctionDal.Add(thyroidFunction);
                return new SuccessResult();
            }

            public IResult Delete(ThyroidFunction thyroidFunction)
            {
                _thyroidFunctionDal.Delete(thyroidFunction);
                return new SuccessResult();
            }

            public IDataResult<ThyroidFunction> Get(int id)
            {
                return new SuccessDataResult<ThyroidFunction>(_thyroidFunctionDal.Get(p => p.Id == id));
            }

            public IDataResult<List<ThyroidFunction>> GetAll()
            {
                return new SuccessDataResult<List<ThyroidFunction>>(_thyroidFunctionDal.GetAll());
            }

            public IDataResult<List<ThyroidFunction>> GetAllByPatientId(string patientId)
            {
                return new SuccessDataResult<List<ThyroidFunction>>(_thyroidFunctionDal.GetAll(p => p.PatientCode == patientId));
            }

            public IDataResult<ThyroidFunction> GetByPatientId(string patientId)
            {
                return new SuccessDataResult<ThyroidFunction>(_thyroidFunctionDal.Get(p => p.PatientCode == patientId));
            }

            public IResult Update(ThyroidFunction thyroidFunction)
            {
                _thyroidFunctionDal.Update(thyroidFunction);
                return new SuccessResult();
            }

            public IResult importRecords(string dataFile, string tableName)
            {
                this._thyroidFunctionDal.importRecords(dataFile, tableName);
                return new SuccessResult();
            }
        }
    }


