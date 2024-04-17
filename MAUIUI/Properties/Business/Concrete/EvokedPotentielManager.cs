using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Concrete
{
    public class EvokedPotentielManager : IEvokedPotentielService
        {
            IEvokedPotentielDal _QMGDal;
            public EvokedPotentielManager(IEvokedPotentielDal QMG_Dal)
            {
                _QMGDal = QMG_Dal;
            }
            IResult IEvokedPotentielService.Add(EvokedPotentiel FatigueTest)
            {
                _QMGDal.Add(FatigueTest);
                return new SuccessResult();
            }

            IResult IEvokedPotentielService.Update(EvokedPotentiel FatigueTest)
            {
                _QMGDal.Update(FatigueTest);
                return new SuccessResult();
            }

            IResult IEvokedPotentielService.Delete(EvokedPotentiel FatigueTest)
            {
                _QMGDal.Delete(FatigueTest);
                return new SuccessResult();
            }

            IDataResult<List<EvokedPotentiel>> IEvokedPotentielService.GetAll()
            {
                return new SuccessDataResult<List<EvokedPotentiel>>(_QMGDal.GetAll());
            }

            IDataResult<List<EvokedPotentiel>> IEvokedPotentielService.GetAllByPatientId(string patientId)
            {
                return new SuccessDataResult<List<EvokedPotentiel>>(_QMGDal.GetAll(p => p.PatientCode == patientId));
            }

            IDataResult<EvokedPotentiel> IEvokedPotentielService.Get(int id)
            {
                return new SuccessDataResult<EvokedPotentiel>(_QMGDal.Get(p => p.Id == id));
            }

            IDataResult<EvokedPotentiel> IEvokedPotentielService.GetByDate(DateTime date)
            {
                return new SuccessDataResult<EvokedPotentiel>(_QMGDal.Get(p => p.ExameDate == date));
            }
            IDataResult<EvokedPotentiel> IEvokedPotentielService.GetByPatientId(string patientId)
            {
                return new SuccessDataResult<EvokedPotentiel>(_QMGDal.Get(p => p.PatientCode == patientId));
            }

            public IResult importRecords(string dataFile, string tableName)
            {
                this._QMGDal.importRecords(dataFile, tableName);
                return new SuccessResult();
            }
        }
    }


