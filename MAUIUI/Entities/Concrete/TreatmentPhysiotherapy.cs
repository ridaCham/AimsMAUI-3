using MAUIUI.Core.Entities;
namespace MAUIUI.Entities.Concrete
{


    public class TreatmentPhysiotherapy : IEntity
{
    public int? Id { get; set; }
    public string PatientCode { get; set; }
    public Dictionary<string, Func<string, object>> Mapping()
    {
        return new Dictionary<string, Func<string, object>>(new Dictionary<string, Func<string, object>>
                {
                    { "PatientCode", cellValue => cellValue },
                    { "TreatmentId", cellValue =>  cellValue==null? null :int.Parse(cellValue) },
                    { "PhysiotherapyEndDate", cellValue => cellValue==null? null : DateTime.Parse(cellValue) },
                    { "PhysiotherapyStartDate", cellValue =>  cellValue==null? null :DateTime.Parse(cellValue) },
                    { "Physiotherapy", cellValue => cellValue },
                });
    }
    public int? TreatmentId { get; set; }
    public string? Physiotherapy { get; set; }
    public DateTime? PhysiotherapyEndDate { get; set; }
    public DateTime? PhysiotherapyStartDate { get; set; }
}

}