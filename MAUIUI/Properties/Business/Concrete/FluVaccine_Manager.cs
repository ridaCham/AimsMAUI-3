using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Concrete
{
    public class FluVaccine_Manager : IFluVaccine_Service
        {
            IFluVaccine_Dal _vaccine_Dal;
            public FluVaccine_Manager(IFluVaccine_Dal vaccine_Dal)
            {
                _vaccine_Dal = vaccine_Dal;
            }
            public IResult Add(FluVaccine vaccine_)
            {
            _vaccine_Dal.Add(vaccine_);
                return new SuccessResult();
            }

            public IResult Delete(FluVaccine vaccine_)
            {
            _vaccine_Dal.Delete(vaccine_);
                return new SuccessResult();
            }

            public IDataResult<FluVaccine> Get(int id)
            {
                return new SuccessDataResult<FluVaccine>(_vaccine_Dal.Get(p => p.Id == id));
            }

            public IDataResult<List<FluVaccine>> GetAll()
            {
                return new SuccessDataResult<List<FluVaccine>>(_vaccine_Dal.GetAll());
            }

            public IDataResult<List<FluVaccine>> GetAllByPatientId(string patientId)
            {
                return new SuccessDataResult<List<FluVaccine>>(_vaccine_Dal.GetAll(p => p.PatientCode == patientId));
            }

            public IDataResult<FluVaccine> GetByPatientId(string patientId)
            {
                return new SuccessDataResult<FluVaccine>(_vaccine_Dal.Get(p => p.PatientCode == patientId));
            }

            public IResult Update(FluVaccine vaccine_)
            {
            _vaccine_Dal.Update(vaccine_);
                return new SuccessResult();
            }

            public IResult importRecords(string dataFile, string tableName)
            {
                this._vaccine_Dal.importRecords(dataFile, tableName);
                return new SuccessResult();
            }
        }
    }


