using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Abstract
{
    public interface ITreatmentYogaService
    {
        IResult Add(TreatmentYoga treatment);
        IResult Update(TreatmentYoga treatment);
        IResult Delete(TreatmentYoga treatment);
        IDataResult<List<TreatmentYoga>> GetAll(string PatientCode);
        public IResult importRecords(string dataFile, string tableName);
        IDataResult<List<TreatmentYoga>> GetAllByPatientId(string PatientCode);
        IDataResult<TreatmentYoga> Get(int id);
        IDataResult<TreatmentYoga> GetByPatientId(string PatientCode);

    }
}

