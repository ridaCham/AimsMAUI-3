using MAUIUI.Core.Entities;
namespace MAUIUI.Entities.Concrete
{

    public class EvokedPotentiel : IEntity
{
    public int Id { get; set; }
    public Dictionary<string, Func<string, object>> Mapping()
    {

        return new Dictionary<string, Func<string, object>>(new Dictionary<string, Func<string, object>>
                {
                    { "PatientCode", cellValue => cellValue},
                    { "ExameDate", cellValue => cellValue==null? null :DateTime.Parse(cellValue) },
                    { "VEPRight", cellValue => cellValue },
                    { "VEPLeft", cellValue => cellValue },
                    { "VEPRightMesc", cellValue => cellValue },
                    { "VEPLeftMesc", cellValue => cellValue },
                    { "VEPMescRange", cellValue => cellValue },
                    { "VEPMescRangeTotal", cellValue => cellValue },
                    { "VEPRightAmplitude", cellValue => cellValue },
                    { "VEPLeftAmplitude", cellValue => cellValue },
                    { "BAEPRight", cellValue => cellValue },
                    { "BAEPLeft", cellValue => cellValue },
                    { "RightSEPUpperExtrimity", cellValue => cellValue },
                    { "LeftSEPUpperExtrimity", cellValue => cellValue },
                    { "RightSEPLowerExtrimity", cellValue => cellValue },
                    { "LeftSEPLowerExtrimity", cellValue => cellValue },
                    { "RightMEPUpperExtrimity", cellValue => cellValue },
                    { "LeftMEPUpperExtrimity", cellValue => cellValue },
                    { "RightMEPLowerExtrimity", cellValue => cellValue },
                    { "LeftMEPLowerExtrimity", cellValue => cellValue },
                    { "Remarks", cellValue => cellValue },
                });
    }
    public string PatientCode { get; set; }
    public DateTime? ExameDate { get; set; }
    public string? VEPRight { get; set; }
    public string? VEPLeft { get; set; }
    public string? VEPRightMesc { get; set; }
    public string? VEPLeftMesc { get; set; }
    public string? VEPMescRange { get; set; }
    public string? VEPMescRangeTotal { get; set; }
    public string? VEPRightAmplitude { get; set; }
    public string? VEPLeftAmplitude { get; set; }
    public string? BAEPRight { get; set; }
    public string? BAEPLeft { get; set; }
    public string? RightSEPUpperExtrimity { get; set; }
    public string? LeftSEPUpperExtrimity { get; set; }
    public string? RightSEPLowerExtrimity { get; set; }
    public string? LeftSEPLowerExtrimity { get; set; }
    public string? RightMEPUpperExtrimity { get; set; }
    public string? LeftMEPUpperExtrimity { get; set; }
    public string? RightMEPLowerExtrimity { get; set; }
    public string? LeftMEPLowerExtrimity { get; set; }
    public string? Remarks { get; set; }
}

}