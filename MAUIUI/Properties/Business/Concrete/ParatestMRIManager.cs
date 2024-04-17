using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Concrete
{
    public class ParatestMRIManager : IParatestMRIService
        {
            IParatestMRIDal _paratestMRIDal;
            public ParatestMRIManager(IParatestMRIDal pregnancyDal)
            {
                _paratestMRIDal = pregnancyDal;
            }

            public IResult Add(ParatestMRI pregnancy)
            {
                _paratestMRIDal.Add(pregnancy);
                return new SuccessResult();
            }

            public IResult Delete(ParatestMRI pregnancy)
            {
                _paratestMRIDal.Delete(pregnancy);
                return new SuccessResult();
            }

            public IDataResult<ParatestMRI> Get(int id)
            {
                return new SuccessDataResult<ParatestMRI>(_paratestMRIDal.Get(p => p.Id == id));
            }
            public IDataResult<ParatestMRI> GetByDate(DateTime date)
            {
                return new SuccessDataResult<ParatestMRI>(_paratestMRIDal.Get(p => p.ParatestmriExamDate == date));
            }

            public IDataResult<List<ParatestMRI>> GetAll()
            {
                return new SuccessDataResult<List<ParatestMRI>>(_paratestMRIDal.GetAll());
            }

            public IDataResult<List<ParatestMRI>> GetAllByPatientId(string patientId)
            {
                return new SuccessDataResult<List<ParatestMRI>>(_paratestMRIDal.GetAll(p => p.PatientCode == patientId));
            }

            public IDataResult<ParatestMRI> GetByPatientId(string patientId)
            {
                return new SuccessDataResult<ParatestMRI>(_paratestMRIDal.Get(p => p.PatientCode == patientId));
            }

            public IResult Update(ParatestMRI pregnancy)
            {
                _paratestMRIDal.Update(pregnancy);
                return new SuccessResult();
            }

            public IResult importRecords(string dataFile, string tableName)
            {
                this._paratestMRIDal.importRecords(dataFile, tableName);
                return new SuccessResult();
            }
        }
    }


