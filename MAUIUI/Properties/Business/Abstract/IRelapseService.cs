using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Abstract
{
    public interface IRelapseService
    {
        IResult Add(Relapse relapse);
        IResult Update(Relapse relapse);
        IResult Delete(Relapse relapse);
        IDataResult<List<Relapse>> GetAll();
        IDataResult<List<Relapse>> GetAllByPatientId(string PatientCode);
        public IResult importRecords(string dataFile, string tableName);
        IDataResult<Relapse> Get(string id);
        IDataResult<Relapse> GetByPatientId(string PatientCode);
    }
}

