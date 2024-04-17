using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;
using MAUIUI.Entities.DTOs;

namespace MAUIUI.Business.Concrete
{
    public class DiagnosisManager : IDiagnosisService
        {
            IDiagnosisDal _diagnosisDal;
            public DiagnosisManager(IDiagnosisDal diagnosisDal)
            {
                _diagnosisDal = diagnosisDal;
            }


            public IResult Add(Diagnosis diagnosis)
            {
                _diagnosisDal.Add(diagnosis);
                return new SuccessResult();
            }

            public IResult Delete(Diagnosis diagnosis)
            {
                _diagnosisDal.Delete(diagnosis);
                return new SuccessResult();
            }

            public IDataResult<Diagnosis> Get(string id)
            {
                return new SuccessDataResult<Diagnosis>(_diagnosisDal.Get(p => p.PatientCode == id));
            }

            public IDataResult<List<Diagnosis>> GetAll()
            {
                return new SuccessDataResult<List<Diagnosis>>(_diagnosisDal.GetAll());
            }

            public IDataResult<List<Diagnosis>> GetAllByPatientId(string patientId)
            {
                return new SuccessDataResult<List<Diagnosis>>(_diagnosisDal.
                    GetAll(p => p.PatientCode == patientId));
            }

            public IDataResult<List<DiagnosisStatistic>> GetAllConfirmedDiagnosisCount()
            {
                return new SuccessDataResult<List<DiagnosisStatistic>>(_diagnosisDal.GetAllConfirmedDiagnosisCount());
            }



            public IDataResult<Diagnosis> GetByPatientId(string patientId)
            {
                return new SuccessDataResult<Diagnosis>(_diagnosisDal.Get(p => p.PatientCode == patientId));
            }

            public IResult Update(Diagnosis diagnosis)
            {
                _diagnosisDal.Update(diagnosis);
                return new SuccessResult();
            }

            public IResult importRecords(string dataFile, string tableName)
            {
                this._diagnosisDal.importRecords(dataFile, tableName);
                return new SuccessResult();
            }


        }
    }


