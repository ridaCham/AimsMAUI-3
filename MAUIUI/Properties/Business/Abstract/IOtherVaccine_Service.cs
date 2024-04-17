using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Abstract
{
    public interface IOtherVaccine_Service
{
    IResult Add(OtherVaccine vaccine_);
    IResult Update(OtherVaccine vaccine_);
    public IResult importRecords(string dataFile, string tableName);
    IResult Delete(OtherVaccine vaccine_);
    IDataResult<List<OtherVaccine>> GetAll();
    IDataResult<List<OtherVaccine>> GetAllByPatientId(string PatientCode);
    IDataResult<OtherVaccine> Get(int id);
    IDataResult<OtherVaccine> GetByPatientId(string PatientCode);
}


}