using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Abstract
{
    public interface IVisitService
{
    IResult Add(Visit visit);
    public IResult importRecords(string dataFile, string tableName);
    IResult Update(Visit visit);
    IResult Delete(Visit visit);
    IDataResult<List<Visit>> GetAll();
    IDataResult<List<Visit>> GetAllByPatientId(string PatientCode);
    IDataResult<Visit> Get(int id);
    IDataResult<Visit> GetByPatientId(string PatientCode);
}
}

