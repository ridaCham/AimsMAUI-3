using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Abstract
{
    public interface IEvokedPotentielService
{
    IResult Add(EvokedPotentiel MGADL_);
    IResult Update(EvokedPotentiel MGADL_);
    IResult Delete(EvokedPotentiel MGADL_);
    IDataResult<List<EvokedPotentiel>> GetAll();
    IDataResult<List<EvokedPotentiel>> GetAllByPatientId(string PatientCode);
    IDataResult<EvokedPotentiel> Get(int id);
    IDataResult<EvokedPotentiel> GetByDate(DateTime date);
    IDataResult<EvokedPotentiel> GetByPatientId(string PatientCode);
    public IResult importRecords(string dataFile, string tableName);
}


}