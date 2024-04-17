using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Abstract
{
    public interface ICovid19Service
{
    IResult Add(Covid19 covid19);
    IResult Update(Covid19 covid19);
    IResult Delete(Covid19 covid19);
    IDataResult<List<Covid19>> GetAll();
    IDataResult<List<Covid19>> GetAllByPatientId(string PatientCode);
    IDataResult<Covid19> Get(int id);
    IDataResult<Covid19> GetByPatientId(string PatientCode);
    public IResult importRecords(string dataFile, string tableName);
    IDataResult<Covid19> GetByPatientIdAndOnsetDate(string recivedId, DateTime? dateOfOnset);
}

}
