namespace MAUIUI.Views;

public partial class AddNewPatientPage : ContentPage
{
	public AddNewPatientPage()
	{
		InitializeComponent();


    }
    private void Button_SaveAddNewPatient_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void NameField_textBoxChanged(object sender, TextChangedEventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(e.NewTextValue) && !e.NewTextValue.All(char.IsLetter))
        {
            ((Entry)sender).Text = e.OldTextValue;
        }
    }

    private void SurNameField_textBoxChanged(object sender, TextChangedEventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(e.NewTextValue) && !e.NewTextValue.All(char.IsLetter))
        {
            ((Entry)sender).Text = e.OldTextValue;
        }
    }

    private void TCEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(e.NewTextValue) && (!e.NewTextValue.All(char.IsDigit) || e.NewTextValue.Length > 11))
        {
            ((Entry)sender).Text = e.OldTextValue;
        }
    }
}