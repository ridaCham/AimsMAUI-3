using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Abstract
{
    public interface ITreatmentPhysiotherapyService
    {
        IResult Add(TreatmentPhysiotherapy treatment);
        IResult Update(TreatmentPhysiotherapy treatment);
        IResult Delete(TreatmentPhysiotherapy treatment);
        IDataResult<List<TreatmentPhysiotherapy>> GetAll(string PatientCode);
        IDataResult<List<TreatmentPhysiotherapy>> GetAllByPatientId(string PatientCode);
        public IResult importRecords(string dataFile, string tableName);
        IDataResult<TreatmentPhysiotherapy> Get(int id);
        IDataResult<TreatmentPhysiotherapy> GetByPatientId(string PatientCode);
    }
}

