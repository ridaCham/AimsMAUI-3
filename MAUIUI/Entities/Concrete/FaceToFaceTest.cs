using MAUIUI.Core.Entities;
namespace MAUIUI.Entities.Concrete
{

    public class FaceToFaceTest : IEntity
{
    public Dictionary<string, Func<string, object>> Mapping()
    {
        return new Dictionary<string, Func<string, object>>(new Dictionary<string, Func<string, object>>
                {
                    { "PatientCode", cellValue => cellValue},
                    { "Date", cellValue => cellValue==null? null : DateTime.Parse(cellValue) },
                    { "DominantHand", cellValue => cellValue },
                    { "AmbilationIndex", cellValue => cellValue },
                    { "RightTimeToWalk", cellValue => cellValue },
                    { "LeftTimeToWalk", cellValue => cellValue },
                    { "RightNineHolePegTest", cellValue => cellValue },
                    { "LeftNineHolePegTest", cellValue => cellValue },
                    { "PasatTest", cellValue => cellValue },
                    { "StroopTest", cellValue => cellValue },
                    { "WisconsinTest", cellValue => cellValue },
                    { "DigitSymbolTest", cellValue => cellValue },
                    { "RightNineHolePegTest2", cellValue => cellValue },
                    { "LeftNineHolePegTest2", cellValue => cellValue },
                });
    }
    public DateTime? Date { get; set; }
    public int Id { get; set; }
    public string PatientCode { get; set; }
    public string? DominantHand { get; set; }
    public string? AmbilationIndex { get; set; }
    public string? RightTimeToWalk { get; set; }
    public string? LeftTimeToWalk { get; set; }
    public string? RightNineHolePegTest { get; set; }
    public string? LeftNineHolePegTest { get; set; }
    public string? PasatTest { get; set; }
    public string? StroopTest { get; set; }
    public string? WisconsinTest { get; set; }
    public string? DigitSymbolTest { get; set; }
    public string? RightNineHolePegTest2 { get; set; }
    public string? LeftNineHolePegTest2 { get; set; }
}
}
