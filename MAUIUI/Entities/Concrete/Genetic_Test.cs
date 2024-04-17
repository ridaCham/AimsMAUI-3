using MAUIUI.Core.Entities;
namespace MAUIUI.Entities.Concrete
{

    public class Genetic_Test : IEntity
{
    public int Id { get; set; }
    public Dictionary<string, Func<string, object>> Mapping()
    {
        return new Dictionary<string, Func<string, object>>(new Dictionary<string, Func<string, object>>
                {
                    { "PatientCode", cellValue => cellValue },
                    { "GeneticTest", cellValue => cellValue },
                    { "GeneticTestComment", cellValue => cellValue },
                });
    }
    public string PatientCode { get; set; }
    public string? GeneticTest { get; set; }
    public string? GeneticTestComment { get; set; }
}

}
