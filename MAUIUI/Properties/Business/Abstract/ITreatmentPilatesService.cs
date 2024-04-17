using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Abstract
{
    public interface ITreatmentPilatesService
    {
        IResult Add(TreatmentPilates treatment);
        IResult Update(TreatmentPilates treatment);
        IResult Delete(TreatmentPilates treatment);
        IDataResult<List<TreatmentPilates>> GetAll(string PatientCode);
        IDataResult<List<TreatmentPilates>> GetAllByPatientId(string PatientCode);
        IDataResult<TreatmentPilates> Get(int id);
        public IResult importRecords(string dataFile, string tableName);
        IDataResult<TreatmentPilates> GetByPatientId(string PatientCode);
    }
}

