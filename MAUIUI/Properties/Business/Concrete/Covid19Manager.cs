using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Concrete
{
    public class Covid19Manager : ICovid19Service
        {
            ICovid19Dal _covid19Dal;
            public Covid19Manager(ICovid19Dal covid19Dal)
            {
                _covid19Dal = covid19Dal;
            }


            public IResult Add(Covid19 covid19)
            {
                _covid19Dal.Add(covid19);
                return new SuccessResult();
            }

            public IResult Delete(Covid19 covid19)
            {
                _covid19Dal.Delete(covid19);
                return new SuccessResult();
            }

            public IDataResult<Covid19> Get(int id)
            {
                return new SuccessDataResult<Covid19>(_covid19Dal.
                    Get(p => p.Id == id));
            }

            public IDataResult<List<Covid19>> GetAll()
            {

                return new SuccessDataResult<List<Covid19>>();
            }

            public IDataResult<List<Covid19>> GetAllByPatientId(string patientId)
            {
                return new SuccessDataResult<List<Covid19>>(_covid19Dal.
                                            GetAll(p => p.PatientCode == patientId));
            }

            public IDataResult<Covid19> GetByPatientId(string patientId)
            {
                return new SuccessDataResult<Covid19>(_covid19Dal.
                                Get(p => p.PatientCode == patientId));
            }

            public IResult Update(Covid19 covid19)
            {
                _covid19Dal.Update(covid19);
                return new SuccessResult();
            }

            public IResult importRecords(string dataFile, string tableName)
            {
                this._covid19Dal.importRecords(dataFile, tableName);
                return new SuccessResult();
            }

            public IDataResult<Covid19> GetByPatientIdAndOnsetDate(string recivedId, DateTime? dateOfOnset)
            {
                return new SuccessDataResult<Covid19>(_covid19Dal.Get(p => p.PatientCode == recivedId && p.DateOfOnset == dateOfOnset));
            }
        }
    }


