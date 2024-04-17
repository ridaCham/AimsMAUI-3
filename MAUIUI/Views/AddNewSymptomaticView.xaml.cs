namespace MAUIUI.Views;

public partial class AddNewSymptomaticView : ContentView
{
    private readonly StackLayout _layout_Symptomatic;

    public AddNewSymptomaticView(StackLayout layout_Symptomatic)
    {
        InitializeComponent();

        _layout_Symptomatic = layout_Symptomatic;
    }

    private void Button_SaveAddNewSymptomatic_Clicked(object sender, EventArgs e)
    {
        if (_layout_Symptomatic.Children[0] is not SymptomaticView)
        {
            _layout_Symptomatic.Children.Clear();
            _layout_Symptomatic.Children.Add(new SymptomaticView(_layout_Symptomatic));
        }
    }
    private void Button_CancelAddNewSymptomatic_Clicked(object sender, EventArgs e)
    {
        if (_layout_Symptomatic.Children[0] is not SymptomaticView)
        {
            _layout_Symptomatic.Children.Clear();
            _layout_Symptomatic.Children.Add(new SymptomaticView(_layout_Symptomatic));
        }

    }
}