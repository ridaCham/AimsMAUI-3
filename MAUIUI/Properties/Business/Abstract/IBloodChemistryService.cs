using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Abstract
{
    public interface IBloodChemistryService
{
    IResult Add(BloodChemistry bloodChemistry);
    IResult Update(BloodChemistry bloodChemistry);
    IResult Delete(BloodChemistry bloodChemistry);
    IDataResult<List<BloodChemistry>> GetAll();
    IDataResult<List<BloodChemistry>> GetAllByPatientId(string PatientCode);
    IDataResult<BloodChemistry> Get(int id);
    IDataResult<BloodChemistry> GetByPatientId(string PatientCode);
    public IResult importRecords(string dataFile, string tableName);
    IDataResult<BloodChemistry> GetByExamDate(string recivedId, DateTime? examDate);
}

}
