using MAUIUI.Entities.Concrete;

namespace MAUIUI.Views;

public partial class SymptomsView : ContentView
{
	public SymptomsView()
	{
		InitializeComponent();
	}


    public void setSmptoms(Visit _visit)
    {

        if (BlurredVision_checkBox.IsChecked)
            _visit.blurredVission = "Yes";
        else _visit.blurredVission = "No";

        if (FieldDefect_checkBox.IsChecked)
            _visit.fielddefect = "Yes";
        else _visit.fielddefect = "No";

        if (Oscillopsia_checkBox.IsChecked)
            _visit.oscillopsia = "Yes";
        else _visit.oscillopsia = "No";

        if (DiplopiaGazeParesis_checkBox.IsChecked)
            _visit.Diplopia = "Yes";
        else _visit.Diplopia = "No";

        if (NeckWeakness_checkBox.IsChecked)
            _visit.neckWeakness = "Yes";
        else _visit.neckWeakness = "No";

        if (Dysphagia_checkBox.IsChecked)
            _visit.Dysphagia = "Yes";
        else _visit.Dysphagia = "No";

        if (TregeminalNerve_checkBox.IsChecked)
            _visit.tregeminalNerve = "Yes";
        else _visit.tregeminalNerve = "No";

        if (Neuralgia_checkBox.IsChecked)
            _visit.tregeminalNeuralgia = "Yes";
        else _visit.tregeminalNeuralgia = "No";

        if (AtypicalPain_checkBox.IsChecked)
            _visit.tregeminalAtypicalPain = "Yes";
        else _visit.tregeminalAtypicalPain = "No";

        if (TregminalParesthesiae_checkBox.IsChecked)
            _visit.tregeminalParesthesiae = "Yes";
        else _visit.tregeminalParesthesiae = "No";

        if (Hypoesthesiae_checkBox.IsChecked)
            _visit.TregeminalHypoesthesiae = "Yes";
        else _visit.TregeminalHypoesthesiae = "No";

        if (MotorUpperExtremities_checkBox.IsChecked)
            _visit.motorUpperExtremities = "Yes";
        else _visit.motorUpperExtremities = "No";

        if (MotorLowerExtremities_checkBox.IsChecked)
            _visit.motorLowerExtremities = "Yes";
        else _visit.motorLowerExtremities = "No";

        if (AtaxiaUpperExtremities_checkBox.IsChecked)
            _visit.AtaxiaUpperExtremities = "Yes";
        else _visit.AtaxiaUpperExtremities = "No";

        if (AtaxiaLowerExtremities_checkBox.IsChecked)
            _visit.AtaxiaLowerExtremities = "Yes";
        else _visit.AtaxiaLowerExtremities = "No";

        if (GaitDisturbanceParesis_checkBox.IsChecked)
            _visit.gaitParesis = "Yes";
        else _visit.gaitParesis = "No";

        if (GaitDisturbanceAtaxia_checkBox.IsChecked)
            _visit.gaitAtaxia = "Yes";
        else _visit.gaitAtaxia = "No";

        if (GaitDisturbanceSpasticity_checkBox.IsChecked)
            _visit.GaitSpasticity = "Yes";
        else _visit.GaitSpasticity = "No";

        if (Tremor_checkBox.IsChecked)
            _visit.tremor = "Yes";
        else _visit.tremor = "No";

        if (Dysaesthesiae_checkBox.IsChecked)
            _visit.Dysaesthesiae = "Yes";
        else _visit.Dysaesthesiae = "No";

        if (PainHeadeche_checkBox.IsChecked)
            _visit.painHeadeche = "Yes";
        else _visit.painHeadeche = "No";

        if (Hypotonia_checkBox.IsChecked)
            _visit.hypotonya = "Yes";
        else _visit.hypotonya = "No";

        if (Hypersalivation_checkBox.IsChecked)
            _visit.hypersalivation = "Yes";
        else _visit.hypersalivation = "No";

        if (TonicSpasms_checkBox.IsChecked)
            _visit.tonicspasms = "Yes";
        else _visit.tonicspasms = "No";

        if (Presth_checkBox.IsChecked)
            _visit.paresthesiae = "Yes";
        else _visit.paresthesiae = "No";

        if (Vertigo_checkBox.IsChecked)
            _visit.Vertigo = "Yes";
        else _visit.Vertigo = "No";

        if (HearingLoss_checkBox.IsChecked)
            _visit.hearingLoss = "Yes";
        else _visit.hearingLoss = "No";

        if (FacialPalsycheckBox.IsChecked)
            _visit.facialPalsy = "Yes";
        else _visit.facialPalsy = "No";

        if (Myokymia_checkBox.IsChecked)
            _visit.Myokymia = "Yes";
        else _visit.Myokymia = "No";

        if (Dysarthria_checkBox.IsChecked)
            _visit.Dysarthria = "Yes";
        else _visit.Dysarthria = "No";

        if (Hemispasm_checkBox.IsChecked)
            _visit.Hemispasm = "Yes";
        else _visit.Hemispasm = "No";

        if (Nausea_checkBox.IsChecked)
            _visit.Nausea = "Yes";
        else _visit.Nausea = "No";

        if (Vomiting_checkBox.IsChecked)
            _visit.vomiting = "Yes";
        else _visit.vomiting = "No";

        if (Hiccups_checkBox.IsChecked)
            _visit.Hiccups = "Yes";
        else _visit.Hiccups = "No";

        if (Nystagmus_checkBox.IsChecked)
            _visit.SymptomsNystagmus = "Yes";
        else _visit.SymptomsNystagmus = "No";

        if (Seizures_checkBox.IsChecked)
            _visit.Seizures = "Yes";
        else _visit.Seizures = "No";

        if (LhermittesSign_checkBox.IsChecked)
            _visit.lhermittesSign = "Yes";
        else _visit.lhermittesSign = "No";

        if (Micturition_checkBox.IsChecked)
            _visit.micturition = "Yes";
        else _visit.micturition = "No";

        if (DefecationProblems_checkBox.IsChecked)
            _visit.DefecationProblems = "Yes";
        else _visit.DefecationProblems = "No";

        if (SexualFunctionsProblems_checkBox.IsChecked)
            _visit.sexualFunctionsProblem = "Yes";
        else _visit.sexualFunctionsProblem = "No";

        if (MoodProblems_checkBox.IsChecked)
            _visit.moodProblems = "Yes";
        else _visit.moodProblems = "No";

        if (CognitionProblems_checkBox.IsChecked)
            _visit.Cognitionproblems = "Yes";
        else _visit.Cognitionproblems = "No";

        if (Fatigue_checkBox.IsChecked)
            _visit.fatigue = "Yes";
        else _visit.fatigue = "No";

        if (ExtrapyramidalSymtoms_checkBox.IsChecked)
            _visit.extrapyramidalSymtoms = "Yes";
        else _visit.extrapyramidalSymtoms = "No";

        if (HypotonicSpeech_checkBox.IsChecked)
            _visit.hypotonicSpeech = "Yes";
        else _visit.hypotonicSpeech = "No";

        if (NazoneSpeech_checkBox.IsChecked)
            _visit.nazoneSpeech = "Yes";
        else _visit.nazoneSpeech = "No";

        if (Hemiplegia_checkBox.IsChecked)
            _visit.hemiplegia = "Yes";
        else _visit.hemiplegia = "No";

        if (RespiratoryProblem_checkBox.IsChecked)
            _visit.respiratoryproblem = "Yes";
        else _visit.respiratoryproblem = "No";

        if (ExcessiveSweating_checkBox.IsChecked)
            _visit.excessiveSweating = "Yes";
        else _visit.excessiveSweating = "No";

        if (FluxationYes_radioButton.IsChecked)
            _visit.Fluxation = "Yes";
        else if (FluxationNo_radioButton.IsChecked)
            _visit.Fluxation = "No";
    }
        public void setSmptomsFields(Visit _visit)
	{
        if (_visit.blurredVission == "Yes")
            BlurredVision_checkBox.IsChecked = true;

        if (_visit.fielddefect == "Yes")
            FieldDefect_checkBox.IsChecked = true;

        if (_visit.oscillopsia == "Yes")
            Oscillopsia_checkBox.IsChecked = true;

        if (_visit.Diplopia == "Yes")
            DiplopiaGazeParesis_checkBox.IsChecked = true;

        if (_visit.neckWeakness == "Yes")
            NeckWeakness_checkBox.IsChecked = true;

        if (_visit.Dysphagia == "Yes")
            Dysphagia_checkBox.IsChecked = true;

        if (_visit.tregeminalNerve == "Yes")
            TregeminalNerve_checkBox.IsChecked = true;

        if (_visit.tregeminalNeuralgia == "Yes")
            Neuralgia_checkBox.IsChecked = true;

        if (_visit.tregeminalAtypicalPain == "Yes")
            AtypicalPain_checkBox.IsChecked = true;

        if (_visit.tregeminalParesthesiae == "Yes")
            TregminalParesthesiae_checkBox.IsChecked = true;

        if (_visit.TregeminalHypoesthesiae == "Yes")
            Hypoesthesiae_checkBox.IsChecked = true;

        if (_visit.motorUpperExtremities == "Yes")
            MotorUpperExtremities_checkBox.IsChecked = true;

        if (_visit.motorLowerExtremities == "Yes")
            MotorLowerExtremities_checkBox.IsChecked = true;

        if (_visit.AtaxiaUpperExtremities == "Yes")
            AtaxiaUpperExtremities_checkBox.IsChecked = true;

        if (_visit.AtaxiaLowerExtremities == "Yes")
            AtaxiaLowerExtremities_checkBox.IsChecked = true;

        if (_visit.gaitParesis == "Yes")
            GaitDisturbanceParesis_checkBox.IsChecked = true;

        if (_visit.gaitAtaxia == "Yes")
            GaitDisturbanceAtaxia_checkBox.IsChecked = true;

        if (_visit.GaitSpasticity == "Yes")
            GaitDisturbanceSpasticity_checkBox.IsChecked = true;

        if (_visit.tremor == "Yes")
            Tremor_checkBox.IsChecked = true;

        if (_visit.Dysaesthesiae == "Yes")
            Dysaesthesiae_checkBox.IsChecked = true;

        if (_visit.painHeadeche == "Yes")
            PainHeadeche_checkBox.IsChecked = true;

        if (_visit.hypotonya == "Yes")
            Hypotonia_checkBox.IsChecked = true;

        if (_visit.hypersalivation == "Yes")
            Hypersalivation_checkBox.IsChecked = true;

        if (_visit.tonicspasms == "Yes")
            TonicSpasms_checkBox.IsChecked = true;

        if (_visit.paresthesiae == "Yes")
            Presth_checkBox.IsChecked = true;

        if (_visit.Vertigo == "Yes")
            Vertigo_checkBox.IsChecked = true;

        if (_visit.hearingLoss == "Yes")
            HearingLoss_checkBox.IsChecked = true;

        if (_visit.facialPalsy == "Yes")
            FacialPalsycheckBox.IsChecked = true;

        if (_visit.Myokymia == "Yes")
            Myokymia_checkBox.IsChecked = true;

        if (_visit.Dysarthria == "Yes")
            Dysarthria_checkBox.IsChecked = true;

        if (_visit.Hemispasm == "Yes")
            Hemispasm_checkBox.IsChecked = true;

        if (_visit.Nausea == "Yes")
            Nausea_checkBox.IsChecked = true;

        if (_visit.vomiting == "Yes")
            Vomiting_checkBox.IsChecked = true;

        if (_visit.Hiccups == "Yes")
            Hiccups_checkBox.IsChecked = true;

        if (_visit.SymptomsNystagmus == "Yes")
            Nystagmus_checkBox.IsChecked = true;

        if (_visit.Seizures == "Yes")
            Seizures_checkBox.IsChecked = true;

        if (_visit.lhermittesSign == "Yes")
            LhermittesSign_checkBox.IsChecked = true;

        if (_visit.micturition == "Yes")
            Micturition_checkBox.IsChecked = true;

        if (_visit.DefecationProblems == "Yes")
            DefecationProblems_checkBox.IsChecked = true;

        if (_visit.sexualFunctionsProblem == "Yes")
            SexualFunctionsProblems_checkBox.IsChecked = true;

        if (_visit.moodProblems == "Yes")
            MoodProblems_checkBox.IsChecked = true;

        if (_visit.Cognitionproblems == "Yes")
            CognitionProblems_checkBox.IsChecked = true;

        if (_visit.fatigue == "Yes")
            Fatigue_checkBox.IsChecked = true;

        if (_visit.extrapyramidalSymtoms == "Yes")
            ExtrapyramidalSymtoms_checkBox.IsChecked = true;

        if (_visit.hypotonicSpeech == "Yes")
            HypotonicSpeech_checkBox.IsChecked = true;

        if (_visit.nazoneSpeech == "Yes")
            NazoneSpeech_checkBox.IsChecked = true;

        if (_visit.hemiplegia == "Yes")
            Hemiplegia_checkBox.IsChecked = true;

        if (_visit.respiratoryproblem == "Yes")
            RespiratoryProblem_checkBox.IsChecked = true;

        if (_visit.excessiveSweating == "Yes")
            ExcessiveSweating_checkBox.IsChecked = true;

        if (_visit.Fluxation == "Yes")
            FluxationYes_radioButton.IsChecked = true;
        if (_visit.Fluxation == "No")
            FluxationNo_radioButton.IsChecked = true;
    }
}