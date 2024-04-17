using MAUIUI.Business.Abstract;
using MAUIUI.Business.DependencyResoulver.AutofacResoulver;
using MAUIUI.Entities.Concrete;
using MAUIUI.Helpers;

namespace MAUIUI.Views;

public partial class AddNewParaclinicalBloodChemistryView : ContentView
{

    IBloodChemistryService bloodChemistryService;
    string _RecivedId;
    BloodChemistry _bloodChemistry;
    private readonly StackLayout _layout_ParaclinicalTests;

    public AddNewParaclinicalBloodChemistryView(StackLayout layout_ParaclinicalTests, string _selectedpatientId)
    {
        InitializeComponent();
        _layout_ParaclinicalTests = layout_ParaclinicalTests;
        _RecivedId = _selectedpatientId;
        bloodChemistryService = InstanceFactory.GetInstance<IBloodChemistryService>();
        _bloodChemistry = new BloodChemistry();

    }
    public bool setBloodChemistry(BloodChemistry _bloodChemistry)
    {
        _bloodChemistry.PatientCode = _RecivedId;
        if (setDateFieldHelper.ValidateUnnullableDate(BloodExamDate_textBox) == null)
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
    private void Button_SaveBloodChemistry_Clicked(object sender, EventArgs e)
    {
        if (setBloodChemistry(_bloodChemistry))
        {
            bloodChemistryService.Add(_bloodChemistry);
            if (_layout_ParaclinicalTests.Children[0] is not ParaclinicalBloodChemistryView)
            {
                _layout_ParaclinicalTests.Children.Clear();
                _layout_ParaclinicalTests.Children.Add(new ParaclinicalBloodChemistryView(_layout_ParaclinicalTests, _RecivedId));
            }
        }
    }
}
