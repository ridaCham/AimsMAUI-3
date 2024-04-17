using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Abstract
{
    public interface ILaboratoryTestsNotesService
{
    IResult Add(LaboratoryTestsNotes note);
    IResult Update(LaboratoryTestsNotes note);
    IResult Delete(LaboratoryTestsNotes note);
    IDataResult<List<LaboratoryTestsNotes>> GetAllByPatientId(string PatientCode);
    IDataResult<LaboratoryTestsNotes> GetByPatientId(string PatientCode);
    public IResult importRecords(string dataFile, string tableName);
}


}
//MRI--->Vaccine

