using MAUIUI.Core.Entities;
namespace MAUIUI.Entities.Concrete
{

    public class AddNewFamilyHistory : IEntity
{
    public int Id { get; set; }
    public string PatientCode { get; set; }
    public string? Relationship { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public DateTime? BirthDate { get; set; }
    public string? Disease { get; set; }
    public string? MG { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? Remarks { get; set; }
    public string? OtherRelationship { get; set; }

    public Dictionary<string, Func<string, object>> Mapping()
    {
        return new Dictionary<string, Func<string, object>>(new Dictionary<string, Func<string, object>>
                {
                    { "PatientCode", cellValue => cellValue },
                    { "Relationship", cellValue => cellValue },
                    { "Name", cellValue =>cellValue},
                    { "Surname", cellValue =>cellValue },
                    { "BirthDate", cellValue => cellValue==null? null : DateTime.Parse(cellValue) },
                    { "Disease", cellValue =>cellValue },
                    { "MG", cellValue =>cellValue },
                    { "StartDate", cellValue => cellValue==null? null : DateTime.Parse(cellValue) },
                    { "EndDate", cellValue =>  cellValue==null? null :DateTime.Parse(cellValue) },
                    { "OtherRelationship", cellValue =>cellValue },
                    { "Remarks", cellValue =>cellValue },
                });
    }
    }
}

