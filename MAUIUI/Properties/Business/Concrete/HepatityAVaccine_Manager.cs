using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Concrete
{
    public class HepatityAVaccine_Manager : IHepatityAVaccine_Service
        {
            IHepatitisAVaccine_Dal _vaccine_Dal;
            public HepatityAVaccine_Manager(IHepatitisAVaccine_Dal vaccine_Dal)
            {
                _vaccine_Dal = vaccine_Dal;
            }
            public IResult Add(HepatitisAVaccine vaccine_)
            {
            _vaccine_Dal.Add(vaccine_);
                return new SuccessResult();
            }

            public IResult Delete(HepatitisAVaccine vaccine_)
            {
            _vaccine_Dal.Delete(vaccine_);
                return new SuccessResult();
            }

            public IDataResult<HepatitisAVaccine> Get(int id)
            {
                return new SuccessDataResult<HepatitisAVaccine>(_vaccine_Dal.Get(p => p.Id == id));
            }

            public IDataResult<List<HepatitisAVaccine>> GetAll()
            {
                return new SuccessDataResult<List<HepatitisAVaccine>>(_vaccine_Dal.GetAll());
            }

            public IDataResult<List<HepatitisAVaccine>> GetAllByPatientId(string patientId)
            {
                return new SuccessDataResult<List<HepatitisAVaccine>>(_vaccine_Dal.GetAll(p => p.PatientCode == patientId));
            }

            public IDataResult<HepatitisAVaccine> GetByPatientId(string patientId)
            {
                return new SuccessDataResult<HepatitisAVaccine>(_vaccine_Dal.Get(p => p.PatientCode == patientId));
            }

            public IResult Update(HepatitisAVaccine vaccine_)
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


