namespace MAUIUI.Views;

public partial class PhysiotherapyView : ContentView
{
    private readonly StackLayout _layout_Physiotherapy;

    public PhysiotherapyView(StackLayout layout_Physiotherapy)
    {
        InitializeComponent();
        _layout_Physiotherapy = layout_Physiotherapy;
    }
    private void Button_AddNewPhysiotherapy_Clicked(object sender, EventArgs e)
    {
        if (_layout_Physiotherapy.Children[0] is not AddNewPhysiotherapyView)
        {
            _layout_Physiotherapy.Children.Clear();
            _layout_Physiotherapy.Children.Add(new AddNewPhysiotherapyView(_layout_Physiotherapy));
        }

    }
}