using System.Drawing;
using System.Text.Json;
using DocumentFormat.OpenXml.VariantTypes;
using MAUIUI.Business.Abstract;
using MAUIUI.Business.DependencyResoulver.AutofacResoulver;
using MAUIUI.Entities.Concrete;
using MAUIUI.Helpers;
using Microsoft.Extensions.Options;
using Microsoft.Maui.Storage;

namespace MAUIUI.Views;

public partial class IdentificationPage : ContentPage
{

    IIdentificationService _identificationManager;
    Identifications _indentificaiton;
    private string _recivedPatientId;
    PatientsView _parentPage;
    private int errorCount;

    private string newPhotoPath;
    private string newPhotoExtenssion;
    public IdentificationPage(string selectedPatient, PatientsView parentPage)
    {
        InitializeComponent();

        _parentPage = parentPage;
        string json="";

        if (Device.RuntimePlatform != Device.WinUI)
        {
            if (File.Exists("..//Aims.db"))
            {
                json = File.ReadAllText("..//countriesandstates.json");
            }
        }
        else json = File.ReadAllText("countriesandstates.json");

        JsonDocument jsonDocument = JsonDocument.Parse(json);
        JsonElement root = jsonDocument.RootElement;
        countries = JsonSerializer.Deserialize<List<Country>>(json);
        birthCountries = JsonSerializer.Deserialize<List<Country>>(json);
        var countryNames = countries.Select(country => country.name).ToList();
        var birthCountryNames = birthCountries.Select(country => country.name).ToList();
        Country_comboBox.ItemsSource = countryNames;
        BirthCountry_comboBox.ItemsSource = birthCountryNames;
        //pts = parent;
        _recivedPatientId = selectedPatient;
        _identificationManager = InstanceFactory.GetInstance<IIdentificationService>();
        _indentificaiton = new Identifications();
        Country_comboBox.SelectedIndex = -1;
        BirthCountry_comboBox.SelectedIndex = -1;
        _indentificaiton = _identificationManager.GetByPatientId(_recivedPatientId).Data;
        if (_indentificaiton != null)
        {
            setFields();

            if (File.Exists(_indentificaiton.ImagePath))
            { 
               /* using (Bitmap bitmap = new Bitmap(_indentificaiton.ImagePath))
                {
                    pictureBox1.Source = new Bitmap(bitmap);
                }*/
            }
        }

    }
    private void Button_SaveIdentification_Clicked(object sender, EventArgs e)
    {

        // Retrieve patient data by ID
        _indentificaiton = _identificationManager.GetByPatientId(_recivedPatientId).Data;
        if (_indentificaiton == null)
        {
            // Handle case where patient not found (e.g., display error message)
            return;
        }
        List<string> errors = new List<string>();
        if (NameField_textBox.Text.Length < 2)
        {
            errors.Add("Name must be at least 2 characters long.");
        }
        if (SurNameField_textBox.Text.Length < 2)
        {
            errors.Add("Surname must be at least 2 characters long.");
        }
        if (Gender_comboBox.SelectedItem == null)
        {
            errors.Add("Please select a gender.");
        }
        if (1!=1 || Email_textBox.Text.Length > 0 && !IsValidEmail(Email_textBox.Text))
        {
            errors.Add("Invalid email address.");
        }
        if (!IsValidPhone(Phone_textBox.Text))
        {
            errors.Add("Invalid phone number.");
        }
        if (!ValidateDate(BirthDate_textBox))
        {
            errors.Add("Invalid birth date.");
        }

        if (errors.Any())
        {
            // Display validation errors to the user (e.g., using a modal or tooltip)
            DisplayAlert("Validation Errors", string.Join("\n", errors), "OK");
            return;
        }

        // Update patient data (assuming properties exist in Patient class)
        //_indentificaiton.Name = NameField_textBox.Text;
        //_indentificaiton.SurName = SurNameField_textBox.Text;
        //_indentificaiton.Gender = Gender_comboBox.SelectedItem.ToString(); // Assuming string representation
        //_indentificaiton.Email = Email_textBox.Text;
        //_indentificaiton.Phone = Phone_textBox.Text;
        //_indentificaiton.BirthDate = BirthDate_textBox.Date;
        // ... Update other properties as needed

        // Call update method (assuming asynchronous)
        if (setIdentification())
        {
            _identificationManager.Update(_indentificaiton);
            _parentPage._patients= _identificationManager.GetAllToGirdView().Data;
            _parentPage._patients.Sort((x, y) => x.SurName.CompareTo(y.SurName));
            _parentPage.setDatagirdView();
            Navigation.PopAsync();
        }
        


    }
    private bool IsValidEmail(string email)
    {
        return true;
        // Implement email validation logic (e.g., using regex or a dedicated library)
        // ...
    }
    private bool IsValidPhone(string phone)
    {
        return true;
        // Implement phone number validation logic (e.g., using regex or a dedicated library)
        // ...
    }
    private bool ValidateDate(DatePicker datePicker)
    {
        if (datePicker.Date == null)
        {
            return false;
        }

        // Additional date validation logic (e.g., minimum/maximum age)
        // ...

        return true;
    }



