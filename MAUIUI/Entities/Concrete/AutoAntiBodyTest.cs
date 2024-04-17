using MAUIUI.Core.Entities;
namespace MAUIUI.Entities.Concrete
{

    public class AutoAntiBodyTest : IEntity
{
    public Dictionary<string, Func<string, object>> Mapping()
    {
        return new Dictionary<string, Func<string, object>>(new Dictionary<string, Func<string, object>>
                {
                     { "PatientCode", cellValue => cellValue },
                    { "ExamDate", cellValue => cellValue==null? null : DateTime.Parse(cellValue) },
                    { "Acetylecholine", cellValue => cellValue },
                    { "AcetylecholineComment", cellValue => cellValue },
                    { "AntiMusk", cellValue => cellValue },
                    { "AntiMuskComment", cellValue => cellValue },
                    { "AntiRyanodin", cellValue => cellValue },
                    { "AntiRyanodinComment", cellValue => cellValue },
                    { "AntiGliadin", cellValue => cellValue },
                    { "AntiGliadinComment", cellValue => cellValue },
                    { "Rapsodine", cellValue => cellValue },
                    { "RapsodineComment", cellValue => cellValue },
                    { "LRP4", cellValue => cellValue },
                    { "LRP4Comment", cellValue => cellValue },
                    { "Titin", cellValue => cellValue },
                    { "TitinComment", cellValue => cellValue },
                    { "CLChannelAntibody", cellValue => cellValue },
                    { "CLChannelAntibodyComment", cellValue => cellValue },
                    { "AntiNMO", cellValue => cellValue },
                    { "AntiNMOComment", cellValue => cellValue },
                    { "IsAntiRoNormal", cellValue => cellValue },
                    { "AntiRo", cellValue => cellValue },
                    { "AntiRoComment", cellValue => cellValue },
                    { "IsASMANormal", cellValue => cellValue },
                    { "ASMAComment", cellValue => cellValue },
                    { "ASMA", cellValue => cellValue },
                    { "AntimitochondrialComment", cellValue => cellValue },
                    { "IsAntimitochondrialNormal", cellValue => cellValue },
                    { "Antimitochondrial", cellValue => cellValue },
                    { "ANAComment", cellValue => cellValue },
                    { "IsANANormal", cellValue => cellValue },
                    { "ANA", cellValue => cellValue },
                    { "BasophilComment", cellValue => cellValue },
                    { "IsBasophilNormal", cellValue => cellValue },
                    { "BasophilCount", cellValue => cellValue },
                    { "AntiMOG", cellValue => cellValue },
                    { "AntiMOGComment", cellValue => cellValue },
                    { "La", cellValue => cellValue },
                    { "IsLaNormal", cellValue => cellValue },
                    { "LaComment", cellValue => cellValue },
                    { "LAC", cellValue => cellValue },
                    { "IsLACNormal", cellValue => cellValue },
                    { "LACComment", cellValue => cellValue },
                    { "Sm", cellValue => cellValue },
                    { "IsSmNormal", cellValue => cellValue },
                    { "SmComment", cellValue => cellValue },
                    { "RNP", cellValue => cellValue },
                    { "RNPComment", cellValue => cellValue },
                    { "IsRNPNormal", cellValue => cellValue },
                    { "Scl70", cellValue => cellValue },
                    { "IsScl70Normal", cellValue => cellValue },
                    { "Scl70Comment", cellValue => cellValue },
                    { "Jo1", cellValue => cellValue },
                    { "IsJo1Normal", cellValue => cellValue },
                    { "Jo1Comment", cellValue => cellValue },
                    { "AntiParietalComment", cellValue => cellValue },
                    { "AntiParietalNormal", cellValue => cellValue },
                    { "AntiParietal", cellValue => cellValue },
                    { "AntiCardiolininComment", cellValue => cellValue },
                    { "AntiCardiolininNormal", cellValue => cellValue },
                    { "AntiCardiolinin", cellValue => cellValue },
                    { "AntiLKMComment", cellValue => cellValue },
                    { "IsAntiLKMNormal", cellValue => cellValue },
                    { "AntiLKM", cellValue => cellValue },
                    { "ANCAComment", cellValue => cellValue },
                    { "IsANCANormal", cellValue => cellValue },
                    { "ANCA", cellValue => cellValue },
                    { "AntiDNAComment", cellValue => cellValue },
                    { "IsAntiDNANormal", cellValue => cellValue },
                    { "AntiDNA", cellValue => cellValue },
                    { "antiTransglutaminaseComment", cellValue => cellValue },
                    { "antiTransglutaminase", cellValue => cellValue },
                    { "IsAntiTransglutaminase", cellValue => cellValue },

    });
    }
    public int Id { get; set; }
    public string PatientCode { get; set; }
    public DateTime? ExamDate { get; set; }
    public string? Acetylecholine { get; set; }
    public string? AcetylecholineComment { get; set; }
    public string? AntiMusk { get; set; }
    public string? AntiMuskComment { get; set; }
    public string? AntiRyanodin { get; set; }
    public string? AntiRyanodinComment { get; set; }
    public string? AntiGliadin { get; set; }
    public string? AntiGliadinComment { get; set; }
    public string? Rapsodine { get; set; }
    public string? RapsodineComment { get; set; }
    public string? LRP4 { get; set; }
    public string? LRP4Comment { get; set; }
    public string? Titin { get; set; }
    public string? TitinComment { get; set; }
    public string? CLChannelAntibody { get; set; }
    public string? CLChannelAntibodyComment { get; set; }
    public string? AntiNMO { get; set; }
    public string? AntiNMOComment { get; set; }
    public string? AntiMOG { get; set; }
    public string? AntiMOGComment { get; set; }
    public string? BasophilCount { get; set; }
    public string? IsBasophilNormal { get; set; }
    public string? BasophilComment { get; set; }
    public string? ANA { get; set; }
    public string? IsANANormal { get; set; }
    public string? ANAComment { get; set; }
    public string? Antimitochondrial { get; set; }
    public string? IsAntimitochondrialNormal { get; set; }
    public string? AntimitochondrialComment { get; set; }
    public string? ASMA { get; set; }
    public string? IsASMANormal { get; set; }
    public string? ASMAComment { get; set; }
    public string? AntiRo { get; set; }
    public string? IsAntiRoNormal { get; set; }
    public string? AntiRoComment { get; set; }
    public string? La { get; set; }
    public string? IsLaNormal { get; set; }
    public string? LaComment { get; set; }
    public string? LAC { get; set; }
    public string? IsLACNormal { get; set; }
    public string? LACComment { get; set; }
    public string? Sm { get; set; }
    public string? IsSmNormal { get; set; }
    public string? SmComment { get; set; }
    public string? RNP { get; set; }
    public string? IsRNPNormal { get; set; }
    public string? RNPComment { get; set; }
    public string? Scl70 { get; set; }
    public string? IsScl70Normal { get; set; }
    public string? Scl70Comment { get; set; }
    public string? Jo1 { get; set; }
    public string? IsJo1Normal { get; set; }
    public string? Jo1Comment { get; set; }
    public string? AntiDNA { get; set; }
    public string? IsAntiDNANormal { get; set; }
    public string? AntiDNAComment { get; set; }
    public string? ANCA { get; set; }
    public string? IsANCANormal { get; set; }
    public string? ANCAComment { get; set; }
    public string? AntiLKM { get; set; }
    public string? IsAntiLKMNormal { get; set; }
    public string? AntiLKMComment { get; set; }
    public string? AntiCardiolinin { get; set; }
    public string? AntiCardiolininNormal { get; set; }
    public string? AntiCardiolininComment { get; set; }
    public string? AntiParietal { get; set; }
    public string? AntiParietalNormal { get; set; }
    public string? AntiParietalComment { get; set; }
    public string? IsAntiTransglutaminase { get; set; }
    public string? antiTransglutaminase { get; set; }
    public string? antiTransglutaminaseComment { get; set; }

    }
}

