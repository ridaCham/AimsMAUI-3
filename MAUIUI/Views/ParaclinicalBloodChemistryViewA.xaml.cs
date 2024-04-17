using MAUIUI.Business.Abstract;
using MAUIUI.Business.DependencyResoulver.AutofacResoulver;
using MAUIUI.Entities.Concrete;
using MAUIUI.Helpers;

namespace MAUIUI.Views;

public partial class ParaclinicalBloodChemistryView : ContentView
{
    private readonly StackLayout _layout_ParaclinicalTests;
    IBloodChemistryService bloodChemistryService;
    string _RecivedId;
    BloodChemistry bloodChemistry;
    List<string?> _BloodChemistryDates;
    List<BloodChemistry> _BloodChemistryList;

    public ParaclinicalBloodChemistryView(StackLayout layout_ParaclinicalTests, string _selectedpatientId)
    {
        InitializeComponent();
        _layout_ParaclinicalTests = layout_ParaclinicalTests;
        _RecivedId = _selectedpatientId;
        bloodChemistryService = InstanceFactory.GetInstance<IBloodChemistryService>();


        _BloodChemistryList = new List<BloodChemistry>();
        _BloodChemistryList = bloodChemistryService.GetAllByPatientId(_RecivedId).Data;

        if (_BloodChemistryList.Count > 0)
        {
            bloodChemistry = new BloodChemistry();
            _BloodChemistryDates = new List<string?>();
            foreach (var bloodchemistry in _BloodChemistryList)
            {
                if (bloodchemistry.ExamDate != null)
                {
                    _BloodChemistryDates.Add(bloodchemistry.Id.ToString() +
                        ". " + bloodchemistry.ExamDate.ToString().Substring(0, 10));
                }
            }
            this.OtherBloodChemistry_combobox.ItemsSource = _BloodChemistryDates;
            bloodChemistry = _BloodChemistryList[0];
            setFields(bloodChemistry);
        }

    }

    private void Button_AddNewBloodChemistry_Clicked(object sender, EventArgs e)
    {
        if (_layout_ParaclinicalTests.Children[0] is not AddNewParaclinicalBloodChemistryView)
        {
            _layout_ParaclinicalTests.Children.Clear();
            _layout_ParaclinicalTests.Children.Add(new AddNewParaclinicalBloodChemistryView(_layout_ParaclinicalTests,_RecivedId));
        }
    }

    private void Button_SaveBloodChemistry_Clicked(object sender, EventArgs e)
    {
        if (bloodChemistry == null)
        {
            Navigation.PopAsync();
        }
        else if (setBloodChemistry(bloodChemistry))
        {
            bloodChemistryService.Update(bloodChemistry);
            Navigation.PopAsync();
        }
    }

