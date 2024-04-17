using MAUIUI.Business.Abstract;
using MAUIUI.Business.DependencyResoulver.AutofacResoulver;
using MAUIUI.Entities.Concrete;
using MAUIUI.Helpers;

namespace MAUIUI.Views;

public partial class RelapsesPage : ContentPage
{

    // IRelapseService relapsesService; 
    IRelapseService relapsesService;
    string _RecivedId;
    List<Relapse> _relapsesList;
    List<string?> _relapsesDates;
    Relapse _relapses;



    public RelapsesPage(string selectedPatient)
	{
		InitializeComponent();

        _RecivedId = selectedPatient;
        relapsesService = InstanceFactory.GetInstance<IRelapseService>();
        _relapsesList = new List<Relapse>();
        _relapsesList = relapsesService.GetAllByPatientId(_RecivedId).Data;


        if (_relapsesList.Count > 0)
        {
            _relapses = new Relapse();
            _relapsesDates = new List<string?>();
            foreach (var bloodchemistry in _relapsesList)
            {
                if (bloodchemistry.DateOfOnset != null)
                {
                    _relapsesDates.Add(bloodchemistry.Id.ToString() +
                        ". " + bloodchemistry.DateOfOnset.ToString().Substring(0, 10));
                }
            }
            this.OtherThyroidFunctions_combobox.ItemsSource= _relapsesDates;
            _relapses = _relapsesList[0];
            setFields();
        }
    }



