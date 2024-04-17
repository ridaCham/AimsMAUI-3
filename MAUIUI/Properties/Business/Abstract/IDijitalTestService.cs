using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Abstract
{
    public interface IDijitalTestService
{
    IResult Add(DijitalTest MGADL_);
    IResult Update(DijitalTest MGADL_);
    IResult Delete(DijitalTest MGADL_);
    IDataResult<List<DijitalTest>> GetAll();
    IDataResult<List<DijitalTest>> GetAllByPatientId(string PatientCode);
    IDataResult<DijitalTest> Get(int id);
    IDataResult<DijitalTest> GetByPatientId(string PatientCode, DateTime? dateTime);
    IDataResult<DijitalTest> GetByDate(DateTime date);
    public IResult importRecords(string dataFile, string tableName);
}


}