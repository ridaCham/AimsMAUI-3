namespace MAUIUI.Views;

public partial class PregnancyPage : ContentPage
{
    string _patientCode;

    public PregnancyPage(string patientCode)
	{
		InitializeComponent();
        _patientCode = patientCode;

        layout_Outcome.Children.Add(new OutcomeView(layout_Outcome));

    }
    private void Button_AddNewPregnancy_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AddNewPregnancyPage(_patientCode));
        
    }
    private void Button_SavePregnancy_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();

    }


}