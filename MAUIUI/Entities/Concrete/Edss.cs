using MAUIUI.Core.Entities;
namespace MAUIUI.Entities.Concrete
{

    public class Edss : IEntity
{
    public Dictionary<string, Func<string, object>> Mapping()
    {
        return new Dictionary<string, Func<string, object>>(new Dictionary<string, Func<string, object>>
                {
                    { "PatientCode", cellValue => cellValue},
                    { "Date", cellValue => cellValue==null? null : DateTime.Parse(cellValue) },
                    { "Cerebellar", cellValue => cellValue==null? null : int.Parse(cellValue) },
                    { "Pyramidal", cellValue => cellValue==null? null : int.Parse(cellValue) },
                    { "Brainstem", cellValue => cellValue==null? null : int.Parse(cellValue) },
                    { "Sensory", cellValue => cellValue==null? null : int.Parse(cellValue) },
                    { "Bowel", cellValue => cellValue==null? null : int.Parse(cellValue) },
                    { "Visual", cellValue => cellValue==null? null : int.Parse(cellValue) },
                    { "Mental", cellValue => cellValue==null? null : int.Parse(cellValue) },
                    { "Ambilation", cellValue => cellValue==null? null : int.Parse(cellValue) },
                    { "Total", cellValue => cellValue==null? null : float.Parse(cellValue) },
                    { "Remarks", cellValue => cellValue },
                });
    }
    public DateTime? Date { get; set; }
    public int? Id { get; set; }
    public string PatientCode { get; set; }
    public int? Cerebellar { get; set; }
    public int? Pyramidal { get; set; }
    public int? Brainstem { get; set; }
    public int? Sensory { get; set; }
    public int? Bowel { get; set; }
    public int? Visual { get; set; }
    public int? Mental { get; set; }
    public int? Ambilation { get; set; }
    public float? Total { get; set; }
    public string? Remarks { get; set; }
}

}