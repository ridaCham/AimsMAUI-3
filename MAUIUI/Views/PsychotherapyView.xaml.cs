namespace MAUIUI.Views;

public partial class PsychotherapyView : ContentView
{
    private readonly StackLayout _layout_Psychotherapy;

    public PsychotherapyView(StackLayout layout_Psychotherapy)
    {
        InitializeComponent();
        _layout_Psychotherapy = layout_Psychotherapy;
    }
    private void Button_AddNewPsychotherapyView_Clicked(object sender, EventArgs e)
    {
        if (_layout_Psychotherapy.Children[0] is not AddNewPsychotherapyView)
        {
            _layout_Psychotherapy.Children.Clear();
            _layout_Psychotherapy.Children.Add(new AddNewPsychotherapyView(_layout_Psychotherapy));
        }

    }
}