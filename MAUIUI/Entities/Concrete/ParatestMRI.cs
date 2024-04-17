using MAUIUI.Core.Entities;

namespace MAUIUI.Entities.Concrete
{


    public class ParatestMRI : IEntity
{
    public Dictionary<string, Func<string, object>> Mapping()
    {
        return new Dictionary<string, Func<string, object>>(new Dictionary<string, Func<string, object>>
                {
                    { "PatientCode", cellValue => cellValue },
                    { "ParatestmriExamDate", cellValue => cellValue==null? null : DateTime.Parse(cellValue) },
                    { "NbOfT1", cellValue => cellValue },
                    { "NbOfGd", cellValue => cellValue },
                    { "NbOfT2", cellValue => cellValue },
                    { "NbOfNew", cellValue => cellValue },
                    { "CNSRegion", cellValue => cellValue },
                    { "T1", cellValue => cellValue },
                    { "T1Detail", cellValue => cellValue },
                    { "T1Gadolinium", cellValue => cellValue },
                    { "T1GadoliniumDetail", cellValue => cellValue },
                    { "T2", cellValue => cellValue },
                    { "T2Detail", cellValue => cellValue },
                    { "Remarks", cellValue => cellValue },
                    { "ImagePath", cellValue => cellValue },
                });
    }
    public int Id { get; set; }
    public string PatientCode { get; set; }
    public string? NbOfT1 { get; set; }
    public string? NbOfGd { get; set; }
    public string? NbOfT2 { get; set; }
    public string? ImagePath { get; set; }

    public string? NbOfNew { get; set; }
    public string? CNSRegion { get; set; }
    public string? T1 { get; set; }
    public string? T1Detail { get; set; }
    public string? T1Gadolinium { get; set; }
    public string? T1GadoliniumDetail { get; set; }
    public string? T2 { get; set; }
    public string? T2Detail { get; set; }
    public string? Remarks { get; set; }
    public DateTime? ParatestmriExamDate { get; set; }
    }
}

