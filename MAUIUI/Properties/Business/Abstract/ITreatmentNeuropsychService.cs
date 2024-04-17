using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Abstract
{
    public interface ITreatmentNeuropsychService
    {
        IResult Add(TreatmentNeuropsych treatment);
        IResult Update(TreatmentNeuropsych treatment);
        IResult Delete(TreatmentNeuropsych treatment);
        IDataResult<List<TreatmentNeuropsych>> GetAll(string PatientCode);
        IDataResult<List<TreatmentNeuropsych>> GetAllByPatientId(string PatientCode);
        public IResult importRecords(string dataFile, string tableName);
        IDataResult<TreatmentNeuropsych> Get(int id);
        IDataResult<TreatmentNeuropsych> GetByPatientId(string PatientCode);
    }
}

