using System.Reflection.PortableExecutable;
using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Concrete
{
    public class Vaccine_Manager : IVaccine_Service
    {
        IVaccine_Dal _vaccine_Dal;
        public Vaccine_Manager(IVaccine_Dal vaccine_Dal)
        {
            _vaccine_Dal = vaccine_Dal;
        }
        public IResult Add(Vaccine_ vaccine_)
        {
            _vaccine_Dal.Add(vaccine_);
            return new SuccessResult();
        }

        public IResult Delete(Vaccine_ vaccine_)
        {
            _vaccine_Dal.Delete(vaccine_);
            return new SuccessResult();
        }

        public IDataResult<Vaccine_> Get(int id)
        {
            return new SuccessDataResult<Vaccine_>(_vaccine_Dal.Get(p => p.Id == id));
        }

        public IDataResult<List<Vaccine_>> GetAll()
        {
            return new SuccessDataResult<List<Vaccine_>>(_vaccine_Dal.GetAll());
        }

        public IDataResult<List<Vaccine_>> GetAllByPatientId(string patientId)
        {
            return new SuccessDataResult<List<Vaccine_>>(_vaccine_Dal.GetAll(p => p.PatientCode == patientId));
        }

        public IDataResult<Vaccine_> GetByPatientId(string patientId)
        {
            return new SuccessDataResult<Vaccine_>(_vaccine_Dal.Get(p => p.PatientCode == patientId));
        }

        public IResult Update(Vaccine_ vaccine_)
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


