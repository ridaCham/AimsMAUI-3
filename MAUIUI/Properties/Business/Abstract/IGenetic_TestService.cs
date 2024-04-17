using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Abstract
{
    public interface IGenetic_TestService
{
    IResult Add(Genetic_Test genetic_Test);
    IResult Update(Genetic_Test genetic_Test);
    IResult Delete(Genetic_Test genetic_Test);
    IDataResult<List<Genetic_Test>> GetAll();
    IDataResult<List<Genetic_Test>> GetAllByPatientId(string PatientCode);
    IDataResult<Genetic_Test> Get(int id);
    public IResult importRecords(string dataFile, string tableName);
    IDataResult<Genetic_Test> GetByPatientId(string PatientCode);
}


}