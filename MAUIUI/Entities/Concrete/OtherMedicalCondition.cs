using MAUIUI.Core.Entities;
namespace MAUIUI.Entities.Concrete
{
    public class OtherMedicalCondition : IEntity
{
    public Dictionary<string, Func<string, object>> Mapping()
    {
        return new Dictionary<string, Func<string, object>>(new Dictionary<string, Func<string, object>>
                {
                    { "PatientCode", cellValue => cellValue},
                    { "DateOfOnset", cellValue =>cellValue==null? null : DateTime.Parse(cellValue) },
                    { "IsSeriousAdverseEvent", cellValue => cellValue },
                    { "MedicalCondition", cellValue => cellValue },
                    { "Severity", cellValue => cellValue },
                    { "SeriousAdverseEvent", cellValue => cellValue },
                    { "DrugRelationship", cellValue => cellValue },
                    { "Tretmenet", cellValue => cellValue },
                    { "Outcome", cellValue => cellValue },
                    { "OutcomeDate", cellValue =>cellValue==null? null : DateTime.Parse(cellValue) },
                    { "Remarks", cellValue => cellValue },
                });
    }
    public int Id { get; set; }
    public string PatientCode { get; set; }
    public string? IsSeriousAdverseEvent { get; set; }
    public DateTime? DateOfOnset { get; set; }
    public string? MedicalCondition { get; set; }
    public string? Severity { get; set; }
    public string? SeriousAdverseEvent { get; set; }
    public string? DrugRelationship { get; set; }
    public string? Tretmenet { get; set; }
    public string? Outcome { get; set; }
    public DateTime? OutcomeDate { get; set; }
    public string? Remarks { get; set; }

    }
}

