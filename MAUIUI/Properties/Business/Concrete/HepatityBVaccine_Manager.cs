using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Concrete
{
    public partial class HepatityBVaccine_Manager : IHepatityBVaccine_Service
        {
            IHepatitisBVaccine_Dal _vaccine_Dal;
            public HepatityBVaccine_Manager(IHepatitisBVaccine_Dal vaccine_Dal)
            {
                _vaccine_Dal = vaccine_Dal;
            }
            public IResult Add(HepatitisBVaccine vaccine_)
            {
            _vaccine_Dal.Add(vaccine_);
                return new SuccessResult();
            }

            public IResult Delete(HepatitisBVaccine vaccine_)
            {
            _vaccine_Dal.Delete(vaccine_);
                return new SuccessResult();
            }

            public IDataResult<HepatitisBVaccine> Get(int id)
            {
                return new SuccessDataResult<HepatitisBVaccine>(_vaccine_Dal.Get(p => p.Id == id));
            }

            public IDataResult<List<HepatitisBVaccine>> GetAll()
            {
                return new SuccessDataResult<List<HepatitisBVaccine>>(_vaccine_Dal.GetAll());
            }

            public IDataResult<List<HepatitisBVaccine>> GetAllByPatientId(string patientId)
            {
                return new SuccessDataResult<List<HepatitisBVaccine>>(_vaccine_Dal.GetAll(p => p.PatientCode == patientId));
            }

            public IDataResult<HepatitisBVaccine> GetByPatientId(string patientId)
            {
                return new SuccessDataResult<HepatitisBVaccine>(_vaccine_Dal.Get(p => p.PatientCode == patientId));
            }

            public IResult Update(HepatitisBVaccine vaccine_)
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


