namespace MAUIUI.Views;

public partial class AddNewOutcomeView : ContentView
{
    private readonly StackLayout _layout_Outcome;
	public AddNewOutcomeView(StackLayout layout_Outcome)
	{
		InitializeComponent();

        _layout_Outcome = layout_Outcome;
	}
    private void Button_SaveAddNewOutcome_Clicked(object sender, EventArgs e)
    {
        if (_layout_Outcome.Children[0] is not OutcomeView)
        {
            _layout_Outcome.Children.Clear();
            _layout_Outcome.Children.Add(new OutcomeView(_layout_Outcome));
        }
    }
    private void Button_CancelAddNewOutcome_Clicked(object sender, EventArgs e)
    {
        if (_layout_Outcome.Children[0] is not OutcomeView)
        {
            _layout_Outcome.Children.Clear();
            _layout_Outcome.Children.Add(new OutcomeView(_layout_Outcome));
        }

    }
}