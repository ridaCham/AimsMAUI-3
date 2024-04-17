using MAUIUI.Business.Abstract;
using MAUIUI.Business.DependencyResoulver.AutofacResoulver;
using MAUIUI.Entities.Concrete;
using MAUIUI.Helpers;

namespace MAUIUI.Views;

public partial class AddNewParaclinicalHaematologyView : ContentView
{
    private readonly StackLayout _layout_ParaclinicalTests;
    IHaematologyService haematologyService;
    string _RecivedId;
    Haematology haematology;

    public AddNewParaclinicalHaematologyView(StackLayout layout_ParaclinicalTests, string _selectedpatientId)
    {
        InitializeComponent();
        _layout_ParaclinicalTests = layout_ParaclinicalTests;
        _RecivedId = _selectedpatientId;
        haematologyService = InstanceFactory.GetInstance<IHaematologyService>();
        haematology = new Haematology();

    }

    public bool setHaematology(Haematology _haematology)
    {
        _haematology.PatientCode = _RecivedId;
        if (setDateFieldHelper.ValidateUnnullableDate(this.BloodExamDate_textBox) == null)
        {
            _haematology.ExamDate = BloodExamDate_textBox.Date;
        }
        else return false;
        _haematology.HomoglobineCount = HemoglobinCount_textBoxx.Text;
        _haematology.WhiteCellCount = WhiteCellCoount_textBox.Text;
        _haematology.RedCellCount = RedCellCoount_textBox.Text;
        _haematology.LymphocyteCount = LymphocyteCount_textBox.Text;
        _haematology.LymphocyteLimitCount = LymphocyteLoweLimit_textBox.Text;
        _haematology.TCellCount = TCellCount_textBox.Text;
        _haematology.CD4TCellCount = CD4TCellCoount_textBox.Text;
        _haematology.CD8TCellCount = CD8TCellCoount_textBox.Text;
        _haematology.CD19TCellCount = CD19TCellCoount_textBox.Text;
        _haematology.NKCellCount = NKCellCount_textBox.Text;
        _haematology.NeutrophilCount = NeutrophilCount_textBox.Text;
        _haematology.MonocyteCount = MonocyteCount_textBox.Text;
        _haematology.EosinophilCount = EosinophilCount_textBox.Text;
        _haematology.BasophilCount = BasophilCount_textBox.Text;
        _haematology.PlateletCount = PlateletCount_textBox.Text;
        _haematology.ESRCount = ESR_textBox.Text;
        _haematology.ACECount = ACE_textBox.Text;
        _haematology.LDHCount = LDH_textBox.Text;
        _haematology.Beta2Microglobine = Beta2_textBox.Text;
        _haematology.VitaminD = VitaminD_textBox.Text;
        _haematology.CD20 = CD20_textBox.Text; 
        if (WhiteNormalYes_radioButton.IsChecked)
        {
            _haematology.IsWhiteCellNormal = "Yes";
        }
        else if (WhiteNormalNo_radioButton.IsChecked)
        {
            _haematology.IsWhiteCellNormal = "No";
        }
        if (RedCellNormalYes_radioButton.IsChecked)
        {
            _haematology.IsRedCellNormal = "Yes";
        }
        else if (RedCellNormalNo_radioButton.IsChecked)
        {
            _haematology.IsRedCellNormal = "No";
        }
        if (LymphocyteNormalYes_radioButton.IsChecked)
        {
            _haematology.IsLymphocyteNormal = "Yes";
        }
        else if (LymphocyteNormalNo_radioButton.IsChecked)
        {
            _haematology.IsLymphocyteNormal = "No";
        }
        if (LymphocyteLoweLimitNormalYes_radioButton.IsChecked)
        {
            _haematology.IsLymphocyteLoweLimitNormal = "Yes";
        }
        else if (LymphocyteLoweLimitNormalNo_radioButton.IsChecked)
        {
            _haematology.IsLymphocyteLoweLimitNormal = "No";
        }
        if (TCellNormalYes_radioButton.IsChecked)
        {
            _haematology.IsTCellNormal = "Yes";
        }
        else if (TCellNormalNo_radioButton.IsChecked)
        {
            _haematology.IsTCellNormal = "No";
        }
        if (CD4TNormalYes_radioButton.IsChecked)
        {
            _haematology.IsCD4TCellNormal = "Yes";
        }
        else if (CD4TNormalNo_radioButton.IsChecked)
        {
            _haematology.IsCD4TCellNormal = "No";
        }
        if (CD8TNormalYes_radioButton.IsChecked)
        {
            _haematology.IsCD8TCellNormal = "Yes";
        }
        else if (CD8TNormalNo_radioButton.IsChecked)
        {
            _haematology.IsCD8TCellNormal = "No";
        }
        if (CD19TNormalYes_radioButton.IsChecked)
        {
            _haematology.IsCD19TCellNormal = "Yes";
        }
        else if (CD19TNormalNo_radioButton.IsChecked)
        {
            _haematology.IsCD19TCellNormal = "No";
        }
        if (NKCellNormalYes_radioButton.IsChecked)
        {
            _haematology.IsNKCellNormal = "Yes";
        }
        else if (NKCellNormalNo_radioButton.IsChecked)
        {
            _haematology.IsNKCellNormal = "No";
        }
        if (NeutrophilNormalYes_radioButton.IsChecked)
        {
            _haematology.IsNeutrophilNormal = "Yes";
        }
        else if (NeutrophilNormalNo_radioButton.IsChecked)
        {
            _haematology.IsNeutrophilNormal = "No";
        }
        if (MonocyteNormalYes_radioButton.IsChecked)
        {
            _haematology.IsMonocyteNormal = "Yes";
        }
        else if (MonocyteNormalNo_radioButton.IsChecked)
        {
            _haematology.IsMonocyteNormal = "No";
        }
        if (EosinophilNormalYes_radioButton.IsChecked)
        {
            _haematology.IsEosinophilNormal = "Yes";
        }
        else if (EosinophilNormalNo_radioButton.IsChecked)
        {
            _haematology.IsEosinophilNormal = "No";
        }
        if (BasophilYes_radioButton.IsChecked)
        {
            _haematology.IsBasophilNormal = "Yes";
        }
        else if (BasophilNo_radioButton.IsChecked)
        {
            _haematology.IsBasophilNormal = "No";
        }
        if (PlateletYes_radioButton.IsChecked)
        {
            _haematology.IsPlateletNormal = "Yes";
        }
        else if (PlateletNo_radioButton.IsChecked)
        {
            _haematology.IsPlateletNormal = "No";
        }
        if (HemoglobinYes_radioButton.IsChecked)
        {
            _haematology.IsHomoglobineNormal = "Yes";
        }
        else if (HemoglobinNo_radioButton.IsChecked)
        {
            _haematology.IsHomoglobineNormal = "No";
        }
        if (ESRYes_radioButton.IsChecked)
        {
            _haematology.IsESRNormal = "Yes";
        }
        else if (ESRNo_radioButton.IsChecked)
        {
            _haematology.IsESRNormal = "No";
        }
        if (ACEYes_radioButton.IsChecked)
        {
            _haematology.IsACENormal = "Yes";
        }
        else if (ACENo_radioButton.IsChecked)
        {
            _haematology.IsACENormal = "No";
        }
        if (LDHYes_radioButton.IsChecked)
        {
            _haematology.IsLDHNormal = "Yes";
        }
        else if (LDHNo_radioButton.IsChecked)
        {
            _haematology.IsLDHNormal = "No";
        }
        if (Beta2Yes_radioButton.IsChecked)
        {
            _haematology.IsBeta2MicroglobineNormal = "Yes";
        }
        else if (Beta2No_radioButton.IsChecked)
        {
            _haematology.IsBeta2MicroglobineNormal = "No";
        }
        if (VitaminDYes_radioButton.IsChecked)
        {
            _haematology.IsVitaminDNormal = "Yes";
        }
        else if (VitaminDNo_radioButton.IsChecked)
        {
            _haematology.IsVitaminDNormal = "No";
        }
        if (CD20NormalYes_radioButton.IsChecked)
        {
            _haematology.IsCD20Normal = "Yes";
        }
        else if (CD20NormalNo_radioButton.IsChecked)
        {
            _haematology.IsCD20Normal = "No";
        }
        _haematology.WhiteCellComment = WhiteCellComments_textBox.Text;
        _haematology.RedCellComment = RedCellComments_textBox.Text;
        _haematology.LymphocyteComment = LymphocyteComments_textBox.Text;
        _haematology.LymphocyteLimitComment = LowerLimitComments_textBox.Text;
        _haematology.TCellComment = TCellComments_textBox.Text;
        _haematology.CD4TCellComment = CD4TCellComments_textBox.Text;
        _haematology.CD8TCellComment = CD8TCellComments_textBox.Text;
        _haematology.CD19TCellComment = CD19TCellComments_textBox.Text;
        _haematology.NKCellComment = NKCellComments_textBox.Text;
        _haematology.NeutrophilComment = NeutrophilComments_textBox.Text;
        _haematology.MonocyteComment = MonocyteComments_textBox.Text;
        _haematology.EosinophilComment = EosinophilComments_textBox.Text;
        _haematology.BasophilComment = BasophilComments_textBox3.Text;
        _haematology.PlateletComment = PlateletComments_textBox.Text;
        _haematology.HomoglobineComment = HemoglobinComments_textBox.Text;
        _haematology.ESRComment = ECRComments_textBox.Text;
        _haematology.ACEComment = ACEComments_textBox.Text;
        _haematology.LDHComment = LDHComments_textBox.Text;
        _haematology.Beta2MicroglobineComment = Beta2Comments_textBox.Text;
        _haematology.VitaminDComment = VitaminDComment_textBox.Text;
        _haematology.CD20Comment = CD20Comment_textBox.Text;
        return true;
    }

    private void Button_SaveAddNewParaclinicalHaematology_Clicked(object sender, EventArgs e)
    {
        if (setHaematology(haematology))
        {
            haematologyService.Add(haematology);
            _layout_ParaclinicalTests.Children.Clear();
            _layout_ParaclinicalTests.Children.Add(new ParaclinicalHaematologyView(_layout_ParaclinicalTests, _RecivedId));

        }

    }
}