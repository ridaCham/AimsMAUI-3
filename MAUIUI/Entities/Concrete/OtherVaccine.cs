using MAUIUI.Core.Entities;
namespace MAUIUI.Entities.Concrete
{
    public class OtherVaccine : IEntity
{
    public int Id { get; set; }
    public string PatientCode { get; set; }
    public string? Vaccine { get; set; }
    public DateTime? VaccineDate { get; set; }

    public Dictionary<string, Func<string, object>> Mapping()
    {
        return new Dictionary<string, Func<string, object>>(new Dictionary<string, Func<string, object>>
            {
                    { "PatientCode", cellValue => cellValue },
                    { "Vaccine", cellValue => cellValue },
                    { "VaccineDate", cellValue =>cellValue==null? null : DateTime.Parse(cellValue) },
            });
    }
}
}
