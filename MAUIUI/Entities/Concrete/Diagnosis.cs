using MAUIUI.Core.Entities;
namespace MAUIUI.Entities.Concrete
{

    public class Diagnosis : IEntity
{
    public int Id { get; set; }
    public Dictionary<string, Func<string, object>> Mapping()
    {
        return new Dictionary<string, Func<string, object>>(new Dictionary<string, Func<string, object>>
                {
                    { "PatientCode", cellValue => cellValue },
                    { "DateOfOnset", cellValue => cellValue },
                    { "Supratentorial", cellValue => cellValue },
                    { "BrainstemCerebellum", cellValue => cellValue },
                    { "SpinalCord", cellValue => cellValue },
                    { "OpticPathways", cellValue => cellValue },
                    { "ProgressionFromOnset", cellValue => cellValue },
                    { "OtherSymptoms", cellValue => cellValue },
                    { "ConfirmedDiagnosisDate", cellValue => cellValue },
                    { "DiagnosisConfirmedByClinicalFindings", cellValue => cellValue },
                    { "DiagnosisConfirmedByMri", cellValue => cellValue },
                    { "DiagnosisConfirmedByCsf", cellValue => cellValue },
                    { "DiagnosisConfirmedByEvokedPotentials", cellValue => cellValue },
                    { "DiagnosisConfirmedByOther", cellValue => cellValue },
                    { "DiagnosisMcDonaldClassification", cellValue => cellValue },
                    { "DiagnosisPoserClassification", cellValue => cellValue },
                    { "DiagnosisNmoClassification", cellValue => cellValue },
                    { "StartodProgression", cellValue => cellValue },
                    { "RisOnsetDate", cellValue => cellValue },
                    { "DiagnosisRemarks", cellValue => cellValue },
                });
    }
    public string PatientCode { get; set; }
    public string? DateOfOnset { get; set; }
    public string? Supratentorial { get; set; }
    public string? BrainstemCerebellum { get; set; }
    public string? SpinalCord { get; set; }
    public string? OpticPathways { get; set; }
    public string? ProgressionFromOnset { get; set; }
    public string? OtherSymptoms { get; set; }
    public string? ConfirmedDiagnosisDate { get; set; }
    public string? DiagnosisConfirmedByClinicalFindings { get; set; }
    public string? DiagnosisConfirmedByMri { get; set; }
    public string? DiagnosisConfirmedByCsf { get; set; }
    public string? DiagnosisConfirmedByEvokedPotentials { get; set; }
    public string? DiagnosisConfirmedByOther { get; set; }
    public string? DiagnosisMcDonaldClassification { get; set; }
    public string? DiagnosisPoserClassification { get; set; }
    public string? DiagnosisNmoClassification { get; set; }
    public string? StartodProgression { get; set; }
    public string? RisOnsetDate { get; set; }
    public string? DiagnosisRemarks { get; set; }

}

}