    private async void PickPhoto_Clicked(object sender, EventArgs e)
    {
        var result = await MediaPicker.PickPhotoAsync();

        if (result != null)
        {
            var stream = await result.OpenReadAsync();
            pictureBox1.Source = ImageSource.FromStream(() => stream);
        }
    }


    private async void pictureBox1_Clicked(object sender, EventArgs e)
    {
        try
        {

                var result =await FilePicker.Default.PickAsync();
                if (result != null)
                {
                        //using var stream = await result.OpenReadAsync();
                        pictureBox1.Source = ImageSource.FromFile(result.FullPath);
                    
                }

                pictureBox1.Source = ImageSource.FromFile(result.FullPath);
            
            // ... (Previous code)



            //var result = await FilePicker.PickAsync(new PickOptions
            //{
            //    FileTypes = FilePickerFileType.Images,
            //    PickerTitle="Please choose an image"
            //});
            //if (result != null)
            //{
            //    var stream =await result.OpenReadAsync();
            //    pictureBox1.Source = ImageSource.FromStream(()=> stream);
            //}

            // Use FilePicker for cross-platform file selection
            //        FilePicker filePicker = FilePicker.Default;
            //filePicker.PickerTitle = "Select an image";  // Optional title for the dialog
            //filePicker.FileTypes = new FilePickerFileType()
            //{
            //    FileType = MimeTypeMaps.GetMimeType(".png"),  // Use MimeTypeMaps for consistency
            //    Description = "Picture Files"
            //};

            //FileResult fileResult = await filePicker.PickAsync();

            //if (fileResult != null)
            //{
            //    string newPhotoPath = fileResult.FullPath;
            //    string newPhotoExtension = Path.GetExtension(newPhotoPath);

            //    // Load the image using await for efficient handling
            //    using (Stream imageStream = await fileResult.OpenReadAsync())
            //    {
            //        pictureBox1.Image = new StreamImageSource { Stream = imageStream };
            //    }

            //    if (newPhotoPath != null)
            //    {
            //        string destinationPath = Path.Combine("PatientImages", _indentificaiton.PatientCode + newPhotoExtension);

            //        // Check if file exists before deletion
            //        if (await FileExistsAsync(destinationPath))
            //        {
            //            await Microsoft.Maui.Storage.(destinationPath);
            //        }

            //        // Use Storage API for cross-platform file operations
            //        await Storage.Current.GetFileFromPathAsync(newPhotoPath)
            //            .CopyToAsync(Storage.Current.GetFileFromPathAsync(destinationPath));

            //        // Update identification object
            //        _indentificaiton.ImagePath = destinationPath;
            //        _identificationManager.Update(_indentificaiton);
            //    }
            //}

        }
        catch (Exception ex)
        {
            // Handle exceptions gracefully (e.g., display error message)
            Console.WriteLine("Error picking image: " + ex.Message);
        }
    }



