namespace MAUIUI.Views;

public partial class CovidPage : ContentPage
{
    string _patientCode;

    public CovidPage(string patientCode)
    {
        InitializeComponent();
        _patientCode = patientCode;
        ChangeEnabled_DeathDate();
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
        Navigation.PopAsync();
    }

    private void Button_AddNew_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AddNewCovidPage(_patientCode));
    }

    private void CheckBox_Symptomatic_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
         ChangeEnabled_SymptomaticFever();

    }
    private void ChangeEnabled_SymptomaticFever()
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