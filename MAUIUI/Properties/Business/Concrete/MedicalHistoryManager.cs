using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Concrete
{
    public class MedicalHistoryManager : IMedicalHistoryService
        {
            IMedicalHistoryDal _medicalHistoryDal;
            public MedicalHistoryManager(IMedicalHistoryDal medicalHistoryDal)
            {
                _medicalHistoryDal = medicalHistoryDal;
            }

            IResult IMedicalHistoryService.Add(MedicalHistory medicalHistory)
            {
                _medicalHistoryDal.Add(medicalHistory);
                return new SuccessResult();
            }

            IResult IMedicalHistoryService.Update(MedicalHistory medicalHistory)
            {
                _medicalHistoryDal.Update(medicalHistory);
                return new SuccessResult();
            }

            IResult IMedicalHistoryService.Delete(MedicalHistory medicalHistory)
            {
                _medicalHistoryDal.Delete(medicalHistory);
                return new SuccessResult();
            }

            IDataResult<List<MedicalHistory>> IMedicalHistoryService.GetAll()
            {
                return new SuccessDataResult<List<MedicalHistory>>(_medicalHistoryDal.GetAll());
            }

            IDataResult<List<MedicalHistory>> IMedicalHistoryService.GetAllByPatientId(string patientId)
            {
                return new SuccessDataResult<List<MedicalHistory>>(
                    _medicalHistoryDal.GetAll(p => p.PatientCode == patientId));
            }

            IDataResult<MedicalHistory> IMedicalHistoryService.Get(int id)
            {
                return new SuccessDataResult<MedicalHistory>(_medicalHistoryDal.Get(p => p.Id == id));
            }

            IDataResult<MedicalHistory> IMedicalHistoryService.GetByPatientId(string patientId)
            {
                return new SuccessDataResult<MedicalHistory>(_medicalHistoryDal.Get(p => p.PatientCode == patientId));
            }

            public IResult importRecords(string dataFile, string tableName)
            {
                this._medicalHistoryDal.importRecords(dataFile, tableName);
                return new SuccessResult();
            }
        }
    }


