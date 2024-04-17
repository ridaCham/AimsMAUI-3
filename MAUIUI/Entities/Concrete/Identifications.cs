using MAUIUI.Core.Entities;
namespace MAUIUI.Entities.Concrete
{

    public class Identifications : IEntity
{
    public Dictionary<string, Func<string, object>> Mapping()
    {

        return new Dictionary<string, Func<string, object>>(new Dictionary<string, Func<string, object>>
                {
                    { "Deleted", cellValue => cellValue !=null? int.Parse(cellValue): int.Parse("00") },
                    { "Weight",  cellValue => cellValue !=null? int.Parse(cellValue): int.Parse("00") },
                    { "Height", cellValue => cellValue !=null? int.Parse(cellValue): int.Parse("00") },
                    { "BirthDate", cellValue => cellValue == null ? null : DateTime.Parse(cellValue) },
                    { "PatientCode", cellValue =>  cellValue },
                    { "Name", cellValue =>  cellValue },
                    { "SurName", cellValue =>  cellValue },
                    { "Gender", cellValue =>  cellValue },
                    { "BirthCountry", cellValue =>  cellValue },
                    { "BirthCity", cellValue =>  cellValue },
                    { "HealthInsurance", cellValue =>  cellValue },
                    { "InsuranceReference", cellValue =>  cellValue },
                    { "EmployeeStatus", cellValue =>  cellValue },
                    { "Adress", cellValue =>  cellValue },
                    { "State", cellValue =>  cellValue },
                    { "city", cellValue =>  cellValue },
                    { "Country", cellValue =>  cellValue },
                    { "Phone", cellValue =>  cellValue },
                    { "IdentificationNo", cellValue =>  cellValue },
                    { "PatientNum", cellValue =>  cellValue },
                    { "FileNum", cellValue =>  cellValue },
                    { "Email", cellValue =>  cellValue },
                    { "Education", cellValue =>  cellValue },
                    { "Deceased", cellValue =>  cellValue },
                    { "CauseOfDeath", cellValue =>  cellValue },
                    { "DateOfDeath", cellValue => cellValue == null ? null : DateTime.Parse(cellValue) },
                    { "ImagePath", cellValue =>  cellValue },
                    { "MSClassification", cellValue =>  cellValue },
                });

    }
    public int Id { get; set; }
    public string Name { get; set; }
    public string SurName { get; set; }
    public DateTime BirthDate { get; set; }
    public string? ImagePath { get; set; }
    public string? MSClassification { get; set; }
    public string? PatientCode { get; set; }
    public string Gender { get; set; }
    public string? BirthCountry { get; set; }
    public string? BirthCity { get; set; } = "";
    public string? HealthInsurance { get; set; }
    public string? InsuranceReference { get; set; }
    public int? Height { get; set; }
    public int? Weight { get; set; }
    public string? EmployeeStatus { get; set; }
    public string? Adress { get; set; }
    public string? State { get; set; }
    public string? city { get; set; } = "";
    public string? Country { get; set; }
    public string? Phone { get; set; }
    public string? IdentificationNo { get; set; }
    public string? PatientNum { get; set; }
    public string? FileNum { get; set; }
    public string? Email { get; set; }
    public string? Education { get; set; }
    public string? Deceased { get; set; }
    public string? CauseOfDeath { get; set; }
    public DateTime? DateOfDeath { get; set; }
    public int? Deleted { get; set; } = 0;
}


}