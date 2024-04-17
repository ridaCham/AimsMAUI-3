using MAUIUI.Business.Abstract;
using MAUIUI.Business.DependencyResoulver.AutofacResoulver;
using MAUIUI.Entities.Concrete;
using MAUIUI.Helpers;

namespace MAUIUI.Views;

public partial class ParaclinicalCSFView : ContentView
{
    private readonly StackLayout _layout_ParaclinicalTests;

    ICSFService _CSFService;
    string _RecivedId;
    List<CSF> _CSFs;
    CSF cSF;
    List<string?> _CSFDates;

    public ParaclinicalCSFView(StackLayout layout_ParaclinicalTests, string _selectedPatientId)
    {
        InitializeComponent();
        _layout_ParaclinicalTests = layout_ParaclinicalTests;
        _RecivedId = _selectedPatientId;
        _CSFService = InstanceFactory.GetInstance<ICSFService>();
        _CSFs = new List<CSF>();
        _CSFs = _CSFService.GetAllByPatientId(_RecivedId).Data;
        if (_CSFs.Count > 0)
        {
            cSF = new CSF();
            _CSFDates = new List<string?>();
            foreach (var bloodchemistry in _CSFs)
            {
                if (bloodchemistry.CSFCollectionDate != null)
                {
                    _CSFDates.Add(bloodchemistry.Id.ToString() +
                        ". " + bloodchemistry.CSFCollectionDate.ToString().Substring(0, 10));
                }
            }
            this.OtherCsf_combobox.ItemsSource = _CSFDates;
            cSF = _CSFs[0];
            setFields(cSF);

        }

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
    
     
    private void setFields(CSF _CSF)
    {
        setDateFieldHelper.setMaskedTextboxDate(_CSF.CSFCollectionDate,
            CsfCollectionDate_textBox);
        if (_CSF.CSFKept == "Yes")
        {
            Kept_radioButton.IsChecked = true;
        }
        else Kept_radioButton.IsChecked = false;
        if (_CSF.CSFKept == "No")
        {
            NonKept_radioButton.IsChecked = true;
        }
        else NonKept_radioButton.IsChecked = false;
        if (_CSF.CSFTraumatic == "Yes")
        {
            Traumatic_checkBox.IsChecked = true;
        }
        else Traumatic_checkBox.IsChecked = false;
        if (_CSF.AbnormalCSFTraumatic == "Yes")
        {
            Typical_checkBox.IsChecked = true;
        }
        else Typical_checkBox.IsChecked = false;
        if (_CSF.CSFNormal == "Yes")
        {
            Normal_checkBox.IsChecked = true;
        }
        else Normal_checkBox.IsChecked = false;
        if (_CSF.CSFAbnormal == "Yes")
        {
            Atypical_checkBox.IsChecked = true;
        }
        else Atypical_checkBox.IsChecked = false;

        this.WhiteCellCount_textBox.Text = _CSF.WhiteCellCount;
        this.Lymphocytes_textBox.Text = _CSF.Lymphocyte;
        this.Granulocytes_textBox.Text = _CSF.Granulocyte;
        this.PlasmaCells_textBox.Text = _CSF.PlasmaCell;
        this.Erythrocytes_textBox.Text = _CSF.Erythrocytes;

        this.TotalProtein_textBox.Text = _CSF.TotalProtein;
        this.Glucose_textBox.Text = _CSF.Glucose;
        this.Albumin_textBox.Text = _CSF.Albumin;
        this.QAlbumin_textBox.Text = _CSF.QAlbumin;
        this.IgG_textBox.Text = _CSF.IgG;
        this.IgGIndex_textBox.Text = _CSF.IgGIndex;
        this.Other_textBox.Text = _CSF.Other;

        setDateFieldHelper.getPickerValue(JCVirusinCSF_comboBox, _CSF.JCVirusInCSF);
        setDateFieldHelper.getPickerValue(Result_comboBox, _CSF.Result);
        if (_CSF.OligoclonalNotDone == "Yes")
        {
            NotDone_checkBox.IsChecked = true;
        }
        else NotDone_checkBox.IsChecked = false;

        if (_CSF.OCBAbcentInCSF == "Yes")
        {
            OCBAbsent_checkBox.IsChecked = true;
        }
        else OCBAbsent_checkBox.IsChecked = false;

        if (_CSF.OCBDetectedInCSF == "Yes")
        {
            OCBDetected_checkBox.IsChecked = true;
        }
        else OCBDetected_checkBox.IsChecked = false;
        NumOCBinCSF_textBox.Text = _CSF.NumberOfOligoclonal;

        if (_CSF.MatchedOCBDetected == "Yes")
        {
            MatchedOCB_checkBox.IsChecked = true;
        }
        else MatchedOCB_checkBox.IsChecked = false;

        if (_CSF.NoMatchedOCBDetected == "Yes")
        {
            NOMatchedOCB_checkBox.IsChecked = true;
        }
        else NOMatchedOCB_checkBox.IsChecked = false;
        if (_CSF.SerumSimpleNotDone == "Yes")
        {
            SerumNotDone_checkBox.IsChecked = true;
        }
        else SerumNotDone_checkBox.IsChecked = false;
        this.Remarks_textBox.Text = _CSF.Remarks;
    }







    private void Button_AddNewCSF_Clicked(object sender, EventArgs e)
    {
        if (_layout_ParaclinicalTests.Children[0] is not AddNewParaclinicalCSFView)
        {
            _layout_ParaclinicalTests.Children.Clear();
            _layout_ParaclinicalTests.Children.Add(new AddNewParaclinicalCSFView(_layout_ParaclinicalTests,_RecivedId));
        }
    }

    private void Button_SaveCSF_Clicked(object sender, EventArgs e)
    {

        if (cSF == null)
        {
            Navigation.PopAsync();
        }
        else if (setCsf(cSF))
        {
            _CSFService.Update(cSF);
            Navigation.PopAsync();
        }
    }

    void  OtherCsf_combobox_SelectedIndexChanged(System.Object sender, System.EventArgs e)
    {

        foreach (var csf in _CSFs)
        {
            if (csf.CSFCollectionDate != null && OtherCsf_combobox.SelectedItem.ToString().Contains(csf.Id.ToString() +
                ". " + csf.CSFCollectionDate.ToString().Substring(0, csf.CSFCollectionDate.ToString().IndexOf(" "))))
            {
                this.cSF = csf;
                setFields(cSF);
            }
        }
    }

}