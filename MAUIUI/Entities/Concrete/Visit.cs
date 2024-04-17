using System;
using MAUIUI.Core.Entities;

namespace MAUIUI.Entities.Concrete
{


    public class Visit : IEntity
    {
        public int Id { get; set; }
        public string PatientCode { get; set; }
        public DateTime? VisitDate { get; set; }
        public string? ExaminatedBy { get; set; }
        public string? firstVisit { get; set; }
        public string? VideoPath { get; set; }
        public string? AudioPath { get; set; }
        public string? Administrative { get; set; }
        public string? routine { get; set; }
        public string? suspectedRelapse { get; set; }
        public string? phone { get; set; }
        public string? retrospective { get; set; }
        public string? Height { get; set; }
        public string? Weight { get; set; }
        public string? BMI { get; set; }
        public string? BloodPressure { get; set; }
        public string? BloodPressureBase { get; set; }
        public string? Temperature { get; set; }
        public string? TemperaturePulse { get; set; }
        public string? CountsOneBreath { get; set; }
        public string? blurredVission { get; set; }
        public string? fielddefect { get; set; }
        public string? oscillopsia { get; set; }
        public string? Diplopia { get; set; }
        public string? neckWeakness { get; set; }
        public string? Dysphagia { get; set; }
        public string? tregeminalNerve { get; set; }
        public string? tregeminalNeuralgia { get; set; }
        public string? tregeminalAtypicalPain { get; set; }
        public string? tregeminalParesthesiae { get; set; }
        public string? TregeminalHypoesthesiae { get; set; }
        public string? motorUpperExtremities { get; set; }
        public string? motorLowerExtremities { get; set; }
        public string? AtaxiaUpperExtremities { get; set; }
        public string? AtaxiaLowerExtremities { get; set; }
        public string? gaitParesis { get; set; }
        public string? gaitAtaxia { get; set; }
        public string? GaitSpasticity { get; set; }
        public string? tremor { get; set; }
        public string? Dysaesthesiae { get; set; }
        public string? painHeadeche { get; set; }
        public string? hypotonya { get; set; }
        public string? hypersalivation { get; set; }
        public string? tonicspasms { get; set; }
        public string? paresthesiae { get; set; }
        public string? Vertigo { get; set; }
        public string? hearingLoss { get; set; }
        public string? facialPalsy { get; set; }
        public string? Myokymia { get; set; }
        public string? Dysarthria { get; set; }
        public string? Hemispasm { get; set; }
        public string? Nausea { get; set; }
        public string? vomiting { get; set; }
        public string? Hiccups { get; set; }
        public string? SymptomsNystagmus { get; set; }
        public string? Seizures { get; set; }
        public string? lhermittesSign { get; set; }
        public string? micturition { get; set; }
        public string? DefecationProblems { get; set; }
        public string? sexualFunctionsProblem { get; set; }
        public string? moodProblems { get; set; }
        public string? Cognitionproblems { get; set; }
        public string? fatigue { get; set; }
        public string? extrapyramidalSymtoms { get; set; }
        public string? hypotonicSpeech { get; set; }
        public string? nazoneSpeech { get; set; }
        public string? hemiplegia { get; set; }
        public string? respiratoryproblem { get; set; }
        public string? excessiveSweating { get; set; }
        public string? Fluxation { get; set; }
        public string? MentionAndMood { get; set; }
        public string? VisualAcuity { get; set; }
        public string? FieldsDiscPupils { get; set; }
        public string? EyeMovements { get; set; }
        public string? Nystagmus { get; set; }
        public string? Pitoz { get; set; }
        public string? LowerCranialNerves { get; set; }
        public string? MotorRU { get; set; }
        public string? MotorLU { get; set; }
        public string? MotorRL { get; set; }
        public string? MotorLL { get; set; }
        public string? MotorNeckFlexion { get; set; }
        public string? MotorNeckExtation { get; set; }
        public string? DTRSUE { get; set; }
        public string? DTRSLE { get; set; }
        public string? SensoryRU { get; set; }
        public string? SensoryLU { get; set; }
        public string? SensoryRL { get; set; }
        public string? SensoryLL { get; set; }
        public string? CereballarUE { get; set; }
        public string? CereballarLE { get; set; }
        public string? GaitTruncBalance { get; set; }
        public string? BladderBowel { get; set; }
        public string? BabinskiR { get; set; }
        public string? BabinskiL { get; set; }
        public string? OrthostaticHypotension { get; set; }
        public string? MuscleToneRU { get; set; }
        public string? MuscleToneLU { get; set; }
        public string? MuscleToneRL { get; set; }
        public string? MuscleToneLL { get; set; }
        public string? Total { get; set; }
        public string? Remarks { get; set; }
        public Dictionary<string, Func<string, object>> Mapping()
        {
            return new Dictionary<string, Func<string, object>>(new Dictionary<string, Func<string, object>>
    {
        { "PatientCode", cellValue =>  cellValue },
        { "VisitDate", cellValue => cellValue == null ? null : DateTime.Parse(cellValue) },
        { "ExaminatedBy", cellValue =>  cellValue },
        { "firstVisit", cellValue =>  cellValue },
        { "Administrative", cellValue =>  cellValue },
        { "routine", cellValue =>  cellValue },
        { "suspectedRelapse", cellValue =>  cellValue },
        { "phone", cellValue =>  cellValue },
        { "retrospective", cellValue =>  cellValue },
        { "Height", cellValue =>  cellValue },
        { "Weight", cellValue =>  cellValue },
        { "BMI", cellValue =>  cellValue },
        { "BloodPressure", cellValue =>  cellValue },
        { "BloodPressureBase", cellValue =>  cellValue },
        { "Temperature", cellValue =>  cellValue },
        { "TemperaturePulse", cellValue =>  cellValue },
        { "CountsOneBreath", cellValue =>  cellValue },
        { "Fluxation", cellValue =>  cellValue },
        { "blurredVission", cellValue =>  cellValue },
        { "fielddefect", cellValue =>  cellValue },
        { "oscillopsia", cellValue =>  cellValue },
        { "Diplopia", cellValue =>  cellValue },
        { "neckWeakness", cellValue =>  cellValue },
        { "Dysphagia", cellValue =>  cellValue },
        { "tregeminalNerve", cellValue =>  cellValue },
        { "tregeminalNeuralgia", cellValue =>  cellValue },
        { "tregeminalAtypicalPain", cellValue =>  cellValue },
        { "tregeminalParesthesiae", cellValue =>  cellValue },
        { "TregeminalHypoesthesiae", cellValue =>  cellValue },
        { "motorUpperExtremities", cellValue =>  cellValue },
        { "motorLowerExtremities", cellValue =>  cellValue },
        { "AtaxiaUpperExtremities", cellValue =>  cellValue },
        { "AtaxiaLowerExtremities", cellValue =>  cellValue },
        { "gaitParesis", cellValue =>  cellValue },
        { "gaitAtaxia", cellValue =>  cellValue },
        { "GaitSpasticity", cellValue =>  cellValue },
        { "tremor", cellValue =>  cellValue },
        { "Dysaesthesiae", cellValue =>  cellValue },
        { "painHeadeche", cellValue =>  cellValue },
        { "lhermittesSign", cellValue =>  cellValue },
        { "micturition", cellValue =>  cellValue },
        { "DefecationProblems", cellValue =>  cellValue },
        { "sexualFunctionsProblem", cellValue =>  cellValue },
        { "moodProblems", cellValue =>  cellValue },
        { "Cognitionproblems", cellValue =>  cellValue },
        { "fatigue", cellValue =>  cellValue },
        { "extrapyramidalSymtoms", cellValue =>  cellValue },
        { "hypotonicSpeech", cellValue =>  cellValue },
        { "nazoneSpeech", cellValue =>  cellValue },
        { "hemiplegia", cellValue =>  cellValue },
        { "respiratoryproblem", cellValue =>  cellValue },
        { "excessiveSweating", cellValue =>  cellValue },
        { "hypotonya", cellValue =>  cellValue },
        { "hypersalivation", cellValue =>  cellValue },
        { "tonicspasms", cellValue =>  cellValue },
        { "paresthesiae", cellValue =>  cellValue },
        { "Vertigo", cellValue =>  cellValue },
        { "hearingLoss", cellValue =>  cellValue },
        { "facialPalsy", cellValue =>  cellValue },
        { "Myokymia", cellValue =>  cellValue },
        { "Dysarthria", cellValue =>  cellValue },
        { "Hemispasm", cellValue =>  cellValue },
        { "Nausea", cellValue =>  cellValue },
        { "vomiting", cellValue =>  cellValue },
        { "Hiccups", cellValue =>  cellValue },
        { "SymptomsNystagmus", cellValue =>  cellValue },
        { "Seizures", cellValue =>  cellValue },
        { "MentionAndMood", cellValue =>  cellValue },
        { "VisualAcuity", cellValue =>  cellValue },
        { "FieldsDiscPupils", cellValue =>  cellValue },
        { "EyeMovements", cellValue =>  cellValue },
        { "Nystagmus", cellValue =>  cellValue },
        { "Pitoz", cellValue =>  cellValue },
        { "LowerCranialNerves", cellValue =>  cellValue },
        { "MotorRU", cellValue =>  cellValue },
        { "MotorLU", cellValue =>  cellValue },
        { "MotorRL", cellValue =>  cellValue },
        { "MotorLL", cellValue =>  cellValue },
        { "MotorNeckFlexion", cellValue =>  cellValue },
        { "MotorNeckExtation", cellValue =>  cellValue },
        { "DTRSUE", cellValue =>  cellValue },
        { "DTRSLE", cellValue =>  cellValue },
        { "SensoryRU", cellValue =>  cellValue },
        { "SensoryLU", cellValue =>  cellValue },
        { "SensoryRL", cellValue =>  cellValue },
        { "SensoryLL", cellValue =>  cellValue },
        { "CereballarUE", cellValue =>  cellValue },
        { "CereballarLE", cellValue =>  cellValue },
        { "GaitTruncBalance", cellValue =>  cellValue },
        { "BladderBowel", cellValue =>  cellValue },
        { "BabinskiR", cellValue =>  cellValue },
        { "BabinskiL", cellValue =>  cellValue },
        { "OrthostaticHypotension", cellValue =>  cellValue },
        { "Total", cellValue =>  cellValue },
        { "MuscleToneRU", cellValue =>  cellValue },
        { "MuscleToneLU", cellValue =>  cellValue },
        { "MuscleToneRL", cellValue =>  cellValue },
        { "MuscleToneLL", cellValue =>  cellValue },
        { "Remarks", cellValue =>  cellValue },
        { "VideoPath", cellValue =>  cellValue },
        { "AudioPath", cellValue =>  cellValue },
    });
        }

    }
}

