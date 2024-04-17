using MAUIUI.Business.Abstract;
using MAUIUI.Business.DependencyResoulver.AutofacResoulver;
using MAUIUI.Entities.Concrete;
using MAUIUI.Helpers;

namespace MAUIUI.Views;

public partial class AddNewVisitPage : ContentPage
{
    private Button? _disabledButtonLayoutSymptoms;
    private SymptomsView _symptomsView;
    private TestsView _testsView;
    private EDSSView _edssView;
    private string walkingVideoPath;
    IVisitService _VisitService;
    string _RecivedId;
    List<Visit> _visitlist;
    Visit _visit;
    List<string?> _CSFDates;
    string videoExtenssion;
    string audioExtenssion;
    string videoPath;
    string audioPath;

    public AddNewVisitPage(string selectedId)
    {
        InitializeComponent();
        _symptomsView = new SymptomsView();
        _testsView = new TestsView();
        _edssView = new EDSSView();
        _RecivedId = selectedId;
        _VisitService = InstanceFactory.GetInstance<IVisitService>();
        ChangeContentLayoutSymptoms(_symptomsView, Button_Symptoms);
    }





    private bool setVisits()
    {
        _visit.PatientCode = _RecivedId;
        if (setDateFieldHelper.ValidateUnnullableDate(VisitDate_textBox) == null)
            _visit.VisitDate = VisitDate_textBox.Date;
        else return false;

        if (FirstVisit_checkbox.IsChecked)
            _visit.firstVisit = "Yes";
        else _visit.firstVisit = "No";

        if (Administrative_checkbox.IsChecked)
            _visit.Administrative = "Yes";
        else _visit.Administrative = "No";

        if (Routine_checkbox.IsChecked)
            _visit.routine = "Yes";
        else _visit.routine = "No";

        if (SuspectedRelapse_checkbox.IsChecked)
            _visit.suspectedRelapse = "Yes";
        else _visit.suspectedRelapse = "No";

        if (Phone_checkbox.IsChecked)
            _visit.phone = "Yes";
        else _visit.phone = "No";

        if (Retrospective_checkbox.IsChecked)
            _visit.retrospective = "Yes";
        else _visit.retrospective = "No";

        //if (BlurredVision_checkBox.Checked)
        //    _visit.blurredVission = "Yes";
        //else _visit.blurredVission = "No";

        //if (FieldDefect_checkBox.Checked)
        //    _visit.fielddefect = "Yes";
        //else _visit.fielddefect = "No";

        //if (Oscillopsia_checkBox.Checked)
        //    _visit.oscillopsia = "Yes";
        //else _visit.oscillopsia = "No";

        //if (DiplopiaGazeParesis_checkBox.Checked)
        //    _visit.Diplopia = "Yes";
        //else _visit.Diplopia = "No";

        //if (NeckWeakness_checkBox.Checked)
        //    _visit.neckWeakness = "Yes";
        //else _visit.neckWeakness = "No";

        //if (Dysphagia_checkBox.Checked)
        //    _visit.Dysphagia = "Yes";
        //else _visit.Dysphagia = "No";

        //if (TregeminalNerve_checkBox.Checked)
        //    _visit.tregeminalNerve = "Yes";
        //else _visit.tregeminalNerve = "No";

        //if (Neuralgia_checkBox.Checked)
        //    _visit.tregeminalNeuralgia = "Yes";
        //else _visit.tregeminalNeuralgia = "No";

        //if (AtypicalPain_checkBox.Checked)
        //    _visit.tregeminalAtypicalPain = "Yes";
        //else _visit.tregeminalAtypicalPain = "No";

        //if (TregminalParesthesiae_checkBox.Checked)
        //    _visit.tregeminalParesthesiae = "Yes";
        //else _visit.tregeminalParesthesiae = "No";

        //if (Hypoesthesiae_checkBox.Checked)
        //    _visit.TregeminalHypoesthesiae = "Yes";
        //else _visit.TregeminalHypoesthesiae = "No";

        //if (MotorUpperExtremities_checkBox.Checked)
        //    _visit.motorUpperExtremities = "Yes";
        //else _visit.motorUpperExtremities = "No";

        //if (MotorLowerExtremities_checkBox.Checked)
        //    _visit.motorLowerExtremities = "Yes";
        //else _visit.motorLowerExtremities = "No";

        //if (AtaxiaUpperExtremities_checkBox.Checked)
        //    _visit.AtaxiaUpperExtremities = "Yes";
        //else _visit.AtaxiaUpperExtremities = "No";

        //if (AtaxiaLowerExtremities_checkBox.Checked)
        //    _visit.AtaxiaLowerExtremities = "Yes";
        //else _visit.AtaxiaLowerExtremities = "No";

        //if (GaitDisturbanceParesis_checkBox.Checked)
        //    _visit.gaitParesis = "Yes";
        //else _visit.gaitParesis = "No";

        //if (GaitDisturbanceAtaxia_checkBox.Checked)
        //    _visit.gaitAtaxia = "Yes";
        //else _visit.gaitAtaxia = "No";

        //if (GaitDisturbanceSpasticity_checkBox.Checked)
        //    _visit.GaitSpasticity = "Yes";
        //else _visit.GaitSpasticity = "No";

        //if (Tremor_checkBox.Checked)
        //    _visit.tremor = "Yes";
        //else _visit.tremor = "No";

        //if (Dysaesthesiae_checkBox.Checked)
        //    _visit.Dysaesthesiae = "Yes";
        //else _visit.Dysaesthesiae = "No";

        //if (PainHeadeche_checkBox.Checked)
        //    _visit.painHeadeche = "Yes";
        //else _visit.painHeadeche = "No";

        //if (Hypotonia_checkBox.Checked)
        //    _visit.hypotonya = "Yes";
        //else _visit.hypotonya = "No";

        //if (Hypersalivation_checkBox.Checked)
        //    _visit.hypersalivation = "Yes";
        //else _visit.hypersalivation = "No";

        //if (TonicSpasms_checkBox.Checked)
        //    _visit.tonicspasms = "Yes";
        //else _visit.tonicspasms = "No";

        //if (Presth_checkBox.Checked)
        //    _visit.paresthesiae = "Yes";
        //else _visit.paresthesiae = "No";

        //if (Vertigo_checkBox.Checked)
        //    _visit.Vertigo = "Yes";
        //else _visit.Vertigo = "No";

        //if (HearingLoss_checkBox.Checked)
        //    _visit.hearingLoss = "Yes";
        //else _visit.hearingLoss = "No";

        //if (FacialPalsycheckBox.Checked)
        //    _visit.facialPalsy = "Yes";
        //else _visit.facialPalsy = "No";

        //if (Myokymia_checkBox.Checked)
        //    _visit.Myokymia = "Yes";
        //else _visit.Myokymia = "No";

        //if (Dysarthria_checkBox.Checked)
        //    _visit.Dysarthria = "Yes";
        //else _visit.Dysarthria = "No";

        //if (Hemispasm_checkBox.Checked)
        //    _visit.Hemispasm = "Yes";
        //else _visit.Hemispasm = "No";

        //if (Nausea_checkBox.Checked)
        //    _visit.Nausea = "Yes";
        //else _visit.Nausea = "No";

        //if (Vomiting_checkBox.Checked)
        //    _visit.vomiting = "Yes";
        //else _visit.vomiting = "No";

        //if (Hiccups_checkBox.Checked)
        //    _visit.Hiccups = "Yes";
        //else _visit.Hiccups = "No";

        //if (Nystagmus_checkBox.Checked)
        //    _visit.SymptomsNystagmus = "Yes";
        //else _visit.SymptomsNystagmus = "No";

        //if (Seizures_checkBox.Checked)
        //    _visit.Seizures = "Yes";
        //else _visit.Seizures = "No";

        //if (LhermittesSign_checkBox.IsChecked)
        //    _visit.lhermittesSign = "Yes";
        //else _visit.lhermittesSign = "No";

        //if (Micturition_checkBox.IsChecked)
        //    _visit.micturition = "Yes";
        //else _visit.micturition = "No";

        //if (DefecationProblems_checkBox.IsChecked)
        //    _visit.DefecationProblems = "Yes";
        //else _visit.DefecationProblems = "No";

        //if (SexualFunctionsProblems_checkBox.IsChecked)
        //    _visit.sexualFunctionsProblem = "Yes";
        //else _visit.sexualFunctionsProblem = "No";

        //if (MoodProblems_checkBox.IsChecked)
        //    _visit.moodProblems = "Yes";
        //else _visit.moodProblems = "No";

        //if (CognitionProblems_checkBox.IsChecked)
        //    _visit.Cognitionproblems = "Yes";
        //else _visit.Cognitionproblems = "No";

        //if (Fatigue_checkBox.IsChecked)
        //    _visit.fatigue = "Yes";
        //else _visit.fatigue = "No";

        //if (ExtrapyramidalSymtoms_checkBox.IsChecked)
        //    _visit.extrapyramidalSymtoms = "Yes";
        //else _visit.extrapyramidalSymtoms = "No";

        //if (HypotonicSpeech_checkBox.IsChecked)
        //    _visit.hypotonicSpeech = "Yes";
        //else _visit.hypotonicSpeech = "No";

        //if (NazoneSpeech_checkBox.IsChecked)
        //    _visit.nazoneSpeech = "Yes";
        //else _visit.nazoneSpeech = "No";

        //if (Hemiplegia_checkBox.IsChecked)
        //    _visit.hemiplegia = "Yes";
        //else _visit.hemiplegia = "No";

        //if (RespiratoryProblem_checkBox.IsChecked)
        //    _visit.respiratoryproblem = "Yes";
        //else _visit.respiratoryproblem = "No";

        //if (ExcessiveSweating_checkBox.IsChecked)
        //    _visit.excessiveSweating = "Yes";
        //else _visit.excessiveSweating = "No";

        //if (FluxationYes_radioButton.IsChecked)
        //    _visit.Fluxation = "Yes";
        //else if (FluxationNo_radioButton.IsChecked)
        //    _visit.Fluxation = "No";

        if (MentationNormal_radioButton.IsChecked)
            _visit.MentionAndMood = "Normal";
        else if (MentationMild_radioButton.IsChecked)
            _visit.MentionAndMood = "Mild";
        else if (MentationModerate_radioButton.IsChecked)
            _visit.MentionAndMood = "Moderate";
        else if (MentationSevere_radioButton.IsChecked)
            _visit.MentionAndMood = "Severe";
        else _visit.MentionAndMood = null;

        if (CranialVisualAcuitiyNormal_radiobutton.IsChecked)
            _visit.VisualAcuity = "Normal";
        else if (CranialVisualAcuitiyMild_radiobutton.IsChecked)
            _visit.VisualAcuity = "Mild";
        else if (CranialVisualAcuitiyModerate_radiobutton.IsChecked)
            _visit.VisualAcuity = "Moderate";
        else if (CranialVisualAcuitiySevere_radiobutton.IsChecked)
            _visit.VisualAcuity = "Severe";
        else _visit.VisualAcuity = null;

        if (CranialFieldsNormal_radiobutton.IsChecked)
            _visit.FieldsDiscPupils = "Normal";
        else if (CranialFieldsMild_radiobutton.IsChecked)
            _visit.FieldsDiscPupils = "Mild";
        else if (CranialFieldsModerate_radiobutton.IsChecked)
            _visit.FieldsDiscPupils = "Moderate";
        else if (CranialFieldsSevere_radiobutton.IsChecked)
            _visit.FieldsDiscPupils = "Severe";
        else _visit.FieldsDiscPupils = null;
        //if (FluxationYes_radioButton.IsChecked)
        //    _visit.Fluxation = "Yes";
        //else if (FluxationNo_radioButton.IsChecked)
        _visit.Fluxation = "No";
        if (CranialEyeMoveNormal_radiobutton.IsChecked)
            _visit.EyeMovements = "Normal";
        else if (CranialEyeMoveMild_radiobutton.IsChecked)
            _visit.EyeMovements = "Mild";
        else if (CranialEyeMoveModerate_radiobutton.IsChecked)
            _visit.EyeMovements = "Moderate";
        else if (CranialEyeMoveSevere_radiobutton.IsChecked)
            _visit.EyeMovements = "Severe";
        else _visit.EyeMovements = null;

        if (CranialNystagmusNormal_radiobutton.IsChecked)
            _visit.Nystagmus = "Normal";
        else if (CranialNystagmusMild_radiobutton.IsChecked)
            _visit.Nystagmus = "Mild";
        else if (CranialNystagmusModerate_radiobutton.IsChecked)
            _visit.Nystagmus = "Moderate";
        else if (CranialNystagmusSevere_radiobutton.IsChecked)
            _visit.Nystagmus = "Severe";
        else _visit.Nystagmus = null;

        if (CranialPitozNormal_radiobutton.IsChecked)
            _visit.Pitoz = "Normal";
        else if (CranialPitozMild_radiobutton.IsChecked)
            _visit.Pitoz = "Mild";
        else if (CranialPitozModerate_radiobutton.IsChecked)
            _visit.Pitoz = "Moderate";
        else if (CranialPitozSevere_radiobutton.IsChecked)
            _visit.Pitoz = "Severe";
        else _visit.Pitoz = null;

        if (CranialLowerNervesNormal_radiobutton.IsChecked)
            _visit.LowerCranialNerves = "Normal";
        else if (CranialLowerNervesMild_radiobutton.IsChecked)
            _visit.LowerCranialNerves = "Mild";
        else if (CranialLowerNervesModerate_radiobutton.IsChecked)
            _visit.LowerCranialNerves = "Moderate";
        else if (CranialLowerNervesSevere_radiobutton.IsChecked)
            _visit.LowerCranialNerves = "Severe";
        else _visit.LowerCranialNerves = null;

        if (MotorRU0_radiobutton.IsChecked)
            _visit.MotorRU = "0";
        else if (MotorRU1_radiobutton.IsChecked)
            _visit.MotorRU = "1";
        else if (MotorRU2_radiobutton.IsChecked)
            _visit.MotorRU = "2";
        else if (MotorRU3_radiobutton.IsChecked)
            _visit.MotorRU = "3";
        else if (MotorRU4_radiobutton.IsChecked)
            _visit.MotorRU = "4";
        else if (MotorRU5_radiobutton.IsChecked)
            _visit.MotorRU = "5";
        else _visit.MotorRU = null;

        if (MotorLU0_radiobutton.IsChecked)
            _visit.MotorLU = "0";
        else if (MotorLU1_radiobutton.IsChecked)
            _visit.MotorLU = "1";
        else if (MotorLU2_radiobutton.IsChecked)
            _visit.MotorLU = "2";
        else if (MotorLU3_radiobutton.IsChecked)
            _visit.MotorLU = "3";
        else if (MotorLU4_radiobutton.IsChecked)
            _visit.MotorLU = "4";
        else if (MotorLU5_radiobutton.IsChecked)
            _visit.MotorLU = "5";
        else _visit.MotorLU = null;

        if (MotorRL0_radiobutton.IsChecked)
            _visit.MotorRL = "0";
        else if (MotorRL1_radiobutton.IsChecked)
            _visit.MotorRL = "1";
        else if (MotorRL2_radiobutton.IsChecked)
            _visit.MotorRL = "2";
        else if (MotorRL3_radiobutton.IsChecked)
            _visit.MotorRL = "3";
        else if (MotorRL4_radiobutton.IsChecked)
            _visit.MotorRL = "4";
        else if (MotorRL5_radiobutton.IsChecked)
            _visit.MotorRL = "5";
        else _visit.MotorRL = null;

        if (MotorLL0_radiobutton.IsChecked)
            _visit.MotorLL = "0";
        else if (MotorLL1_radiobutton.IsChecked)
            _visit.MotorLL = "1";
        else if (MotorLL2_radiobutton.IsChecked)
            _visit.MotorLL = "2";
        else if (MotorLL3_radiobutton.IsChecked)
            _visit.MotorLL = "3";
        else if (MotorLL4_radiobutton.IsChecked)
            _visit.MotorLL = "4";
        else if (MotorLL5_radiobutton.IsChecked)
            _visit.MotorLL = "5";
        else _visit.MotorLL = null;

        if (MotorNeckFlexion0_radiobutton.IsChecked)
            _visit.MotorNeckFlexion = "0";
        else if (MotorNeckFlexion1_radiobutton.IsChecked)
            _visit.MotorNeckFlexion = "1";
        else if (MotorNeckFlexion2_radiobutton.IsChecked)
            _visit.MotorNeckFlexion = "2";
        else if (MotorNeckFlexion3_radiobutton.IsChecked)
            _visit.MotorNeckFlexion = "3";
        else if (MotorNeckFlexion4_radiobutton.IsChecked)
            _visit.MotorNeckFlexion = "4";
        else if (MotorNeckFlexion5_radiobutton.IsChecked)
            _visit.MotorNeckFlexion = "5";
        else _visit.MotorNeckFlexion = null;

        if (MotorNeckExtation0_radiobutton.IsChecked)
            _visit.MotorNeckExtation = "0";
        else if (MotorNeckExtation1_radiobutton.IsChecked)
            _visit.MotorNeckExtation = "1";
        else if (MotorNeckExtation2_radiobutton.IsChecked)
            _visit.MotorNeckExtation = "2";
        else if (MotorNeckExtation3_radiobutton.IsChecked)
            _visit.MotorNeckExtation = "3";
        else if (MotorNeckExtation4_radiobutton.IsChecked)
            _visit.MotorNeckExtation = "4";
        //else if (MotorNeckExtation5_radiobutton.IsChecked)
        //    _visit.MotorNeckExtation = "5";
        //else _visit.MotorNeckExtation = null;

        if (DTRSUENormal_radiobutton.IsChecked)
            _visit.DTRSUE = "Normal";
        else if (DTRSUEMild_radiobutton.IsChecked)
            _visit.DTRSUE = "Mild";
        else if (DTRSUEModerate_radiobutton.IsChecked)
            _visit.DTRSUE = "Moderate";
        else if (DTRSUESevere_radiobutton.IsChecked)
            _visit.DTRSUE = "Severe";
        else _visit.DTRSUE = null;

        if (DTRSLENormal_radiobutton.IsChecked)
            _visit.DTRSLE = "Normal";
        else if (DTRSLEMild_radiobutton.IsChecked)
            _visit.DTRSLE = "Mild";
        else if (DTRSLEModerate_radiobutton.IsChecked)
            _visit.DTRSLE = "Moderate";
        else if (DTRSLESevere_radiobutton.IsChecked)
            _visit.DTRSLE = "Severe";
        else _visit.DTRSLE = null;

        if (SensoryRUNormal_radiobutton.IsChecked)
            _visit.SensoryRU = "Normal";
        else if (SensoryRUMild_radiobutton.IsChecked)
            _visit.SensoryRU = "Mild";
        else if (SensoryRUModerate_radiobutton.IsChecked)
            _visit.SensoryRU = "Moderate";
        else if (SensoryRUSevere_radiobutton.IsChecked)
            _visit.SensoryRU = "Severe";
        else _visit.SensoryRU = null;

        if (SensoryLUNormal_radiobutton.IsChecked)
            _visit.SensoryLU = "Normal";
        else if (SensoryLUMild_radiobutton.IsChecked)
            _visit.SensoryLU = "Mild";
        else if (SensoryLUModerate_radiobutton.IsChecked)
            _visit.SensoryLU = "Moderate";
        else if (SensoryLUSevere_radiobutton.IsChecked)
            _visit.SensoryLU = "Severe";
        else _visit.SensoryLU = null;

        if (SensoryRLNormal_radiobutton.IsChecked)
            _visit.SensoryRL = "Normal";
        else if (SensoryRLMild_radiobutton.IsChecked)
            _visit.SensoryRL = "Mild";
        else if (SensoryRLModerate_radiobutton.IsChecked)
            _visit.SensoryRL = "Moderate";
        else if (SensoryRLSevere_radiobutton.IsChecked)
            _visit.SensoryRL = "Severe";
        else _visit.SensoryRL = null;

        if (SensoryLLNormal_radiobutton.IsChecked)
            _visit.SensoryLL = "Normal";
        else if (SensoryLLMild_radiobutton.IsChecked)
            _visit.SensoryLL = "Mild";
        else if (SensoryLLModerate_radiobutton.IsChecked)
            _visit.SensoryLL = "Moderate";
        else if (SensoryLLSevere_radiobutton.IsChecked)
            _visit.SensoryLL = "Severe";
        else _visit.SensoryLL = null;

        if (CereballarUENormal_radioButton.IsChecked)
            _visit.CereballarUE = "Normal";
        else if (CereballarUEMild_radioButton.IsChecked)
            _visit.CereballarUE = "Mild";
        else if (CereballarUEModerate_radioButton.IsChecked)
            _visit.CereballarUE = "Moderate";
        else if (CereballarUESevere_radioButton.IsChecked)
            _visit.CereballarUE = "Severe";
        else _visit.CereballarUE = null;

        if (CereballarLENormal_radioButton.IsChecked)
            _visit.CereballarLE = "Normal";
        else if (CereballarLEMild_radioButton.IsChecked)
            _visit.CereballarLE = "Mild";
        else if (CereballarLEModerate_radioButton.IsChecked)
            _visit.CereballarLE = "Moderate";
        else if (CereballarLESevere_radioButton.IsChecked)
            _visit.CereballarLE = "Severe";
        else _visit.CereballarLE = null;

        if (GaitTruncBalanceNormal_radiobutton.IsChecked)
            _visit.GaitTruncBalance = "Normal";
        else if (GaitTruncBalanceMild_radiobutton.IsChecked)
            _visit.GaitTruncBalance = "Mild";
        else if (GaitTruncBalanceModerate_radiobutton.IsChecked)
            _visit.GaitTruncBalance = "Moderate";
        else if (GaitTruncBalanceSevere_radiobutton.IsChecked)
            _visit.GaitTruncBalance = "Severe";
        else _visit.GaitTruncBalance = null;

        if (BladderBowelNormal_radiobutton.IsChecked)
            _visit.BladderBowel = "Normal";
        else if (BladderBowelMild_radiobutton.IsChecked)
            _visit.BladderBowel = "Mild";
        else if (BladderBowelModerate_radiobutton.IsChecked)
            _visit.BladderBowel = "Moderate";
        else if (BladderBowelSevere_radiobutton.IsChecked)
            _visit.BladderBowel = "Severe";
        else _visit.BladderBowel = null;

        if (BabinskiRYes_radioButton.IsChecked)
            _visit.BabinskiR = "Yes";
        else if (BabinskiRNo_radioButton.IsChecked)
            _visit.BabinskiR = "No";

        if (BabinskiLYes_radioButton.IsChecked)
            _visit.BabinskiL = "Yes";
        else if (BabinskiLNo_radioButton.IsChecked)
            _visit.BabinskiL = "No";

        if (OrthostaticYes_radioButton.IsChecked)
            _visit.OrthostaticHypotension = "Yes";
        else if (OrthostaticNo_radioButton.IsChecked)
            _visit.OrthostaticHypotension = "No";

        if (MusculeToneRUNormal_radioButton.IsChecked)
            _visit.MuscleToneRU = "Normal";
        else if (MusculeToneRUHypotonia_radioButton.IsChecked)
            _visit.MuscleToneRU = "Hypotonia";
        else if (MusculeToneRUHypertoni_radioButton.IsChecked)
            _visit.MuscleToneRU = "Hypertonia";
        else _visit.MuscleToneRU = null;

        if (MusculeToneLUNormal_radioButton.IsChecked)
            _visit.MuscleToneLU = "Normal";
        else if (MusculeToneLUHypotonia_radioButton.IsChecked)
            _visit.MuscleToneLU = "Hypotonia";
        else if (MusculeToneLUHypertoni_radioButton.IsChecked)
            _visit.MuscleToneLU = "Hypertonia";
        else _visit.MuscleToneLU = null;

        if (MusculeToneRLNormal_radioButton.IsChecked)
            _visit.MuscleToneRL = "Normal";
        else if (MusculeToneRLHypotonia_radioButton.IsChecked)
            _visit.MuscleToneRL = "Hypotonia";
        else if (MusculeToneRLHypertoni_radioButton.IsChecked)
            _visit.MuscleToneRL = "Hypertonia";
        else _visit.MuscleToneRL = null;

        if (MusculeToneLLNormal_radioButton.IsChecked)
            _visit.MuscleToneLL = "Normal";
        else if (MusculeToneLLHypotonia_radioButton.IsChecked)
            _visit.MuscleToneLL = "Hypotonia";
        else if (MusculeToneLLHypertoni_radioButton.IsChecked)
            _visit.MuscleToneLL = "Hypertonia";
        else _visit.MuscleToneLL = null;


        _visit.ExaminatedBy = Examinedby_combobox.SelectedItem.ToString();
        _visit.Height = Height_textbox.Text;
        _visit.Weight = Weight_textBox.Text;
        _visit.BMI = BMI_textBox.Text;
        _visit.BloodPressure = BloodPressure_textBox1.Text;
        _visit.BloodPressureBase = BloodPressure_textBox2.Text;
        _visit.Temperature = Temperature_textBox.Text;
        _visit.TemperaturePulse = Pulse_textBox.Text;
        _visit.CountsOneBreath = Counts_textBox.Text;
        //_visit.Total = AddNewVisitTotal_textbox.Text;
        _visit.Remarks = Remarks_textbox.Text;


        return true;
    }

