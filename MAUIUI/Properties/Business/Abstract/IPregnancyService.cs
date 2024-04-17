using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Abstract
{
    public interface IPregnancyService
{
    IResult Add(Pregnancy pregnancy);
    IResult Update(Pregnancy pregnancy);
    IResult Delete(Pregnancy pregnancy);
    IDataResult<List<Pregnancy>> GetAll();
    public IResult importRecords(string dataFile, string tableName);
    IDataResult<List<Pregnancy>> GetAllByPatientId(string PatientCode);
    IDataResult<Pregnancy> Get(int id);
    IDataResult<Pregnancy> GetByPatientId(string patientId);
}


}