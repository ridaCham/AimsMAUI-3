using MAUIUI.Core.Entities;

namespace MAUIUI.Entities.Concrete
{
    public class Relapse : IEntity
    {
        public Dictionary<string, Func<string, object>> Mapping()
        {
            return new Dictionary<string, Func<string, object>>(new Dictionary<string, Func<string, object>>
                {
                    { "PatientCode", cellValue =>cellValue},
                    { "Duration", cellValue => cellValue==null? null : int.Parse(cellValue) },
                    { "DateOfOnset", cellValue => cellValue==null? null : DateTime.Parse(cellValue) },
                    { "CosticosteroidsStartDate", cellValue => cellValue==null? null : DateTime.Parse(cellValue) },
                    { "CosticosteroidsEndDate", cellValue =>  cellValue==null? null :DateTime.Parse(cellValue) },
                    { "OtherTreatmentStartDate", cellValue => cellValue==null? null : DateTime.Parse(cellValue) },
                    { "OtherTreatmentEndDate", cellValue => cellValue==null? null : DateTime.Parse(cellValue) },


                    { "Recovery", cellValue =>cellValue },
                    { "Severity", cellValue =>cellValue },
                    { "ADLFunction", cellValue =>cellValue },
                    { "PyramidalTract", cellValue =>cellValue },
                    { "Brainstem", cellValue =>cellValue },
                    { "Cerebellum", cellValue =>cellValue },
                    { "BowelBladder", cellValue =>cellValue },
                    { "SensoryFunctions", cellValue =>cellValue },
                    { "VisualFunctions", cellValue =>cellValue },
                    { "NeuropsychoFunctions", cellValue =>cellValue },
                    { "OtherFunctionalSystemAffected", cellValue =>cellValue },
                    { "other_Treatment", cellValue =>cellValue },
                    { "Treatment", cellValue =>cellValue },
                    { "CosticosteroidsCase", cellValue =>cellValue },
                    { "Costicosteroids", cellValue =>cellValue },
                    { "OtherTreatment", cellValue =>cellValue },
                    { "OtherTreatmentRemarks", cellValue =>cellValue },
                    { "Remarks", cellValue =>cellValue },
                });
        }
        public int Id { get; set; }
        public string PatientCode { get; set; }
        public DateTime? DateOfOnset { get; set; }
        public int? Duration { get; set; }
        public string? Recovery { get; set; }
        public string? Severity { get; set; }
        public string? ADLFunction { get; set; }
        public string? PyramidalTract { get; set; }
        public string? Brainstem { get; set; }
        public string? Cerebellum { get; set; }
        public string? BowelBladder { get; set; }
        public string? SensoryFunctions { get; set; }
        public string? VisualFunctions { get; set; }
        public string? NeuropsychoFunctions { get; set; }
        public string? OtherFunctionalSystemAffected { get; set; }
        public string? other_Treatment { get; set; }
        public string? Treatment { get; set; }
        public string? CosticosteroidsCase { get; set; }
        public string? Costicosteroids { get; set; }
        public DateTime? CosticosteroidsStartDate { get; set; }
        public DateTime? CosticosteroidsEndDate { get; set; }
        public string? OtherTreatment { get; set; }
        public string? OtherTreatmentRemarks { get; set; }
        public DateTime? OtherTreatmentStartDate { get; set; }
        public DateTime? OtherTreatmentEndDate { get; set; }
        public string? Remarks { get; set; }
    }
}


















