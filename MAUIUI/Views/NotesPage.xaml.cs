namespace MAUIUI.Views;

public partial class NotesPage : ContentPage
{

	public NotesPage()
	{
		InitializeComponent();
	}
    private void Button_SaveNotesPage_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
    private void Button_CancelNotesPage_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();

    }
}