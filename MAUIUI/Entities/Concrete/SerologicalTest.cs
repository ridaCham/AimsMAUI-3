using MAUIUI.Core.Entities;

namespace MAUIUI.Entities.Concrete
{
    public class SerologicalTest : IEntity
    {
        public Dictionary<string, Func<string, object>> Mapping()
        {
            return new Dictionary<string, Func<string, object>>(new Dictionary<string, Func<string, object>>
                {
                    { "PatientCode", cellValue =>cellValue},
                    { "ExamDate", cellValue =>  cellValue==null? null :DateTime.Parse(cellValue) },
                    { "TotalGalialFibrilerAsidikProtein", cellValue =>  cellValue },
                    { "GalialFibrilerAsidikProtein", cellValue =>  cellValue },
                    { "TotalNeurofilamentLightChain", cellValue =>  cellValue },
                    { "NeurofilamentLightChain", cellValue =>  cellValue },
                    { "StoolBotulismToxinComment", cellValue =>  cellValue },
                    { "StoolBotulismToxin", cellValue =>  cellValue },
                    { "MantouxTestComment", cellValue =>  cellValue },
                    { "MantouxTest", cellValue =>  cellValue },
                    { "QuantiferonGoldTestComment", cellValue =>  cellValue },
                    { "QuantiferonGoldTest", cellValue =>  cellValue },
                    { "PregnancyTestComment", cellValue =>  cellValue },
                    { "PregnancyTest", cellValue =>  cellValue },
                    { "AntiVaricellaComment", cellValue =>  cellValue },
                    { "AntiVaricella", cellValue =>  cellValue },
                    { "AntiHIVComment", cellValue =>  cellValue },
                    { "AntiHIV", cellValue =>  cellValue },
                    { "AntiHCVComment", cellValue =>  cellValue },
                    { "AntiHCV", cellValue =>  cellValue },
                    { "HBVComment", cellValue =>  cellValue },
                    { "HBV", cellValue =>  cellValue },
                });
        }
        public int Id { get; set; }
        public string PatientCode { get; set; }
        public DateTime? ExamDate { get; set; }
        public string? HBV { get; set; }
        public string? HBVComment { get; set; }
        public string? AntiHCV { get; set; }
        public string? AntiHCVComment { get; set; }
        public string? AntiHIV { get; set; }
        public string? AntiHIVComment { get; set; }
        public string? AntiVaricella { get; set; }
        public string? AntiVaricellaComment { get; set; }
        public string? PregnancyTest { get; set; }
        public string? PregnancyTestComment { get; set; }
        public string? QuantiferonGoldTest { get; set; }
        public string? QuantiferonGoldTestComment { get; set; }
        public string? MantouxTest { get; set; }
        public string? MantouxTestComment { get; set; }
        public string? StoolBotulismToxin { get; set; }
        public string? StoolBotulismToxinComment { get; set; }
        public string? NeurofilamentLightChain { get; set; }
        public string? TotalNeurofilamentLightChain { get; set; }
        public string? GalialFibrilerAsidikProtein { get; set; }
        public string? TotalGalialFibrilerAsidikProtein { get; set; }

    }
}


















