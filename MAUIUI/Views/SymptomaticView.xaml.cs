namespace MAUIUI.Views;

public partial class SymptomaticView : ContentView
{
    private readonly StackLayout _layout_Symptomatic;

    public SymptomaticView(StackLayout layout_Symptomatic)
	{
		InitializeComponent();
        _layout_Symptomatic = layout_Symptomatic;
    }
    private void Button_AddNewSymptomaticView_Clicked(object sender, EventArgs e)
    {
        if (_layout_Symptomatic.Children[0] is not AddNewSymptomaticView)
        {
            _layout_Symptomatic.Children.Clear();
            _layout_Symptomatic.Children.Add(new AddNewSymptomaticView(_layout_Symptomatic));
        }
         
    }
}