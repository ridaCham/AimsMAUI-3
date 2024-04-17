using MAUIUI.Core.Entities;

namespace MAUIUI.Entities.Concrete
{

    public class FluVaccine : IEntity
{
    public int Id { get; set; }
    public string PatientCode { get; set; }
    public DateTime? FluDate { get; set; }

    public Dictionary<string, Func<string, object>> Mapping()
    {
        return new Dictionary<string, Func<string, object>>(new Dictionary<string, Func<string, object>>
            {
                    { "PatientCode", cellValue => cellValue },
                    { "FluDate", cellValue =>cellValue==null? null : DateTime.Parse(cellValue) },
            });
    }
}

}