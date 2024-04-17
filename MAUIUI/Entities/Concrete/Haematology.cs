using MAUIUI.Core.Entities;
namespace MAUIUI.Entities.Concrete
{

    public class Haematology : IEntity
{ //adapha
    public int Id { get; set; }
    public Dictionary<string, Func<string, object>> Mapping()
    {
        return new Dictionary<string, Func<string, object>>(new Dictionary<string, Func<string, object>>
                {
                    { "PatientCode", cellValue => cellValue },
                    { "ExamDate", cellValue => cellValue==null? null : DateTime.Parse(cellValue) },
                    { "WhiteCellCount", cellValue => cellValue },
                    { "IsWhiteCellNormal", cellValue => cellValue },
                    { "WhiteCellComment", cellValue => cellValue },
                    { "RedCellCount", cellValue => cellValue },
                    { "IsRedCellNormal", cellValue => cellValue },
                    { "RedCellComment", cellValue => cellValue },
                    { "LymphocyteCount", cellValue => cellValue },
                    { "IsLymphocyteNormal", cellValue => cellValue },
                    { "LymphocyteComment", cellValue => cellValue },
                    { "IsLymphocyteLoweLimitNormal", cellValue => cellValue },
                    { "LymphocyteLimitCount", cellValue => cellValue },
                    { "LymphocyteLimitComment", cellValue => cellValue },
                    { "TCellCount", cellValue => cellValue },
                    { "NKCellComment", cellValue => cellValue },
                    { "IsNKCellNormal", cellValue => cellValue },
                    { "NKCellCount", cellValue => cellValue },
                    { "MonocyteComment", cellValue => cellValue },
                    { "IsMonocyteNormal", cellValue => cellValue },
                    { "MonocyteCount", cellValue => cellValue },
                    { "NeutrophilComment", cellValue => cellValue },
                    { "IsNeutrophilNormal", cellValue => cellValue },
                    { "NeutrophilCount", cellValue => cellValue },
                    { "CD19TCellComment", cellValue => cellValue },
                    { "IsCD19TCellNormal", cellValue => cellValue },
                    { "CD19TCellCount", cellValue => cellValue },
                    { "CD8TCellComment", cellValue => cellValue },
                    { "IsCD8TCellNormal", cellValue => cellValue },
                    { "CD8TCellCount", cellValue => cellValue },
                    { "CD4TCellComment", cellValue => cellValue },
                    { "IsCD4TCellNormal", cellValue => cellValue },
                    { "CD4TCellCount", cellValue => cellValue },
                    { "TCellComment", cellValue => cellValue },
                    { "IsTCellNormal", cellValue => cellValue },
                    { "HomoglobineCount", cellValue => cellValue },
                    { "PlateletComment", cellValue => cellValue },
                    { "IsPlateletNormal", cellValue => cellValue },
                    { "PlateletCount", cellValue => cellValue },
                    { "BasophilComment", cellValue => cellValue },
                    { "IsBasophilNormal", cellValue => cellValue },
                    { "BasophilCount", cellValue => cellValue },
                    { "EosinophilComment", cellValue => cellValue },
                    { "IsEosinophilNormal", cellValue => cellValue },
                    { "EosinophilCount", cellValue => cellValue },
                    { "IsHomoglobineNormal", cellValue => cellValue },
                    { "HomoglobineComment", cellValue => cellValue },
                    { "ESRCount", cellValue => cellValue },
                    { "IsESRNormal", cellValue => cellValue },
                    { "ESRComment", cellValue => cellValue },
                    { "ACECount", cellValue => cellValue },
                    { "IsACENormal", cellValue => cellValue },
                    { "ACEComment", cellValue => cellValue },
                    { "LDHCount", cellValue => cellValue },
                    { "IsLDHNormal", cellValue => cellValue },
                    { "LDHComment", cellValue => cellValue },
                    { "Beta2Microglobine", cellValue => cellValue },
                    { "IsBeta2MicroglobineNormal", cellValue => cellValue },
                    { "Beta2MicroglobineComment", cellValue => cellValue },
                    { "VitaminD", cellValue => cellValue },
                    { "IsVitaminDNormal", cellValue => cellValue },
                    { "VitaminDComment", cellValue => cellValue },
                    { "CD20", cellValue => cellValue },
                    { "IsCD20Normal", cellValue => cellValue },
                    { "CD20Comment", cellValue => cellValue }
                });
    }
    public string PatientCode { get; set; }
    public DateTime? ExamDate { get; set; }
    public string? WhiteCellCount { get; set; }
    public string? IsWhiteCellNormal { get; set; }
    public string? WhiteCellComment { get; set; }
    public string? RedCellCount { get; set; }
    public string? IsRedCellNormal { get; set; }

    public string? IsLymphocyteLoweLimitNormal { get; set; }
    public string? RedCellComment { get; set; }
    public string? LymphocyteCount { get; set; }
    public string? IsLymphocyteNormal { get; set; }
    public string? LymphocyteComment { get; set; }
    public string? LymphocyteLimitCount { get; set; }
    public string? LymphocyteLimitComment { get; set; }
    public string? TCellCount { get; set; }
    public string? IsTCellNormal { get; set; }
    public string? TCellComment { get; set; }
    public string? CD4TCellCount { get; set; }
    public string? IsCD4TCellNormal { get; set; }
    public string? CD4TCellComment { get; set; }
    public string? CD8TCellCount { get; set; }
    public string? IsCD8TCellNormal { get; set; }
    public string? CD8TCellComment { get; set; }
    public string? CD19TCellCount { get; set; }
    public string? IsCD19TCellNormal { get; set; }
    public string? CD19TCellComment { get; set; }
    public string? NeutrophilCount { get; set; }
    public string? IsNeutrophilNormal { get; set; }
    public string? NeutrophilComment { get; set; }
    public string? MonocyteCount { get; set; }
    public string? IsMonocyteNormal { get; set; }
    public string? MonocyteComment { get; set; }
    public string? NKCellCount { get; set; }
    public string? IsNKCellNormal { get; set; }
    public string? NKCellComment { get; set; }
    public string? EosinophilCount { get; set; }
    public string? IsEosinophilNormal { get; set; }
    public string? EosinophilComment { get; set; }
    public string? BasophilCount { get; set; }
    public string? IsBasophilNormal { get; set; }
    public string? BasophilComment { get; set; }
    public string? PlateletCount { get; set; }
    public string? IsPlateletNormal { get; set; }
    public string? PlateletComment { get; set; }
    public string? HomoglobineCount { get; set; }
    public string? IsHomoglobineNormal { get; set; }
    public string? HomoglobineComment { get; set; }
    public string? ESRCount { get; set; }
    public string? IsESRNormal { get; set; }
    public string? ESRComment { get; set; }
    public string? ACECount { get; set; }
    public string? IsACENormal { get; set; }
    public string? ACEComment { get; set; }
    public string? LDHCount { get; set; }
    public string? IsLDHNormal { get; set; }
    public string? LDHComment { get; set; }
    public string? Beta2Microglobine { get; set; }
    public string? IsBeta2MicroglobineNormal { get; set; }
    public string? Beta2MicroglobineComment { get; set; }
    public string? VitaminD { get; set; }
    public string? IsVitaminDNormal { get; set; }
    public string? VitaminDComment { get; set; }
    public string? CD20 { get; set; }
    public string? IsCD20Normal { get; set; }
    public string? CD20Comment { get; set; }

}


}