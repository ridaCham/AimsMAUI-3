using MAUIUI.Business.Abstract;
using MAUIUI.Business.DependencyResoulver.AutofacResoulver;
using MAUIUI.Entities.Concrete;
using MAUIUI.Helpers;

namespace MAUIUI.Views;

public partial class MalignancyPage : ContentPage
{
    string _RecivedId;
    IMalignancyService malignancyService;
    List<Malignancy> _malignancyList;
    Malignancy _malignancy;
    List<string?> _malignancyDates;
    public MalignancyPage(string patientCode)
    {
            InitializeComponent();
            _RecivedId = patientCode;

		ChangeEnabled_DeathDate();
        malignancyService = InstanceFactory.GetInstance<IMalignancyService>();

        _malignancyList = new List<Malignancy>();
        _malignancyList = malignancyService.GetAllByPatientId(_RecivedId).Data;

        if (_malignancyList.Count > 0)
        {
            _malignancy = new Malignancy();
            _malignancyDates = new List<string?>();
            foreach (var malignancy in _malignancyList)
            {
                if (malignancy.DateOfDiagnosis != null)
                {
                    _malignancyDates.Add(malignancy.Id.ToString() +
                        ". " + malignancy.DateOfDiagnosis.ToString().Substring(0, 10));
                }
            }
            this.OtherMalignancy_combobox.ItemsSource = _malignancyDates;
            _malignancy = _malignancyList[0];
            setFields();
        }
    }

   
    private bool setMalignancy()
    {
        _malignancy.PatientCode = _RecivedId;
        if (setDateFieldHelper.ValidateUnnullableDate(MalignancyDateofDiagnosisDate_textBox)==null)
        {
            _malignancy.DateOfDiagnosis = MalignancyDateofDiagnosisDate_textBox.Date;
        }
        else return false;

        setDateFieldHelper.getPickerValue(StateDiagnosis_combobox, _malignancy.StateOfDiagnosis);

        _malignancy.SiteOfPrimaryCancer = InputValidator.CaseFormatter(SiteofPrimary_textbox.Text);
        if (setDateFieldHelper.ValidateNullableDate(MalignancyOutcomeDate_textBox)==null)
        {
            _malignancy.OutcomeDate = MalignancyOutcomeDate_textBox.Date; 
        }
        else return false;
        _malignancy.HistologicalDiagnosis = InputValidator.CaseFormatter(Histological_textbox.Text);
        if (UnknownOutcome_radiobutton.IsChecked)
        {
            _malignancy.Outcome = "Unknown";
        }
        else if (Ongoing_radiobutton.IsChecked)
        {
            _malignancy.Outcome = "Ongoing";
        }
        else if (remission_radiobutton.IsChecked)
        {
            _malignancy.Outcome = "Remission";
        }
        //else if (MalignancyDeath_radioButton.IsChecked)
        //{
        //    _malignancy.Outcome = "Death";
        //}

        //if (NoTreatment_checkbox.IsChecked)
        //{
        //    _malignancy.NoTretmenet = "Yes";
        //}
        //else _malignancy.NoTretmenet = "No";
        //if (Surgery_checkbox.IsChecked)
        //{
        //    _malignancy.Surgery = "Yes";
        //}
        //else _malignancy.Surgery = "No";
        //if (Chemotherapy_checkbox.IsChecked)
        //{
        //    _malignancy.Chemotherapy = "Yes";
        //}
        //else _malignancy.Chemotherapy = "No";
        //if (Radiotherapy_checkbox.Checked)
        //{
        //    _malignancy.Radiotherapy = "Yes";
        //}
        //else _malignancy.Radiotherapy = "No";
        //_malignancy.TretmenetOther = InputValidator.CaseFormatter(Other_textbox.Text);

        //_malignancy.Remarks = InputValidator.CaseFormatter(remarks_textbox.Text);
        //if (NoTreatment_checkbox.IsChecked)
        //{
        //    _malignancy.NoTretmenet = "Yes";
        //}
        //else _malignancy.NoTretmenet = "No";
        //if (Surgery_checkbox.IsChecked)
        //{
        //    _malignancy.Surgery = "Yes";
        //}
        //else _malignancy.Surgery = "No";
        //if (Chemotherapy_checkbox.IsChecked)
        //{
        //    _malignancy.Chemotherapy = "Yes";
        //}
        //else _malignancy.Chemotherapy = "No";
        //if (Radiotherapy_checkbox.IsChecked)
        //{
        //    _malignancy.Radiotherapy = "Yes";
        //}
        //else _malignancy.Radiotherapy = "No";
        return true;

    }
    private void setFields()
    {
        setDateFieldHelper.setMaskedTextboxDate(_malignancy.DateOfDiagnosis,
            MalignancyDateofDiagnosisDate_textBox);

        setDateFieldHelper.setPicker(StateDiagnosis_combobox, _malignancy.StateOfDiagnosis);
        this.SiteofPrimary_textbox.Text = _malignancy.SiteOfPrimaryCancer;
        this.Histological_textbox.Text = _malignancy.HistologicalDiagnosis;
        if (_malignancy.Outcome == "Unknown")
        {
            UnknownOutcome_radiobutton.IsChecked = true;
        }
        else if (_malignancy.Outcome == "Ongoing")
        {
            Ongoing_radiobutton.IsChecked = true;
        }
        else if (_malignancy.Outcome == "Remission")
        {
            remission_radiobutton.IsChecked = true;
        }
        else if (_malignancy.Outcome == "Death")
        {
           // MalignancyDeath_radioButton.IsChecked = true;
        }
        //isimlendirme hatası

        //if (_malignancy.NoTretmenet == "Yes")
        //{
        //    NoTreatment_checkbox.IsChecked = true;
        //}
        //if (_malignancy.Surgery == "Yes")
        //{
        //    Surgery_checkbox.IsChecked = true;
        //}
        //if (_malignancy.Chemotherapy == "Yes")
        //{
        //    Chemotherapy_checkbox.IsChecked = true;
        //}
        //if (_malignancy.Radiotherapy == "Yes")
        //{
        //    Radiotherapy_checkbox.IsChecked = true;
        //}
        //Other_textbox.Text = _malignancy.TretmenetOther;
        //setDateFieldHelper.setMaskedTextboxDate(_malignancy.OutcomeDate,
        //    MalignancyOutcomeDate_textBox);
        //this.remarks_textbox.Text = _malignancy.Remarks;

        //if (_malignancy.NoTretmenet == "Yes")
        //{
        //    NoTreatment_checkbox.IsChecked = true;
        //}
        //else NoTreatment_checkbox.IsChecked = false;

        //if (_malignancy.Surgery == "Yes")
        //{
        //    Surgery_checkbox.IsChecked = true;
        //}
        //else Surgery_checkbox.IsChecked = false;

        //if (_malignancy.Chemotherapy == "Yes")
        //{
        //    Chemotherapy_checkbox.Checked = true;
        //}
        //else Chemotherapy_checkbox.IsChecked = false;

        //if (_malignancy.Radiotherapy == "Yes")
        //{
        //    Radiotherapy_checkbox.IsChecked = true;
        //}
        //else Radiotherapy_checkbox.IsChecked = false;

        this.Other_textbox.Text = _malignancy.TretmenetOther;
    }

