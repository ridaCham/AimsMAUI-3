using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Abstract
{
    public interface ICovid19Vaccine_Service
{
    IResult Add(Covid19Vaccine vaccine_);
    IResult Update(Covid19Vaccine vaccine_);
    public IResult importRecords(string dataFile, string tableName);
    IResult Delete(Covid19Vaccine vaccine_);
    IDataResult<List<Covid19Vaccine>> GetAll();
    IDataResult<List<Covid19Vaccine>> GetAllByPatientId(string PatientCode);
    IDataResult<Covid19Vaccine> Get(int id);
    IDataResult<Covid19Vaccine> GetByPatientId(string PatientCode);
}

}