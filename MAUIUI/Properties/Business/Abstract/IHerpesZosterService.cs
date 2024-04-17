using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Abstract
{

    public interface IHerpesZosterService
{
    IResult Add(HerpesZoster herpesZoster);
    IResult Update(HerpesZoster herpesZoster);
    IResult Delete(HerpesZoster herpesZoster);
    public IResult importRecords(string dataFile, string tableName);
    IDataResult<List<HerpesZoster>> GetAll();
    IDataResult<List<HerpesZoster>> GetAllByPatientId(string PatientCode);
    IDataResult<HerpesZoster> Get(int id);
    IDataResult<HerpesZoster> GetByPatientId(string PatientCode);
    IDataResult<HerpesZoster> GetByPatientIdAndOnsetDate(string recivedId, DateTime? dateOfDiagnosis);
}


}