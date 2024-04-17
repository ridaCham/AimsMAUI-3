using MAUIUI.Business.Abstract;
using MAUIUI.Business.DependencyResoulver.AutofacResoulver;
using MAUIUI.Entities.Concrete;
using MAUIUI.Helpers;

namespace MAUIUI.Views;

public partial class AddNewMalignancyPage : ContentPage
{
    string _patientCode;
    IMalignancyService malignancyService;
    Malignancy _malignancy;

    public AddNewMalignancyPage(string patientCode)
    {
        InitializeComponent();
        _patientCode = patientCode;
        malignancyService = InstanceFactory.GetInstance<IMalignancyService>();
        _malignancy = new Malignancy();

        ChangeEnabled_DeathDate();
	}
     

    private bool setMalignancy()
    {
        _malignancy.PatientCode = _patientCode;
        if (setDateFieldHelper.ValidateUnnullableDate(MalignancyDateofDiagnosisDate_textBox)==null)
        {
            _malignancy.DateOfDiagnosis = MalignancyDateofDiagnosisDate_textBox.Date;
        }
        else return false;
        _malignancy.StateOfDiagnosis = StateDiagnosis_combobox.SelectedItem.ToString();
        _malignancy.SiteOfPrimaryCancer = InputValidator.CaseFormatter(SiteofPrimary_textbox.Text);
        if (setDateFieldHelper.ValidateNullableDate(MalignancyOutcomeDate_textBox) == null)
        {
            _malignancy.OutcomeDate = MalignancyOutcomeDate_textBox.Date;
        }
        else return false;
        _malignancy.HistologicalDiagnosis = InputValidator.CaseFormatter(Histological_textbox.Text);
        if (UnknownOutcome_radiobutton.IsChecked)
        {
            _malignancy.Outcome = "Unknown";
        }
        else if (Ongoing_radiobutton.IsChecked)
        {
            _malignancy.Outcome = "Ongoing";
        }
        else if (remission_radiobutton.IsChecked)
        {
            _malignancy.Outcome = "Remission";
        }
        /*else if (Death_radiobutton.IsChecked)
        //{
        //    _malignancy.Outcome = "Death";
        //}
        //if (NoTreatment_checkbox.IsChecked)
        //{
        //    _malignancy.NoTretmenet = "Yes";
        //}
        //else _malignancy.NoTretmenet = "No";
        //if (Surgery_checkbox.IsChecked)
        //{
        //    _malignancy.Surgery = "Yes";
        //}
        //else _malignancy.Surgery = "No";
        //if (Chemotherapy_checkbox.IsChecked)
        //{
        //    _malignancy.Chemotherapy = "Yes";
        //}
        //else _malignancy.Chemotherapy = "No";
        //if (Radiotherapy_checkbox.IsChecked)
        //{
        //    _malignancy.Radiotherapy = "Yes";
        //}
        //else _malignancy.Radiotherapy = "No";
        //if (NoTreatment_checkbox.IsChecked)
        //{
        //    _malignancy.NoTretmenet = "Yes";
        //}
        //else _malignancy.NoTretmenet = "No";
        //if (Surgery_checkbox.IsChecked)
        //{
        //    _malignancy.Surgery = "Yes";
        //}
        //else _malignancy.Surgery = "No";
        //if (Chemotherapy_checkbox.IsChecked)
        //{
        //    _malignancy.Chemotherapy = "Yes";
        //}
        //else _malignancy.Chemotherapy = "No";
        //if (Radiotherapy_checkbox.IsChecked)
        //{
        //    _malignancy.Radiotherapy = "Yes";
        //}
        //else _malignancy.Radiotherapy = "No";*/
        _malignancy.TretmenetOther = InputValidator.CaseFormatter(Other_textbox.Text);
        
        _malignancy.Remarks = InputValidator.CaseFormatter(remarks_textbox.Text);
        return true;
    }




    private void Button_Save_Clicked(object sender, EventArgs e)
    {
        if (setMalignancy() &&
                setDateFieldHelper.ValidateStartEndDate(this.MalignancyDateofDiagnosisDate_textBox, this.MalignancyOutcomeDate_textBox)==null)
        {
            malignancyService.Add(_malignancy);
            Navigation.PopAsync();
        }
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
}