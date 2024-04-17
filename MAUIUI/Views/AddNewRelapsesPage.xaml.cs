using MAUIUI.Business.Abstract;
using MAUIUI.Business.DependencyResoulver.AutofacResoulver;
using MAUIUI.Entities.Concrete;
using MAUIUI.Helpers;

namespace MAUIUI.Views;

public partial class AddNewRelapsesPage : ContentPage
{

    string _recivedPatientId;
    IRelapseService relapsesService;
    string _RecivedId;
    Relapse _relapses;
    List<Relapse> _relapsesList;
    List<string?> _relapsesDates;
    public AddNewRelapsesPage(string selectedPatient)
	{
		InitializeComponent();
        _RecivedId = selectedPatient;
        relapsesService = InstanceFactory.GetInstance<IRelapseService>();
        _relapses = new Relapse();
    }
    private void Button_SaveAddNewRelapses_Clicked(object sender, EventArgs e)
    { 
        if (setRelapses() && setDateFieldHelper.
                ValidateStartEndDate(this.RelapsesCosticosteroidsStartDate_textBox, this.RelapsesCosticosteroidsEndDate_textBox) ==null&& setDateFieldHelper.
                ValidateStartEndDate(this.RelapsesOtherStartDate_textBox, this.RelapsesOtherEndingDate_textBox) == null)
        {
            relapsesService.Add(_relapses);
            Navigation.PopAsync();
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
        if(Duration_textbox.Text!=null)
        _relapses.Duration = Duration_textbox.Text.Length > 0 ? int.Parse(Duration_textbox.Text) : null;

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

        if (setDateFieldHelper.ValidateNullableDate(RelapsesCosticosteroidsStartDate_textBox) == null)
        {
            _relapses.CosticosteroidsStartDate =  RelapsesCosticosteroidsStartDate_textBox.Date;
        }
        else return false;
        if (setDateFieldHelper.ValidateNullableDate(RelapsesCosticosteroidsEndDate_textBox) == null)
        {
            _relapses.CosticosteroidsEndDate = RelapsesCosticosteroidsEndDate_textBox.Date;
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
}