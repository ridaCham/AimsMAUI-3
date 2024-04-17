using MAUIUI.Core.Entities;
namespace MAUIUI.Entities.Concrete
{

    public class HerpesZoster : IEntity
{
    public Dictionary<string, Func<string, object>> Mapping()
    {

        return new Dictionary<string, Func<string, object>>(new Dictionary<string, Func<string, object>>
                {
                    { "PatientCode", cellValue => cellValue},
                    { "DateOfDiagnosis", cellValue => cellValue==null? null :DateTime.Parse(cellValue) },
                    { "OutcomeDate", cellValue => cellValue==null? null :DateTime.Parse(cellValue) },
                    { "TreatmentModality", cellValue => cellValue },
                    { "Outcome", cellValue => cellValue },
                    { "Remarks", cellValue => cellValue },
                });
    }
    public int Id { get; set; }
    public string PatientCode { get; set; }
    public DateTime? DateOfDiagnosis { get; set; }
    public string? TreatmentModality { get; set; }
    public string? Outcome { get; set; }
    public DateTime? OutcomeDate { get; set; }
    public string? Remarks { get; set; }
}


}