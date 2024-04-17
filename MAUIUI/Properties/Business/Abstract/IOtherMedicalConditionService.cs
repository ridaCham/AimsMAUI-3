using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Abstract
{
    public interface IOtherMedicalConditionService
{
    IResult Add(OtherMedicalCondition otherMedicalCondition);
    IResult Update(OtherMedicalCondition otherMedicalCondition);
    IResult Delete(OtherMedicalCondition otherMedicalCondition);
    IDataResult<List<OtherMedicalCondition>> GetAll();
    public IResult importRecords(string dataFile, string tableName);
    IDataResult<List<OtherMedicalCondition>> GetAllByPatientId(string PatientCode);
    IDataResult<OtherMedicalCondition> Get(int id);
    IDataResult<OtherMedicalCondition> GetByPatientId(string PatientCode);
    IDataResult<OtherMedicalCondition> GetDateOfOnset(string recivedId, DateTime? dateOfOnset);
}


}