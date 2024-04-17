using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Abstract
{
    public interface IEdssService
{
    IResult Add(Edss MGADL_);
    IResult Update(Edss MGADL_);
    IResult Delete(Edss MGADL_);
    IDataResult<List<Edss>> GetAll();
    IDataResult<List<Edss>> GetAllByPatientId(string PatientCode);
    IDataResult<Edss> Get(int id);
    IDataResult<Edss> GetByPatientId(string PatientCode, DateTime? dateTime);
    public IResult importRecords(string dataFile, string tableName);
}


}