    private bool setRelapses()
    {

        if (setDateFieldHelper.ValidateUnnullableDate(RelapsesDateofOnsetDate_textBox)==null)
        {
            _relapses.DateOfOnset = RelapsesDateofOnsetDate_textBox.Date;
        }
        else return false;

        _relapses.PatientCode = this._RecivedId;
        try
        {
            _relapses.Duration = Duration_textbox.Text.Length > 0 ? int.Parse(Duration_textbox.Text) : null;
        }
        catch (Exception)
        {
            DisplayAlert("Error", "The number of days entered is too long", "OK"); 
            return false;
        }


        if (PyramidalTract_checkBox.IsChecked)
        {
            _relapses.PyramidalTract = "Yes";
        }
        else _relapses.PyramidalTract = "No";
        if (Brainstem_checkBox.IsChecked)
        {
            _relapses.Brainstem = "Yes";
        }
        else _relapses.Brainstem = "No";
        if (Sensory_checkBox.IsChecked)
        {
            _relapses.SensoryFunctions = "Yes";
        }
        else _relapses.SensoryFunctions = "No";
        if (Cerebellum_checkBox.IsChecked)
        {
            _relapses.Cerebellum = "Yes";
        }
        else _relapses.Cerebellum = "No";
        if (Bowel_checkBox.IsChecked)
        {
            _relapses.BowelBladder = "Yes";
        }
        else _relapses.BowelBladder = "No";
        if (VisualFunctions_checkBox.IsChecked)
        {
            _relapses.VisualFunctions = "Yes";
        }
        else _relapses.VisualFunctions = "No";
        if (Neuropsych_checkBox.IsChecked)
        {
            _relapses.NeuropsychoFunctions = "Yes";
        }
        else _relapses.NeuropsychoFunctions = "No";

        if (FunOther_textBox.Text!=null) 
        _relapses.OtherFunctionalSystemAffected = InputValidator.CaseFormatter(FunOther_textBox.Text);

        if (RecoverySoru_radioButton.IsChecked)
        {
            _relapses.Recovery = "?";
        }
        else if (RecoveryComplete_radioButton.IsChecked)
        {
            _relapses.Recovery = "Complete";
        }
        else if (RecoveryPartial_radioButton.IsChecked)
        {
            _relapses.Recovery = "Partial";
        }
        else if (RecoveryNone_radioButton.IsChecked)
        {
            _relapses.Recovery = "None";
        }

        if (ADLFunctionSoru_radioButton.IsChecked)
        {
            _relapses.ADLFunction = "Unknown";
        }
        else if (ADLFunctionYes_radioButton.IsChecked)
        {
            _relapses.ADLFunction = "Yes";
        }
        else if (ADLFunctionNo_radioButton.IsChecked)
        {
            _relapses.ADLFunction = "No";
        }

        if (SeveritySoru_radioButton.IsChecked)
        {
            _relapses.Severity = "?";
        }
        else if (SeverityMild_radioButton.IsChecked)
        {
            _relapses.Severity = "Mild";
        }
        else if (SeverityModerate_radioButton.IsChecked)
        {
            _relapses.Severity = "Moderate";
        }
        else if (SeveritySevere_radioButton.IsChecked)
        {
            _relapses.Severity = "Severe";
        }

        if (TreatmentSoru_radioButton.IsChecked)
        {
            _relapses.Treatment = "?";
        }
        else if (TreatmentNot_radioButton.IsChecked)
        {
            _relapses.Treatment = "Not_Treated";
        }
        else if (TreatmentAmbulatory_radioButton.IsChecked)
        {
            _relapses.Treatment = "Ambulatory";
        }
        else if (TreatmentHospital_radioButton.IsChecked)
        {
            _relapses.Treatment = "Hospital";
        }

        setDateFieldHelper.getPickerValue(Treatmentcombo_comboBox, _relapses.other_Treatment); 

        if (CosticosteroidsSoru_radioButton.IsChecked)
        {
            _relapses.Costicosteroids = "?";
        }
        else if (CosticosteroidsYes_radioButton.IsChecked)
        {
            _relapses.Costicosteroids = "Yes";
        }
        else if (CosticosteroidsNo_radioButton.IsChecked)
        {
            _relapses.Costicosteroids = "No";
        }
        setDateFieldHelper.getPickerValue(Costicosteroids_comboBox, _relapses.CosticosteroidsCase); 

        if (setDateFieldHelper.ValidateNullableDate(RelapsesCosticosteroidsStartDate_textBox)==null)
        {
            _relapses.CosticosteroidsStartDate = RelapsesCosticosteroidsStartDate_textBox.Date;
        }
        else return false;
        if (setDateFieldHelper.ValidateNullableDate(RelapsesCosticosteroidsEndDate_textBox) == null)
        {
            _relapses.CosticosteroidsEndDate =  RelapsesCosticosteroidsEndDate_textBox.Date;
        }
        else return false;

        setDateFieldHelper.getPickerValue(OtherTreatment_comboBox, _relapses.OtherTreatment); 

        if (setDateFieldHelper.ValidateNullableDate(RelapsesOtherStartDate_textBox)==null)
        {
            _relapses.OtherTreatmentStartDate = RelapsesOtherStartDate_textBox.Date;
        }
        else return false;
        if (setDateFieldHelper.ValidateNullableDate(RelapsesOtherEndingDate_textBox)==null)
        {
            _relapses.OtherTreatmentEndDate = RelapsesOtherEndingDate_textBox.Date;
        }
        else return false;
        _relapses.Remarks = InputValidator.CaseFormatter(Remarks_textBox.Text);
        _relapses.OtherTreatmentRemarks = InputValidator.CaseFormatter(OtherTreatmentRemarks_textBox.Text);
        return true;
    }
    private void setFields()
    {
        setDateFieldHelper.setMaskedTextboxDate(_relapses.DateOfOnset,
            RelapsesDateofOnsetDate_textBox);
        this.Duration_textbox.Text = _relapses.Duration.ToString();
        if (_relapses.PyramidalTract == "Yes")
        {
            PyramidalTract_checkBox.IsChecked = true;
        }
        else PyramidalTract_checkBox.IsChecked = false;
        if (_relapses.Brainstem == "Yes")
        {
            Brainstem_checkBox.IsChecked = true;
        }
        else Brainstem_checkBox.IsChecked = false;
        if (_relapses.SensoryFunctions == "Yes")
        {
            Sensory_checkBox.IsChecked = true;
        }
        else Sensory_checkBox.IsChecked = false;
        if (_relapses.NeuropsychoFunctions == "Yes")
        {
            Neuropsych_checkBox.IsChecked = true;
        }
        else Neuropsych_checkBox.IsChecked = false; ;
        if (_relapses.BowelBladder == "Yes")
        {
            Bowel_checkBox.IsChecked = true;

        }
        else Bowel_checkBox.IsChecked = false;
        if (_relapses.Cerebellum == "Yes")
        {
            Cerebellum_checkBox.IsChecked = true;
        }
        else Cerebellum_checkBox.IsChecked = false;
        if (_relapses.VisualFunctions == "Yes")
        {
            VisualFunctions_checkBox.IsChecked = true;
        }
        else VisualFunctions_checkBox.IsChecked = false;

        this.FunOther_textBox.Text = _relapses.OtherFunctionalSystemAffected;

        if (_relapses.Recovery == "?")
        {
            RecoverySoru_radioButton.IsChecked = true;
        }
        else if (_relapses.Recovery == "Complete")
        {
            RecoveryComplete_radioButton.IsChecked = true;
        }
        else if (_relapses.Recovery == "Partial")
        {
            RecoveryPartial_radioButton.IsChecked = true;
        }
        else if (_relapses.Recovery == "None")
        {
            RecoveryNone_radioButton.IsChecked = true;
        }


        if (_relapses.Severity == "?")
        {
            SeveritySoru_radioButton.IsChecked = true;
        }
        else if (_relapses.Severity == "Mild")
        {
            SeverityMild_radioButton.IsChecked = true;
        }
        else if (_relapses.Severity == "Moderate")
        {
            SeverityModerate_radioButton.IsChecked = true;
        }
        else if (_relapses.Severity == "Severe")
        {
            SeveritySevere_radioButton.IsChecked = true;
        }

        if (_relapses.Treatment == "?")
        {
            TreatmentSoru_radioButton.IsChecked = true;
        }
        else if (_relapses.Treatment == "Not_Treated")
        {
            TreatmentNot_radioButton.IsChecked = true;
        }
        else if (_relapses.Treatment == "Ambulatory")
        {
            TreatmentAmbulatory_radioButton.IsChecked = true;
        }
        else if (_relapses.Treatment == "Hospital")
        {
            TreatmentHospital_radioButton.IsChecked = true;
        }
        setDateFieldHelper.setPicker(Treatmentcombo_comboBox, _relapses.other_Treatment);

        if (_relapses.ADLFunction == "Unknown")
        {
            this.ADLFunctionSoru_radioButton.IsChecked = true;
        }
        else if (_relapses.ADLFunction == "Yes")
        {
            ADLFunctionYes_radioButton.IsChecked = true;
        }
        else if (_relapses.ADLFunction == "No")
        {
            ADLFunctionNo_radioButton.IsChecked = true;
        }

        if (_relapses.Costicosteroids == "?")
        {
            CosticosteroidsSoru_radioButton.IsChecked = true;
        }
        else if (_relapses.Costicosteroids == "Yes")
        {
            CosticosteroidsYes_radioButton.IsChecked = true;
        }
        else if (_relapses.Costicosteroids == "No")
        {
            CosticosteroidsNo_radioButton.IsChecked = true;
        }
        setDateFieldHelper.setPicker(Costicosteroids_comboBox, _relapses.CosticosteroidsCase); 
        setDateFieldHelper.setMaskedTextboxDate(_relapses.CosticosteroidsStartDate,
            RelapsesCosticosteroidsStartDate_textBox);
        setDateFieldHelper.setMaskedTextboxDate(_relapses.CosticosteroidsEndDate,
            RelapsesCosticosteroidsEndDate_textBox); 
        setDateFieldHelper.setPicker(OtherTreatment_comboBox, _relapses.OtherTreatment);
        setDateFieldHelper.setMaskedTextboxDate(_relapses.OtherTreatmentStartDate,
            RelapsesOtherStartDate_textBox);
        setDateFieldHelper.setMaskedTextboxDate(_relapses.OtherTreatmentEndDate,
            RelapsesOtherEndingDate_textBox);

        this.OtherTreatmentRemarks_textBox.Text = _relapses.OtherTreatmentRemarks;
        this.Remarks_textBox.Text = _relapses.Remarks;
    }


