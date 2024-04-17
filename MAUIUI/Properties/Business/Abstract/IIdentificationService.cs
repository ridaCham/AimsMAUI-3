using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;
using MAUIUI.Entities.DTOs;
namespace MAUIUI.Business.Abstract
{
    public interface IIdentificationService
{
    IResult Add(Identifications note);
    IResult Update(Identifications note);
    IResult Delete(Identifications note);
    IDataResult<List<Identifications>> GetAllByPatientId(string PatientCode);
    IDataResult<List<Identifications>> GetAll();
    IResult importRecords(string dataFile, string tableName);
    IDataResult<List<DiagnosisStatistic>> GetAllConfirmedDiagnosisCount();
    IDataResult<Identifications> Get(int PatientCode);
    IDataResult<Identifications> GetByPatientId(string PatientCode);
    IDataResult<List<IdentificationDetails>> GetAllGenderCount();
    IDataResult<List<IdentificationDataGirdviewDetails>> GetAllToGirdView();
    IDataResult<List<IdentificationDataGirdviewDetails>> GetAllDeletedToGirdView();
    IDataResult<List<IdentificationStatistics>> GetAllStatistics(params string[] selectedFields);
    IDataResult<List<IdentificationStatistics>> GetAllStatisticsInit();
}


}