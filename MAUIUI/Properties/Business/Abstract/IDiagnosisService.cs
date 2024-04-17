using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;
using MAUIUI.Entities.DTOs;
namespace MAUIUI.Business.Abstract
{
    public interface IDiagnosisService
{
    IResult Add(Diagnosis diagnosis);
    IResult Update(Diagnosis diagnosis);
    IResult Delete(Diagnosis diagnosis);
    IDataResult<List<Diagnosis>> GetAll();
    IDataResult<List<Diagnosis>> GetAllByPatientId(string PatientCode);
    IDataResult<List<DiagnosisStatistic>> GetAllConfirmedDiagnosisCount();

    IDataResult<Diagnosis> Get(string id);
    public IResult importRecords(string dataFile, string tableName);
    IDataResult<Diagnosis> GetByPatientId(string PatientCode);
}

}