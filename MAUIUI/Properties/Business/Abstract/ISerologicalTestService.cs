using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Abstract
{
    public interface ISerologicalTestService
    {
        IResult Add(SerologicalTest serologicalTest);
        IResult Update(SerologicalTest serologicalTest);
        IResult Delete(SerologicalTest serologicalTest);
        IDataResult<List<SerologicalTest>> GetAll();
        IDataResult<List<SerologicalTest>> GetAllByPatientId(string PatientCode);
        public IResult importRecords(string dataFile, string tableName);
        IDataResult<SerologicalTest> Get(int id);
        IDataResult<SerologicalTest> GetByPatientId(string PatientCode);
    }
}

