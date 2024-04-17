using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Abstract
{
    public interface IHaematologyService
{
    IResult Add(Haematology haematology);
    IResult Update(Haematology haematology);
    IResult Delete(Haematology haematology);
    IDataResult<List<Haematology>> GetAll();
    public IResult importRecords(string dataFile, string tableName);
    IDataResult<List<Haematology>> GetAllByPatientId(string PatientCode);
    IDataResult<Haematology> Get(int id);
    IDataResult<Haematology> GetByPatientId(string PatientCode);
}

}
//MRI--->Vaccine

