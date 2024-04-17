using MAUIUI.Core.Entities;
namespace MAUIUI.Entities.Concrete
{


    public class TreatmentSymptomatic : IEntity
{
    public int? Id { get; set; }
    public string PatientCode { get; set; }
    public int? TreatmentId { get; set; }
    public string? SymptomaticTreatment { get; set; }
    public string? SymptomaticPosology { get; set; }
    public string? SymptomaticOtherPosology { get; set; }
    public DateTime? SymptomaticStartingOn { get; set; }
    public DateTime? SymptomaticEndingOn { get; set; }
    public string? SReasonForDiscontinuation { get; set; } = " ";

    public Dictionary<string, Func<string, object>> Mapping()
    {
        return new Dictionary<string, Func<string, object>>(new Dictionary<string, Func<string, object>>
                {
                    { "PatientCode", cellValue =>cellValue},
                    { "TreatmentId", cellValue => cellValue==null? null : int.Parse(cellValue) },
                    { "SymptomaticEndingOn", cellValue => cellValue==null? null : DateTime.Parse(cellValue) },
                    { "SymptomaticStartingOn", cellValue => cellValue==null? null : DateTime.Parse(cellValue) },
                    { "SymptomaticTreatment", cellValue => cellValue },
                    { "SymptomaticPosology", cellValue => cellValue },
                    { "SymptomaticOtherPosology", cellValue => cellValue },
                    { "SReasonForDiscontinuation", cellValue => cellValue },
                });
    }
}

}