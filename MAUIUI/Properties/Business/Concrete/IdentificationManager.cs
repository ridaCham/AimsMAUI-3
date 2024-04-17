using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;
using MAUIUI.Entities.DTOs;

namespace MAUIUI.Business.Concrete
{
    public class IdentificationManager : IIdentificationService
        {
            IIdentificationDal _IdentificationDal;
            public IdentificationManager(IIdentificationDal noteDal)
            {
                _IdentificationDal = noteDal;
            }

            IResult IIdentificationService.Add(Identifications note)
            {

                _IdentificationDal.Add(note);
                return new SuccessResult();
            }

            IResult IIdentificationService.Update(Identifications note)
            {
                _IdentificationDal.Update(note);
                return new SuccessResult();
            }

            public IDataResult<List<DiagnosisStatistic>> GetAllConfirmedDiagnosisCount()
            {
                return new SuccessDataResult<List<DiagnosisStatistic>>(_IdentificationDal.GetAllConfirmedDiagnosisCount());
            }

            IResult IIdentificationService.Delete(Identifications note)
            {
                _IdentificationDal.Delete(note);
                return new SuccessResult();
            }

            IDataResult<Identifications> IIdentificationService.Get(int patientId)
            {
                return new SuccessDataResult<Identifications>(_IdentificationDal.Get(p => p.Id == patientId));
            }

            IDataResult<List<Identifications>> IIdentificationService.GetAllByPatientId(string id)
            {
                return new SuccessDataResult<List<Identifications>>(_IdentificationDal.GetAll(p => p.PatientCode == id));
            }

            IDataResult<Identifications> IIdentificationService.GetByPatientId(string patientId)
            {
                return new SuccessDataResult<Identifications>(_IdentificationDal.Get(p => p.PatientCode == patientId));
            }

            public IDataResult<List<IdentificationDetails>> GetAllGenderCount()
            {
                return new SuccessDataResult<List<IdentificationDetails>>(_IdentificationDal.GetAllGenderCount());
            }

            public IDataResult<List<IdentificationDataGirdviewDetails>> GetAllToGirdView()
            {
                return new SuccessDataResult<List<IdentificationDataGirdviewDetails>>(_IdentificationDal.GetAllToGirdView(0));
            }

            public IDataResult<List<IdentificationStatistics>> GetAllStatistics(params string[] selectedFields)
            {
                return new SuccessDataResult<List<IdentificationStatistics>>(_IdentificationDal.GetAllStatistics(selectedFields));
            }

            public IDataResult<List<Identifications>> GetAll()
            {
                return new SuccessDataResult<List<Identifications>>(_IdentificationDal.GetAll());
            }

            public IDataResult<List<IdentificationDataGirdviewDetails>> GetAllDeletedToGirdView()
            {
                return new SuccessDataResult<List<IdentificationDataGirdviewDetails>>(_IdentificationDal.GetAllToGirdView(1));
            }

            public IResult importRecords(string dataFile, string tableName)
            {
                this._IdentificationDal.importRecords(dataFile, tableName);
                return new SuccessResult();
            }

            public IDataResult<List<IdentificationStatistics>> GetAllStatisticsInit()
            {
                return new SuccessDataResult<List<IdentificationStatistics>>(_IdentificationDal.GetAllStatisticsInit());
            }
        }
    }


