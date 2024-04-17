namespace MAUIUI.Views;

public partial class FamilyDiseaseHistoryView : ContentView
{
    private StackLayout _layout { get; set; }
    public FamilyDiseaseHistoryView(StackLayout layout)
	{
        _layout = layout;
		InitializeComponent();
	}

    private void button_AddNew_Clicked(object sender, EventArgs e)
    {
        _layout.Children.Clear();
        _layout.Children.Add(new AddNewFamilyDiseaseHistoryView(_layout));
    }

}