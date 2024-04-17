using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Abstract
{
    public interface IOutcomeService
{
    IResult Add(Outcome outcome);
    IResult Update(Outcome outcome);
    IResult Delete(Outcome outcome);
    IDataResult<List<Outcome>> GetAllByPregnancyEndDate(string PatientCode, DateTime? dateTime);
    IDataResult<Outcome> Get(int id);
    public IResult importRecords(string dataFile, string tableName);
}

}
//MRI--->Vaccine

