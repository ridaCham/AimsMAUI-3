using MAUIUI.Business.Abstract;
using MAUIUI.Business.DependencyResoulver.AutofacResoulver;
using MAUIUI.Entities.Concrete;
using MAUIUI.Helpers;

namespace MAUIUI.Views;


public partial class AddNewParaclinicalThyroidFunctionsView : ContentView
{
    private readonly StackLayout _layout_ParaclinicalTests;
    IThyroidFunctionService thyroidFunctionService;
    string _RecivedId;
    ThyroidFunction _thyroidFunction;
    public AddNewParaclinicalThyroidFunctionsView(StackLayout layout_ParaclinicalTests, string _selectedpatientId)
    {
        InitializeComponent();
        _layout_ParaclinicalTests = layout_ParaclinicalTests;
        _RecivedId = _selectedpatientId;
        thyroidFunctionService = InstanceFactory.GetInstance<IThyroidFunctionService>();
        _thyroidFunction = new ThyroidFunction();

    }


    private void hThyroidSave_Click(object sender, EventArgs e)
    {


    }



    public bool setThyroid(ThyroidFunction _thyroidFunction)
    {
        _thyroidFunction.PatientCode = _RecivedId;
        if (setDateFieldHelper.ValidateUnnullableDate(ThyroidExamDate_textBox) == null)
        {
            _thyroidFunction.ExamDate = ThyroidExamDate_textBox.Date;
        }
        else return false;
        _thyroidFunction.Antimicrosomal = AntiMicro_textBox.Text;
        _thyroidFunction.Antithiroglobulin = AntiThy_textBox.Text;
        _thyroidFunction.T3 = ThyT3_textBox.Text;
        _thyroidFunction.T4 = ThyT4_textBox.Text;
        _thyroidFunction.TSH = ThyTSH_textBox.Text;

        if (MicroNormalYes_radioButton.IsChecked)
        {
            _thyroidFunction.IsAntimicrosomalNormal = "Yes";
        }
        else if (MicroNormalNo_radioButton.IsChecked)
        {
            _thyroidFunction.IsAntimicrosomalNormal = "No";
        }
        if (ThyNormalYes_radioButton.IsChecked)
        {
            _thyroidFunction.IsAntithiroglobulinNormal = "Yes";
        }
        else if (ThyNormalNo_radioButton.IsChecked)
        {
            _thyroidFunction.IsAntithiroglobulinNormal = "No";
        }
        if (T3NormalYes_radioButton.IsChecked)
        {
            _thyroidFunction.IsT3Normal = "Yes";
        }
        else if (T3NormalNo_radioButton.IsChecked)
        {
            _thyroidFunction.IsT3Normal = "No";
        }
        if (T4NormalYes_radioButton.IsChecked)
        {
            _thyroidFunction.IsT4Normal = "Yes";
        }
        else if (T4NormalNo_radioButton.IsChecked)
        {
            _thyroidFunction.IsT4Normal = "No";
        }
        if (TshNormalYes_radioButton.IsChecked)
        {
            _thyroidFunction.IsTSHNormal = "Yes";
        }
        else if (TshNormalNo_radioButton.IsChecked)
        {
            _thyroidFunction.IsTSHNormal = "No";
        }
        _thyroidFunction.AntimicrosomalComment = AntiMicroComments_textBox.Text;
        _thyroidFunction.AntithiroglobulinComment = AntiThyComments_textBox.Text;
        _thyroidFunction.T3Comment = T3Comments_textBox.Text;
        _thyroidFunction.T4Comment = T4Comments_textBox.Text;
        _thyroidFunction.TSHComment = TshComments_textBox.Text;
        return true;
    }



    private void Button_SaveAddNewThyroidFunctions_Clicked(object sender, EventArgs e)
    {
        if (setThyroid(_thyroidFunction))
        {
            thyroidFunctionService.Add(_thyroidFunction);
            _layout_ParaclinicalTests.Children.Clear();
            _layout_ParaclinicalTests.Children.Add(new ParaclinicalThyroidFunctionsView(_layout_ParaclinicalTests,_RecivedId));

        }
    }
}
