using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Concrete
{
    public class BloodChemistryManager : IBloodChemistryService
        {
            IBloodChemistryDal _bloodChemistryDal;
            public BloodChemistryManager(IBloodChemistryDal bloodChemistryDal)
            {
                _bloodChemistryDal = bloodChemistryDal;
            }


            public IResult Add(BloodChemistry bloodChemistry)
            {
                _bloodChemistryDal.Add(bloodChemistry);
                return new SuccessResult();
            }

            public IResult Delete(BloodChemistry bloodChemistry)
            {
                _bloodChemistryDal.Delete(bloodChemistry);
                return new SuccessResult();
            }

            public IDataResult<BloodChemistry> Get(int id)
            {
                return new SuccessDataResult<BloodChemistry>(_bloodChemistryDal.Get(p => p.Id == id));
            }

            public IDataResult<List<BloodChemistry>> GetAll()
            {
                return new SuccessDataResult<List<BloodChemistry>>(
                                            _bloodChemistryDal.GetAll());
            }

            public IDataResult<List<BloodChemistry>> GetAllByPatientId(string patientId)
            {
                return new SuccessDataResult<List<BloodChemistry>>(
                                _bloodChemistryDal.GetAll(p => p.PatientCode == patientId));
            }

            public IDataResult<BloodChemistry> GetByPatientId(string patientId)
            {
                return new SuccessDataResult<BloodChemistry>(
                    _bloodChemistryDal.Get(p => p.PatientCode == patientId));
            }

            public IResult Update(BloodChemistry bloodChemistry)
            {
                _bloodChemistryDal.Update(bloodChemistry);
                return new SuccessResult();
            }

            public IResult importRecords(string dataFile, string tableName)
            {
                this._bloodChemistryDal.importRecords(dataFile, tableName);
                return new SuccessResult();
            }

            public IDataResult<BloodChemistry> GetByExamDate(string recivedId, DateTime? examDate)
            {
                return new SuccessDataResult<BloodChemistry>(
                   _bloodChemistryDal.Get(p => p.PatientCode == recivedId && p.ExamDate == examDate));
            }
        }
    }


