using MAUIUI.Core.Entities;
namespace MAUIUI.Entities.Concrete
{

    public class LaboratoryTestsNotes : IEntity
{
    public int Id { get; set; }
    public string PatientCode { get; set; }
    public string? Notes { get; set; }
    public Dictionary<string, Func<string, object>> Mapping()
    {
        return new Dictionary<string, Func<string, object>>(new Dictionary<string, Func<string, object>>
                {
                    { "PatientCode", cellValue => cellValue},
                    { "Notes", cellValue =>  cellValue },
                });
    }
}


}