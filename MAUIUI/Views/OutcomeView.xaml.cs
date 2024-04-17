namespace MAUIUI.Views;

public partial class OutcomeView : ContentView
{
    private readonly StackLayout _layout_Outcome;

    public OutcomeView(StackLayout layout_Outcome)
	{
		InitializeComponent();
        _layout_Outcome = layout_Outcome;
	}
    private void button_AddOutcome_Clicked(object sender, EventArgs e)
    {
        if (_layout_Outcome.Children[0] is not AddNewOutcomeView)
        {
            _layout_Outcome.Children.Clear();
            _layout_Outcome.Children.Add(new AddNewOutcomeView(_layout_Outcome));
        }

    }
}