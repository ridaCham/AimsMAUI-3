namespace MAUIUI.Views;

public partial class AddNewVaccineHepatitisBView : ContentView
{
    private readonly StackLayout _layout_VaccineHepatitisB;
    public AddNewVaccineHepatitisBView(StackLayout layout_VaccineHepatitisB)
    {
        InitializeComponent();

        _layout_VaccineHepatitisB = layout_VaccineHepatitisB;
    }

    private void Button_SaveVaccineHepatitisB_Clicked(object sender, EventArgs e)
    {
        if (_layout_VaccineHepatitisB.Children[0] is not VaccineHepatitisBView)
        {
            _layout_VaccineHepatitisB.Children.Clear();
            _layout_VaccineHepatitisB.Children.Add(new VaccineHepatitisBView(_layout_VaccineHepatitisB));
        }
    }
}