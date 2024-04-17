using MAUIUI.Core.Utilities.Results;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Abstract
{
    public interface IFaceToFaceTestService
{
    IResult Add(FaceToFaceTest MGADL_);
    IResult Update(FaceToFaceTest MGADL_);
    IResult Delete(FaceToFaceTest MGADL_);
    IDataResult<List<FaceToFaceTest>> GetAll();
    IDataResult<List<FaceToFaceTest>> GetAllByPatientId(string PatientCode);
    IDataResult<FaceToFaceTest> Get(int id);
    IDataResult<FaceToFaceTest> GetByPatientId(string PatientCode, DateTime? dateTime);
    IDataResult<FaceToFaceTest> GetByDate(DateTime date);
    public IResult importRecords(string dataFile, string tableName);
}


}