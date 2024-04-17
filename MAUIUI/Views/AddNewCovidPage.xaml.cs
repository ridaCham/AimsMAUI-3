using MAUIUI.Business.Abstract;
using MAUIUI.Business.DependencyResoulver.AutofacResoulver;
using MAUIUI.Entities.Concrete;
using MAUIUI.Helpers;

namespace MAUIUI.Views;

public partial class AddNewCovidPage : ContentPage
{
    string _patientCode;
    ICovid19Service covid19Service;
    Covid19 _covid19;
    public AddNewCovidPage(string patientCode)
    {
        InitializeComponent();
        _patientCode = patientCode;
        ChangeEnabled_DeathDate();
        covid19Service = InstanceFactory.GetInstance<ICovid19Service>();
        _covid19 = new Covid19();
    }


    public bool setCovid19()
    {

        _covid19.PatientCode = _patientCode;
        if (setDateFieldHelper.ValidateUnnullableDate(CovidDateofOnsetDate_textBox)==null)
        {
            _covid19.DateOfOnset = CovidDateofOnsetDate_textBox.Date;
        }
        else return false;

        if (setDateFieldHelper.ValidateNullableDate(CovidConfirmedDiagnosisDate_textBox)==null)
        {
            _covid19.ConfirmedDiagnosisDate = CovidConfirmedDiagnosisDate_textBox.Date;
        }
        else return false;
        _covid19.ConfirmedByPCR = ConfirmedPCR_comboBox.SelectedItem.ToString();
        _covid19.ConfirmedBySerology = Serology_comboBox.SelectedItem.ToString();
        _covid19.ConfirmedByTypicalChestImaging = Typical_comboBox.SelectedItem.ToString();
        //eksik
        //_covid19.DMTCeased = InputValidator.CaseFormatter(DMTceased_textBox.Text);
        _covid19.SymptomaticOther = InputValidator.CaseFormatter(OtherrSymptomatic_textBox.Text);
        if (PregnancyUnknown_radioButton.IsChecked)
        {
            _covid19.Pregnancy = "Unknown";
        }
        else if (PregnancyYes_radioButton.IsChecked)
        {
            _covid19.Pregnancy = "Yes";
        }
        else if (PregnancyNo_radioButton.IsChecked)
        {
            _covid19.Pregnancy = "No";
        }
        if (CurrentUnknown_radioButton.IsChecked)
        {
            _covid19.CurrentSmoker = "Unknown";
        }
        else if (CurrentYes_radioButton.IsChecked)
        {
            _covid19.CurrentSmoker = "Yes";
        }
        else if (CurrentNo_radioButton.IsChecked)
        {
            _covid19.CurrentSmoker = "No";
        }
        if (ObesityUnknown_radioButton.IsChecked)
        {
            _covid19.Obesity = "Unknown";
        }
        else if (ObesityYes_radioButton.IsChecked)
        {
            _covid19.Obesity = "Yes";
        }
        else if (ObesityNo_radioButton.IsChecked)
        {
            _covid19.Obesity = "No";
        }
        if (OtherComorUnknown_radioButton.IsChecked)
        {
            _covid19.OtherComorbidities = "Unknown";
        }
        else if (OtherComorYes_radioButton.IsChecked)
        {
            _covid19.OtherComorbidities = "Yes";
        }
        else if (OtherComorNo_radioButton.IsChecked)
        {
            _covid19.OtherComorbidities = "No";
        }
        if (CovidSymptomatic_checkBox.IsChecked)
        {
            _covid19.Symptomatic = "Yes";
        }
        else _covid19.Symptomatic = "No";
        if (CovidFever_checkBox.IsChecked)
        {
            _covid19.SymptomaticFever = "Yes";
        }
        else _covid19.SymptomaticFever = "No";
        if (CovidFatigue_checkBox.IsChecked)
        {
            _covid19.SymptomaticFatigue = "Yes";
        }
        else _covid19.SymptomaticFatigue = "No";
        if (CovidDryCough_checkBox.IsChecked)
        {
            _covid19.SymptomaticDryCough = "Yes";
        }
        else _covid19.SymptomaticDryCough = "No";
        if (CovidPneumonia_checkBox.IsChecked)
        {
            _covid19.SymptomaticPneumonia = "Yes";
        }
        else _covid19.SymptomaticPneumonia = "No";
        if (CovidSore_checkBox.IsChecked)
        {
            _covid19.SymptomaticSoreThroat = "Yes";
        }
        else _covid19.SymptomaticSoreThroat = "No";
        if (CovidAnosmia_checkBox.IsChecked)
        {
            _covid19.SymptomaticAnosmia = "Yes";
        }
        else _covid19.SymptomaticAnosmia = "No";
        if (CovidPain_checkBox.IsChecked)
        {
            _covid19.SymptomaticPain = "Yes";
        }
        else _covid19.SymptomaticPain = "No";
        if (CovidDiarrhea_checkBox.IsChecked)
        {
            _covid19.SymptomaticDiarrhea = "Yes";
        }
        else _covid19.SymptomaticDiarrhea = "No";
        //if (CovidSeverity_checkBox.Checked)
        //{
        //    _covid19.Severity = "Yes";
        //}
        //else _covid19.Severity = "No";
        if (CovidSevSevere_checkBox.IsChecked)
        {
            _covid19.SeveritySevere = "Yes";
        }
        else _covid19.SeveritySevere = "No";
        if (CovidSevMild_checkBox.IsChecked)
        {
            _covid19.SeverityMild = "Yes";
        }
        else _covid19.SeverityMild = "No";
        if (CovidSevModarate_checkBox.IsChecked)
        {
            _covid19.SeverityModarate = "Yes";
        }
        else _covid19.SeverityModarate = "No";
        if (CovidSevUnknown_checkBox.IsChecked)
        {
            _covid19.SeverityUnkonwn = "Yes";
        }
        else _covid19.SeverityUnkonwn = "No";
        //if (DMTceased_checkBox.IsChecked)
        //{
        //    _covid19.DMTCeased = "Yes";
        //}
        //else _covid19.DMTCeased = "No";
        if (OtherMedicalCVS_checkBox.IsChecked)
        {
            _covid19.CVSHypertension = "Yes";
        }
        else _covid19.CVSHypertension = "No";
        if (OtherMedicalDiabetes_checkBox.IsChecked)
        {
            _covid19.Diabetes = "Yes";
        }
        else _covid19.Diabetes = "No";
        if (OtherMedicalMalignancy_checkBox.IsChecked)
        {
            _covid19.Malignancy = "Yes";
        }
        else _covid19.Malignancy = "No";
        if (OtherMedicalRenal_checkBox.IsChecked)
        {
            _covid19.RenalDisease = "Yes";
        }
        else _covid19.RenalDisease = "No";
        if (OtherMedicalChronic_checkBox.IsChecked)
        {
            _covid19.chronicLungDisease = "Yes";
        }
        else _covid19.chronicLungDisease = "No";
        if (OtherMedicalLiver_checkBox.IsChecked)
        {
            _covid19.LiverDisease = "Yes";
        }
        else _covid19.LiverDisease = "No";
        if (LabHospitalAdmission_checkBox.IsChecked)
        {
            _covid19.LaboratoireAdmition = "Yes";
        }
        else _covid19.LaboratoireAdmition = "No";
        if (HospitalAdmission_checkBox.IsChecked)
        {
            _covid19.HospitalAdmition = "Yes";
        }
        else _covid19.HospitalAdmition = "No";
        if (ICUAdmission_checkBox.IsChecked)
        {
            _covid19.ICUAdmition = "Yes";
        }
        else _covid19.ICUAdmition = "No";
        if (Ventilation_checkBox.IsChecked)
        {
            _covid19.VentilationBox = "Yes";
        }
        else _covid19.VentilationBox = "No";
        if (EcmoRequired_checkBox.IsChecked)
        {
            _covid19.ECMO = "Yes";
        }
        else _covid19.ECMO = "No";
        if (setDateFieldHelper.ValidateNullableDate(CovidHospitalFromDate_textBox)==null)
        {
            _covid19.HospitalAdmitionStart = CovidHospitalFromDate_textBox.Date;// == "  .  ." ? null : DateTime.Parse(CovidHospitalFromDate_textBox.Text);
        }
        else return false;
        if (setDateFieldHelper.ValidateNullableDate(CovidHospitalToDate_textBox)==null)
        {
            _covid19.HospitalAdmitionEnd = CovidHospitalToDate_textBox.Date;// == "  .  ." ? null : DateTime.Parse(CovidHospitalToDate_textBox.Text);
        }
        else return false;
        if (setDateFieldHelper.ValidateNullableDate(CovidIcuFromDate_textBox)==null)
        {
            _covid19.ICUAdmitionStart = CovidIcuFromDate_textBox.Date;// == "  .  ." ? null : DateTime.Parse(CovidIcuFromDate_textBox.Text);
        }
        else return false;
        if (setDateFieldHelper.ValidateNullableDate(CovidIcuToDate_textBox)==null)
        {
            _covid19.ICUAdmitionEnd = CovidIcuToDate_textBox.Date;// == "  .  ." ? null : DateTime.Parse(CovidIcuToDate_textBox.Text);
        }
        else return false;
        _covid19.Ventilation = Ventilation_comboBox.SelectedItem.ToString();
        //_covid19.LymphocyteCount =int.Parse(LabLymphocyte_textBox.Text);

        if (!string.IsNullOrEmpty(LabLymphocyte_textBox.Text))
        {
            _covid19.LymphocyteCount = int.Parse(LabLymphocyte_textBox.Text);
        }
        if (setDateFieldHelper.ValidateNullableDate(CovidLaboratoryLymphocyteDate_textBox)==null)
        {
            _covid19.LymphocyteExamDate = CovidLaboratoryLymphocyteDate_textBox.Date;
        }
        else return false;
        _covid19.WhiteCellCount = LabWhile_textBox.Text;
        if (setDateFieldHelper.ValidateNullableDate(CovidLaboratoryWhileDate_textBox)==null)
        {
            _covid19.WhiteCellExamDate = CovidLaboratoryWhileDate_textBox.Date;// == "  .  ." ? null : DateTime.Parse(CovidLaboratoryWhileDate_textBox.Text);
        }
        else return false;
        _covid19.CD19BCount = LabCD19_textBox.Text;
        if (setDateFieldHelper.ValidateNullableDate(CovidLaboratoryCdDate_textBox)==null)
        {
            _covid19.CD19BExamDate = CovidLaboratoryCdDate_textBox.Date;// == "  .  ." ? null : DateTime.Parse(CovidLaboratoryCdDate_textBox.Text);
        }
        else return false;

        _covid19.Remarks = InputValidator.CaseFormatter(CovidRemarks_textBox.Text);
        if (CovidOutUnknown_radioButton.IsChecked)
        {
            _covid19.Outcome = "Unknown";
        }
        else if (CovidOutOngoing_radioButton.IsChecked)
        {
            _covid19.Outcome = "Ongoing";
        }
        else if (CovidOutRemission_radioButton.IsChecked)
        {
            _covid19.Outcome = "Remission";
        }
        else if (CovidOutDeath_radioButton.IsChecked)
        {
            _covid19.Outcome = "Death";
        }
        if (setDateFieldHelper.ValidateNullableDate(CovidOutcomeDate_textBox)==null)
        {
            _covid19.OutcomeDate = CovidOutcomeDate_textBox.Date;// == "  .  ." ? null : DateTime.Parse(CovidOutcomeDate_textBox.Text);
        }
        else return false;


        return true;
    }
     








