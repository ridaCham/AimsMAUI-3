using MAUIUI.Core.Entities;
namespace MAUIUI.Entities.Concrete
{

    public class HepatitisAVaccine : IEntity
{
    public int Id { get; set; }
    public string PatientCode { get; set; }
    public DateTime? HepatitisADate { get; set; }

    public Dictionary<string, Func<string, object>> Mapping()
    {
        return new Dictionary<string, Func<string, object>>(new Dictionary<string, Func<string, object>>
            {
                    { "PatientCode", cellValue => cellValue },
                    { "HepatitisADate", cellValue => cellValue==null? null :DateTime.Parse(cellValue) },
            });
    }
}


}