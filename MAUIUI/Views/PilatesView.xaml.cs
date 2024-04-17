namespace MAUIUI.Views;

public partial class PilatesView : ContentView
{
    private readonly StackLayout _layout_Pilates;

    public PilatesView(StackLayout layout_Pilates)
    {
        InitializeComponent();
        _layout_Pilates = layout_Pilates;
    }

    private void Button_AddNewPilates_Clicked(object sender, EventArgs e)
    {
        if (_layout_Pilates.Children[0] is not AddNewPilatesView)
        {
            _layout_Pilates.Children.Clear();
            _layout_Pilates.Children.Add(new AddNewPilatesView(_layout_Pilates));
        }
    }
}