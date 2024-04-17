namespace MAUIUI.Views;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

public partial class DeletedPatientsPage : ContentPage
{
	public DeletedPatientsPage()
	{
		InitializeComponent();
	}
    private void Button_CloseDeletedPatients_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();

    }
    private void Button_RetryDeletedPatients_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();

    }

}