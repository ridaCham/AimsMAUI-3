using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Concrete
{
    public class GeneralNotesManager : IGeneralNotesService
        {
            IGeneralNotesDal _generalNotesDal;
            public GeneralNotesManager(IGeneralNotesDal noteDal)
            {
                _generalNotesDal = noteDal;
            }

            IResult IGeneralNotesService.Add(GeneralNotes note)
            {
                _generalNotesDal.Add(note);
                return new SuccessResult();
            }

            IResult IGeneralNotesService.Update(GeneralNotes note)
            {
                _generalNotesDal.Update(note);
                return new SuccessResult();
            }

            IResult IGeneralNotesService.Delete(GeneralNotes note)
            {
                _generalNotesDal.Delete(note);
                return new SuccessResult();
            }



            IDataResult<List<GeneralNotes>> IGeneralNotesService.GetAllByPatientId(string patientId)
            {
                return new SuccessDataResult<List<GeneralNotes>>(_generalNotesDal.GetAll(p => p.PatientCode == patientId));
            }

            IDataResult<GeneralNotes> IGeneralNotesService.GetByPatientId(string patientId)
            {
                return new SuccessDataResult<GeneralNotes>(_generalNotesDal.Get(p => p.PatientCode == patientId));
            }

            public IResult importRecords(string dataFile, string tableName)
            {
                this._generalNotesDal.importRecords(dataFile, tableName);
                return new SuccessResult();
            }
        }
    }


