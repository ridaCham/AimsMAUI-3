using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Abstract
{
    public interface IParatestMRIService
{
    IResult Add(ParatestMRI paratestMRI);
    IResult Update(ParatestMRI paratestMRI);
    IResult Delete(ParatestMRI paratestMRI);
    IDataResult<List<ParatestMRI>> GetAll();
    IDataResult<List<ParatestMRI>> GetAllByPatientId(string PatientCode);
    IDataResult<ParatestMRI> Get(int id);
    IDataResult<ParatestMRI> GetByDate(DateTime date);
    public IResult importRecords(string dataFile, string tableName);
    IDataResult<ParatestMRI> GetByPatientId(string PatientCode);
}

}
