using MAUIUI.Business.Abstract;
using MAUIUI.Business.DependencyResoulver.AutofacResoulver;
using MAUIUI.Entities.Concrete;
using MAUIUI.Helpers;

namespace MAUIUI.Views;

public partial class DiagnosisPage : ContentPage
{
    IDiagnosisService diagnosisService;
    string _RecivedId;
    Diagnosis _diagnosis;
    public DiagnosisPage(string _selectedPatientId)
	{
		InitializeComponent();
        _RecivedId = _selectedPatientId;
        diagnosisService = InstanceFactory.GetInstance<IDiagnosisService>();
        _diagnosis = new Diagnosis();
        _diagnosis = diagnosisService.GetByPatientId(_RecivedId).Data;
        if (_diagnosis != null)
        {
            setFields();
        }
       
    }
    private void setFields()
    {
        if (_diagnosis.DateOfOnset != "  .  ." && _diagnosis.DateOfOnset != null)
        {
            setDateFieldHelper.setMaskedTextboxDate(DateTime.Parse(_diagnosis.DateOfOnset),
            DiagnosisDateofOnsetDate_textBox);
        }

        if (_diagnosis.Supratentorial == "Yes")
        {
            Supratentorial_checkBox.IsChecked = true;
        }
        else Supratentorial_checkBox.IsChecked = false;
        if (_diagnosis.BrainstemCerebellum == "Yes")
        {
            Brainstem_checkBox.IsChecked = true;
        }
        else Brainstem_checkBox.IsChecked = false;
        if (_diagnosis.SpinalCord == "Yes")
        {
            Spinal_Cord_checkBox.IsChecked = true;

        }
        else Spinal_Cord_checkBox.IsChecked = false;
        if (_diagnosis.OpticPathways == "Yes")
        {
            Optic_Pathways_checkBox.IsChecked = true;
        }
        else Optic_Pathways_checkBox.IsChecked = false; ;
        if (_diagnosis.ProgressionFromOnset == "Yes")
        {
            ProgressionFromOnset_checkBox.IsChecked = true;

        }
        else ProgressionFromOnset_checkBox.IsChecked = false;
        OtherSymptoms_textBox.Text = _diagnosis.OtherSymptoms;
        if (_diagnosis.ConfirmedDiagnosisDate != "  .  ." && _diagnosis.ConfirmedDiagnosisDate != null)
        {
            setDateFieldHelper.setMaskedTextboxDate(DateTime.Parse(_diagnosis.ConfirmedDiagnosisDate),
            DiagnosisConfirmedDate_textBox);
        }
        if (_diagnosis.DiagnosisConfirmedByClinicalFindings == "Yes")
        {
            ClinicalFindings_checkBox.IsChecked = true;
        }
        else ClinicalFindings_checkBox.IsChecked = false;
        if (_diagnosis.DiagnosisConfirmedByMri == "Yes")
        {
            MRI_checkBox.IsChecked = true;

        }
        else MRI_checkBox.IsChecked = false;
        if (_diagnosis.DiagnosisConfirmedByCsf == "Yes")
        {
            CSF_checkBox.IsChecked = true;
        }
        else CSF_checkBox.IsChecked = false;
        if (_diagnosis.DiagnosisConfirmedByEvokedPotentials == "Yes")
        {
            EvokedPotentiels_checkBox.IsChecked = true;
        }
        else EvokedPotentiels_checkBox.IsChecked = false;
        OtherDiagnosis_textBox.Text = _diagnosis.DiagnosisConfirmedByOther;
        setDateFieldHelper.setPicker(McDonaldClassification_comboBox, _diagnosis.DiagnosisMcDonaldClassification);
        setDateFieldHelper.setPicker(PoserClassification_comboBox, _diagnosis.DiagnosisPoserClassification);
        setDateFieldHelper.setPicker(MNOClassification_comboBox,_diagnosis.DiagnosisNmoClassification);

        if (_diagnosis.StartodProgression != "  .  ." && _diagnosis.StartodProgression != null)
        {
            setDateFieldHelper.setMaskedTextboxDate(DateTime.Parse(_diagnosis.StartodProgression), DiagnosisStartDate_textBox);
        }
        if (_diagnosis.RisOnsetDate != "  .  ." && _diagnosis.RisOnsetDate != null)
        {
            setDateFieldHelper.setMaskedTextboxDate(DateTime.Parse(_diagnosis.RisOnsetDate),
            DiagnosisRisDate_textBox);
        }
        Remarks_textbox.Text = _diagnosis.DiagnosisRemarks;

    }


