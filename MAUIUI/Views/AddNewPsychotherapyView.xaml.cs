namespace MAUIUI.Views;

public partial class AddNewPsychotherapyView : ContentView
{
    private readonly StackLayout _layout_Psychotherapy;

    public AddNewPsychotherapyView(StackLayout layout_Psychotherapy)
    {
        InitializeComponent();

        _layout_Psychotherapy = layout_Psychotherapy;
    }

    private void Button_SaveAddNewPsychotherapy_Clicked(object sender, EventArgs e)
    {
        if (_layout_Psychotherapy.Children[0] is not PsychotherapyView)
        {
            _layout_Psychotherapy.Children.Clear();
            _layout_Psychotherapy.Children.Add(new PsychotherapyView(_layout_Psychotherapy));
        }
    }
    private void Button_CancelAddNewPsychotherapy_Clicked(object sender, EventArgs e)
    {
        if (_layout_Psychotherapy.Children[0] is not PsychotherapyView)
        {
            _layout_Psychotherapy.Children.Clear();
            _layout_Psychotherapy.Children.Add(new PsychotherapyView(_layout_Psychotherapy));
        }

    }
}