    private void NameField_textBoxChanged(object sender, TextChangedEventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(e.NewTextValue) && !e.NewTextValue.All(char.IsLetter))
        {
            ((Entry)sender).Text = e.OldTextValue;
        }
    }

    private void SurNameField_textBoxChanged(object sender, TextChangedEventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(e.NewTextValue) && !e.NewTextValue.All(char.IsLetter))
        {
            ((Entry)sender).Text = e.OldTextValue;
        }
    }

    private void TCEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(e.NewTextValue) && (!e.NewTextValue.All(char.IsDigit) || e.NewTextValue.Length > 11))
        {
            ((Entry)sender).Text = e.OldTextValue;
        }
    }

    private bool setIdentification()
    {

        _indentificaiton.Name = InputValidator.CaseFormatter(NameField_textBox.Text);
        _indentificaiton.Phone = Phone_textBox.Text;
        _indentificaiton.SurName = InputValidator.CaseFormatter(SurNameField_textBox.Text);
        if (setDateFieldHelper.ValidateUnnullableDate(BirthDate_textBox) == null)
        {
            _indentificaiton.BirthDate = BirthDate_textBox.Date;
        }
        else return false;
        _indentificaiton.Gender = Gender_comboBox.SelectedItem.ToString();


        setDateFieldHelper.getPickerValue(BirthCountry_comboBox, _indentificaiton.BirthCountry); 
        setDateFieldHelper.getPickerValue(BirthCity_comboBox, _indentificaiton.BirthCity); 
        _indentificaiton.HealthInsurance = HealthInsurence_textBox.Text;
        _indentificaiton.InsuranceReference = InsuranceReference_textBox.Text;
        if (!string.IsNullOrEmpty(Height_textBox.Text))
        {
            _indentificaiton.Height = int.Parse(Height_textBox.Text);
        }
        else _indentificaiton.Height = null;
        if (!string.IsNullOrEmpty(Weight_textBox.Text))
        {
            _indentificaiton.Weight = int.Parse(Weight_textBox.Text);
        }
        else _indentificaiton.Weight = null; 
        setDateFieldHelper.getPickerValue(EmployementStatus_comboBox, _indentificaiton.EmployeeStatus); 
        _indentificaiton.Adress = InputValidator.CaseFormatter(AdressField_textBox.Text);
        setDateFieldHelper.getPickerValue(Country_comboBox, _indentificaiton.Country); 
        setDateFieldHelper.getPickerValue(City_comboBox, _indentificaiton.city); 
        _indentificaiton.State = this.StateField_textBox.Text;
        _indentificaiton.Email = Email_textBox.Text;
        _indentificaiton.PatientNum = Patientnumber_textBox.Text;
        _indentificaiton.FileNum = Filenumber_textBox.Text; 
        setDateFieldHelper.getPickerValue(Education_comboBox, _indentificaiton.Education); 


        //eksik kisimlaar
        //_indentificaiton.IdentificationNo = Tc_textBox.Text;
        //_indentificaiton.CauseOfDeath = InputValidator.CaseFormatter(Cause_of_death_textBox.Text);
        //if (YesDeceased_radioButton.IsChecked)
        //{

        //    _indentificaiton.Deceased = "Yes";
        //    if (setDateFieldHelper.ValidateNullableDate(DeathDate_maskedTextBox))
        //    {
        //        _indentificaiton.DateOfDeath = DeathDate_maskedTextBox.Text == "  .  ." ? null :
        //            DateTime.Parse(DeathDate_maskedTextBox.Text);
        //    }
        //    else return false;
        //}
        //else _indentificaiton.Deceased = "No";
        return true;


    }
    private void setFields()
    {

        this.NameField_textBox.Text = _indentificaiton.Name;
        this.Phone_textBox.Text = _indentificaiton.Phone;
        this.SurNameField_textBox.Text = _indentificaiton.SurName;

        setDateFieldHelper.setMaskedTextboxDate(_indentificaiton.BirthDate,
            BirthDate_textBox); 
        setDateFieldHelper.setPicker(Gender_comboBox, _indentificaiton.Gender); 
        setDateFieldHelper.setPicker(BirthCountry_comboBox, _indentificaiton.BirthCountry); 
        setDateFieldHelper.setPicker(BirthCity_comboBox, _indentificaiton.BirthCity);
        this.HealthInsurence_textBox.Text = _indentificaiton.HealthInsurance;
        this.InsuranceReference_textBox.Text = _indentificaiton.InsuranceReference;
        this.Height_textBox.Text = _indentificaiton.Height.ToString();
        this.Weight_textBox.Text = _indentificaiton.Weight.ToString(); 
        setDateFieldHelper.setPicker(EmployementStatus_comboBox, _indentificaiton.EmployeeStatus);
        this.AdressField_textBox.Text = _indentificaiton.Adress; 
        setDateFieldHelper.setPicker(Country_comboBox, _indentificaiton.Country); 
        setDateFieldHelper.setPicker(City_comboBox, _indentificaiton.city);
        this.StateField_textBox.Text = _indentificaiton.State;
        this.Phone_textBox.Text = _indentificaiton.Phone;
        this.Patientnumber_textBox.Text = _indentificaiton.PatientNum;
        this.Filenumber_textBox.Text = _indentificaiton.FileNum;
        this.Email_textBox.Text = _indentificaiton.Email;
        

        setDateFieldHelper.setPicker(Education_comboBox, _indentificaiton.Education);
        //eksik kisimlaar
        //this.Tc_textBox.Text = _indentificaiton.IdentificationNo;
        //if (_indentificaiton.CauseOfDeath != null)
        //{
        //    this.Cause_of_death_textBox.Text = _indentificaiton.CauseOfDeath;
        //}
        //if (_indentificaiton.Deceased == "Yes")
        //{
        //    YesDeceased_radioButton.Checked = true;
        //    setDateFieldHelper.setMaskedTextboxDate(_indentificaiton.DateOfDeath,
        //    DeathDate_maskedTextBox);
        //}
        //if (_indentificaiton.Deceased == "No")
        //{
        //    NoDeceased_radioButton.Checked = true;

        //}


    }




    public class Country
    {
        public string name { get; set; }
        public List<State> states { get; set; }
    }
    public class State
    {
        public string name { get; set; }
    }
    private List<Country> countries;
    private List<Country> birthCountries;

    async void pictureBox1_Focused(System.Object sender, Microsoft.Maui.Controls.FocusEventArgs e)
    {
        var result = await FilePicker.PickAsync(new PickOptions
        {
            FileTypes = FilePickerFileType.Images,
            PickerTitle = "Please choose an image"
        });
        if (result != null)
        {
            var stream = await result.OpenReadAsync();
            pictureBox1.Source = ImageSource.FromStream(() => stream);
        }
    }
}











