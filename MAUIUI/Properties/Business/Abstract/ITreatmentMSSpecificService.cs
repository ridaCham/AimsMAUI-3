using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;
using MAUIUI.Entities.DTOs;

namespace MAUIUI.Business.Abstract
{
    public interface ITreatmentMSSpecificService
    {
        IResult Add(TreatmentMSSpecific treatment);
        IResult Update(TreatmentMSSpecific treatment);
        IResult Delete(TreatmentMSSpecific treatment);
        IDataResult<List<TreatmentMSSpecific>> GetAll(string PatientCode);
        IDataResult<List<TreatmentMSSpecific>> GetAllByPatientId(string PatientCode);
        IDataResult<TreatmentMSSpecific> Get(int id);
        IDataResult<List<MsSpecifikTreatmentChart>> GetAllDiagnosisMGClassificationCount();
        IDataResult<TreatmentMSSpecific> GetByPatientId(string PatientCode);
        public IResult importRecords(string dataFile, string tableName);
    }
}

