using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Concrete
{
    public class HerpesZosterManager : IHerpesZosterService
        {
            IHerpesZosterDal _herpesZosterDal;
            public HerpesZosterManager(IHerpesZosterDal herpesZosterDal)
            {
                _herpesZosterDal = herpesZosterDal;
            }

            public IResult Add(HerpesZoster herpesZoster)
            {
                _herpesZosterDal.Add(herpesZoster);
                return new SuccessResult();
            }

            public IResult Delete(HerpesZoster herpesZoster)
            {

                _herpesZosterDal.Delete(herpesZoster);
                return new SuccessResult();
            }

            public IDataResult<HerpesZoster> Get(int id)
            {
                return new SuccessDataResult<HerpesZoster>(_herpesZosterDal.Get(p => p.Id == id));
            }

            public IDataResult<List<HerpesZoster>> GetAll()
            {
                return new SuccessDataResult<List<HerpesZoster>>(_herpesZosterDal.GetAll());
            }

            public IDataResult<List<HerpesZoster>> GetAllByPatientId(string patientId)
            {
                return new SuccessDataResult<List<HerpesZoster>>(_herpesZosterDal.GetAll(p => p.PatientCode == patientId));
            }

            public IDataResult<HerpesZoster> GetByPatientId(string patientId)
            {
                return new SuccessDataResult<HerpesZoster>(_herpesZosterDal.Get(p => p.PatientCode == patientId));
            }

            public IResult Update(HerpesZoster herpesZoster)
            {
                _herpesZosterDal.Update(herpesZoster);
                return new SuccessResult();
            }

            public IResult importRecords(string dataFile, string tableName)
            {
                this._herpesZosterDal.importRecords(dataFile, tableName);
                return new SuccessResult();
            }

            public IDataResult<HerpesZoster> GetByPatientIdAndOnsetDate(string recivedId, DateTime? dateOfDiagnosis)
            {
                return new SuccessDataResult<HerpesZoster>(_herpesZosterDal.Get(p => p.PatientCode == recivedId && p.DateOfDiagnosis == dateOfDiagnosis));
            }
        }
    }


