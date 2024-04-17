namespace MAUIUI.Views;

public partial class AddNewMsSpecificView : ContentView
{
    private readonly StackLayout _layout_MsSpecific;
    public AddNewMsSpecificView(StackLayout layout_MsSpecific)
    {
        InitializeComponent();

        _layout_MsSpecific = layout_MsSpecific;
    }

    private void Button_SaveAddNewMsSpecific_Clicked(object sender, EventArgs e)
    {
        if (_layout_MsSpecific.Children[0] is not MsSpecificView)
        {
            _layout_MsSpecific.Children.Clear();
            _layout_MsSpecific.Children.Add(new MsSpecificView(_layout_MsSpecific));
        }
    }
    private void Button_CancelAddNewMsSpecific_Clicked(object sender, EventArgs e)
    {
        if (_layout_MsSpecific.Children[0] is not MsSpecificView)
        {
            _layout_MsSpecific.Children.Clear();
            _layout_MsSpecific.Children.Add(new MsSpecificView(_layout_MsSpecific));
        }

    }
}