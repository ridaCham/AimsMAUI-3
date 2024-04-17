using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Abstract
{
    public interface IHepatityAVaccine_Service
{
    IResult Add(HepatitisAVaccine vaccine_);
    IResult Update(HepatitisAVaccine vaccine_);
    public IResult importRecords(string dataFile, string tableName);
    IResult Delete(HepatitisAVaccine vaccine_);
    IDataResult<List<HepatitisAVaccine>> GetAll();
    IDataResult<List<HepatitisAVaccine>> GetAllByPatientId(string PatientCode);
    IDataResult<HepatitisAVaccine> Get(int id);
    IDataResult<HepatitisAVaccine> GetByPatientId(string PatientCode);
}

}
