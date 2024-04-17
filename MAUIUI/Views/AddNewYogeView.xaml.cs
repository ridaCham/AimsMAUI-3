namespace MAUIUI.Views;

public partial class AddNewYogeView : ContentView
{
    private readonly StackLayout _layout_Yoge;

    public AddNewYogeView(StackLayout layout_Yoge)
    {
        InitializeComponent();

        _layout_Yoge = layout_Yoge;
    }

    private void Button_SaveAddNewYoge_Clicked(object sender, EventArgs e)
    {
        if (_layout_Yoge.Children[0] is not YogeView)
        {
            _layout_Yoge.Children.Clear();
            _layout_Yoge.Children.Add(new YogeView(_layout_Yoge));
        }
    }
    private void Button_CancelAddNewYoge_Clicked(object sender, EventArgs e)
    {
        if (_layout_Yoge.Children[0] is not YogeView)
        {
            _layout_Yoge.Children.Clear();
            _layout_Yoge.Children.Add(new YogeView(_layout_Yoge));
        }

    }
}