    public bool setBloodChemistry(BloodChemistry _bloodChemistry)
    {
        _bloodChemistry.PatientCode = _RecivedId;
        if (setDateFieldHelper.ValidateUnnullableDate(BloodExamDate_textBox)==null)
        {
            _bloodChemistry.ExamDate = BloodExamDate_textBox.Date;
        }
        else return false;
        _bloodChemistry.TotalProtein = TotalProtein_textBox.Text;
        _bloodChemistry.Albumin = Albumin_textBox.Text;
        _bloodChemistry.Calcium = Calicium_textBox.Text;
        _bloodChemistry.Urea = Urea_textBox.Text;
        _bloodChemistry.UricAcid = UricAcid_textBox.Text;
        _bloodChemistry.Creatinine = Creatinine_textBox.Text;
        _bloodChemistry.SGOT = SGOT_AST_textBox.Text;
        _bloodChemistry.SGPT = SGPT_ALT_textBox.Text;
        _bloodChemistry.GammaGT = Gamma_Gt_textBox.Text;
        _bloodChemistry.Bilirubin = Bilirubin_textBox.Text;
        _bloodChemistry.AlkalinePhosphatase = AlkalinePhosphatase_textBox.Text;
        _bloodChemistry.Amylase = Amylase_textBox.Text;
        _bloodChemistry.Lipase = Lipase_textBox.Text;

        if (TotalProteinYes_radioButton.IsChecked)
        {
            _bloodChemistry.IsTotalProteinNormal = "Yes";
        }
        else if (TotalProteinNo_radioButton.IsChecked)
        {
            _bloodChemistry.IsTotalProteinNormal = "No";
        }
        if (AlbuminYes_radioButton.IsChecked)
        {
            _bloodChemistry.IsAlbuminNormal = "Yes";
        }
        else if (AlbuminNo_radioButton.IsChecked)
        {
            _bloodChemistry.IsAlbuminNormal = "No";
        }
        if (CaliciumYes_radioButton.IsChecked)
        {
            _bloodChemistry.IsCalciumNormal = "Yes";
        }
        else if (CaliciumNo_radioButton.IsChecked)
        {
            _bloodChemistry.IsCalciumNormal = "No";
        }
        if (UreaYes_radioButton.IsChecked)
        {
            _bloodChemistry.IsUreaNormal = "Yes";
        }
        else if (UreaNo_radioButton.IsChecked)
        {
            _bloodChemistry.IsUreaNormal = "No";
        }
        if (UricAcidYes_radioButton.IsChecked)
        {
            _bloodChemistry.IsUricAcidNormal = "Yes";
        }
        else if (UricAcidNo_radioButton.IsChecked)
        {
            _bloodChemistry.IsUricAcidNormal = "No";
        }
        if (CreatinineYes_radioButton.IsChecked)
        {
            _bloodChemistry.IsCreatinineNormal = "Yes";
        }
        else if (CreatinineNo_radioButton.IsChecked)
        {
            _bloodChemistry.IsCreatinineNormal = "No";
        }

        if (SGOT_ASTYes_radioButton.IsChecked)
        {
            _bloodChemistry.IsSGOTNormal = "Yes";
        }
        else if (SGOT_ASTLipaseNo_radioButton.IsChecked)
        {
            _bloodChemistry.IsSGOTNormal = "No";
        }
        if (SGPT_ALTYes_radioButton.IsChecked)
        {
            _bloodChemistry.IsSGPTNormal = "Yes";
        }
        else if (SGPT_ALTNo_radioButton.IsChecked)
        {
            _bloodChemistry.IsSGPTNormal = "No";
        }
        if (Gamma_GtYes_radioButton.IsChecked)
        {
            _bloodChemistry.IsGammaGTNormal = "Yes";
        }
        else if (Gamma_GtNo_radioButton.IsChecked)
        {
            _bloodChemistry.IsGammaGTNormal = "No";
        }
        if (BilrubinYes_radioButton.IsChecked)
        {
            _bloodChemistry.IsBilirubinNormal = "Yes";
        }
        else if (BilirubinNo_radioButton.IsChecked)
        {
            _bloodChemistry.IsBilirubinNormal = "No";
        }
         //if (BilirubinYes_radioButton.Checked)
         //   {
         //       _bloodChemistry.IsBilirubinNormal = "Yes";
         //   }
         //   else if (BilirubinNo_radioButton.IsChecked)
         //   {
         //       _bloodChemistry.IsBilirubinNormal = "No";
         //   }
            if (AlkalinePhosphataseYes_radioButton.IsChecked)
            {
                _bloodChemistry.IsAlkalinePhosphataseNormal = "Yes";
            }
            else if (AlkalinePhosphataseNo_radioButton.IsChecked)
{
    _bloodChemistry.IsAlkalinePhosphataseNormal = "No";
}
if (AmylaseYes_radioButton.IsChecked)
{
    _bloodChemistry.IsAmylaseNormal = "Yes";
}
else if (AmylaseNo_radioButton.IsChecked)
{
    _bloodChemistry.IsAmylaseNormal = "No";
}
if (LipaseYes_radioButton.IsChecked)
{
    _bloodChemistry.IsLipaseNormal = "Yes";
}
else if (LipaseNo_radioButton.IsChecked)
{
    _bloodChemistry.IsLipaseNormal = "No";
}
_bloodChemistry.TotalProteinComment = TotalProteinComment_textBox.Text;
_bloodChemistry.AlbuminComment = AlbuminComment_textBox.Text;
_bloodChemistry.CalciumComment = CaliciumComment_textBox.Text;
_bloodChemistry.UreaComment = UreaComment_textBox.Text;
_bloodChemistry.UricAcidComment = UricAcidComment_textBox.Text;
_bloodChemistry.CreatinineComment = CreatinineComment_textBox.Text;
_bloodChemistry.SGOTComment = Sgot_altComment_textBox.Text;
_bloodChemistry.SGPTComment = SGPT_ALTComment_textBox.Text;
_bloodChemistry.GammaGTComment = GAMMA_GTComment_textBox.Text;
_bloodChemistry.BilirubinComment = BilirubinComment_textBox.Text;
_bloodChemistry.AlkalinePhosphataseComment = AlkalinePhosphataseComment_textBox.Text;
_bloodChemistry.AmylaseComment = AmylaseComment_textBox.Text;
_bloodChemistry.LipaseComment = LipaseComment_textBox.Text;
return true;
        }
    public void setFields(BloodChemistry _bloodChemistry)
    {

        setDateFieldHelper.setMaskedTextboxDate(_bloodChemistry.ExamDate,
            BloodExamDate_textBox);
        this.TotalProtein_textBox.Text = _bloodChemistry.TotalProtein;
        this.Albumin_textBox.Text = _bloodChemistry.Albumin;
        this.Calicium_textBox.Text = _bloodChemistry.Calcium;
        this.Urea_textBox.Text = _bloodChemistry.Urea;
        this.UricAcid_textBox.Text = _bloodChemistry.UricAcid;
        this.Creatinine_textBox.Text = _bloodChemistry.Creatinine;
        this.SGOT_AST_textBox.Text = _bloodChemistry.SGOT;
        this.SGPT_ALT_textBox.Text = _bloodChemistry.SGPT;
        this.Gamma_Gt_textBox.Text = _bloodChemistry.GammaGT;
        this.Bilirubin_textBox.Text = _bloodChemistry.Bilirubin;
        this.AlkalinePhosphatase_textBox.Text = _bloodChemistry.AlkalinePhosphatase;
        this.Amylase_textBox.Text = _bloodChemistry.Amylase;
        this.Lipase_textBox.Text = _bloodChemistry.Lipase;

        if (_bloodChemistry.IsTotalProteinNormal == "Yes")
        {
            TotalProteinYes_radioButton.IsChecked = true;
        }
        else if (_bloodChemistry.IsTotalProteinNormal == "No")
        {
            TotalProteinNo_radioButton.IsChecked = true;
        }
        if (_bloodChemistry.IsAlbuminNormal == "Yes")
        {
            AlbuminYes_radioButton.IsChecked = true;
        }
        else if (_bloodChemistry.IsAlbuminNormal == "No")
        {
            AlbuminNo_radioButton.IsChecked = true;
        }
        if (_bloodChemistry.IsCalciumNormal == "Yes")
        {
            CaliciumYes_radioButton.IsChecked = true;
        }
        else if (_bloodChemistry.IsCalciumNormal == "No")
        {
            CaliciumNo_radioButton.IsChecked = true;
        }
        if (_bloodChemistry.IsUreaNormal == "Yes")
        {
            UreaYes_radioButton.IsChecked = true;
        }
        else if (_bloodChemistry.IsUreaNormal == "No")
        {
            UreaNo_radioButton.IsChecked = true;
        }
        if (_bloodChemistry.IsUricAcidNormal == "Yes")
        {
            UricAcidYes_radioButton.IsChecked = true;
        }
        else if (_bloodChemistry.IsUricAcidNormal == "No")
        {
            UricAcidNo_radioButton.IsChecked = true;
        }
        if (_bloodChemistry.IsCreatinineNormal == "Yes")
        {
            CreatinineYes_radioButton.IsChecked = true;
        }
        else if (_bloodChemistry.IsCreatinineNormal == "No")
        {
            CreatinineNo_radioButton.IsChecked = true;
        }
        if (_bloodChemistry.IsSGOTNormal == "Yes")
        {
            SGOT_ASTYes_radioButton.IsChecked = true;
        }
        else if (_bloodChemistry.IsSGOTNormal == "No")
        {
            SGOT_ASTLipaseNo_radioButton.IsChecked = true;
        }
        if (_bloodChemistry.IsSGPTNormal == "Yes")
        {
            SGPT_ALTYes_radioButton.IsChecked = true;
        }
        else if (_bloodChemistry.IsSGPTNormal == "No")
        {
            SGPT_ALTNo_radioButton.IsChecked = true;
        }
        if (_bloodChemistry.IsGammaGTNormal == "Yes")
        {
            Gamma_GtYes_radioButton.IsChecked = true;
        }
        else if (_bloodChemistry.IsGammaGTNormal == "No")
        {
            Gamma_GtNo_radioButton.IsChecked = true;
        }
        if (_bloodChemistry.IsBilirubinNormal == "Yes")
        {
            BilrubinYes_radioButton.IsChecked = true;
        }
        else if (_bloodChemistry.IsBilirubinNormal == "No")
        {
            BilirubinNo_radioButton.IsChecked = true;
        }
        if (_bloodChemistry.IsAlkalinePhosphataseNormal == "Yes")
        {
            AlkalinePhosphataseYes_radioButton.IsChecked = true;
        }
        else if (_bloodChemistry.IsAlkalinePhosphataseNormal == "No")
        {
            AlkalinePhosphataseNo_radioButton.IsChecked = true;
        }
        if (_bloodChemistry.IsAmylaseNormal == "Yes")
        {
            AmylaseYes_radioButton.IsChecked = true;
        }
        else if (_bloodChemistry.IsAmylaseNormal == "No")
        {
            AmylaseNo_radioButton.IsChecked = true;
        }
        if (_bloodChemistry.IsLipaseNormal == "Yes")
        {
            LipaseYes_radioButton.IsChecked = true;
        }
        else if (_bloodChemistry.IsLipaseNormal == "No")
        {
            LipaseNo_radioButton.IsChecked = true;
        }
        this.TotalProteinComment_textBox.Text = _bloodChemistry.TotalProteinComment;
        this.AlbuminComment_textBox.Text = _bloodChemistry.AlbuminComment;
        this.CaliciumComment_textBox.Text = _bloodChemistry.CalciumComment;
        this.UreaComment_textBox.Text = _bloodChemistry.UreaComment;
        this.UricAcidComment_textBox.Text = _bloodChemistry.UricAcidComment;
        this.CreatinineComment_textBox.Text = _bloodChemistry.CreatinineComment;
        this.Sgot_altComment_textBox.Text = _bloodChemistry.SGOTComment;
        this.SGPT_ALTComment_textBox.Text = _bloodChemistry.SGPTComment;
        this.GAMMA_GTComment_textBox.Text = _bloodChemistry.GammaGTComment;
        this.BilirubinComment_textBox.Text = _bloodChemistry.BilirubinComment;
        this.AlkalinePhosphataseComment_textBox.Text = _bloodChemistry.AlkalinePhosphataseComment;
        this.AmylaseComment_textBox.Text = _bloodChemistry.AmylaseComment;
        this.LipaseComment_textBox.Text = _bloodChemistry.LipaseComment;
    }

