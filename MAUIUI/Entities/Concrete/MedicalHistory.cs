using MAUIUI.Core.Entities;

namespace MAUIUI.Entities.Concrete
{

    public class MedicalHistory : IEntity
{
    public int Id { get; set; }
    public string PatientCode { get; set; }
    public DateTime? EntryDate { get; set; }
    public string? ReferredBy { get; set; }
    public string? VisitFrequency { get; set; }
    public string? PreviousRelapses { get; set; }
    public string? EthnicOrigin { get; set; }
    public string? DominantHand { get; set; }
    public string? SmookingHistory { get; set; }
    public string? AlcoholUse { get; set; }

    public string? remarks { get; set; }

    public Dictionary<string, Func<string, object>> Mapping()
    {
        return new Dictionary<string, Func<string, object>>(new Dictionary<string, Func<string, object>>
                {
                    { "PatientCode", cellValue => cellValue },
                    { "EntryDate", cellValue => cellValue==null? null : DateTime.Parse(cellValue) },

                    { "ReferredBy", cellValue => cellValue },
                    { "VisitFrequency", cellValue => cellValue },
                    { "PreviousRelapses", cellValue => cellValue },
                    { "EthnicOrigin", cellValue => cellValue },
                    { "DominantHand", cellValue => cellValue },
                    { "SmookingHistory", cellValue => cellValue },
                    { "AlcoholUse", cellValue => cellValue },
                    { "remarks", cellValue => cellValue },
                });
        }
    }
}

