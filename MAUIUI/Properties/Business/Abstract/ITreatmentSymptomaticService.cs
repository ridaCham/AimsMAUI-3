using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Abstract
{
    public interface ITreatmentSymptomaticService
    {
        IResult Add(TreatmentSymptomatic treatment);
        IResult Update(TreatmentSymptomatic treatment);
        IResult Delete(TreatmentSymptomatic treatment);
        IDataResult<List<TreatmentSymptomatic>> GetAll(string PatientCode);
        IDataResult<List<TreatmentSymptomatic>> GetAllByPatientId(string PatientCode);
        IDataResult<TreatmentSymptomatic> Get(int id);
        public IResult importRecords(string dataFile, string tableName);
        IDataResult<TreatmentSymptomatic> GetByPatientId(string PatientCode);
    }
}

