using MAUIUI.Business.Abstract;
using MAUIUI.Business.DependencyResoulver.AutofacResoulver;
using MAUIUI.Entities.Concrete;
using MAUIUI.Helpers;

namespace MAUIUI.Views;

public partial class AddNewOtherMedicalConditionPage : ContentPage
{
    string _patientCode;
    IOtherMedicalConditionService otherMedicalConditionService;
    OtherMedicalCondition _othermedicalcondition;
    public AddNewOtherMedicalConditionPage(string patientCode)
    {
        InitializeComponent();
        _patientCode = patientCode;
        ChangeEnabled_DeathDate();
        otherMedicalConditionService = InstanceFactory.GetInstance<IOtherMedicalConditionService>();
        _othermedicalcondition = new OtherMedicalCondition();
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
        if (setMalignancy() &&
                setDateFieldHelper.ValidateStartEndDate(this.OtherMedicalDateofDate_textBox, this.OtherMedicalOutcomeDate_textBox)==null)
        {
            otherMedicalConditionService.Add(_othermedicalcondition);
            Navigation.PopAsync();
        }
    }

    private bool setMalignancy()
    {

        _othermedicalcondition.PatientCode = _patientCode;
        if (setDateFieldHelper.ValidateUnnullableDate(OtherMedicalDateofDate_textBox)==null)
        {
            _othermedicalcondition.DateOfOnset = OtherMedicalDateofDate_textBox.Date;
        }
        else return false;
        if (setDateFieldHelper.ValidateNullableDate(OtherMedicalOutcomeDate_textBox)==null)
        {
            _othermedicalcondition.OutcomeDate = OtherMedicalOutcomeDate_textBox.Date;// == "  .  ." ? null : DateTime.Parse(OtherMedicalOutcomeDate_textBox.Text);
        }
        else return false;
        _othermedicalcondition.MedicalCondition = OtherMedicalCondition_comboBox.SelectedItem.ToString();
        if (SeverityMild_radioButton.IsChecked)
        {
            _othermedicalcondition.Severity = "Mild";
        }
        else if (SeverityModerate_radioButton.IsChecked)
        {
            _othermedicalcondition.Severity = "Moderate";
        }
        else if (SeveritySevere_radioButton.IsChecked)
        {
            _othermedicalcondition.Severity = "Severe";
        }
        else if (SeverityLife_Thereatening_radioButton.IsChecked)
        {
            _othermedicalcondition.Severity = "Life-thereatening";
        }

        if (OutcomeUnknown_radioButton.IsChecked)
        {
            _othermedicalcondition.Outcome = "Unknown";
        }
        else if (OutcomeOngoing_radioButton.IsChecked)
        {
            _othermedicalcondition.Outcome = "Ongoing";
        }
        else if (OutcomeRecovery_radioButton.IsChecked)
        {
            _othermedicalcondition.Outcome = "Recovery";
        }
        //Eksik isimlendirme

        //else if (OutcomeDeath_radioButton.IsChecked)
        //{
        //    _othermedicalcondition.Outcome = "Death";
        //}
        if (ResultinDeath_radioButton.IsChecked)
        {
            _othermedicalcondition.SeriousAdverseEvent = "Result in death";
        }
        else if (IsLife_radioButton.IsChecked)
        {
            _othermedicalcondition.SeriousAdverseEvent = "Is life-thereatening";
        }
        else if (Permanent_radioButton.IsChecked)
        {
            _othermedicalcondition.SeriousAdverseEvent = "Permanent/serious disability incapacity";
        }
        else if (Requires_radioButton.IsChecked)
        {
            _othermedicalcondition.SeriousAdverseEvent = "Requires/prolongs hospitalisation";
        }
        else if (Congenital_radioButton.IsChecked)
        {
            _othermedicalcondition.SeriousAdverseEvent = "Congenital anomaly/birth defect";
        }
        else if (Othermedicalimportant_radioButton.IsChecked)
        {
            _othermedicalcondition.SeriousAdverseEvent = "Other medical important condition";
        }

        if (DrugNotRelated_radioButton.IsChecked)
        {
            _othermedicalcondition.DrugRelationship = "Not_related";
        }
        else if (DrugRelated_radioButton.IsChecked)
        {
            _othermedicalcondition.DrugRelationship = "Related";
        }
        if (SeriousAdverse_checkBox.IsChecked)
        {
            _othermedicalcondition.IsSeriousAdverseEvent = "Yes";
        }
        else if (!SeriousAdverse_checkBox.IsChecked)
        {
            _othermedicalcondition.IsSeriousAdverseEvent = "No";
        }
        _othermedicalcondition.Tretmenet = DrugTreatment_comboBox.SelectedItem.ToString();
        _othermedicalcondition.Remarks = InputValidator.CaseFormatter(Remarks_textBox.Text);
        return true;
    }
}