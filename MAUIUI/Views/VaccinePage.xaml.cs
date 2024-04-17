using MAUIUI.Business.Abstract;
using MAUIUI.Business.DependencyResoulver.AutofacResoulver;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Views;

public partial class VaccinePage : ContentPage
{
    string _patientCode;
    IVaccine_Service vaccineService;
    IFluVaccine_Service fluVaccineService;
    IHepatityAVaccine_Service hepatityAVaccineService;
    IHepatityBVaccine_Service hepatityBVaccineService;
    ICovid19Vaccine_Service covid19VaccineService;
    IOtherVaccine_Service otherVaccineService;
    string _RecivedId;
    Vaccine_ _vaccine;
    FluVaccine _fluvaccine;
    HepatitisAVaccine _HepatitisAvaccine;
    HepatitisBVaccine _HepatitisBvaccine;
    Covid19Vaccine _Covid19vaccine;
    OtherVaccine _Othervaccine;


    List<FluVaccine> _fluvaccineList;
    List<HepatitisAVaccine> _HepatitisAvaccineList;
    List<HepatitisBVaccine> _HepatitisBvaccineList;
    List<Covid19Vaccine> _Covid19vaccineList;
    List<OtherVaccine> _OthervaccineList;

    List<string?> fluDates;
    List<string?> hepatityADates;
    List<string?> hepatityBDates;
    List<string?> covidDates;
    List<string?> otherDates;
    public VaccinePage(string patientCode)
    {
        InitializeComponent();
        _patientCode = patientCode;
        layout_VaccineCovid.Children.Add(new VaccineCovidView(layout_VaccineCovid));
        layout_VaccineHepatitisA.Children.Add(new VaccineHepatitisAView(layout_VaccineHepatitisA));
        layout_VaccineHepatitisB.Children.Add(new VaccineHepatitisBView(layout_VaccineHepatitisB));


        layout_VaccineFlu.Children.Add(new VaccineFluView(layout_VaccineFlu));
        layout_VaccineOther.Children.Add(new VaccineOtherView(layout_VaccineOther));



        vaccineService = InstanceFactory.GetInstance<IVaccine_Service>();
        fluVaccineService = InstanceFactory.GetInstance<IFluVaccine_Service>();
        hepatityAVaccineService = InstanceFactory.GetInstance<IHepatityAVaccine_Service>();
        hepatityBVaccineService = InstanceFactory.GetInstance<IHepatityBVaccine_Service>();
        covid19VaccineService = InstanceFactory.GetInstance<ICovid19Vaccine_Service>();
        otherVaccineService = InstanceFactory.GetInstance<IOtherVaccine_Service>();
        _vaccine = vaccineService.GetByPatientId(_RecivedId).Data;
        _fluvaccineList = fluVaccineService.GetAllByPatientId(_RecivedId).Data;
        _HepatitisAvaccineList = hepatityAVaccineService.GetAllByPatientId(_RecivedId).Data;
        _HepatitisBvaccineList = hepatityBVaccineService.GetAllByPatientId(_RecivedId).Data;
        _Covid19vaccineList = covid19VaccineService.GetAllByPatientId(_RecivedId).Data;
        _OthervaccineList = otherVaccineService.GetAllByPatientId(_RecivedId).Data;

        if (_vaccine != null)
        {
            setFields();
        }
        if (_fluvaccineList.Count > 0)
        {
            fluDates = new List<string?>();
            foreach (var vaccine in _fluvaccineList)
            {
                if (vaccine.FluDate != null)
                {
                    fluDates.Add(vaccine.Id.ToString() + ". " +
                        vaccine.FluDate.ToString().Substring(0, 10));
                }
            }
            this.Otherflu_combobox.ItemsSource = fluDates;
            _fluvaccine = _fluvaccineList[0];
           // setFluFields();
        }
        if (_HepatitisAvaccineList.Count > 0)
        {
            hepatityADates = new List<string?>();
            foreach (var vaccine in _HepatitisAvaccineList)
            {
                if (vaccine.HepatitisADate != null)
                {
                    hepatityADates.Add(vaccine.Id.ToString() + ". " +
                        vaccine.HepatitisADate.ToString().Substring(0, 10));
                }
            }
            this.Otherhepa_combobox.ItemsSource = hepatityADates;
            _HepatitisAvaccine = _HepatitisAvaccineList[0];
            //setHepatitisAFields();
        }
        if (_HepatitisBvaccineList.Count > 0)
        {
            hepatityBDates = new List<string?>();
            foreach (var vaccine in _HepatitisBvaccineList)
            {
                if (vaccine.HepatitisBDate != null)
                {
                    hepatityBDates.Add(vaccine.Id.ToString() + ". " +
                        vaccine.HepatitisBDate.ToString().Substring(0, 10));
                }
            }
            this.Otherhepb_combobox.ItemsSource = hepatityBDates;
            _HepatitisBvaccine = _HepatitisBvaccineList[0];
            //  setHepatitisBFields();
        }
        if (_Covid19vaccineList.Count > 0)
        {
            covidDates = new List<string?>();
            foreach (var vaccine in _Covid19vaccineList)
            {
                if (vaccine.CovidDate != null)
                {
                    covidDates.Add(vaccine.Id.ToString() + ". " +
                        vaccine.CovidDate.ToString().Substring(0, 10));
                }
            }
            this.Othercovid_combobox.ItemsSource = covidDates;
            _Covid19vaccine = _Covid19vaccineList[0];
            //setCovidFields();
        }
        if (_OthervaccineList.Count > 0)
        {
            otherDates = new List<string?>();
            foreach (var vaccine in _OthervaccineList)
            {
                if (vaccine.VaccineDate != null)
                {
                    otherDates.Add(vaccine.Id.ToString() + ". " +
                        vaccine.VaccineDate.ToString().Substring(0, 10));
                }
            }
            this.Othervaccine_combobox.ItemsSource = otherDates;
            _Othervaccine = _OthervaccineList[0];
            // setOtherVaccineFields();
        }



    }


