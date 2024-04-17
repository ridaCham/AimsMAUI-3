using MAUIUI.Core.Entities;
namespace MAUIUI.Entities.Concrete
{


    public class TreatmentPsychotherapy : IEntity
{
    public int? Id { get; set; }
    public string PatientCode { get; set; }
    public int? TreatmentId { get; set; }
    public string? Psychotherapy { get; set; }
    public DateTime? PsychotherapyEndDate { get; set; }
    public DateTime? PsychotherapyStartDate { get; set; }
    public Dictionary<string, Func<string, object>> Mapping()
    {
        return new Dictionary<string, Func<string, object>>(new Dictionary<string, Func<string, object>>
                {
                    { "PatientCode", cellValue => cellValue},
                    { "TreatmentId", cellValue => cellValue==null? null : int.Parse(cellValue) },
                    { "Psychotherapy", cellValue => cellValue },
                    { "PsychotherapyEndDate", cellValue => cellValue==null? null : DateTime.Parse(cellValue) },
                    { "PsychotherapyStartDate", cellValue => cellValue==null? null : DateTime.Parse(cellValue) },
                });
    }
}

}