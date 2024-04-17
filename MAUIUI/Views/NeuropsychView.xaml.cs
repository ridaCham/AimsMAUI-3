namespace MAUIUI.Views;

public partial class NeuropsychView : ContentView
{
    private readonly StackLayout _layout_Neuropsych;

    public NeuropsychView(StackLayout layout_Neuropsych)
    {
        InitializeComponent();
        _layout_Neuropsych = layout_Neuropsych;
    }
    private void Button_AddNewNeuropsych_Clicked(object sender, EventArgs e)
    {
        if (_layout_Neuropsych.Children[0] is not AddNewNeuropsychView)
        {
            _layout_Neuropsych.Children.Clear();
            _layout_Neuropsych.Children.Add(new AddNewNeuropsychView(_layout_Neuropsych));
        }

    }
}