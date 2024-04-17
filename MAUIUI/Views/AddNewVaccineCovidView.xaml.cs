namespace MAUIUI.Views;

public partial class AddNewVaccineCovidView : ContentView
{
    private readonly StackLayout _layout_VaccineCovid;
    public AddNewVaccineCovidView(StackLayout layout_VaccineCovid)
    {
        InitializeComponent();

        _layout_VaccineCovid = layout_VaccineCovid;
    }

    private void Button_SaveAddNewVaccineCovid_Clicked(object sender, EventArgs e)
    {
        if (_layout_VaccineCovid.Children[0] is not VaccineCovidView)
        {
            _layout_VaccineCovid.Children.Clear();
            _layout_VaccineCovid.Children.Add(new VaccineCovidView(_layout_VaccineCovid));
        }
    }
}