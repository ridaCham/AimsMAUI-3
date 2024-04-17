using MAUIUI.Core.Entities;

namespace MAUIUI.Views;

public partial class StatisticsView : ContentView
{
    User _user;
	public StatisticsView(User user)
	{
		InitializeComponent();
        _user = user;
	}

    private void Button_SaveStatistics_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new HomePage(_user));
    }

    private void Button_CleanStatistics_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new HomePage(_user));
    }
}