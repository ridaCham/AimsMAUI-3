using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Concrete
{
    public class OtherMedicalConditionManager : IOtherMedicalConditionService
        {
            IOtherMedicalConditionDal _otherMedicalConditionDal;
            public OtherMedicalConditionManager(IOtherMedicalConditionDal otherMedicalConditionDal)
            {
                _otherMedicalConditionDal = otherMedicalConditionDal;
            }
            public IResult Add(OtherMedicalCondition otherMedicalCondition)
            {
                _otherMedicalConditionDal.Add(otherMedicalCondition);
                return new SuccessResult();

            }

            public IResult Delete(OtherMedicalCondition otherMedicalCondition)
            {
                _otherMedicalConditionDal.Delete(otherMedicalCondition);
                return new SuccessResult();
            }

            public IDataResult<OtherMedicalCondition> Get(int id)
            {
                return new SuccessDataResult<OtherMedicalCondition>(
                                    _otherMedicalConditionDal.Get(p => p.Id == id));
            }

            public IDataResult<List<OtherMedicalCondition>> GetAll()
            {
                return new SuccessDataResult<List<OtherMedicalCondition>>(_otherMedicalConditionDal.GetAll());
            }

            public IDataResult<List<OtherMedicalCondition>> GetAllByPatientId(string patientId)
            {
                return new SuccessDataResult<List<OtherMedicalCondition>>(
                    _otherMedicalConditionDal.GetAll(p => p.PatientCode == patientId));
            }

            public IDataResult<OtherMedicalCondition> GetByPatientId(string patientId)
            {
                return new SuccessDataResult<OtherMedicalCondition>(
                        _otherMedicalConditionDal.Get(p => p.PatientCode == patientId));
            }

            public IResult Update(OtherMedicalCondition otherMedicalCondition)
            {
                _otherMedicalConditionDal.Update(otherMedicalCondition);
                return new SuccessResult();
            }

            public IResult importRecords(string dataFile, string tableName)
            {
                this._otherMedicalConditionDal.importRecords(dataFile, tableName);
                return new SuccessResult();
            }

            public IDataResult<OtherMedicalCondition> GetDateOfOnset(string recivedId, DateTime? dateOfOnset)
            {
                return new SuccessDataResult<OtherMedicalCondition>(
                        _otherMedicalConditionDal.Get(p => p.PatientCode == recivedId && p.DateOfOnset == dateOfOnset));
            }
        }
    }


