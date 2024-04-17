using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Abstract
{
    public interface IFluVaccine_Service
{
    IResult Add(FluVaccine vaccine_);
    IResult Update(FluVaccine vaccine_);
    public IResult importRecords(string dataFile, string tableName);
    IResult Delete(FluVaccine vaccine_);
    IDataResult<List<FluVaccine>> GetAll();
    IDataResult<List<FluVaccine>> GetAllByPatientId(string PatientCode);
    IDataResult<FluVaccine> Get(int id);
    IDataResult<FluVaccine> GetByPatientId(string PatientCode);
}


}