namespace MAUIUI.Views;

public partial class ImmunosuppressionAssociatedPage : ContentPage
{

    string _patientCode;

    public ImmunosuppressionAssociatedPage(string patientCode)
    {
        InitializeComponent();
        _patientCode = patientCode;

        ChangeEnabled_DeathDate();
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
        Navigation.PopAsync();
    }

    private void Button_AddNew_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AddNewImmunosuppressionAssociatedPage(_patientCode));
    }
}