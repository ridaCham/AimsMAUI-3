namespace MAUIUI.Views;

public partial class VaccineHepatitisBView : ContentView
{
    private readonly StackLayout _layout_VaccineHepatitisB;

    public VaccineHepatitisBView(StackLayout layout_VaccineHepatitisB)
    {
        InitializeComponent();
        _layout_VaccineHepatitisB = layout_VaccineHepatitisB;
    }


    private void Button_AddNewVaccineHepatitisB_Clicked(object sender, EventArgs e)
    {
        if (_layout_VaccineHepatitisB.Children[0] is not AddNewVaccineHepatitisBView)
        {

            _layout_VaccineHepatitisB.Children.Clear();
            _layout_VaccineHepatitisB.Children.Add(new AddNewVaccineHepatitisBView(_layout_VaccineHepatitisB));
        }
    }
}


