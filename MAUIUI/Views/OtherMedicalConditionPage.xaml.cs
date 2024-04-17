namespace MAUIUI.Views;

public partial class OtherMedicalConditionPage : ContentPage
{
    string _patientCode;

    public OtherMedicalConditionPage(string patientCode)
    {
        InitializeComponent();
        _patientCode = patientCode;
        ChangeEnabled_DeathDate();
    }

    private void OutcomeDeath_radioButton_Checked(object sender, CheckedChangedEventArgs e)
    {
        ChangeEnabled_DeathDate();
    }

    private void ChangeEnabled_DeathDate()
    {
        //if (OutcomeDeath_radioButton.IsChecked)
        //{
        //    OtherMedicalOutcomeDate_textBox.IsEnabled = true;
        //    OtherMedicalOutcomeDate_textBox.BackgroundColor = Colors.White;
        //}
        //else
        //{
        //    OtherMedicalOutcomeDate_textBox.IsEnabled = false;
        //    OtherMedicalOutcomeDate_textBox.BackgroundColor = Colors.DarkGray;
        //    OtherMedicalOutcomeDate_textBox.Text = "";
        //}
    }

    private void Button_Save_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void Button_AddNew_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AddNewOtherMedicalConditionPage(_patientCode));
    }
}