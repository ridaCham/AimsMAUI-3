using MAUIUI.Business.Abstract;
using MAUIUI.Business.DependencyResoulver.AutofacResoulver;
using MAUIUI.Entities.Concrete;
using MAUIUI.Helpers;

namespace MAUIUI.Views;

public partial class AddNewHerpesZosterPage : ContentPage
{
    string _patientCode;
    IHerpesZosterService herpesZosterService;
    HerpesZoster _herpesZoster;

    public AddNewHerpesZosterPage(string patientCode)
    {
        InitializeComponent();
        _patientCode = patientCode;
        ChangeEnabled_DeathDate();
        herpesZosterService = InstanceFactory.GetInstance<IHerpesZosterService>();
        _herpesZoster = new HerpesZoster();
    }

    public bool setHerpesZoster()
    {
        _herpesZoster.PatientCode = _patientCode;
        if (setDateFieldHelper.ValidateUnnullableDate(HerpesDateofDiagnosisDate_textBox)==null)
        {
            _herpesZoster.DateOfDiagnosis = HerpesDateofDiagnosisDate_textBox.Date;
        }
        else return false;

        if (setDateFieldHelper.ValidateNullableDate(HerpesOutcomeDate_textBox)==null)
        {
            _herpesZoster.OutcomeDate = HerpesOutcomeDate_textBox.Date ;
        }
        else return false;
        _herpesZoster.TreatmentModality = InputValidator.CaseFormatter(HerpesZosterTreatmnet_textBox.Text);
        if (OutUnknown_radioButton.IsChecked)
        {
            _herpesZoster.Outcome = "Unknown";
        }
        else if (OutRemission_radioButton.IsChecked)
        {
            _herpesZoster.Outcome = "Remission";
        }
        else if (Outngoing_radioButton.IsChecked)
        {
            _herpesZoster.Outcome = "Ongoing";
        }
        else if (RadioButton_Death.IsChecked)
        {
            _herpesZoster.Outcome = "Death";
        }

        _herpesZoster.Remarks = InputValidator.CaseFormatter(HerpesZosterRemarks_textBox.Text);
        return true;
    }
   


    private void RadioButton_Death_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        ChangeEnabled_DeathDate();
    }

    private void ChangeEnabled_DeathDate()
    {
        if (RadioButton_Death.IsChecked)
        {
            HerpesOutcomeDate_textBox.IsEnabled = true;
            HerpesOutcomeDate_textBox.BackgroundColor = Colors.White;
        }
        else
        {
            HerpesOutcomeDate_textBox.IsEnabled = false;
            HerpesOutcomeDate_textBox.BackgroundColor = Colors.DarkGray;
           // HerpesOutcomeDate_textBox.Text = "";
        }
    }

    private void Button_Save_Clicked(object sender, EventArgs e)
    {
        if (setHerpesZoster() &&
            setDateFieldHelper.ValidateStartEndDate(this.HerpesDateofDiagnosisDate_textBox, this.HerpesOutcomeDate_textBox) == null)
        {
            herpesZosterService.Add(_herpesZoster);
            Navigation.PopAsync();
        }
    }

}