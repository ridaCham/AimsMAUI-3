using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Abstract
{
    public interface IHepatityBVaccine_Service
{
    IResult Add(HepatitisBVaccine vaccine_);
    IResult Update(HepatitisBVaccine vaccine_);
    public IResult importRecords(string dataFile, string tableName);
    IResult Delete(HepatitisBVaccine vaccine_);
    IDataResult<List<HepatitisBVaccine>> GetAll();
    IDataResult<List<HepatitisBVaccine>> GetAllByPatientId(string PatientCode);
    IDataResult<HepatitisBVaccine> Get(int id);
    IDataResult<HepatitisBVaccine> GetByPatientId(string PatientCode);
}


}