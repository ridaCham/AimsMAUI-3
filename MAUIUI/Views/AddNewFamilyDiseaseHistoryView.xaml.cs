namespace MAUIUI.Views;

public partial class AddNewFamilyDiseaseHistoryView : ContentView
{
    private StackLayout _layout { get; set; }
    public AddNewFamilyDiseaseHistoryView(StackLayout layout)
	{
		_layout = layout;
        InitializeComponent();

    }

    private void button_Save_Clicked(object sender, EventArgs e)
    {
        _layout.Children.Clear();
        _layout.Children.Add(new FamilyDiseaseHistoryView(_layout));
    }
}