/*
        IIdentificationService _identificationManager;
        private string _recivedPatientId;
        private patients pts;
        private int errorCount;

        private string newPhotoPath;
        private string newPhotoExtenssion; 
        public identification(string selectedPatient, patients parent)
        {

            InitializeComponent();

            string json = File.ReadAllText("countriesandstates.json");
            JsonDocument jsonDocument = JsonDocument.Parse(json);
            JsonElement root = jsonDocument.RootElement;
            countries = JsonSerializer.Deserialize<List<Country>>(json);
            birthCountries = JsonSerializer.Deserialize<List<Country>>(json);
            var countryNames = countries.Select(country => country.name).ToList();
            var birthCountryNames = birthCountries.Select(country => country.name).ToList();
            Country_comboBox.DataSource = countryNames;
            BirthCountry_comboBox.DataSource = birthCountryNames;
            pts = parent;
            _recivedPatientId = selectedPatient;
            _identificationManager = InstanceFactory.GetInstance<IIdentificationService>();
            _indentificaiton = new Identifications();
            Country_comboBox.SelectedIndex = -1;
            BirthCountry_comboBox.SelectedIndex = -1;
            _indentificaiton = _identificationManager.GetByPatientId(_recivedPatientId).Data;
            if (_indentificaiton != null)
            {
                setFields();

                if (File.Exists(_indentificaiton.ImagePath))
                {

                    using (Bitmap bitmap = new Bitmap(_indentificaiton.ImagePath))
                    {
                        pictureBox1.Image = new Bitmap(bitmap);
                    }
                } 
            }

        }
*/
/*
        private void button5_Click(object sender, EventArgs e)
        {
            _indentificaiton = _identificationManager.GetByPatientId(_recivedPatientId).Data;

            if (NameField_textBox.Text.Length < 2)
            {
                errorProvider1.SetError(NameField_textBox, "enter at least two characters!");
            }
            else
            {
                errorProvider1.SetError(NameField_textBox, null);
            }
            if (SurNameField_textBox.Text.Length < 2)
            {
                errorProvider1.SetError(SurNameField_textBox, "enter at least two characters!");
            }
            else
            {
                errorProvider1.SetError(SurNameField_textBox, null);
            }
            if (Gender_comboBox.Text.Length < 2)
            {
                errorProvider1.SetError(Gender_comboBox, "enter at least two characters!");
            }
            else
            {
                errorProvider1.SetError(Gender_comboBox, null);
            }
            if (Email_textBox.Text.Length > 0 && !InputValidator.EmailValidating(Email_textBox.Text))
            {
                errorProvider1.SetError(Email_textBox, "enter a valid email!");
            }
            else
            {
                errorProvider1.SetError(Email_textBox, null);
            }
            if (!InputValidator.PhoneValidating(Phone_textBox.Text, true))
            {
                errorProvider1.SetError(Phone_textBox, "enter a valid phone!");
            }
            else
            {
                errorProvider1.SetError(Phone_textBox, null);
            }
            errorCount = 0;
            foreach (Control control in Controls)
            {
                if (!string.IsNullOrEmpty(errorProvider1.GetError(control)))
                {
                    errorCount++;
                }
            }

            if (!setDateFieldHelper.ValidateUnnullableDate(BirthDate_textBox))
            {
                errorProvider1.SetError(BirthDate_textBox, "enter a valid date!");
            }
            else
            {
                errorProvider1.SetError(BirthDate_textBox, null);
            }

            if (errorCount == 0 && setIdentification() &&
                setDateFieldHelper.ValidateStartEndDate(BirthDate_textBox, DeathDate_maskedTextBox))
            {
                _identificationManager.Update(_indentificaiton);
                pts.dataGridView1.DataSource = pts.patientReader.GetAllToGirdView().Data;
                errorProvider1.SetError(SurNameField_textBox, null);
                this.Hide();
            }

        }
*/

