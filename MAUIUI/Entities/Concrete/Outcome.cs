using MAUIUI.Core.Entities;
namespace MAUIUI.Entities.Concrete
{
    public class Outcome : IEntity
{
    public int Id { get; set; }
    public string PatientCode { get; set; }
    public Dictionary<string, Func<string, object>> Mapping()
    {
        return new Dictionary<string, Func<string, object>>(new Dictionary<string, Func<string, object>>
                {
                    { "PatientCode", cellValue => cellValue},
                    { "PregnancyEndDate", cellValue => cellValue==null? null :DateTime.Parse(cellValue) },
                    { "BreastfeedingStartDate", cellValue =>cellValue==null? null : DateTime.Parse(cellValue) },
                    { "ExclusiveBreastfeedingEndDate", cellValue => cellValue==null? null :DateTime.Parse(cellValue) },
                    { "AllBreastfeedingEndDate", cellValue => cellValue==null? null :DateTime.Parse(cellValue) },
                    { "NeonatalMGStartDate", cellValue => cellValue==null? null :DateTime.Parse(cellValue) },
                    { "NeonatalMGEndDate", cellValue => cellValue==null? null :DateTime.Parse(cellValue) },
                    { "Wegiht", cellValue => cellValue },
                    { "Sex", cellValue => cellValue },
                    { "Breastfeeding", cellValue => cellValue },
                    { "ObstetricComplication", cellValue => cellValue },
                    { "outcome", cellValue => cellValue },
                    { "CogenitalAbnormality", cellValue => cellValue },
                    { "ReasonOfTermination", cellValue => cellValue },
                    { "DeliveryMethod", cellValue => cellValue },
                    { "PregnancyStartDate", cellValue =>cellValue==null? null :  DateTime.Parse(cellValue) },
                });
    }
    public DateTime? PregnancyEndDate { get; set; }
    public string? Wegiht { get; set; }
    public string? Sex { get; set; }
    public string? Breastfeeding { get; set; }
    public DateTime? BreastfeedingStartDate { get; set; }
    public DateTime? ExclusiveBreastfeedingEndDate { get; set; }
    public DateTime? AllBreastfeedingEndDate { get; set; }
    public string? ObstetricComplication { get; set; }
    public string? outcome { get; set; }
    public string? CogenitalAbnormality { get; set; }
    public string? ReasonOfTermination { get; set; }
    public string? DeliveryMethod { get; set; }
    public DateTime? NeonatalMGStartDate { get; set; }
    public DateTime? NeonatalMGEndDate { get; set; }
    public DateTime? PregnancyStartDate { get; set; }
}
}
