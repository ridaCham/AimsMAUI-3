using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Abstract
{
    public interface IThyroidFunctionService
    {
        IResult Add(ThyroidFunction thyroidFunction);
        IResult Update(ThyroidFunction thyroidFunction);
        IResult Delete(ThyroidFunction thyroidFunction);
        IDataResult<List<ThyroidFunction>> GetAll();
        IDataResult<List<ThyroidFunction>> GetAllByPatientId(string PatientCode);
        IDataResult<ThyroidFunction> Get(int id);
        public IResult importRecords(string dataFile, string tableName);
        IDataResult<ThyroidFunction> GetByPatientId(string PatientCode);
    }
}

