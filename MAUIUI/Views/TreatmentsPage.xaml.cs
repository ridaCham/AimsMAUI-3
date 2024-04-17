namespace MAUIUI.Views;

public partial class TreatmentsPage : ContentPage
{
	public TreatmentsPage()
	{
		InitializeComponent();

        layout_MsSpecific.Children.Add(new MsSpecificView(layout_MsSpecific));
        layout_Symptomatic.Children.Add(new SymptomaticView(layout_Symptomatic));


        layout_Neuropsych.Children.Add(new NeuropsychView(layout_Neuropsych));
        layout_Physiotherapy.Children.Add(new PhysiotherapyView(layout_Physiotherapy));
        layout_Pilates.Children.Add(new PilatesView(layout_Pilates));
        layout_Psychotherapy.Children.Add(new PsychotherapyView(layout_Psychotherapy));
        layout_Yoga.Children.Add(new YogeView(layout_Yoga));


    }
    private void Button_SaveTreatments_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();

    }
}