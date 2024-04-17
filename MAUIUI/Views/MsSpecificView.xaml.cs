namespace MAUIUI.Views;

public partial class MsSpecificView : ContentView
{
    private readonly StackLayout _layout_MsSpecific;

    public MsSpecificView(StackLayout layout_MsSpecific)
	{
		InitializeComponent();
        _layout_MsSpecific = layout_MsSpecific;
    }
    private void Button_AddNewMsSpecific_Clicked(object sender, EventArgs e)
    {
        if (_layout_MsSpecific.Children[0] is not AddNewMsSpecificView)
        {
            _layout_MsSpecific.Children.Clear();
            _layout_MsSpecific.Children.Add(new AddNewMsSpecificView(_layout_MsSpecific));
        }

    }
}