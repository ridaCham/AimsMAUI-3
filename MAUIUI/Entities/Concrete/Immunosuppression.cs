using MAUIUI.Core.Entities;
namespace MAUIUI.Entities.Concrete
{

    public class Immunosuppression : IEntity
{
    public Dictionary<string, Func<string, object>> Mapping()
    {
        return new Dictionary<string, Func<string, object>>(new Dictionary<string, Func<string, object>>
                {
                    { "PatientCode", cellValue =>cellValue },
                    { "dateOfDiagnosis", cellValue => cellValue==null? null : DateTime.Parse(cellValue) },
                    { "ImmunosuppressionAssociate", cellValue =>  cellValue },
                    { "TreatmentModality", cellValue =>  cellValue },
                    { "outcome", cellValue =>  cellValue },
                    { "outcomeDate", cellValue => cellValue==null? null : DateTime.Parse(cellValue)  },
                    { "Remarks", cellValue =>  cellValue },
                });
    }
    public int Id { get; set; }
    public string PatientCode { get; set; }
    public DateTime? dateOfDiagnosis { get; set; }
    public string? ImmunosuppressionAssociate { get; set; }
    public string? TreatmentModality { get; set; }
    public string? outcome { get; set; }
    public DateTime? outcomeDate { get; set; }
    public string? Remarks { get; set; }

}


}