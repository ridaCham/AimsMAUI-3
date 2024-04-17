using MAUIUI.Core.Entities;
namespace MAUIUI.Entities.Concrete
{


    public class Vaccine_ : IEntity
{
    public int Id { get; set; }
    public string PatientCode { get; set; }
    public string? Tiberculosis { get; set; }
    public DateTime? TiberculosisDate { get; set; }
    public string? HerpesZoster { get; set; }
    public DateTime? HerpesZosterDate { get; set; }
    public string? HPV { get; set; }
    public DateTime? HPVDate { get; set; }
    public string? YellowFever { get; set; }
    public DateTime? YellowFeverDate { get; set; }
    public string? Remarks { get; set; }
    public Dictionary<string, Func<string, object>> Mapping()
    {
        return new Dictionary<string, Func<string, object>>(new Dictionary<string, Func<string, object>>
                {
                    { "PatientCode", cellValue => cellValue },
                    { "Tiberculosis", cellValue => cellValue },
                    { "TiberculosisDate", cellValue =>cellValue==null? null : DateTime.Parse(cellValue) },
                    { "HPV", cellValue => cellValue },
                    { "HPVDate", cellValue => cellValue==null? null :DateTime.Parse(cellValue) },
                    { "YellowFever", cellValue => cellValue },
                    { "YellowFeverDate", cellValue =>cellValue==null? null : DateTime.Parse(cellValue) },
                    { "HerpesZoster", cellValue => cellValue },
                    { "HerpesZosterDate", cellValue =>cellValue==null? null : DateTime.Parse(cellValue) },
                    { "Remarks", cellValue => cellValue },
                });
    }

    }
}

