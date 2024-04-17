namespace MAUIUI.Views;

public partial class YogeView : ContentView
{
    private readonly StackLayout _layout_Yoge;

    public YogeView(StackLayout layout_Yoge)
    {
        InitializeComponent();
        _layout_Yoge = layout_Yoge;
    }
    private void Button_AddNewYoge_Clicked(object sender, EventArgs e)
    {
        if (_layout_Yoge.Children[0] is not AddNewYogeView)
        {
            _layout_Yoge.Children.Clear();
            _layout_Yoge.Children.Add(new AddNewYogeView(_layout_Yoge));
        }

    }
}