using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Concrete
{
    public class CSFManager : ICSFService
        {
            ICSFDal _QMGDal;
            public CSFManager(ICSFDal QMG_Dal)
            {
                _QMGDal = QMG_Dal;
            }

            IResult ICSFService.Add(CSF FatigueTest)
            {
                _QMGDal.Add(FatigueTest);
                return new SuccessResult();
            }




            IResult ICSFService.Update(CSF FatigueTest)
            {
                _QMGDal.Update(FatigueTest);
                return new SuccessResult();
            }

            IResult ICSFService.Delete(CSF FatigueTest)
            {
                _QMGDal.Delete(FatigueTest);
                return new SuccessResult();
            }

            IDataResult<List<CSF>> ICSFService.GetAll()
            {
                return new SuccessDataResult<List<CSF>>(_QMGDal.GetAll());
            }

            IDataResult<List<CSF>> ICSFService.GetAllByPatientId(string patientId)
            {
                return new SuccessDataResult<List<CSF>>(_QMGDal.GetAll(p => p.PatientCode == patientId));
            }

            IDataResult<CSF> ICSFService.Get(int id)
            {
                return new SuccessDataResult<CSF>(_QMGDal.Get(p => p.Id == id));
            }
            IDataResult<CSF> ICSFService.GetByDate(DateTime date)
            {
                return new SuccessDataResult<CSF>(_QMGDal.Get(p => p.CSFCollectionDate == date));
            }
            IDataResult<CSF> ICSFService.GetByPatientId(string patientId)
            {
                return new SuccessDataResult<CSF>(_QMGDal.Get(p => p.PatientCode == patientId));
            }

            public IResult importRecords(string dataFile, string tableName)
            {
                this._QMGDal.importRecords(dataFile, tableName);
                return new SuccessResult();
            }
        }
    }


