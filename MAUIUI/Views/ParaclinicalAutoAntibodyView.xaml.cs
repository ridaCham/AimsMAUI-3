using MAUIUI.Business.Abstract;
using MAUIUI.Business.DependencyResoulver.AutofacResoulver;
using MAUIUI.Entities.Concrete;
using MAUIUI.Helpers;

namespace MAUIUI.Views;

public partial class ParaclinicalAutoAntibodyView : ContentView
{
    private readonly StackLayout _layout_ParaclinicalTests;

    IAutoAntiBodyTestService autoAntiBodyTestService;
    string _RecivedId;
    List<string?>  _autoAntiBodyTestDates ;
    public List<AutoAntiBodyTest> _autoAntiBodyTestList;
    AutoAntiBodyTest autoAntiBodyTest;
    public ParaclinicalAutoAntibodyView(StackLayout layout_ParaclinicalTests, string _selectedpatientId)
	{
		InitializeComponent();
        _layout_ParaclinicalTests = layout_ParaclinicalTests; 
        _RecivedId = _selectedpatientId;
        
        autoAntiBodyTestService = InstanceFactory.GetInstance<IAutoAntiBodyTestService>();

        _autoAntiBodyTestList = new List<AutoAntiBodyTest>();
        _autoAntiBodyTestList = autoAntiBodyTestService.GetAllByPatientId(_RecivedId).Data;

        if (_autoAntiBodyTestList.Count > 0)
        {
            autoAntiBodyTest = new AutoAntiBodyTest();
            _autoAntiBodyTestDates = new List<string?>();
            foreach (var bloodchemistry in _autoAntiBodyTestList)
            {
                if (bloodchemistry.ExamDate != null)
                {
                    _autoAntiBodyTestDates.Add(bloodchemistry.Id.ToString() +
                        ". " + bloodchemistry.ExamDate.ToString().Substring(0, 10));
                }
            }
            this.OtherAutoantibodys_combobox.ItemsSource = _autoAntiBodyTestDates;
            autoAntiBodyTest = _autoAntiBodyTestList[0];
            setFields(autoAntiBodyTest);
        }

    }


