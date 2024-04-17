namespace MAUIUI.Views;

public partial class AddNewVaccineHepatitisAView : ContentView
{
    private readonly StackLayout _layout_VaccineHepatitisA;
    public AddNewVaccineHepatitisAView(StackLayout layout_VaccineHepatitisA)
    {
        InitializeComponent();

        _layout_VaccineHepatitisA = layout_VaccineHepatitisA;
    }
 
    private void Button_SaveVaccineHepatitisA_Clicked(object sender, EventArgs e)
    {
        if (_layout_VaccineHepatitisA.Children[0] is not VaccineHepatitisAView)
        {
            _layout_VaccineHepatitisA.Children.Clear();
            _layout_VaccineHepatitisA.Children.Add(new VaccineHepatitisAView(_layout_VaccineHepatitisA));
        }
    }
}