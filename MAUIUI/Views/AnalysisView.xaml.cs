namespace MAUIUI.Views;

public partial class AnalysisView : ContentView
{
	public AnalysisView()
	{
		InitializeComponent();
	}

    private void Button_CancelAnalysis_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();


    }
}