    public void setFields(AutoAntiBodyTest _autoAntiBodyTest )
    {
        setDateFieldHelper.setMaskedTextboxDate(_autoAntiBodyTest.ExamDate,
            AutoantibodyExamDate_textBox);
        if (_autoAntiBodyTest.Acetylecholine == "Negative")
        {
            AcetylcholineNegative_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.Acetylecholine == "Positive")
        {
            AcetylcholinePositive_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.AntiMusk == "Negative")
        {
            AntiMuskNegative_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.AntiMusk == "Positive")
        {
            AntiMuskPositive_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.AntiRyanodin == "Negative")
        {
            AntiRyaidinNegative_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.AntiRyanodin == "Positive")
        {
            AntiRyaidinPositive_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.AntiGliadin == "Negative")
        {
            AntiGliadinNegative_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.AntiGliadin == "Positive")
        {
            AntiGliadinPositive_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.LRP4 == "Negative")
        {
            LRP_4Negative_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.LRP4 == "Positive")
        {
            LRP_4Positive_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.Titin == "Negative")
        {
            TitinNegative_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.Titin == "Positive")
        {
            TitinPositive_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.CLChannelAntibody == "Negative")
        {
            CaliciumChannelAntibodyNegative_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.CLChannelAntibody == "Positive")
        {
            CaliciumChannelAntibodyPositive_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.Rapsodine == "Negative")
        {
            AntiRapsonidineNegative_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.Rapsodine == "Positive")
        {
            AntirapsonidinePositive_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.AntiNMO == "Negative")
        {
            AntiNMONegative_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.AntiNMO == "Positive")
        {
            AntiNMOPositive_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.AntiMOG == "Negative")
        {
            AntiMOGNegative_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.AntiMOG == "Positive")
        {
            AntiMOGPositive_radioButton.IsChecked = true;
        }
        AcetylcholineComments_textBox.Text = _autoAntiBodyTest.AcetylecholineComment;
        Anti_muskComment_textBox.Text = _autoAntiBodyTest.AntiMuskComment;
        Anti_ryaidinComment_textBox.Text = _autoAntiBodyTest.AntiRyanodinComment;
        Anti_gliadinComment_textBox.Text = _autoAntiBodyTest.AntiGliadinComment;
        LRP_4Comment_textBox.Text = _autoAntiBodyTest.LRP4Comment;
        TitinComment_textBox.Text = _autoAntiBodyTest.TitinComment;
        AntiNMOComment_textBox.Text = _autoAntiBodyTest.AntiNMOComment;
        CaliciumChannelAntibodyComment_textBox.Text = _autoAntiBodyTest.CLChannelAntibodyComment;
        AntiRapsonidineComment_textBox.Text = _autoAntiBodyTest.RapsodineComment;
        AntiMOGComment_textBox.Text = _autoAntiBodyTest.AntiMOGComment;

        ANA_textBox.Text = _autoAntiBodyTest.ANA;
        Anti_mitochondries_textBox.Text = _autoAntiBodyTest.Antimitochondrial;
        AntiParietalCellAntibodies_textBox.Text = _autoAntiBodyTest.AntiParietal;
        Asma_textBox.Text = _autoAntiBodyTest.ASMA;
        Anti_Ro_textBox.Text = _autoAntiBodyTest.AntiRo;
        La_textBox.Text = _autoAntiBodyTest.La;
        Sm_textBox.Text = _autoAntiBodyTest.Sm;
        Rnp_textBox.Text = _autoAntiBodyTest.RNP;
        Scl_70_textBox.Text = _autoAntiBodyTest.Scl70;
        Jo1_textBox.Text = _autoAntiBodyTest.Jo1;
        AntiDNA_textBox.Text = _autoAntiBodyTest.AntiDNA;
        ANCA_textBox.Text = _autoAntiBodyTest.ANCA;
        Anti_LKM_textBox.Text = _autoAntiBodyTest.AntiLKM;
        Anti_cardiolipin_textBox.Text = _autoAntiBodyTest.AntiCardiolinin;
        LAC_textBox.Text = _autoAntiBodyTest.LAC;
        Anti_transgluamnase_textBox.Text = _autoAntiBodyTest.antiTransglutaminase;

        if (_autoAntiBodyTest.IsANANormal == "Positive")
        {
            AnaYes_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.IsANANormal == "Negative")
        {
            AnaNo_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.IsAntimitochondrialNormal == "Positive")
        {
            Anti_mitochondriesYes_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.IsAntimitochondrialNormal == "Negative")
        {
            Anti_mitochondriesNo_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.AntiParietalNormal == "Positive")
        {
            AntiPartielCellAntibodiesYes_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.AntiParietalNormal == "Negative")
        {
            AntiPartielCellAntibodiesNo_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.IsASMANormal == "Positive")
        {
            AsmaYes_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.IsASMANormal == "Negative")
        {
            AsmaNo_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.IsAntiRoNormal == "Positive")
        {
            AntiRoYes_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.IsAntiRoNormal == "Negative")
        {
            AntiRoNo_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.IsLaNormal == "Positive")
        {
            LAYes_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.IsLaNormal == "Negative")
        {
            LaNo_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.IsSmNormal == "Positive")
        {
            SmYes_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.IsSmNormal == "Negative")
        {
            SmNo_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.IsRNPNormal == "Positive")
        {
            RnpYes_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.IsRNPNormal == "Negative")
        {
            RNPNo_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.IsScl70Normal == "Positive")
        {
            Scl_70Yes_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.IsScl70Normal == "Negative")
        {
            Scl_70No_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.IsJo1Normal == "Positive")
        {
            Jo1Yes_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.IsJo1Normal == "Negative")
        {
            Jo1No_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.IsAntiDNANormal == "Positive")
        {
            AntiDNAYes_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.IsAntiDNANormal == "Negative")
        {
            AntiDNANo_radioButton.IsChecked = true;
        }

        if (_autoAntiBodyTest.IsAntiLKMNormal == "Positive")
        {
            Anti_LKMYes_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.IsAntiLKMNormal == "Negative")
        {
            Anti_LKMNo_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.AntiCardiolininNormal == "Positive")
        {
            Anti_cardiolipinYes_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.AntiCardiolininNormal == "Negative")
        {
            Anti_cardiolipinNo_radioButton.IsChecked = true;
        }


        if (_autoAntiBodyTest.IsANCANormal == "Positive")
        {
            ANCAYes_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.IsANCANormal == "Negative")
        {
            AncaNo_radioButton.IsChecked = true;
        }

        if (_autoAntiBodyTest.IsLACNormal == "Positive")
        {
            LACYes_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.IsLACNormal == "Negative")
        {
            LACNo_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.IsAntiTransglutaminase == "Positive")
        {
            Anti_transglutaminaseYes_radioButton.IsChecked = true;
        }
        if (_autoAntiBodyTest.IsAntiTransglutaminase == "Negative")
        {
            Anti_transglutaminaseNo_radioButton.IsChecked = true;
        }

        AnaComment_textBox.Text = _autoAntiBodyTest.ANAComment;
        Anti_mitochondriesComment_textBox.Text = _autoAntiBodyTest.AntimitochondrialComment;
        AntiParietalCellAntibodiesComment_textBox.Text = _autoAntiBodyTest.AntiParietalComment;
        AsmaComment_textBox.Text = _autoAntiBodyTest.ASMAComment;
        Anti_RoComment_textBox.Text = _autoAntiBodyTest.AntiRoComment;
        LAComment_textBox.Text = _autoAntiBodyTest.LaComment;
        SmComment_textBox.Text = _autoAntiBodyTest.SmComment;
        RnpComment_textBox.Text = _autoAntiBodyTest.RNPComment;
        Scl_70Comment_textBox.Text = _autoAntiBodyTest.Scl70Comment;
        Jo1Comment_textBox.Text = _autoAntiBodyTest.Jo1Comment;
        AntiDNAComment_textBox.Text = _autoAntiBodyTest.AntiDNAComment;
        AncaComment_textBox.Text = _autoAntiBodyTest.ANCAComment;
        Anti_LKMComment_textBox.Text = _autoAntiBodyTest.AntiLKMComment;
        AntiCardiolipinComment_textBox.Text = _autoAntiBodyTest.AntiCardiolininComment;
        LACComment_textBox.Text = _autoAntiBodyTest.LACComment;
        Anti_transgluamnaseComment_textBox.Text = _autoAntiBodyTest.antiTransglutaminaseComment;
    }




