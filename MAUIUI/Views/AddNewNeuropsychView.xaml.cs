namespace MAUIUI.Views;

public partial class AddNewNeuropsychView : ContentView
{
    private readonly StackLayout _layout_Neuropsych;

    public AddNewNeuropsychView(StackLayout layout_Neuropsych)
    {
        InitializeComponent();

        _layout_Neuropsych = layout_Neuropsych;
    }

    private void Button_SaveAddNewNeuropsych_Clicked(object sender, EventArgs e)
    {
        if (_layout_Neuropsych.Children[0] is not NeuropsychView)
        {
            _layout_Neuropsych.Children.Clear();
            _layout_Neuropsych.Children.Add(new NeuropsychView(_layout_Neuropsych));
        }
    }
    private void Button_CancelAddNewNeuropsych_Clicked(object sender, EventArgs e)
    {
        if (_layout_Neuropsych.Children[0] is not NeuropsychView)
        {
            _layout_Neuropsych.Children.Clear();
            _layout_Neuropsych.Children.Add(new NeuropsychView(_layout_Neuropsych));
        }

    }
}