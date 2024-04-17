using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Abstract
{
    public interface IMedicalHistoryService
{
    IResult Add(MedicalHistory medicalHistory);
    IResult Update(MedicalHistory medicalHistory);
    IResult Delete(MedicalHistory medicalHistory);
    IDataResult<List<MedicalHistory>> GetAll();
    public IResult importRecords(string dataFile, string tableName);
    IDataResult<List<MedicalHistory>> GetAllByPatientId(string PatientCode);
    IDataResult<MedicalHistory> Get(int id);
    IDataResult<MedicalHistory> GetByPatientId(string PatientCode);
}


}