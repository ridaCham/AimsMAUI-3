using MAUIUI.Core.Entities;
namespace MAUIUI.Entities.Concrete
{

    public class BloodChemistry : IEntity
{
    public int Id { get; set; }
    public string PatientCode { get; set; }
    public Dictionary<string, Func<string, object>> Mapping()
    {
        return new Dictionary<string, Func<string, object>>(new Dictionary<string, Func<string, object>>
                {
                    { "PatientCode", cellValue => cellValue},
                    { "ExamDate", cellValue => cellValue==null? null :  DateTime.Parse(cellValue)  },
                    { "TotalProtein", cellValue => cellValue },
                    { "IsTotalProteinNormal", cellValue => cellValue },
                    { "TotalProteinComment", cellValue => cellValue },
                    { "Albumin", cellValue => cellValue },
                    { "IsAlbuminNormal", cellValue => cellValue },
                    { "AlbuminComment", cellValue => cellValue },
                    { "Calcium", cellValue => cellValue },
                    { "IsCalciumNormal", cellValue => cellValue },
                    { "CalciumComment", cellValue => cellValue },
                    { "Urea", cellValue => cellValue },
                    { "IsUreaNormal", cellValue => cellValue },
                    { "UreaComment", cellValue => cellValue },
                    { "UricAcid", cellValue => cellValue },
                    { "IsUricAcidNormal", cellValue => cellValue },
                    { "UricAcidComment", cellValue => cellValue },
                    { "Creatinine", cellValue => cellValue },
                    { "IsCreatinineNormal", cellValue => cellValue },
                    { "CreatinineComment", cellValue => cellValue },
                    { "SGOT", cellValue => cellValue },
                    { "IsSGOTNormal", cellValue => cellValue },
                    { "SGOTComment", cellValue => cellValue },
                    { "SGPT", cellValue => cellValue },
                    { "IsSGPTNormal", cellValue => cellValue },
                    { "SGPTComment", cellValue => cellValue },
                    { "GammaGT", cellValue => cellValue },
                    { "IsGammaGTNormal", cellValue => cellValue },
                    { "GammaGTComment", cellValue => cellValue },
                    { "Bilirubin", cellValue => cellValue },
                    { "IsBilirubinNormal", cellValue => cellValue },
                    { "BilirubinComment", cellValue => cellValue },
                    { "AlkalinePhosphatase", cellValue => cellValue },
                    { "IsAlkalinePhosphataseNormal", cellValue => cellValue },
                    { "AlkalinePhosphataseComment", cellValue => cellValue },
                    { "Amylase", cellValue => cellValue },
                    { "IsAmylaseNormal", cellValue => cellValue },
                    { "AmylaseComment", cellValue => cellValue },
                    { "Lipase", cellValue => cellValue },
                    { "IsLipaseNormal", cellValue => cellValue },
                    { "LipaseComment", cellValue => cellValue },
                });
    }
    public DateTime? ExamDate { get; set; }
    public string? TotalProtein { get; set; }
    public string? IsTotalProteinNormal { get; set; }
    public string? TotalProteinComment { get; set; }
    public string? Albumin { get; set; }
    public string? IsAlbuminNormal { get; set; }
    public string? AlbuminComment { get; set; }
    public string? Calcium { get; set; }
    public string? IsCalciumNormal { get; set; }
    public string? CalciumComment { get; set; }
    public string? Urea { get; set; }
    public string? IsUreaNormal { get; set; }
    public string? UreaComment { get; set; }
    public string? UricAcid { get; set; }
    public string? IsUricAcidNormal { get; set; }
    public string? UricAcidComment { get; set; }
    public string? Creatinine { get; set; }
    public string? IsCreatinineNormal { get; set; }
    public string? CreatinineComment { get; set; }
    public string? SGOT { get; set; }
    public string? IsSGOTNormal { get; set; }
    public string? SGOTComment { get; set; }
    public string? SGPT { get; set; }
    public string? IsSGPTNormal { get; set; }
    public string? SGPTComment { get; set; }
    public string? GammaGT { get; set; }
    public string? IsGammaGTNormal { get; set; }
    public string? GammaGTComment { get; set; }
    public string? Bilirubin { get; set; }
    public string? IsBilirubinNormal { get; set; }
    public string? BilirubinComment { get; set; }
    public string? AlkalinePhosphatase { get; set; }
    public string? IsAlkalinePhosphataseNormal { get; set; }
    public string? AlkalinePhosphataseComment { get; set; }
    public string? Amylase { get; set; }
    public string? IsAmylaseNormal { get; set; }
    public string? AmylaseComment { get; set; }
    public string? Lipase { get; set; }
    public string? IsLipaseNormal { get; set; }
    public string? LipaseComment { get; set; }
}

}