    private void Button_Tests_Clicked(object sender, EventArgs e)
    {
        ChangeContentLayoutSymptoms(_testsView, Button_Tests);
    }

    private void Button_EDSS_Clicked(object sender, EventArgs e)
    {
        ChangeContentLayoutSymptoms(_edssView, Button_EDSS);
    }

    private async void Button_WalkingVideo_Clicked(object sender, EventArgs e)
    {
        try
        {
            var options = new PickOptions
            {
                FileTypes = FilePickerFileType.Videos
            };
            var file = await FilePicker.PickAsync(options);
            if (file != null)
            {
                walkingVideoPath = file.FullPath;
            }
        }
        catch (Exception ex)
        {
            // Hata durumunda i lemler
        }
    }

    private async void Button_SpeechVoice_Clicked(object sender, EventArgs e)
    {
        try
        {
            var file = await FilePicker.PickAsync();
            if (file != null)
            {
                walkingVideoPath = file.FullPath;
            }
        }
        catch (Exception ex)
        {
            // Hata durumunda i lemler
        }
    }

    private void Button_AddNewVisit_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AddNewVisitPage(_RecivedId));
    }

    private void Button_Save_Clicked(object sender, EventArgs e)
    {
        if (_visit == null)
        {
            _visit = new Visit();
            if (setVisits())
            {
                _VisitService.Add(_visit);
                //if (videoPath != null)
                //{
                //    _visit.VideoPath = "VisitVideos/" + _visit.PatientCode + "-" + _visit.Id + videoExtenssion;
                //    File.Copy(videoPath, _visit.VideoPath);
                //}
                //if (audioPath != null)
                //{
                //    _visit.AudioPath = "VisitAudios/" + _visit.PatientCode + "-" + _visit.Id + audioExtenssion;
                //    File.Copy(audioPath, _visit.AudioPath);
                //}
                //_VisitService.Update(_visit);
                Navigation.PopAsync();
            }
        }
        else
        {
            if (setVisits())
            {
                _VisitService.Add(_visit);
                //if (videoPath != null)
                //{
                //    _visit.VideoPath = "VisitVideos/" + _visit.PatientCode + "-" + _visit.Id + videoExtenssion;
                //    File.Copy(videoPath, _visit.VideoPath);
                //}
                //if (audioPath != null)
                //{
                //    _visit.AudioPath = "VisitAudios/" + _visit.PatientCode + "-" + _visit.Id + audioExtenssion;
                //    File.Copy(audioPath, _visit.AudioPath);
                //}
                //_VisitService.Update(_visit);
                Navigation.PopAsync();
            }
        }
    }

    private void Button_Symptoms_Clicked(object sender, EventArgs e)
    {
        ChangeContentLayoutSymptoms(_symptomsView, Button_Symptoms);
    }

    private void ChangeContentLayoutSymptoms(ContentView contentView, Button contentButton)
    {
        if (layout_Symptoms.Children.Count == 0)
        {
            layout_Symptoms.Children.Add(contentView);
            contentButton.IsEnabled = false;
            _disabledButtonLayoutSymptoms = contentButton;
        }
        if (layout_Symptoms.Children[0].GetType() != contentView.GetType())
        {
            _disabledButtonLayoutSymptoms.IsEnabled = true;
            contentButton.IsEnabled = false;
            _disabledButtonLayoutSymptoms = contentButton;

            layout_Symptoms.Children.Clear();
            layout_Symptoms.Children.Add(contentView);
        }
    }

}