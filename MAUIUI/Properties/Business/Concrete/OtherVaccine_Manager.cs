using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Concrete
{
    public class OtherVaccine_Manager : IOtherVaccine_Service
        {
            IOtherVaccine_Dal _vaccine_Dal;
            public OtherVaccine_Manager(IOtherVaccine_Dal vaccine_Dal)
            {
                _vaccine_Dal = vaccine_Dal;
            }
            public IResult Add(OtherVaccine vaccine_)
            {
            _vaccine_Dal.Add(vaccine_);
                return new SuccessResult();
            }

            public IResult Delete(OtherVaccine vaccine_)
            {
            _vaccine_Dal.Delete(vaccine_);
                return new SuccessResult();
            }

            public IDataResult<OtherVaccine> Get(int id)
            {
                return new SuccessDataResult<OtherVaccine>(_vaccine_Dal.Get(p => p.Id == id));
            }

            public IDataResult<List<OtherVaccine>> GetAll()
            {
                return new SuccessDataResult<List<OtherVaccine>>(_vaccine_Dal.GetAll());
            }

            public IDataResult<List<OtherVaccine>> GetAllByPatientId(string patientId)
            {
                return new SuccessDataResult<List<OtherVaccine>>(_vaccine_Dal.GetAll(p => p.PatientCode == patientId));
            }

            public IDataResult<OtherVaccine> GetByPatientId(string patientId)
            {
                return new SuccessDataResult<OtherVaccine>(_vaccine_Dal.Get(p => p.PatientCode == patientId));
            }

            public IResult Update(OtherVaccine vaccine_)
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


