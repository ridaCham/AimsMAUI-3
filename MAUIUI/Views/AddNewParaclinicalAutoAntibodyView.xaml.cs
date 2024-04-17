using MAUIUI.Business.Abstract;
using MAUIUI.Business.DependencyResoulver.AutofacResoulver;
using MAUIUI.Entities.Concrete;
using MAUIUI.Helpers;

namespace MAUIUI.Views;

public partial class AddNewParaclinicalAutoAntibodyView : ContentView
{
    private readonly StackLayout _layout_ParaclinicalTests;
    IAutoAntiBodyTestService autoAntiBodyTestService;
    string _RecivedId;
    AutoAntiBodyTest autoAntiBodyTest;
    public AddNewParaclinicalAutoAntibodyView(StackLayout layout_ParaclinicalTests, string _selectedpatientId)
    {
        InitializeComponent();
        _layout_ParaclinicalTests = layout_ParaclinicalTests;
        _RecivedId = _selectedpatientId;
        autoAntiBodyTestService = InstanceFactory.GetInstance<IAutoAntiBodyTestService>();
        autoAntiBodyTest = new AutoAntiBodyTest();
    }


     
    public bool setAutoAntibodyTest( AutoAntiBodyTest _autoAntiBodyTest)
    {
        _autoAntiBodyTest.PatientCode = _RecivedId;
        if (setDateFieldHelper.ValidateUnnullableDate(AutoantibodyExamDate_textBox)==null)
        {
            _autoAntiBodyTest.ExamDate = AutoantibodyExamDate_textBox.Date;
        }
        else return false;
        if (AcetylcholineNegative_radioButton.IsChecked)
        {
            _autoAntiBodyTest.Acetylecholine = "Negative";
        }
        if (AcetylcholinePositive_radioButton.IsChecked)
        {
            _autoAntiBodyTest.Acetylecholine = "Positive";
        }
        if (AntiMuskNegative_radioButton.IsChecked)
        {
            _autoAntiBodyTest.AntiMusk = "Negative";
        }
        if (AntiMuskPositive_radioButton.IsChecked)
        {
            _autoAntiBodyTest.AntiMusk = "Positive";
        }
        if (AntiRyaidinNegative_radioButton.IsChecked)
        {
            _autoAntiBodyTest.AntiRyanodin = "Negative";
        }
        if (AntiRyaidinPositive_radioButton.IsChecked)
        {
            _autoAntiBodyTest.AntiRyanodin = "Positive";
        }
        if (AntiGliadinNegative_radioButton.IsChecked)
        {
            _autoAntiBodyTest.AntiGliadin = "Negative";
        }
        if (AntiGliadinPositive_radioButton.IsChecked)
        {
            _autoAntiBodyTest.AntiGliadin = "Positive";
        }
        if (LRP_4Negative_radioButton.IsChecked)
        {
            _autoAntiBodyTest.LRP4 = "Negative";
        }
        if (LRP_4Positive_radioButton.IsChecked)
        {
            _autoAntiBodyTest.LRP4 = "Positive";
        }
        if (TitinNegative_radioButton.IsChecked)
        {
            _autoAntiBodyTest.Titin = "Negative";
        }
        if (TitinPositive_radioButton.IsChecked)
        {
            _autoAntiBodyTest.Titin = "Positive";
        }
        if (CaliciumChannelAntibodyNegative_radioButton.IsChecked)
        {
            _autoAntiBodyTest.CLChannelAntibody = "Negative";
        }
        if (CaliciumChannelAntibodyPositive_radioButton.IsChecked)
        {
            _autoAntiBodyTest.CLChannelAntibody = "Positive";
        }
        if (AntiNMONegative_radioButton.IsChecked)
        {
            _autoAntiBodyTest.AntiNMO = "Negative";
        }
        if (AntiNMOPositive_radioButton.IsChecked)
        {
            _autoAntiBodyTest.AntiNMO = "Positive";
        }
        if (AntiMOGNegative_radioButton.IsChecked)
        {
            _autoAntiBodyTest.AntiMOG = "Negative";
        }
        if (AntiMOGPositive_radioButton.IsChecked)
        {
            _autoAntiBodyTest.AntiMOG = "Positive";
        }
        if (AntiRapsonidineNegative_radioButton.IsChecked)
        {
            _autoAntiBodyTest.Rapsodine = "Negative";
        }
        if (AntirapsonidinePositive_radioButton.IsChecked)
        {
            _autoAntiBodyTest.Rapsodine = "Positive";
        }
        _autoAntiBodyTest.AcetylecholineComment = AcetylcholineComments_textBox.Text;
        _autoAntiBodyTest.AntiMuskComment = Anti_muskComment_textBox.Text;
        _autoAntiBodyTest.AntiRyanodinComment = Anti_ryaidinComment_textBox.Text;
        _autoAntiBodyTest.AntiGliadinComment = Anti_gliadinComment_textBox.Text;
        _autoAntiBodyTest.LRP4Comment = LRP_4Comment_textBox.Text;
        _autoAntiBodyTest.TitinComment = TitinComment_textBox.Text;
        _autoAntiBodyTest.CLChannelAntibodyComment = CaliciumChannelAntibodyComment_textBox.Text;
        _autoAntiBodyTest.AntiNMOComment = AntiNMOComment_textBox.Text;
        _autoAntiBodyTest.AntiMOGComment = AntiMOGComment_textBox.Text;
        _autoAntiBodyTest.RapsodineComment = AntiRapsonidineComment_textBox.Text;
        _autoAntiBodyTest.ANA = ANA_textBox.Text;
        _autoAntiBodyTest.Antimitochondrial = Anti_mitochondries_textBox.Text;
        _autoAntiBodyTest.AntiParietal = AntiParietalCellAntibodies_textBox.Text;
        _autoAntiBodyTest.ASMA = Asma_textBox.Text;
        _autoAntiBodyTest.AntiRo = Anti_Ro_textBox.Text;
        _autoAntiBodyTest.La = La_textBox.Text;
        _autoAntiBodyTest.Sm = Sm_textBox.Text;
        _autoAntiBodyTest.RNP = Rnp_textBox.Text;
        _autoAntiBodyTest.Scl70 = Scl_70_textBox.Text;
        _autoAntiBodyTest.Jo1 = Jo1_textBox.Text;
        _autoAntiBodyTest.AntiDNA = AntiDNA_textBox.Text;
        _autoAntiBodyTest.ANCA = ANCA_textBox.Text;
        _autoAntiBodyTest.AntiLKM = Anti_LKM_textBox.Text;
        _autoAntiBodyTest.AntiCardiolinin = Anti_cardiolipin_textBox.Text;
        _autoAntiBodyTest.LAC = LAC_textBox.Text;
        _autoAntiBodyTest.antiTransglutaminase = Anti_transgluamnase_textBox.Text;
        if (AnaYes_radioButton.IsChecked)
        {
            _autoAntiBodyTest.IsANANormal = "Positive";
        }
        if (AnaNo_radioButton.IsChecked)
        {
            _autoAntiBodyTest.IsANANormal = "Negative";
        }
        if (Anti_mitochondriesYes_radioButton.IsChecked)
        {
            _autoAntiBodyTest.IsAntimitochondrialNormal = "Positive";
        }
        if (Anti_mitochondriesNo_radioButton.IsChecked)
        {
            _autoAntiBodyTest.IsAntimitochondrialNormal = "Negative";
        }
        if (AntiPartielCellAntibodiesYes_radioButton.IsChecked)
        {
            _autoAntiBodyTest.AntiParietalNormal = "Positive";
        }
        if (AntiPartielCellAntibodiesNo_radioButton.IsChecked)
        {
            _autoAntiBodyTest.AntiParietalNormal = "Negative";
        }
        if (AsmaYes_radioButton.IsChecked)
        {
            _autoAntiBodyTest.IsASMANormal = "Positive";
        }
        if (AsmaNo_radioButton.IsChecked)
        {
            _autoAntiBodyTest.IsASMANormal = "Negative";
        }
        if (AntiRoYes_radioButton.IsChecked)
        {
            _autoAntiBodyTest.IsAntiRoNormal = "Positive";
        }
        if (AntiRoNo_radioButton.IsChecked)
        {
            _autoAntiBodyTest.IsAntiRoNormal = "Negative";
        }
        if (LAYes_radioButton.IsChecked)
        {
            _autoAntiBodyTest.IsLaNormal = "Positive";
        }
        if (LaNo_radioButton.IsChecked)
        {
            _autoAntiBodyTest.IsLaNormal = "Negative";
        }
        if (SmYes_radioButton.IsChecked)
        {
            _autoAntiBodyTest.IsSmNormal = "Positive";
        }
        if (SmNo_radioButton.IsChecked)
        {
            _autoAntiBodyTest.IsSmNormal = "Negative";
        }
        if (RnpYes_radioButton.IsChecked)
        {
            _autoAntiBodyTest.IsRNPNormal = "Positive";
        }
        if (RNPNo_radioButton.IsChecked)
        {
            _autoAntiBodyTest.IsRNPNormal = "Negative";
        }
        if (Scl_70Yes_radioButton.IsChecked)
        {
            _autoAntiBodyTest.IsScl70Normal = "Positive";
        }
        if (Scl_70No_radioButton.IsChecked)
        {
            _autoAntiBodyTest.IsScl70Normal = "Negative";
        }
        if (Jo1Yes_radioButton.IsChecked)
        {
            _autoAntiBodyTest.IsJo1Normal = "Positive";
        }
        if (Jo1No_radioButton.IsChecked)
        {
            _autoAntiBodyTest.IsJo1Normal = "Negative";
        }
        if (AntiDNAYes_radioButton.IsChecked)
        {
            _autoAntiBodyTest.IsAntiDNANormal = "Positive";
        }
        if (AntiDNANo_radioButton.IsChecked)
        {
            _autoAntiBodyTest.IsAntiDNANormal = "Negative";
        }
        if (ANCAYes_radioButton.IsChecked)
        {
            _autoAntiBodyTest.IsANCANormal = "Positive";
        }
        if (AncaNo_radioButton.IsChecked)
        {
            _autoAntiBodyTest.IsANCANormal = "Negative";
        }
        if (Anti_LKMYes_radioButton.IsChecked)
        {
            _autoAntiBodyTest.IsAntiLKMNormal = "Positive";
        }
        if (Anti_LKMNo_radioButton.IsChecked)
        {
            _autoAntiBodyTest.IsAntiLKMNormal = "Negative";
        }
        if (Anti_cardiolipinYes_radioButton.IsChecked)
        {
            _autoAntiBodyTest.AntiCardiolininNormal = "Positive";
        }
        if (Anti_cardiolipinNo_radioButton.IsChecked)
        {
            _autoAntiBodyTest.AntiCardiolininNormal = "Negative";
        }
        if (LACYes_radioButton.IsChecked)
        {
            _autoAntiBodyTest.IsLACNormal = "Positive";
        }
        if (LACNo_radioButton.IsChecked)
        {
            _autoAntiBodyTest.IsLACNormal = "Negative";
        }
        if (Anti_transglutaminaseYes_radioButton.IsChecked)
        {
            _autoAntiBodyTest.IsAntiTransglutaminase = "Positive";
        }
        if (Anti_transglutaminaseNo_radioButton.IsChecked)
        {
            _autoAntiBodyTest.IsAntiTransglutaminase = "Negative";
        }
        _autoAntiBodyTest.ANAComment = AnaComment_textBox.Text;
        _autoAntiBodyTest.AntimitochondrialComment = Anti_mitochondriesComment_textBox.Text;
        _autoAntiBodyTest.AntiParietalComment = AntiParietalCellAntibodiesComment_textBox.Text;
        _autoAntiBodyTest.ASMAComment = AsmaComment_textBox.Text;
        _autoAntiBodyTest.AntiRoComment = Anti_RoComment_textBox.Text;
        _autoAntiBodyTest.LaComment = LAComment_textBox.Text;
        _autoAntiBodyTest.SmComment = SmComment_textBox.Text;
        _autoAntiBodyTest.RNPComment = RnpComment_textBox.Text;
        _autoAntiBodyTest.Scl70Comment = Scl_70Comment_textBox.Text;
        _autoAntiBodyTest.Jo1Comment = Jo1Comment_textBox.Text;
        _autoAntiBodyTest.AntiDNAComment = AntiDNAComment_textBox.Text;
        _autoAntiBodyTest.ANCAComment = AncaComment_textBox.Text;
        _autoAntiBodyTest.AntiLKMComment = Anti_LKMComment_textBox.Text;
        _autoAntiBodyTest.AntiCardiolininComment = AntiCardiolipinComment_textBox.Text;
        _autoAntiBodyTest.LACComment = LACComment_textBox.Text;
        _autoAntiBodyTest.antiTransglutaminaseComment = Anti_transgluamnaseComment_textBox.Text;
        return true;
    }



    private void Button_SaveAddNewAutoAntibody_Clicked(object sender, EventArgs e)
    {
        if (setAutoAntibodyTest(autoAntiBodyTest))
        {
            autoAntiBodyTestService.Add(autoAntiBodyTest);
            _layout_ParaclinicalTests.Children.Clear();
            _layout_ParaclinicalTests.Children.Add(new ParaclinicalAutoAntibodyView(_layout_ParaclinicalTests, _RecivedId));
        }
    }
}