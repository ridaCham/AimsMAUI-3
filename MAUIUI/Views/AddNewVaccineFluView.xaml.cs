namespace MAUIUI.Views;

public partial class AddNewVaccineFluView : ContentView
{
    private readonly StackLayout _layout_VaccineFlu;
    public AddNewVaccineFluView(StackLayout layout_VaccineFlu)
    {
        InitializeComponent();

        _layout_VaccineFlu = layout_VaccineFlu;
    }

    private void Button_SaveVaccineFlu_Clicked(object sender, EventArgs e)
    {
        if (_layout_VaccineFlu.Children[0] is not VaccineFluView)
        {
            _layout_VaccineFlu.Children.Clear();
            _layout_VaccineFlu.Children.Add(new VaccineFluView(_layout_VaccineFlu));
        }
    }
}