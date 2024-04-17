using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Abstract
{
    public interface IMalignancyService
{
    IResult Add(Malignancy malignancy);
    IResult Update(Malignancy malignancy);
    IResult Delete(Malignancy malignancy);
    public IResult importRecords(string dataFile, string tableName);
    IDataResult<List<Malignancy>> GetAll();
    IDataResult<List<Malignancy>> GetAllByPatientId(string PatientCode);
    IDataResult<Malignancy> Get(int id);
    IDataResult<Malignancy> GetByPatientId(string PatientCode);
    IDataResult<Malignancy> GetByMalignancydate(string recivedId, DateTime? dateOfDiagnosis);
}

}