    private void setFields()
    {


        if (_vaccine.HerpesZoster == "Yes")
        {
            VaccineHerpes_checkBox.IsChecked = true;
            if (_vaccine.HerpesZosterDate != null && _vaccine.HerpesZosterDate.ToString().Substring
            (0, _vaccine.HerpesZosterDate.ToString().IndexOf(" ")).Length < 10)
            {
                this.VaccineHerpesZosterDate_textBox.Date = (DateTime)_vaccine.HerpesZosterDate;
            }
            else this.VaccineHerpesZosterDate_textBox.Date = (DateTime)_vaccine.HerpesZosterDate;
        }

        if (_vaccine.Tiberculosis == "Yes")
        {
            VaccineTuberculosis_checkBox.IsChecked = true;

            if (_vaccine.TiberculosisDate != null && _vaccine.TiberculosisDate.ToString().Substring
            (0, _vaccine.TiberculosisDate.ToString().IndexOf(" ")).Length < 10)
            {
                this.VaccineTuberculosisDate_textBox.Date = (DateTime)_vaccine.TiberculosisDate;
            }
            else this.VaccineTuberculosisDate_textBox.Date = (DateTime)_vaccine.TiberculosisDate;
        }
        if (_vaccine.HPV == "Yes")
        {
            VaccineHPV_checkBox.IsChecked = true;
            if (_vaccine.HPVDate != null && _vaccine.HPVDate.ToString().Substring
            (0, _vaccine.HPVDate.ToString().IndexOf(" ")).Length < 10)
            {
                this.VaccineHPVDate_textBox.Date = (DateTime)_vaccine.HPVDate;
            }
            else this.VaccineHPVDate_textBox.Date = (DateTime)_vaccine.HPVDate;


        }
        if (_vaccine.YellowFever == "Yes")
        {
            VaccineYellowFever_checkBox.IsChecked = true;

            if (_vaccine.YellowFeverDate != null && _vaccine.YellowFeverDate.ToString().Substring
            (0, _vaccine.YellowFeverDate.ToString().IndexOf(" ")).Length < 10)
            {
                this.VaccineYellowFeverDate_textBox.Date = (DateTime)_vaccine.YellowFeverDate;
            }
            else this.VaccineYellowFeverDate_textBox.Date = (DateTime)_vaccine.YellowFeverDate;
        }

        VaccineRemarks_textBox.Text = _vaccine.Remarks;
    }


    private void Button_SaveTreatments_Clicked(object sender, EventArgs e)
    {



        Navigation.PopAsync();

    }
}