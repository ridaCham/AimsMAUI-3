using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Concrete
{
    public class OutcomeManager : IOutcomeService
        {
            IOutcomeDal _OutcomeDal;
            public OutcomeManager(IOutcomeDal outcomeDal)
            {
                _OutcomeDal = outcomeDal;
            }
            public IResult Add(Outcome outcome)
            {
                _OutcomeDal.Add(outcome);
                return new SuccessResult();
            }

            public IResult Delete(Outcome outcome)
            {
                _OutcomeDal.Delete(outcome);
                return new SuccessResult();
            }


            public IDataResult<List<Outcome>> GetAllByPregnancyEndDate(string PatientCode, DateTime? dateTime)
            {
                return new SuccessDataResult<List<Outcome>>(_OutcomeDal.GetAll(p => p.PatientCode == PatientCode
                && p.PregnancyStartDate == dateTime));
            }

            public IDataResult<Outcome> Get(int Id)
            {
                return new SuccessDataResult<Outcome>(_OutcomeDal.Get(p => p.Id == Id));
            }

            public IResult Update(Outcome outcome)
            {
                _OutcomeDal.Update(outcome);
                return new SuccessResult();
            }

            public IResult importRecords(string dataFile, string tableName)
            {
                this._OutcomeDal.importRecords(dataFile, tableName);
                return new SuccessResult();
            }


        }
    }


