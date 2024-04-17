namespace MAUIUI.Views;

public partial class VaccineCovidView : ContentView
{
    private readonly StackLayout _layout_VaccineCovid;

    public VaccineCovidView(StackLayout layout_VaccineCovid)
    {
        InitializeComponent();
        _layout_VaccineCovid = layout_VaccineCovid;
    }

    private void Button_AddNewVaccineCovid_Clicked(object sender, EventArgs e)
    {
        if (_layout_VaccineCovid.Children[0] is not AddNewVaccineCovidView)
        {

            _layout_VaccineCovid.Children.Clear();
            _layout_VaccineCovid.Children.Add(new AddNewVaccineCovidView(_layout_VaccineCovid));
        }
    }
}


