namespace MAUIUI.Views;

public partial class VaccineFluView : ContentView
{
    private readonly StackLayout _layout_VaccineFlu;

    public VaccineFluView(StackLayout layout_VaccineFlu)
    {
        InitializeComponent();
        _layout_VaccineFlu = layout_VaccineFlu;
    }


    private void Button_AddNewVaccineFlu_Clicked(object sender, EventArgs e)
    {
        if (_layout_VaccineFlu.Children[0] is not AddNewVaccineFluView)
        {

            _layout_VaccineFlu.Children.Clear();
            _layout_VaccineFlu.Children.Add(new AddNewVaccineFluView(_layout_VaccineFlu));
        }
    }
}


