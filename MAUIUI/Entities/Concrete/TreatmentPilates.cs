using MAUIUI.Core.Entities;
namespace MAUIUI.Entities.Concrete
{


    public class TreatmentPilates : IEntity
{
    public int? Id { get; set; }
    public string PatientCode { get; set; }
    public int? TreatmentId { get; set; }
    public string? Pilates { get; set; }
    public DateTime? PilatesEndDate { get; set; }
    public Dictionary<string, Func<string, object>> Mapping()
    {
        return new Dictionary<string, Func<string, object>>(new Dictionary<string, Func<string, object>>
                {
                    { "PatientCode", cellValue => cellValue},
                    { "TreatmentId", cellValue => cellValue==null? null : int.Parse(cellValue) },
                    { "Pilates", cellValue => cellValue },
                    { "PilatesEndDate", cellValue => cellValue==null? null : DateTime.Parse(cellValue) },
                    { "PilatesStartDate", cellValue => cellValue==null? null : DateTime.Parse(cellValue) },
                });
    }
    public DateTime? PilatesStartDate { get; set; }
}

}