using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Abstract
{
    public interface ITreatmentService
    {
        IResult Add(Treatment treatment);
        IResult Update(Treatment treatment);
        IResult Delete(Treatment treatment);
        IDataResult<List<Treatment>> GetAll();
        public IResult importRecords(string dataFile, string tableName);
        IDataResult<List<Treatment>> GetAllByPatientId(string PatientCode);
        IDataResult<Treatment> Get(int id);
        IDataResult<Treatment> GetByPatientId(string PatientCode);
    }
}

