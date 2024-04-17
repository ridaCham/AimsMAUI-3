
using System.ComponentModel;
using MAUIUI.Business.Abstract;
using MAUIUI.Business.DependencyResoulver.AutofacResoulver;
using MAUIUI.Core.Entities;
using MAUIUI.Entities.Concrete;
using MAUIUI.Entities.DTOs;

namespace MAUIUI.Views;

public partial class PatientsView : ContentView
{
    User _user;
    string selectedPatientId;
    public IIdentificationService patientReader;
    public List<IdentificationDataGirdviewDetails> _patients;
    IdentificationDataGirdviewDetails selectedPatient;
    public PatientsView(User user)
    {
        InitializeComponent();
        _user = user;
        selectedPatient = new IdentificationDataGirdviewDetails();
        patientReader = InstanceFactory.GetInstance<IIdentificationService>();
        _patients = patientReader.GetAllToGirdView().Data;
        if (_patients.Count>0)
        {
            selectedPatient = _patients[0];
            selectedPatientId = patientReader.Get((int)selectedPatient.Id).Data.PatientCode;
        }
        else
        {
            Button_DeletePatient.IsEnabled = false;
            Button_PatientDetails.IsEnabled = false;
            Button_Identification.IsEnabled = false;
            Button_MedicalHistory.IsEnabled = false;
            Button_Diagnosis.IsEnabled = false;
            Button_Visits.IsEnabled = false;
            Button_Relapses.IsEnabled = false;
            Button_Pregnancy.IsEnabled = false;
            Button_ParaclinicalTests.IsEnabled = false;
            Button_Treatments.IsEnabled = false;
            Button_Notes.IsEnabled = false;
        }
        _patients.Sort((x, y) => x.SurName.CompareTo(y.SurName));
        ListView_Patients.ItemsSource = _patients;

        patientCountLabel.Text = "Patients (" + _patients.Count + ")";
        patientCountLabel.Text = "Patients (" + _patients.Count + ")";
        //ListView_Patients.SelectedItem
    }
    private async void Button_DeletePatient_Pressed(object sender, EventArgs e)
    {
        if (sender is Button button)
        {
            button.BackgroundColor = Color.FromArgb("#cccccc");
        }
        if (_patients.Count > 0)
        {
            Identifications _ident = new Identifications();
            _ident = patientReader.GetByPatientId(selectedPatientId).Data;
            _ident.Deleted = 1;

            var result = await App.Current.MainPage.DisplayAlert("Error", "Are you sure you want to delete this patient ? " +_ident.Name, "Yes","No");

            if (result == true)
            {
                patientReader.Update(_ident);
                _patients = patientReader.GetAllToGirdView().Data;
                ListView_Patients.ItemsSource = _patients;

            }
        }
    }
    private void Button_DeletePatient_Released(object sender, EventArgs e)
    {
        if (sender is Button button)
        {
            button.BackgroundColor = Color.FromArgb("#fff");
        }
    }
    private void Button_PatientDetails_Pressed(object sender, EventArgs e)
    {
        if (sender is Button button)
        {
                button.BackgroundColor = Color.FromArgb("#cccccc");
        }
    }
    private void Button_PatientDetails_Released(object sender, EventArgs e)
    {
        if (sender is Button button)
        {
            button.BackgroundColor = Color.FromArgb("#fff");
        }
    }
    private void Button_AddNewPatient_Pressed(object sender, EventArgs e)
    {
        if (sender is Button button)
        {
            button.BackgroundColor = Color.FromArgb("#cccccc");
        }
    }
    private void Button_AddNewPatient_Released(object sender, EventArgs e)
    {
        if (sender is Button button)
        {
            button.BackgroundColor = Color.FromArgb("#fff");
        }
    }
    private void Button_MedicalHistory_Clicked(object sender, EventArgs e)
    {
        if (_patients.Count > 0)
            Navigation.PushAsync(new MedicalHistoryPage(selectedPatientId));
    }
    private void Button_DeletePatient_Clicked(object sender, EventArgs e)
    {
        if (_patients.Count > 0)
            Navigation.PushAsync(new DeletedPatientsPage());
    }
    private void Button_PatientDetails_Clicked(object sender, EventArgs e)
    {
        if (_patients.Count > 0)
            Navigation.PushAsync(new PatientDetailsPage());
    }
    private void Button_AddNewPatient_Clicked(object sender, EventArgs e)
    {
        if (_patients.Count > 0)
            Navigation.PushAsync(new AddNewPatientPage());
    }
    private void Button_Identification_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (_patients.Count > 0)
            Navigation.PushAsync(new IdentificationPage(selectedPatientId, this));
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    private void Button_Diagnosis_Clicked(object sender, EventArgs e)
    {
        if (_patients.Count > 0)
        
            Navigation.PushAsync(new DiagnosisPage(selectedPatientId));
       
    }
    private void Button_Relapses_Clicked(object sender, EventArgs e)
    { 
        if (_patients.Count > 0)
        {

            IRelapseService _RelapseService;
            _RelapseService = InstanceFactory.GetInstance<IRelapseService>();
            List<Relapse> _Relapselist = new List<Relapse>();
            _Relapselist = _RelapseService.GetAllByPatientId(selectedPatientId).Data;
            if (_Relapselist.Count > 0)
            {
                Navigation.PushAsync(new RelapsesPage(selectedPatientId));
            }
            else
            {
                Navigation.PushAsync(new AddNewRelapsesPage( selectedPatientId));
            }
        }
    }
    private void Button_Visits_Clicked(object sender, EventArgs e)
    {
        if (_patients.Count > 0)
        {

            IVisitService _VisitService;
            _VisitService = InstanceFactory.GetInstance<IVisitService>();
            List<Visit> _visitlist = new List<Visit>();
            _visitlist = _VisitService.GetAllByPatientId(selectedPatientId).Data;
            if (_visitlist.Count > 0)
                {
                    Navigation.PushAsync(new VisitsPage(selectedPatientId));
                }
            else
                {
                    Navigation.PushAsync(new AddNewVisitPage(selectedPatientId));
                }
        }
    }
    private void Button_Pregnancy_Clicked(object sender, EventArgs e)
    {
        if (_patients.Count > 0)
        {

            IPregnancyService pregnancyService;

            pregnancyService = InstanceFactory.GetInstance<IPregnancyService>();

            List<Pregnancy> _Pregnancies = pregnancyService.GetAllByPatientId(selectedPatientId).Data;
            if (_Pregnancies.Count > 0)
            {
                Navigation.PushAsync(new PregnancyPage(selectedPatientId));
            }
            else
            {
                Navigation.PushAsync(new AddNewPregnancyPage(selectedPatientId));
            }
        } 
    }
    private void Button_Treatments_Clicked(object sender, EventArgs e)
    {
        if (_patients.Count > 0)
            Navigation.PushAsync(new TreatmentsPage());
    }
    private void Button_Notes_Clicked(object sender, EventArgs e)
    {
        if (_patients.Count > 0)
            Navigation.PushAsync(new NotesPage());
    }
    private void Button_ParaclinicalTests_Clicked(object sender, EventArgs e)
    {
        if (_patients.Count > 0)
            Navigation.PushAsync(new ParaclinicalTestsPage(selectedPatientId));
    }
    public void setDatagirdView()
    {
        ListView_Patients.ItemsSource = _patients;
    }
    private void ListView_Patients_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        object selectedPatient_ = ListView_Patients.SelectedItem;
        selectedPatient = (IdentificationDataGirdviewDetails)selectedPatient_;
        selectedPatientId = patientReader.Get((int)selectedPatient.Id).Data.PatientCode;
    }
}