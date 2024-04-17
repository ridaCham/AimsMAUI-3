using MAUIUI.Core.Entities;
namespace MAUIUI.Entities.Concrete
{

    public class Covid19 : IEntity

{
    public int Id { get; set; }
    public Dictionary<string, Func<string, object>> Mapping()
    {
        return new Dictionary<string, Func<string, object>>(new Dictionary<string, Func<string, object>>
                {
                    { "PatientCode", cellValue => cellValue },
                    { "DateOfOnset", cellValue =>cellValue==null? null : DateTime.Parse(cellValue) },
                    { "ConfirmedDiagnosisDate", cellValue => cellValue==null? null :DateTime.Parse(cellValue) },
                    { "HospitalAdmitionStart", cellValue => cellValue==null? null :DateTime.Parse(cellValue) },
                    { "HospitalAdmitionEnd", cellValue => cellValue==null? null :DateTime.Parse(cellValue) },
                    { "ICUAdmitionStart", cellValue => cellValue==null? null :DateTime.Parse(cellValue) },
                    { "ICUAdmitionEnd", cellValue => cellValue==null? null :DateTime.Parse(cellValue) },
                    { "LymphocyteExamDate", cellValue => cellValue==null? null :DateTime.Parse(cellValue) },
                    { "WhiteCellExamDate", cellValue => cellValue==null? null :DateTime.Parse(cellValue) },
                    { "CD19BExamDate", cellValue => cellValue==null? null :DateTime.Parse(cellValue) },
                    { "OutcomeDate", cellValue => cellValue==null? null :DateTime.Parse(cellValue) },
                    { "LymphocyteCount", cellValue => cellValue==null? null :int.Parse(cellValue) },
                    { "ConfirmedByPCR", cellValue => cellValue },
                    { "ConfirmedBySerology", cellValue => cellValue },
                    { "ConfirmedByTypicalChestImaging", cellValue => cellValue },
                    { "VentilationBox", cellValue => cellValue },
                    { "Severity", cellValue => cellValue },
                    { "SeverityUnkonwn", cellValue => cellValue },
                    { "SeverityMild", cellValue => cellValue },
                    { "SeverityModarate", cellValue => cellValue },
                    { "SeveritySevere", cellValue => cellValue },
                    { "Symptomatic", cellValue => cellValue },
                    { "SymptomaticPain", cellValue => cellValue },
                    { "SymptomaticFever", cellValue => cellValue },
                    { "SymptomaticFatigue", cellValue => cellValue },
                    { "SymptomaticDryCough", cellValue => cellValue },
                    { "SymptomaticAnosmia", cellValue => cellValue },
                    { "SymptomaticSoreThroat", cellValue => cellValue },
                    { "SymptomaticDiarrhea", cellValue => cellValue },
                    { "SymptomaticPneumonia", cellValue => cellValue },
                    { "SymptomaticOther", cellValue => cellValue },
                    { "DMTCeased", cellValue => cellValue },
                    { "DMTCeasedDetail", cellValue => cellValue },
                    { "Pregnancy", cellValue => cellValue },
                    { "CurrentSmoker", cellValue => cellValue },
                    { "Obesity", cellValue => cellValue },
                    { "OtherComorbidities", cellValue => cellValue },
                    { "CVSHypertension", cellValue => cellValue },
                    { "Diabetes", cellValue => cellValue },
                    { "Malignancy", cellValue => cellValue },
                    { "chronicLungDisease", cellValue => cellValue },
                    { "RenalDisease", cellValue => cellValue },
                    { "LiverDisease", cellValue => cellValue },
                    { "HospitalAdmition", cellValue => cellValue },
                    { "ICUAdmition", cellValue => cellValue },
                    { "Ventilation", cellValue => cellValue },
                    { "ECMO", cellValue => cellValue },
                    { "LaboratoireAdmition", cellValue => cellValue },
                    { "WhiteCellCount", cellValue => cellValue },
                    { "CD19BCount", cellValue => cellValue },
                    { "Outcome", cellValue => cellValue },
                    { "Remarks", cellValue => cellValue },
                });
    }
    public string PatientCode { get; set; }
    public DateTime? DateOfOnset { get; set; }
    public DateTime? ConfirmedDiagnosisDate { get; set; }
    public string? ConfirmedByPCR { get; set; }
    public string? ConfirmedBySerology { get; set; }
    public string? ConfirmedByTypicalChestImaging { get; set; }

    public string? VentilationBox { get; set; }
    public string? Severity { get; set; }
    public string? SeverityUnkonwn { get; set; }
    public string? SeverityMild { get; set; }
    public string? SeverityModarate { get; set; }
    public string? SeveritySevere { get; set; }
    public string? Symptomatic { get; set; }
    public string? SymptomaticPain { get; set; }
    public string? SymptomaticFever { get; set; }
    public string? SymptomaticFatigue { get; set; }
    public string? SymptomaticDryCough { get; set; }
    public string? SymptomaticAnosmia { get; set; }
    public string? SymptomaticSoreThroat { get; set; }
    public string? SymptomaticDiarrhea { get; set; }
    public string? SymptomaticPneumonia { get; set; }
    public string? SymptomaticOther { get; set; }

    public string? DMTCeased { get; set; }
    public string? DMTCeasedDetail { get; set; }

    public string? Pregnancy { get; set; }
    public string? CurrentSmoker { get; set; }
    public string? Obesity { get; set; }
    public string? OtherComorbidities { get; set; }
    public string? CVSHypertension { get; set; }
    public string? Diabetes { get; set; }
    public string? Malignancy { get; set; }
    public string? chronicLungDisease { get; set; }
    public string? RenalDisease { get; set; }
    public string? LiverDisease { get; set; }

    public string? HospitalAdmition { get; set; }
    public DateTime? HospitalAdmitionStart { get; set; }
    public DateTime? HospitalAdmitionEnd { get; set; }
    public string? ICUAdmition { get; set; }
    public DateTime? ICUAdmitionStart { get; set; }
    public DateTime? ICUAdmitionEnd { get; set; }
    public string? Ventilation { get; set; }
    public string? ECMO { get; set; }
    public string? LaboratoireAdmition { get; set; }
    public int? LymphocyteCount { get; set; }
    public DateTime? LymphocyteExamDate { get; set; }
    public string? WhiteCellCount { get; set; }
    public DateTime? WhiteCellExamDate { get; set; }
    public string? CD19BCount { get; set; }
    public DateTime? CD19BExamDate { get; set; }
    public string? Outcome { get; set; }
    public DateTime? OutcomeDate { get; set; }
    public string? Remarks { get; set; }


}

}