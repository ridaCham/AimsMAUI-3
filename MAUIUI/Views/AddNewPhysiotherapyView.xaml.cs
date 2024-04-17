namespace MAUIUI.Views;

public partial class AddNewPhysiotherapyView : ContentView
{
    private readonly StackLayout _layout_Physiotherapy;

    public AddNewPhysiotherapyView(StackLayout layout_Physiotherapy)
    {
        InitializeComponent();

        _layout_Physiotherapy = layout_Physiotherapy;
    }

    private void Button_SaveAddNewPhysiotherapy_Clicked(object sender, EventArgs e)
    {
        if (_layout_Physiotherapy.Children[0] is not PhysiotherapyView)
        {
            _layout_Physiotherapy.Children.Clear();
            _layout_Physiotherapy.Children.Add(new PhysiotherapyView(_layout_Physiotherapy));
        }
    }
    private void Button_CancelAddNewPhysiotherapy_Clicked(object sender, EventArgs e)
    {
        if (_layout_Physiotherapy.Children[0] is not PhysiotherapyView)
        {
            _layout_Physiotherapy.Children.Clear();
            _layout_Physiotherapy.Children.Add(new PhysiotherapyView(_layout_Physiotherapy));
        }

    }
}