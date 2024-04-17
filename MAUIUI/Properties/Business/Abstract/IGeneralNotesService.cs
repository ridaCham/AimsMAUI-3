using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Abstract
{
    public interface IGeneralNotesService
{
    IResult Add(GeneralNotes note);
    IResult Update(GeneralNotes note);
    IResult Delete(GeneralNotes note);
    IDataResult<List<GeneralNotes>> GetAllByPatientId(string PatientCode);
    IDataResult<GeneralNotes> GetByPatientId(string PatientCode);
    public IResult importRecords(string dataFile, string tableName);
}


}