using MAUIUI.Business.Abstract;
using MAUIUI.Business.DependencyResoulver.AutofacResoulver;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Views;

public partial class MedicalHistoryPage : ContentPage
{
    string _patientCode;

    public MedicalHistoryPage(string patientCode)
	{
		InitializeComponent();
        _patientCode = patientCode;
		layout_FamilyDiseaseHistory.Children.Add(new FamilyDiseaseHistoryView(layout_FamilyDiseaseHistory)); 
    }

    private void Button_Malignancy_Clicked(object sender, EventArgs e)
    {
        IMalignancyService herpesZosterService = InstanceFactory.GetInstance<IMalignancyService>();
        List<Malignancy> _herpesZosterList = new List<Malignancy>();
        _herpesZosterList = herpesZosterService.GetAllByPatientId(_patientCode).Data; 
        if (_herpesZosterList.Count > 0)
        {
            Navigation.PushAsync(new MalignancyPage(_patientCode));
        }
        else
        { 
            Navigation.PushAsync(new AddNewMalignancyPage(_patientCode));
        } 
    }

    private void Button_HerpesZoster_Clicked(object sender, EventArgs e)
    {
        IHerpesZosterService herpesZosterService = InstanceFactory.GetInstance<IHerpesZosterService>();
        List<HerpesZoster> _herpesZosterList = new List<HerpesZoster>();
        _herpesZosterList = herpesZosterService.GetAllByPatientId(_patientCode).Data;

        if (_herpesZosterList.Count > 0)
        {
            Navigation.PushAsync(new HerpesZosterPage(_patientCode));
        }
        else
        {
            Navigation.PushAsync(new AddNewHerpesZosterPage(_patientCode));
        }


    }

    private void Button_Covid_Clicked(object sender, EventArgs e)
    {
        ICovid19Service covid19Service = InstanceFactory.GetInstance<ICovid19Service>();

        List<Covid19> _covid19List = new List<Covid19>();
        _covid19List = covid19Service.GetAllByPatientId(_patientCode).Data;

        if (_covid19List.Count > 0)
        {
            Navigation.PushAsync(new CovidPage(_patientCode));
        }
        else
        {
            Navigation.PushAsync(new AddNewCovidPage(_patientCode)); 
        }
    }

    private void Button_ImmunosuppressionAssociated_Clicked(object sender, EventArgs e)
    {
        IImmunosuppressionService _immunosuppressionManager = InstanceFactory.GetInstance<IImmunosuppressionService>();

        List<Immunosuppression> _ImmunosuppressionList = new List<Immunosuppression>();
        _ImmunosuppressionList = _immunosuppressionManager.GetAllByPatientId(_patientCode).Data;

        if (_ImmunosuppressionList.Count > 0)
        {
            Navigation.PushAsync(new ImmunosuppressionAssociatedPage(_patientCode)); 
        }
        else
        {
            Navigation.PushAsync(new AddNewImmunosuppressionAssociatedPage(_patientCode));
        }

    }

    private void Button_OtherMedicalCondition_Clicked(object sender, EventArgs e)
    {
        IOtherMedicalConditionService otherMedicalConditionService = InstanceFactory.GetInstance<IOtherMedicalConditionService>();
        List<OtherMedicalCondition> _cotherConditionList = otherMedicalConditionService.GetAllByPatientId(_patientCode).Data;

        if (_cotherConditionList.Count > 0)
        {
            Navigation.PushAsync(new OtherMedicalConditionPage(_patientCode));
        }
        else
        {
            Navigation.PushAsync(new AddNewOtherMedicalConditionPage(_patientCode));
        }


    }

    private void Button_Vaccine_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new VaccinePage(_patientCode));
    }




    private void Button_SaveMedicalHistory_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}