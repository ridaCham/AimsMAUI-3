using MAUIUI.Core.Entities;
namespace MAUIUI.Entities.Concrete
{

    public class Covid19Vaccine : IEntity
{
    public int Id { get; set; }
    public string PatientCode { get; set; }
    public string? Covid { get; set; }
    public DateTime? CovidDate { get; set; }
    public string? CovidDose { get; set; }

    public Dictionary<string, Func<string, object>> Mapping()
    {
        return new Dictionary<string, Func<string, object>>(new Dictionary<string, Func<string, object>>
            {
                    { "PatientCode", cellValue => cellValue },
                    { "Covid", cellValue => cellValue },
                    { "CovidDose", cellValue => cellValue },
                    { "CovidDate", cellValue => cellValue==null? null :DateTime.Parse(cellValue) },
            });
    }
}
}

