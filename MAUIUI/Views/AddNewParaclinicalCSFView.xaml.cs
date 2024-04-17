using MAUIUI.Business.Abstract;
using MAUIUI.Business.DependencyResoulver.AutofacResoulver;
using MAUIUI.Entities.Concrete;
using MAUIUI.Helpers;

namespace MAUIUI.Views;

public partial class AddNewParaclinicalCSFView : ContentView
{
    private readonly StackLayout _layout_ParaclinicalTests;

    ICSFService _CSFService;
    string _RecivedId;
    List<CSF> _CSFs;
    CSF cSF;
    List<string?> _CSFDates;
    public AddNewParaclinicalCSFView(StackLayout layout_ParaclinicalTests, string _selectedPatientId)
    {
        InitializeComponent();
        _layout_ParaclinicalTests = layout_ParaclinicalTests;
        _RecivedId = _selectedPatientId;
        _CSFService = InstanceFactory.GetInstance<ICSFService>();
        _CSFs = new List<CSF>();
        cSF = new CSF();

    }



    private bool setCsf(CSF _CSF)
    {
        _CSF.PatientCode = _RecivedId;
        if (setDateFieldHelper.ValidateUnnullableDate(CsfCollectionDate_textBox) == null)
        {
            _CSF.CSFCollectionDate = CsfCollectionDate_textBox.Date;
        }
        else return false;
        if (Kept_radioButton.IsChecked)
        {
            _CSF.CSFKept = "Yes";
        }
        else if (NonKept_radioButton.IsChecked)
        {
            _CSF.CSFKept = "No";
        }

        if (Traumatic_checkBox.IsChecked)
        {
            _CSF.CSFTraumatic = "Yes";
        }
        else _CSF.CSFTraumatic = "No";
        if (Typical_checkBox.IsChecked)
        {
            _CSF.AbnormalCSFTraumatic = "Yes";
        }
        else _CSF.AbnormalCSFTraumatic = "No";
        if (Normal_checkBox.IsChecked)
        {
            _CSF.CSFNormal = "Yes";
        }
        else _CSF.CSFNormal = "No";
        if (Atypical_checkBox.IsChecked)
        {
            _CSF.CSFAbnormal = "Yes";
        }
        else _CSF.CSFAbnormal = "No";

        _CSF.WhiteCellCount = this.WhiteCellCount_textBox.Text;
        _CSF.Lymphocyte = this.Lymphocytes_textBox.Text;
        _CSF.Granulocyte = this.Granulocytes_textBox.Text;
        _CSF.PlasmaCell = this.PlasmaCells_textBox.Text;
        _CSF.Erythrocytes = this.Erythrocytes_textBox.Text;

        _CSF.TotalProtein = this.TotalProtein_textBox.Text;
        _CSF.Glucose = this.Glucose_textBox.Text;
        _CSF.Albumin = this.Albumin_textBox.Text;
        _CSF.QAlbumin = this.QAlbumin_textBox.Text;
        _CSF.IgG = this.IgG_textBox.Text;
        _CSF.IgGIndex = this.IgGIndex_textBox.Text;
        _CSF.Other = this.Other_textBox.Text;





        _CSF.JCVirusInCSF = setDateFieldHelper.getPickerValue(JCVirusinCSF_comboBox, _CSF.JCVirusInCSF);
        _CSF.Result = setDateFieldHelper.getPickerValue(Result_comboBox, _CSF.Result);

        if (NotDone_checkBox.IsChecked)
        {
            _CSF.OligoclonalNotDone = "Yes";
        }
        else _CSF.OligoclonalNotDone = "No";

        if (OCBAbsent_checkBox.IsChecked)
        {
            _CSF.OCBAbcentInCSF = "Yes";
        }
        else _CSF.OCBAbcentInCSF = "No";

        if (OCBDetected_checkBox.IsChecked)
        {
            _CSF.OCBDetectedInCSF = "Yes";
        }
        else _CSF.OCBDetectedInCSF = "No";
        _CSF.NumberOfOligoclonal = NumOCBinCSF_textBox.Text;
        if (MatchedOCB_checkBox.IsChecked)
        {
            _CSF.MatchedOCBDetected = "Yes";
        }
        else _CSF.MatchedOCBDetected = "No";
        if (NOMatchedOCB_checkBox.IsChecked)
        {
            _CSF.NoMatchedOCBDetected = "Yes";
        }
        else _CSF.NoMatchedOCBDetected = "No";
        if (SerumNotDone_checkBox.IsChecked)
        {
            _CSF.SerumSimpleNotDone = "Yes";
        }
        else _CSF.SerumSimpleNotDone = "No";

        _CSF.Remarks = this.Remarks_textBox.Text;
        return true;
    }


    private void Button_SaveAddNewCSF_Clicked(object sender, EventArgs e)
    {
        if (setCsf(cSF))
        {
            _CSFService.Add(cSF);
            _layout_ParaclinicalTests.Children.Clear();
            _layout_ParaclinicalTests.Children.Add(new ParaclinicalCSFView(_layout_ParaclinicalTests, _RecivedId));
        }
    }
}