using MAUIUI.Core.Entities;
namespace MAUIUI.Entities.Concrete
{

    public class Malignancy : IEntity
{
    public int Id { get; set; }
    public string PatientCode { get; set; }
    public DateTime? DateOfDiagnosis { get; set; }
    public string? StateOfDiagnosis { get; set; }
    public string? SiteOfPrimaryCancer { get; set; }
    public string? HistologicalDiagnosis { get; set; }
    public string? NoTretmenet { get; set; }
    public string? Surgery { get; set; }
    public string? Chemotherapy { get; set; }
    public string? Radiotherapy { get; set; }
    public string? TretmenetOther { get; set; }

    public string? Outcome { get; set; }
    public DateTime? OutcomeDate { get; set; }
    public string? Remarks { get; set; }

    public Dictionary<string, Func<string, object>> Mapping()
    {
        return new Dictionary<string, Func<string, object>>(new Dictionary<string, Func<string, object>>
                {
                    { "PatientCode", cellValue => cellValue},
                    { "DateOfDiagnosis", cellValue => cellValue==null? null : DateTime.Parse(cellValue) },
                    { "OutcomeDate", cellValue => cellValue==null? null : DateTime.Parse(cellValue) },
                    { "StateOfDiagnosis", cellValue => cellValue },
                    { "SiteOfPrimaryCancer", cellValue => cellValue },
                    { "HistologicalDiagnosis", cellValue => cellValue },
                    { "NoTretmenet", cellValue => cellValue },
                    { "Surgery", cellValue => cellValue },
                    { "Chemotherapy", cellValue => cellValue },
                    { "Radiotherapy", cellValue => cellValue },
                    { "TretmenetOther", cellValue => cellValue },
                    { "Outcome", cellValue => cellValue },
                    { "Remarks", cellValue => cellValue },
                });
    }
}

}
