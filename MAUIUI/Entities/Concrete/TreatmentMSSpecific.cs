using MAUIUI.Core.Entities;

namespace MAUIUI.Entities.Concrete
{
    public class TreatmentMSSpecific : IEntity
    {
        public int? Id { get; set; }
        public string PatientCode { get; set; }
        public int? TreatmentId { get; set; }
        public Dictionary<string, Func<string, object>> Mapping()
        {
            return new Dictionary<string, Func<string, object>>(new Dictionary<string, Func<string, object>>
                {
                    { "PatientCode", cellValue =>cellValue},
                    { "TreatmentId", cellValue =>  cellValue==null? null :int.Parse(cellValue) },
                    { "StartingOn", cellValue =>  cellValue==null? null :DateTime.Parse(cellValue) },
                    { "EndingOn", cellValue =>  cellValue==null? null :DateTime.Parse(cellValue) },
                    { "MSSpecificTreatment", cellValue => cellValue },
                    { "Posology", cellValue => cellValue },
                    { "MsSpesificOtherPosology", cellValue => cellValue },
                    { "ReasonForDiscontinuation", cellValue => cellValue },
                });
        }
        public string? MSSpecificTreatment { get; set; }
        public string? Posology { get; set; }
        public string? MsSpesificOtherPosology { get; set; }
        public DateTime? StartingOn { get; set; }
        public DateTime? EndingOn { get; set; }
        public string? ReasonForDiscontinuation { get; set; } = " ";
    }


















}

