using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Abstract
{
    public interface ITreatmentPsychotherapyService
    {
        IResult Add(TreatmentPsychotherapy treatment);
        IResult Update(TreatmentPsychotherapy treatment);
        IResult Delete(TreatmentPsychotherapy treatment);
        IDataResult<List<TreatmentPsychotherapy>> GetAll(string PatientCode);
        IDataResult<List<TreatmentPsychotherapy>> GetAllByPatientId(string PatientCode);
        IDataResult<TreatmentPsychotherapy> Get(int id);
        public IResult importRecords(string dataFile, string tableName);
        IDataResult<TreatmentPsychotherapy> GetByPatientId(string PatientCode);
    }
}

