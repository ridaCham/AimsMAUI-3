using MAUIUI.Core.Entities;
namespace MAUIUI.Entities.Concrete
{


    public class Pregnancy : IEntity
{
    public Dictionary<string, Func<string, object>> Mapping()
    {

        return new Dictionary<string, Func<string, object>>(new Dictionary<string, Func<string, object>>
                {
                    { "PatientCode", cellValue => cellValue },
                    { "PregnancyStartDate", cellValue => cellValue==null? null : DateTime.Parse(cellValue) },
                    { "EstimetedDeliveryDate", cellValue => cellValue==null? null : DateTime.Parse(cellValue) },
                    { "ARTMethod", cellValue => cellValue },
                    { "MeternalEthnicity", cellValue => cellValue },
                    { "Remarks", cellValue => cellValue },
                });
    }
    public int Id { get; set; }
    public string PatientCode { get; set; }
    public DateTime? PregnancyStartDate { get; set; }
    public DateTime? EstimetedDeliveryDate { get; set; }
    public string? ARTMethod { get; set; }
    public string? MeternalEthnicity { get; set; }
    public string? Remarks { get; set; }

    }
}