    void Picker_SelectedIndexChanged(System.Object sender, System.EventArgs e)
    {

        foreach (var bloodChemistry in _BloodChemistryList)
        {
            if (bloodChemistry.ExamDate != null && OtherBloodChemistry_combobox.SelectedItem.ToString().Contains(bloodChemistry.Id.ToString() +
                ". " + bloodChemistry.ExamDate.ToString().Substring(0, bloodChemistry.ExamDate.ToString().IndexOf(" "))))
            {
                this.bloodChemistry = bloodChemistry;
                RadiobuttonCleaner.cleanRadiobuttons(TotalProteinYes_radioButton, TotalProteinNo_radioButton, AlbuminYes_radioButton,
                        AlbuminNo_radioButton, CaliciumYes_radioButton, CaliciumNo_radioButton, UreaYes_radioButton,
                        UreaNo_radioButton, UricAcidYes_radioButton, UricAcidNo_radioButton, CreatinineYes_radioButton, CreatinineNo_radioButton,
                        SGOT_ASTYes_radioButton, SGOT_ASTLipaseNo_radioButton, SGPT_ALTYes_radioButton, SGPT_ALTNo_radioButton,
                        Gamma_GtYes_radioButton, Gamma_GtNo_radioButton, BilrubinYes_radioButton, BilirubinNo_radioButton, AlkalinePhosphataseYes_radioButton,
                        AlkalinePhosphataseNo_radioButton, AmylaseYes_radioButton, AmylaseNo_radioButton, LipaseYes_radioButton, LipaseNo_radioButton
                    );
                setFields(bloodChemistry);
            }
        }
    }
}


