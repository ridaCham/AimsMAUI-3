using MAUIUI.Core.Entities;
namespace MAUIUI.Entities.Concrete
{

    public class CSF : IEntity
{
    public int? Id { get; set; }
    public Dictionary<string, Func<string, object>> Mapping()
    {
        return new Dictionary<string, Func<string, object>>(new Dictionary<string, Func<string, object>>
                {
                    { "PatientCode", cellValue => cellValue },
                    { "CSFCollectionDate", cellValue => cellValue==null? null : DateTime.Parse(cellValue) },
                    { "CSFKept", cellValue => cellValue },
                    { "CSFNormal", cellValue => cellValue },
                    { "CSFAbnormal", cellValue => cellValue },
                    { "CSFTraumatic", cellValue => cellValue },
                    { "AbnormalCSFTraumatic", cellValue => cellValue },
                    { "WhiteCellCount", cellValue => cellValue },
                    { "Lymphocyte", cellValue => cellValue },
                    { "Granulocyte", cellValue => cellValue },
                    { "PlasmaCell", cellValue => cellValue },
                    { "Erythrocytes", cellValue => cellValue },
                    { "TotalProtein", cellValue => cellValue },
                    { "Glucose", cellValue => cellValue },
                    { "Albumin", cellValue => cellValue },
                    { "QAlbumin", cellValue => cellValue },
                    { "IgG", cellValue => cellValue },
                    { "IgGIndex", cellValue => cellValue },
                    { "Other", cellValue => cellValue },
                    { "JCVirusInCSF", cellValue => cellValue },
                    { "Result", cellValue => cellValue },
                    { "Remarks", cellValue => cellValue },
                    { "OligoclonalNotDone", cellValue => cellValue },
                    { "OCBAbcentInCSF", cellValue => cellValue },
                    { "OCBDetectedInCSF", cellValue => cellValue },
                    { "NumberOfOligoclonal", cellValue => cellValue },
                    { "MatchedOCBDetected", cellValue => cellValue },
                    { "NoMatchedOCBDetected", cellValue => cellValue },
                    { "SerumSimpleNotDone", cellValue => cellValue }
                });
    }
    public string PatientCode { get; set; }

    public string? CSFKept { get; set; }
    public string? CSFNormal { get; set; }
    public string? CSFAbnormal { get; set; }
    public string? CSFTraumatic { get; set; }
    public string? AbnormalCSFTraumatic { get; set; }
    public string? WhiteCellCount { get; set; }
    public string? Lymphocyte { get; set; }
    public string? Granulocyte { get; set; }
    public string? PlasmaCell { get; set; }
    public string? Erythrocytes { get; set; }
    public DateTime? CSFCollectionDate { get; set; }
    public string? TotalProtein { get; set; }
    public string? Glucose { get; set; }
    public string? Albumin { get; set; }
    public string? QAlbumin { get; set; }
    public string? IgG { get; set; }
    public string? IgGIndex { get; set; }
    public string? Other { get; set; }
    public string? JCVirusInCSF { get; set; }
    public string? Result { get; set; }
    public string? Remarks { get; set; }
    public string? OligoclonalNotDone { get; set; }
    public string? OCBAbcentInCSF { get; set; }
    public string? OCBDetectedInCSF { get; set; }
    public string? NumberOfOligoclonal { get; set; }
    public string? MatchedOCBDetected { get; set; }
    public string? NoMatchedOCBDetected { get; set; }
    public string? SerumSimpleNotDone { get; set; }

}

}