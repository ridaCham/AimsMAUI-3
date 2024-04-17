namespace MAUIUI.Views;

public partial class VaccineHepatitisAView : ContentView
{
    private readonly StackLayout _layout_VaccineHepatitisA;

    public VaccineHepatitisAView(StackLayout layout_VaccineHepatitisA)
    {
        InitializeComponent();
        _layout_VaccineHepatitisA = layout_VaccineHepatitisA;
    }

 
    private void Button_AddNewVaccineHepatitisA_Clicked(object sender, EventArgs e)
    {
        if (_layout_VaccineHepatitisA.Children[0] is not AddNewVaccineHepatitisAView)
        {

            _layout_VaccineHepatitisA.Children.Clear();
            _layout_VaccineHepatitisA.Children.Add(new AddNewVaccineHepatitisAView(_layout_VaccineHepatitisA));
        }
    }
}


