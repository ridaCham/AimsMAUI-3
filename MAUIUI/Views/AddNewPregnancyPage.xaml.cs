namespace MAUIUI.Views;

public partial class AddNewPregnancyPage : ContentPage
{
	public AddNewPregnancyPage(string patientCode)
	{
		InitializeComponent();
        layout_Outcome.Children.Add(new OutcomeView(layout_Outcome));

    }
    private void Button_SaveAddNewPregnancy_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();

    }
    private void Button_CancelAddNewPregnancy_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();

    }

}