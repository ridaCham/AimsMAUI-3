using MAUIUI.Core.Entities;
namespace MAUIUI.Entities.Concrete
{


    public class TreatmentYoga : IEntity
{
    public int? Id { get; set; }
    public string PatientCode { get; set; }
    public int? TreatmentId { get; set; }
    public string? Yoga { get; set; }
    public DateTime? YogaEndDate { get; set; }
    public DateTime? YogaStartDate { get; set; }
    public Dictionary<string, Func<string, object>> Mapping()
    {
        return new Dictionary<string, Func<string, object>>(new Dictionary<string, Func<string, object>>
                {
                    { "TreatmentId", cellValue =>  cellValue==null? null :int.Parse(cellValue) },
                    { "PatientCode", cellValue => cellValue },
                    { "Yoga", cellValue => cellValue },
                    { "YogaEndDate", cellValue =>   cellValue==null? null :DateTime.Parse(cellValue) },
                    { "YogaStartDate", cellValue =>  cellValue==null? null :DateTime.Parse(cellValue) }
                });
    }
}

}