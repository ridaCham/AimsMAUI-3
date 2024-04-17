using MAUIUI.Business.Abstract;
using MAUIUI.Business.DependencyResoulver.AutofacResoulver;
using MAUIUI.Entities.Concrete;
using MAUIUI.Helpers;

namespace MAUIUI.Views;

public partial class AddNewImmunosuppressionAssociatedPage : ContentPage
{
    string _patientCode;
    IImmunosuppressionService _immunosuppressionManager;
    Immunosuppression _immunosuppression;

    public AddNewImmunosuppressionAssociatedPage(string patientCode)
    {
        InitializeComponent();
        _patientCode = patientCode;
        ChangeEnabled_DeathDate();
        _immunosuppressionManager = InstanceFactory.GetInstance<IImmunosuppressionService>();
        _immunosuppression = new Immunosuppression();
    }


    private bool setImmunosuppression()
    {
        _immunosuppression.PatientCode = _patientCode;
        if (setDateFieldHelper.ValidateUnnullableDate(IdmmunoDateofDiagnosisDate_textBox)==null)
        {
            _immunosuppression.dateOfDiagnosis = IdmmunoDateofDiagnosisDate_textBox.Date;
        }
        else return false;

        _immunosuppression.ImmunosuppressionAssociate = Immunosuppression_textBox.Text;
        _immunosuppression.TreatmentModality = TreatmentModality_textBox.Text;
        if (OutcomeRUnknown_radioButton.IsChecked)
        {
            _immunosuppression.outcome = "Unknown";
        }
        else if (OutcomeOngoing_radioButton.IsChecked)
        {
            _immunosuppression.outcome = "Ongoing";
        }
        else if (OutcomeRemission_radioButton.IsChecked)
        {
            _immunosuppression.outcome = "Remission";
        }
        else if (OutcomeDeath_radioButton.IsChecked)
        {
            _immunosuppression.outcome = "Death";
        }
        else _immunosuppression.outcome = "  ";
        //if (setDateFieldHelper.ValidateNullableDate(ImmunoOutcomeDate_textBox))
        //{
        //    _immunosuppression.outcomeDate = ImmunoOutcomeDate_textBox.Text == "  .  ." ? null : DateTime.Parse(ImmunoOutcomeDate_textBox.Text);
        //}
        //else return false;
        _immunosuppression.Remarks = ImmuRemarks_textBox.Text;
        return true;
    }
   



    private void OutcomeDeath_radioButton_Changed(object sender, CheckedChangedEventArgs e)
    {
        ChangeEnabled_DeathDate();
    }

    private void ChangeEnabled_DeathDate()
    {
        if (OutcomeDeath_radioButton.IsChecked)
        {
            ImmunoOutcomeDate_textBox.IsEnabled = true;
            ImmunoOutcomeDate_textBox.BackgroundColor = Colors.White;
        }
        else
        {
            ImmunoOutcomeDate_textBox.IsEnabled = false;
            ImmunoOutcomeDate_textBox.BackgroundColor = Colors.DarkGray;
            ImmunoOutcomeDate_textBox.Text = "";
        }
    }

    private void Button_Save_Clicked(object sender, EventArgs e)
    {
        //ImmunoOutcomeDate_textBox dataPiker olacak
        if (setImmunosuppression() /*&&
            setDateFieldHelper.ValidateStartEndDate(this.IdmmunoDateofDiagnosisDate_textBox, this.ImmunoOutcomeDate_textBox) == null*/)
        {
            _immunosuppressionManager.Add(_immunosuppression);
            Navigation.PopAsync();
        }
    }
 
}