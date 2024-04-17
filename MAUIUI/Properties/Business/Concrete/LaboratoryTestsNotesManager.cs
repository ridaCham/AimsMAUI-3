using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Concrete
{
    public class LaboratoryTestsNotesManager : ILaboratoryTestsNotesService
        {
            ILaboratoryTestsNotesDal _LaboratoryTestsNotesDal;
            public LaboratoryTestsNotesManager(ILaboratoryTestsNotesDal noteDal)
            {
                _LaboratoryTestsNotesDal = noteDal;
            }
            IResult ILaboratoryTestsNotesService.Add(LaboratoryTestsNotes note)
            {
                _LaboratoryTestsNotesDal.Add(note);
                return new SuccessResult();
            }

            IResult ILaboratoryTestsNotesService.Update(LaboratoryTestsNotes note)
            {
                _LaboratoryTestsNotesDal.Update(note);
                return new SuccessResult();
            }

            IResult ILaboratoryTestsNotesService.Delete(LaboratoryTestsNotes note)
            {
                _LaboratoryTestsNotesDal.Delete(note);
                return new SuccessResult();
            }



            IDataResult<List<LaboratoryTestsNotes>> ILaboratoryTestsNotesService.GetAllByPatientId(string patientId)
            {
                return new SuccessDataResult<List<LaboratoryTestsNotes>>(_LaboratoryTestsNotesDal.GetAll(p => p.PatientCode == patientId));
            }

            IDataResult<LaboratoryTestsNotes> ILaboratoryTestsNotesService.GetByPatientId(string patientId)
            {
                return new SuccessDataResult<LaboratoryTestsNotes>(_LaboratoryTestsNotesDal.Get(p => p.PatientCode == patientId));
            }

            public IResult importRecords(string dataFile, string tableName)
            {
                this._LaboratoryTestsNotesDal.importRecords(dataFile, tableName);
                return new SuccessResult();
            }
        }
    }