/*
        private void identification_Load_1(object sender, EventArgs e)
        {
            if (YesDeceased_radioButton.Checked)
            {
                Cause_of_death_textBox.Enabled = true;
                DeathDate_maskedTextBox.Enabled = true;
                label18.Enabled = true;
                label19.Enabled = true;
            }
            else
            {
                Cause_of_death_textBox.Enabled = false;
                DeathDate_maskedTextBox.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                YesDeceased_radioButton.Checked = false;
        }
    }

        private void YesDeceased_radioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            Cause_of_death_textBox.Enabled = true;
            DeathDate_maskedTextBox.Enabled = true;
            label18.Enabled = true;
            label19.Enabled = true;
        }

        private void NoDeceased_radioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            Cause_of_death_textBox.Enabled = false;
            Cause_of_death_textBox.Text = "";
            DeathDate_maskedTextBox.Enabled = false;
            DeathDate_maskedTextBox.Text = "";
            label18.Enabled = false;
            label19.Enabled = false;
        }*/
/*

        private void Country_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string countryName = Country_comboBox.Text;
            if (countryName.Length > 0)
            {
                Country selectedCountry = countries.FirstOrDefault(country => country.name == countryName);
                if (selectedCountry != null)
                {
                    List<State> states = selectedCountry.states;
                    City_comboBox.DataSource = states.Select(state => state.name).ToList();
                    City_comboBox.SelectedIndex = -1;
                }
            }
        }
        private void BirthCountry_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string countryName = BirthCountry_comboBox.Text;
            if (countryName.Length > 0)
            {
                Country selectedCountry = countries.FirstOrDefault(country => country.name == countryName);
                if (selectedCountry != null)
                {
                    List<State> states = selectedCountry.states;
                    BirthCity_comboBox.DataSource = states.Select(state => state.name).ToList();
                    BirthCity_comboBox.SelectedIndex = -1;
                }
            }
        }
        


*/