    private void OtherMalignancy_combobox_SelectedIndexChanged(object sender, EventArgs e)
    {
        foreach (var covid in _malignancyList)
        {
            if (covid.DateOfDiagnosis != null && OtherMalignancy_combobox.SelectedItem.ToString().Contains(covid.Id.ToString() +
                ". " + covid.DateOfDiagnosis.ToString().Substring(0, covid.DateOfDiagnosis.ToString().IndexOf(" "))))
            {
                this._malignancy = covid;
                setFields();
            }
        }
    }





    private void RadioButton_Death_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		ChangeEnabled_DeathDate();
    }

	private void ChangeEnabled_DeathDate()
	{
		//if(RadioButton_Death.IsChecked)
		//{
		//	Entry_DeathDate.IsEnabled = true;
		//	Entry_DeathDate.BackgroundColor = Colors.White;
		//}
		//else
		//{
  //          Entry_DeathDate.IsEnabled = false;
  //          Entry_DeathDate.BackgroundColor = Colors.DarkGray;
		//	Entry_DeathDate.Text = "";
  //      }
	}

    private void Button_Save_Clicked(object sender, EventArgs e)
    {
        if (_malignancy == null)
        {
            Navigation.PopAsync();
        }
        else if (setMalignancy() &&
            setDateFieldHelper.ValidateStartEndDate(this.MalignancyDateofDiagnosisDate_textBox, this.MalignancyOutcomeDate_textBox)==null)
        {
            malignancyService.Update(_malignancy);
            Navigation.PopAsync();
        }
    }

    private void Button_AddNew_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new AddNewMalignancyPage(_RecivedId));
    }
}