using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Abstract
{
    public interface IAddNewFamilyHistoryService
{
    public IResult Add(AddNewFamilyHistory addNewFamilyHistory);
    public IResult Delete(AddNewFamilyHistory addNewFamilyHistory);
    public IResult Update(AddNewFamilyHistory addNewFamilyHistory);
    public IDataResult<AddNewFamilyHistory> GetByPatientId(int Id);


    public IResult importRecords(string dataFile, string tableName);
    public IDataResult<List<AddNewFamilyHistory>> GetAllByPatientId(string Id);


    }
}