    private bool setDiagnosis()
    {
        _diagnosis.PatientCode = _RecivedId;
        string dateofonsetset = setDateFieldHelper.ValidateUnnullableDate(DiagnosisDateofOnsetDate_textBox);
        if (dateofonsetset == null)
        {
            _diagnosis.DateOfOnset = DiagnosisDateofOnsetDate_textBox.Date.ToString();
        }
        else
        {
            DisplayAlert("Error", dateofonsetset, "ok");
            return false;
        }

        if (Supratentorial_checkBox.IsChecked)
        {
            _diagnosis.Supratentorial = "Yes";
        }
        else _diagnosis.Supratentorial = "No";
        if (Brainstem_checkBox.IsChecked)
        {
            _diagnosis.BrainstemCerebellum = "Yes";
        }
        else _diagnosis.BrainstemCerebellum = "No";
        if (Spinal_Cord_checkBox.IsChecked)
        {
            _diagnosis.SpinalCord = "Yes";
        }
        else _diagnosis.SpinalCord = "No";
        if (Optic_Pathways_checkBox.IsChecked)
        {
            _diagnosis.OpticPathways = "Yes";
        }
        else _diagnosis.OpticPathways = "No";
        _diagnosis.OtherSymptoms = InputValidator.CaseFormatter(OtherSymptoms_textBox.Text);
        if (ProgressionFromOnset_checkBox.IsChecked)
        {
            _diagnosis.ProgressionFromOnset = "Yes";
        }
        else _diagnosis.ProgressionFromOnset = "No";

        string DiagnosisConfirmedDateSet = setDateFieldHelper.ValidateNullableDate(DiagnosisConfirmedDate_textBox);
        if (DiagnosisConfirmedDateSet == null)
        {
            _diagnosis.ConfirmedDiagnosisDate = DiagnosisConfirmedDate_textBox.Date.ToString() == "  .  ." ? null :
                DiagnosisConfirmedDate_textBox.Date.ToString();
        }
        else
        {
            DisplayAlert("Error", dateofonsetset, "ok");
            return false;
        }
        if (ClinicalFindings_checkBox.IsChecked)
        {
            _diagnosis.DiagnosisConfirmedByClinicalFindings = "Yes";
        }
        else
            _diagnosis.DiagnosisConfirmedByClinicalFindings = "No";
        if (MRI_checkBox.IsChecked)
        {
            _diagnosis.DiagnosisConfirmedByMri = "Yes";
        }
        else
            _diagnosis.DiagnosisConfirmedByMri = "No";
        if (CSF_checkBox.IsChecked)
        {
            _diagnosis.DiagnosisConfirmedByCsf = "Yes";
        }
        else _diagnosis.DiagnosisConfirmedByCsf = "No";
        if (EvokedPotentiels_checkBox.IsChecked)
        {
            _diagnosis.DiagnosisConfirmedByEvokedPotentials = "Yes";
        }
        else _diagnosis.DiagnosisConfirmedByEvokedPotentials = "No";

        _diagnosis.DiagnosisConfirmedByOther = InputValidator.CaseFormatter(OtherDiagnosis_textBox.Text);
        _diagnosis.DiagnosisMcDonaldClassification = McDonaldClassification_comboBox.SelectedItem.ToString();
        _diagnosis.DiagnosisPoserClassification = PoserClassification_comboBox.SelectedItem.ToString();
        _diagnosis.DiagnosisNmoClassification = MNOClassification_comboBox.SelectedItem.ToString();

        string DiagnosisRisDateSet = setDateFieldHelper.ValidateNullableDate(DiagnosisRisDate_textBox);
        if (DiagnosisRisDateSet == null)
        {
            _diagnosis.RisOnsetDate = DiagnosisRisDate_textBox.Date.ToString() == "  .  ." ? null :
                DiagnosisRisDate_textBox.Date.ToString();
        }
        else
        {
            DisplayAlert("Error", dateofonsetset, "ok");
            return false;
        }


        string DiagnosisStartDateSet = setDateFieldHelper.ValidateNullableDate(DiagnosisStartDate_textBox);
        if (DiagnosisStartDateSet == null)
        {
            _diagnosis.StartodProgression = DiagnosisStartDate_textBox.Date.ToString() == "  .  ." ? null :
                DiagnosisStartDate_textBox.Date.ToString();
        }
        else
        {
            DisplayAlert("Error", dateofonsetset, "ok");
            return false;
        }
        _diagnosis.DiagnosisRemarks = InputValidator.CaseFormatter(Remarks_textbox.Text);
        return true;
    }

    private void Button_SaveDiagnosis_Clicked(object sender, EventArgs e)
    {
        _diagnosis = diagnosisService.GetByPatientId(_RecivedId).Data;
        if (_diagnosis == null)
        {
            _diagnosis = new Diagnosis();
            if (setDiagnosis())
            {
                diagnosisService.Add(_diagnosis);
                Navigation.PopAsync();
            }
        }
        else if (_diagnosis != null && setDiagnosis())
        {
            diagnosisService.Update(_diagnosis);
            Navigation.PopAsync();
        }


    }
}