using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Abstract
{
    public interface IAutoAntiBodyTestService
{
    IResult Add(AutoAntiBodyTest autoAntiBodyTest);
    IResult Update(AutoAntiBodyTest autoAntiBodyTest);
    IResult Delete(AutoAntiBodyTest autoAntiBodyTest);
    IDataResult<List<AutoAntiBodyTest>> GetAll();
    IDataResult<List<AutoAntiBodyTest>> GetAllByPatientId(string PatientCode);
    IDataResult<AutoAntiBodyTest> Get(int id);
    public IResult importRecords(string dataFile, string tableName);
    IDataResult<AutoAntiBodyTest> GetByPatientId(string PatientCode);
    }
}

