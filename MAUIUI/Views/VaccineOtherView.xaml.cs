namespace MAUIUI.Views;

public partial class VaccineOtherView : ContentView
{
    private readonly StackLayout _layout_VaccineOther;

    public VaccineOtherView(StackLayout layout_VaccineOther)
    {
        InitializeComponent();
        _layout_VaccineOther = layout_VaccineOther;
    }

    private void Button_AddNewVaccineOther_Clicked(object sender, EventArgs e)
    {
        if (_layout_VaccineOther.Children[0] is not AddNewVaccineOtherView)
        {

            _layout_VaccineOther.Children.Clear();
            _layout_VaccineOther.Children.Add(new AddNewVaccineOtherView(_layout_VaccineOther));
        }
    }
}


