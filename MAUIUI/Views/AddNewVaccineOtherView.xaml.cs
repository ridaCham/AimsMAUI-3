namespace MAUIUI.Views;

public partial class AddNewVaccineOtherView : ContentView
{
    private readonly StackLayout _layout_VaccineOther;
    public AddNewVaccineOtherView(StackLayout layout_VaccineOther)
    {
        InitializeComponent();

        _layout_VaccineOther = layout_VaccineOther;
    }

    private void Button_SaveVaccineOther_Clicked(object sender, EventArgs e)
    {
        if (_layout_VaccineOther.Children[0] is not VaccineOtherView)
        {
            _layout_VaccineOther.Children.Clear();
            _layout_VaccineOther.Children.Add(new VaccineOtherView(_layout_VaccineOther));
        }
    }
}