    private void RadioButton_Death_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        ChangeEnabled_DeathDate();
    }

    private void ChangeEnabled_DeathDate()
    {
        //if (RadioButton_Death.IsChecked)
        //{
        //    Entry_DeathDate.IsEnabled = true;
        //    Entry_DeathDate.BackgroundColor = Colors.White;
        //}
        //else
        //{
        //    Entry_DeathDate.IsEnabled = false;
        //    Entry_DeathDate.BackgroundColor = Colors.DarkGray;
        //    Entry_DeathDate.Text = "";
        //}
    }

    private void Button_Save_Clicked(object sender, EventArgs e)
    {

        if (setCovid19() && setDateFieldHelper.ValidateStartEndDate(this.CovidHospitalFromDate_textBox, this.CovidHospitalToDate_textBox) == null

            && setDateFieldHelper.ValidateStartEndDate(this.CovidIcuFromDate_textBox, this.CovidIcuToDate_textBox) == null &&
            setDateFieldHelper.ValidateStartEndDate(this.CovidDateofOnsetDate_textBox, this.CovidOutcomeDate_textBox) == null &&
            setDateFieldHelper.ValidateStartEndDate(this.CovidDateofOnsetDate_textBox, this.CovidConfirmedDiagnosisDate_textBox) == null &&
            setDateFieldHelper.ValidateStartEndDate(this.CovidDateofOnsetDate_textBox, this.CovidHospitalFromDate_textBox) == null &&
            setDateFieldHelper.ValidateStartEndDate(this.CovidDateofOnsetDate_textBox, this.CovidIcuFromDate_textBox) == null &&
            setDateFieldHelper.ValidateStartEndDate(this.CovidDateofOnsetDate_textBox, this.CovidLaboratoryLymphocyteDate_textBox) == null &&
            setDateFieldHelper.ValidateStartEndDate(this.CovidDateofOnsetDate_textBox, this.CovidLaboratoryWhileDate_textBox) == null &&
            setDateFieldHelper.ValidateStartEndDate(this.CovidDateofOnsetDate_textBox, this.CovidLaboratoryCdDate_textBox) == null)
        {
            covid19Service.Add(_covid19);
            Navigation.PopAsync();
        }
    }

    private void Button_AddNew_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AddNewCovidPage(_patientCode));
    }
}