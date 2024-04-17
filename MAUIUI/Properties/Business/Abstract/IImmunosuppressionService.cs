using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Abstract
{
    public interface IImmunosuppressionService
{
    IResult Add(Immunosuppression mmunosuppression);
    IResult Update(Immunosuppression mmunosuppression);
    IResult Delete(Immunosuppression mmunosuppression);
    IDataResult<List<Immunosuppression>> GetAll();
    IDataResult<List<Immunosuppression>> GetAllByPatientId(string PatientCode);
    public IResult importRecords(string dataFile, string tableName);
    IDataResult<Immunosuppression> Get(string id);
    IDataResult<Immunosuppression> GetByPatientId(string PatientCode);
    IDataResult<Immunosuppression> GetBydateOfDiagnosis(string recivedPatientId, DateTime? dateOfDiagnosis);
}


}