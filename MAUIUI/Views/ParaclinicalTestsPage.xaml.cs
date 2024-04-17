namespace MAUIUI.Views;

public partial class ParaclinicalTestsPage : ContentPage
{
    string _patientCode;
    public ParaclinicalTestsPage(string patientCode)
    {
        InitializeComponent();
        _patientCode = patientCode;
        layout_ParaclinicalTests.Children.Add(new ParaclinicalMRIView(layout_ParaclinicalTests, patientCode));

    }


    private void Button_ParaclinicalMRIView_Clicked(object sender, EventArgs e)
    {
        if (layout_ParaclinicalTests.Children[0] is not ParaclinicalMRIView)
        {
            layout_ParaclinicalTests.Children.Clear();
            layout_ParaclinicalTests.Children.Add(new ParaclinicalMRIView(layout_ParaclinicalTests, _patientCode));
        }

    }
    private void Button_ParaclinicalBloodChemistryView_Clicked(object sender, EventArgs e)
    {
        if (layout_ParaclinicalTests.Children[0] is not ParaclinicalBloodChemistryView)
        {
            layout_ParaclinicalTests.Children.Clear();
            layout_ParaclinicalTests.Children.Add(new ParaclinicalBloodChemistryView(layout_ParaclinicalTests, _patientCode));
        }

    }

    private void Button_ParaclinicalHaematologyView_Clicked(object sender, EventArgs e)
    {
        if (layout_ParaclinicalTests.Children[0] is not ParaclinicalHaematologyView)
        {
            layout_ParaclinicalTests.Children.Clear();
            layout_ParaclinicalTests.Children.Add(new ParaclinicalHaematologyView(layout_ParaclinicalTests, _patientCode));
        }
    }

    private void Button_ParaclinicalEvokedPotentialsView_Clicked(object sender, EventArgs e)
    {
        if (layout_ParaclinicalTests.Children[0] is not ParaclinicalEvokedPotentialsView)
        {
            layout_ParaclinicalTests.Children.Clear();
            layout_ParaclinicalTests.Children.Add(new ParaclinicalEvokedPotentialsView(layout_ParaclinicalTests, _patientCode));
        }
    }

    private void Button_ParaclinicalThyroidFunctionsView_Clicked(object sender, EventArgs e)
    {
        if (layout_ParaclinicalTests.Children[0] is not ParaclinicalThyroidFunctionsView)
        {
            layout_ParaclinicalTests.Children.Clear();
            layout_ParaclinicalTests.Children.Add(new ParaclinicalThyroidFunctionsView(layout_ParaclinicalTests, _patientCode));
        }
    }

    private void Button_ParaclinicalAutoAntibodyView_Clicked(object sender, EventArgs e)
    {
        if (layout_ParaclinicalTests.Children[0] is not ParaclinicalAutoAntibodyView)
        {
            layout_ParaclinicalTests.Children.Clear();
            layout_ParaclinicalTests.Children.Add(new ParaclinicalAutoAntibodyView(layout_ParaclinicalTests,_patientCode));
        }
    }

    private void Button_ParaclinicalCSFView_Clicked(object sender, EventArgs e)
    {
        if (layout_ParaclinicalTests.Children[0] is not ParaclinicalCSFView)
        {
            layout_ParaclinicalTests.Children.Clear();
            layout_ParaclinicalTests.Children.Add(new ParaclinicalCSFView(layout_ParaclinicalTests,_patientCode));
        }
    }

    private void Button_ParaclinicalSerologicalView_Clicked(object sender, EventArgs e)
    {
        if (layout_ParaclinicalTests.Children[0] is not ParaclinicalSerologicalView)
        {
            layout_ParaclinicalTests.Children.Clear();
            layout_ParaclinicalTests.Children.Add(new ParaclinicalSerologicalView(layout_ParaclinicalTests));
        }
    }

    private void Button_ParaclinicalNotesView_Clicked(object sender, EventArgs e)
    {
        if (layout_ParaclinicalTests.Children[0] is not ParaclinicalNotesView)
        {
            layout_ParaclinicalTests.Children.Clear();
            layout_ParaclinicalTests.Children.Add(new ParaclinicalNotesView(layout_ParaclinicalTests));
        }
    }
}