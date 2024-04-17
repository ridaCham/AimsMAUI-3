using MAUIUI.Core.Entities;

namespace MAUIUI.Entities.Concrete
{
    public class Treatment : IEntity
    {
        public Dictionary<string, Func<string, object>> Mapping()
        {
            return new Dictionary<string, Func<string, object>>(new Dictionary<string, Func<string, object>>
                {
                    { "PatientCode", cellValue =>cellValue },
                    { "Remarks", cellValue => cellValue },
                });
        }
        public int Id { get; set; }
        public string PatientCode { get; set; }
        public string? Remarks { get; set; }
    }


















}

