namespace MAUIUI.Views;

public partial class AddNewPilatesView : ContentView
{
    private readonly StackLayout _layout_Pilates;

    public AddNewPilatesView(StackLayout layout_Pilates)
    {
        InitializeComponent();

        _layout_Pilates = layout_Pilates;
    }

    private void Button_SaveAddNewPilates_Clicked(object sender, EventArgs e)
    {
        if (_layout_Pilates.Children[0] is not PilatesView)
        {
            _layout_Pilates.Children.Clear();
            _layout_Pilates.Children.Add(new PilatesView(_layout_Pilates));
        }
    }
    private void Button_CancelAddNewPilates_Clicked(object sender, EventArgs e)
    {
        if (_layout_Pilates.Children[0] is not PilatesView)
        {
            _layout_Pilates.Children.Clear();
            _layout_Pilates.Children.Add(new PilatesView(_layout_Pilates));
        }

    }
}