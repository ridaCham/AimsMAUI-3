using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;
//MRI--->Vaccine

namespace MAUIUI.Business.Abstract
{
    public interface IVaccine_Service
{
    IResult Add(Vaccine_ vaccine_);
    IResult Update(Vaccine_ vaccine_);
    public IResult importRecords(string dataFile, string tableName);
    IResult Delete(Vaccine_ vaccine_);
    IDataResult<List<Vaccine_>> GetAll();
    IDataResult<List<Vaccine_>> GetAllByPatientId(string PatientCode);
    IDataResult<Vaccine_> Get(int id);
    IDataResult<Vaccine_> GetByPatientId(string PatientCode);
}


}