    private void Button_AddNewRelapses_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AddNewRelapsesPage(_RecivedId));
    }
    private void Button_SaveRelapses_Clicked(object sender, EventArgs e)
    {
        if (_relapses == null)
        {
            Navigation.PopAsync();
        }
        else if (setRelapses() && setDateFieldHelper.
                ValidateStartEndDate(this.RelapsesCosticosteroidsStartDate_textBox, this.RelapsesCosticosteroidsEndDate_textBox) ==null && setDateFieldHelper.
                ValidateStartEndDate(this.RelapsesOtherStartDate_textBox, this.RelapsesOtherEndingDate_textBox)==null)
        {
            relapsesService.Update(_relapses);
            Navigation.PopAsync();
        }



    }

    void OtherThyroidFunctions_combobox_SelectedIndexChanged(System.Object sender, System.EventArgs e)
    {
        foreach (var throidFunc in this._relapsesList)
        {
            if (throidFunc.DateOfOnset != null && OtherThyroidFunctions_combobox.SelectedItem.ToString().Contains(throidFunc.Id.ToString() +
                ". " + throidFunc.DateOfOnset.ToString().Substring(0, throidFunc.DateOfOnset.ToString().IndexOf(" "))))
            {
                _relapses = throidFunc;
                RadiobuttonCleaner.cleanRadiobuttons(
                    ADLFunctionSoru_radioButton, ADLFunctionYes_radioButton, ADLFunctionNo_radioButton,
                    RecoveryComplete_radioButton, RecoveryNone_radioButton, RecoveryPartial_radioButton, RecoverySoru_radioButton,
                    SeverityMild_radioButton, SeverityModerate_radioButton, SeveritySevere_radioButton, SeveritySoru_radioButton,
                    TreatmentAmbulatory_radioButton, this.TreatmentHospital_radioButton, this.TreatmentSoru_radioButton, this.TreatmentNot_radioButton,
                    this.CosticosteroidsNo_radioButton, this.CosticosteroidsSoru_radioButton, this.CosticosteroidsYes_radioButton
                    );
              /*  RadiobuttonCleaner.cleanCheckBoxes(
                    this.PyramidalTract_checkBox, Cerebellum_checkBox, Brainstem_checkBox, Sensory_checkBox, Bowel_checkBox, VisualFunctions_checkBox, Neuropsych_checkBox
                    );*/
                setFields();
            }
        }

    }
}