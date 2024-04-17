using MAUIUI.Core.Entities;

namespace MAUIUI.Entities.Concrete
{
    public class TreatmentNeuropsych : IEntity
    {
        public int? Id { get; set; }
        public string PatientCode { get; set; }
        public int? TreatmentId { get; set; }
        public Dictionary<string, Func<string, object>> Mapping()
        {
            return new Dictionary<string, Func<string, object>>(new Dictionary<string, Func<string, object>>
                {
                    { "PatientCode", cellValue => cellValue },
                    { "TreatmentId", cellValue =>  cellValue==null? null :int.Parse(cellValue) },
                    { "NeuropsychEndDate", cellValue =>  cellValue==null? null :DateTime.Parse(cellValue) },
                    { "NeuropsychStartDate", cellValue =>  cellValue==null? null :DateTime.Parse(cellValue) },
                    { "Neuropsych", cellValue => cellValue },
                });
        }
        public string? Neuropsych { get; set; }
        public DateTime? NeuropsychEndDate { get; set; }
        public DateTime? NeuropsychStartDate { get; set; }
    }
}