    private void Button_AddNewAutoAntibody_Clicked(object sender, EventArgs e)
    {
        if (_layout_ParaclinicalTests.Children[0] is not AddNewParaclinicalAutoAntibodyView)
        {
            _layout_ParaclinicalTests.Children.Clear();
            _layout_ParaclinicalTests.Children.Add(new AddNewParaclinicalAutoAntibodyView(_layout_ParaclinicalTests,_RecivedId));
        }
    }



    public bool setAutoAntibodyTest(AutoAntiBodyTest _autoAntiBodyTest)
    {
        _autoAntiBodyTest.PatientCode = _RecivedId;
        if (setDateFieldHelper.ValidateUnnullableDate(AutoantibodyExamDate_textBox) == null)
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



    private void Button_SaveAutoAntibody_Clicked(object sender, EventArgs e)
    { 
        if (autoAntiBodyTest == null)
        {
            Navigation.PopAsync();
        }
        else if (setAutoAntibodyTest(autoAntiBodyTest))
        {
            autoAntiBodyTestService.Update(autoAntiBodyTest);
            Navigation.PopAsync();
        }
    }

    void OtherAutoantibodys_combobox_SelectedIndexChanged(System.Object sender, System.EventArgs e)
    {
        foreach (var bloodChemistry in _autoAntiBodyTestList)
        {
            if (bloodChemistry.ExamDate != null && OtherAutoantibodys_combobox.SelectedItem.ToString().Contains(bloodChemistry.Id.ToString() +
                ". " + bloodChemistry.ExamDate.ToString().Substring(0, bloodChemistry.ExamDate.ToString().IndexOf(" "))))
            {
                this.autoAntiBodyTest = bloodChemistry;
                RadiobuttonCleaner.cleanRadiobuttons(AcetylcholinePositive_radioButton, AntiMuskNegative_radioButton,
                    AntiMuskPositive_radioButton, AntiRyaidinNegative_radioButton, AntiRyaidinPositive_radioButton, AntiGliadinNegative_radioButton,
                        AntiGliadinPositive_radioButton, LRP_4Negative_radioButton, LRP_4Positive_radioButton, TitinNegative_radioButton, TitinPositive_radioButton, CaliciumChannelAntibodyNegative_radioButton, CaliciumChannelAntibodyPositive_radioButton,
                        AntiNMONegative_radioButton, AntiNMOPositive_radioButton, AntiMOGNegative_radioButton, AntiMOGPositive_radioButton, AntiRapsonidineNegative_radioButton,
                        AntirapsonidinePositive_radioButton, AnaYes_radioButton, AnaNo_radioButton, Anti_mitochondriesYes_radioButton, Anti_mitochondriesNo_radioButton, AntiPartielCellAntibodiesYes_radioButton, AntiPartielCellAntibodiesNo_radioButton,
                        AsmaYes_radioButton, AsmaNo_radioButton, AntiRoYes_radioButton, AntiRoNo_radioButton, LAYes_radioButton, LaNo_radioButton, SmYes_radioButton, SmNo_radioButton,
                        RnpYes_radioButton, RNPNo_radioButton, Scl_70Yes_radioButton, Scl_70No_radioButton, Jo1Yes_radioButton, Jo1No_radioButton, AntiDNAYes_radioButton, AntiDNANo_radioButton,
                        ANCAYes_radioButton, AncaNo_radioButton, Anti_LKMYes_radioButton, Anti_LKMNo_radioButton, Anti_cardiolipinYes_radioButton, Anti_cardiolipinNo_radioButton,
                        LACYes_radioButton, LACNo_radioButton, Anti_transglutaminaseYes_radioButton, Anti_transglutaminaseNo_radioButton
                    );
                setFields(autoAntiBodyTest);
            }
        }
    }
}