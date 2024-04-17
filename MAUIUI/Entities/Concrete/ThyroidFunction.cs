using MAUIUI.Core.Entities;

namespace MAUIUI.Entities.Concrete
{
    public class ThyroidFunction : IEntity
    {
        public Dictionary<string, Func<string, object>> Mapping()
        {
            return new Dictionary<string, Func<string, object>>(new Dictionary<string, Func<string, object>>
                {
                    { "PatientCode", cellValue => cellValue },
                    { "ExamDate", cellValue => cellValue==null? null : DateTime.Parse(cellValue) },
                    { "Antimicrosomal", cellValue => cellValue },
                    { "IsAntimicrosomalNormal", cellValue => cellValue },
                    { "AntimicrosomalComment", cellValue => cellValue },
                    { "Antithiroglobulin", cellValue => cellValue },
                    { "IsAntithiroglobulinNormal", cellValue => cellValue },
                    { "AntithiroglobulinComment", cellValue => cellValue },
                    { "T3", cellValue => cellValue },
                    { "IsT3Normal", cellValue => cellValue },
                    { "T3Comment", cellValue => cellValue },
                    { "T4", cellValue => cellValue },
                    { "IsT4Normal", cellValue => cellValue },
                    { "T4Comment", cellValue => cellValue },
                    { "TSH", cellValue => cellValue },
                    { "IsTSHNormal", cellValue => cellValue },
                    { "TSHComment", cellValue => cellValue },
                });
        }
        public int Id { get; set; }
        public string PatientCode { get; set; }
        public DateTime? ExamDate { get; set; }
        public string? Antimicrosomal { get; set; }
        public string? IsAntimicrosomalNormal { get; set; }
        public string? AntimicrosomalComment { get; set; }
        public string? Antithiroglobulin { get; set; }
        public string? IsAntithiroglobulinNormal { get; set; }
        public string? AntithiroglobulinComment { get; set; }
        public string? T3 { get; set; }
        public string? IsT3Normal { get; set; }
        public string? T3Comment { get; set; }
        public string? T4 { get; set; }
        public string? IsT4Normal { get; set; }
        public string? T4Comment { get; set; }
        public string? TSH { get; set; }
        public string? IsTSHNormal { get; set; }
        public string? TSHComment { get; set; }
    }


















}

