using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Abstract
{
    public interface ICSFService
{
    IResult Add(CSF MGADL_);
    IResult Update(CSF MGADL_);
    IResult Delete(CSF MGADL_);
    IDataResult<List<CSF>> GetAll();
    IDataResult<List<CSF>> GetAllByPatientId(string PatientCode);
    IDataResult<CSF> Get(int id);
    IDataResult<CSF> GetByDate(DateTime date);
    IDataResult<CSF> GetByPatientId(string PatientCode);
    public IResult importRecords(string dataFile, string tableName);
}

}
