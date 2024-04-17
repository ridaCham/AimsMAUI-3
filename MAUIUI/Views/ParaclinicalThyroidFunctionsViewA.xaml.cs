using MAUIUI.Business.Abstract;
using MAUIUI.Business.DependencyResoulver.AutofacResoulver;
using MAUIUI.Entities.Concrete;
using MAUIUI.Helpers;

namespace MAUIUI.Views;

public partial class ParaclinicalThyroidFunctionsView : ContentView
{
    private readonly StackLayout _layout_ParaclinicalTests;

    IThyroidFunctionService thyroidFunctionService;
    string _RecivedId;
    List<ThyroidFunction> _ThroidFuncs;
    List<string?> _ThroidsDates;
    ThyroidFunction thyroidFunction;
    public ParaclinicalThyroidFunctionsView(StackLayout layout_ParaclinicalTests, string _selectedpatientId)
    {
        InitializeComponent();
        _layout_ParaclinicalTests = layout_ParaclinicalTests;
        _RecivedId = _selectedpatientId;
        thyroidFunctionService = InstanceFactory.GetInstance<IThyroidFunctionService>();
        _ThroidFuncs = new List<ThyroidFunction>();
        _ThroidFuncs = thyroidFunctionService.GetAllByPatientId(_RecivedId).Data;


        if (_ThroidFuncs.Count > 0)
        {
            thyroidFunction = new ThyroidFunction();
            _ThroidsDates = new List<string?>();
            foreach (var bloodchemistry in _ThroidFuncs)
            {
                if (bloodchemistry.ExamDate != null)
                {
                    _ThroidsDates.Add(bloodchemistry.Id.ToString() +
                        ". " + bloodchemistry.ExamDate.ToString().Substring(0, 10));
                }
            }
            this.OtherThyroidFunctions_combobox.ItemsSource = _ThroidsDates;
            thyroidFunction = _ThroidFuncs[0];
            setFields(thyroidFunction);
        }

    }

     
    public bool setThyroid(ThyroidFunction _thyroidFunction)
    {
        _thyroidFunction.PatientCode = _RecivedId;
        if (setDateFieldHelper.ValidateUnnullableDate(ThyroidExamDate_textBox)==null)
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

    public void setFields(ThyroidFunction _thyroidFunction)
    {
        setDateFieldHelper.setMaskedTextboxDate(_thyroidFunction.ExamDate,
            ThyroidExamDate_textBox);
        this.AntiMicro_textBox.Text = _thyroidFunction.Antimicrosomal;
        this.AntiThy_textBox.Text = _thyroidFunction.Antithiroglobulin;
        this.ThyT3_textBox.Text = _thyroidFunction.T3;
        this.ThyT4_textBox.Text = _thyroidFunction.T4;
        this.ThyTSH_textBox.Text = _thyroidFunction.TSH;

        if (_thyroidFunction.IsAntimicrosomalNormal == "Yes")
        {
            MicroNormalYes_radioButton.IsChecked = true;
        }
        else if (_thyroidFunction.IsAntimicrosomalNormal == "No")
        {
            MicroNormalNo_radioButton.IsChecked = true;
        }
        if (_thyroidFunction.IsAntithiroglobulinNormal == "Yes")
        {
            ThyNormalYes_radioButton.IsChecked = true;
        }
        else if (_thyroidFunction.IsAntithiroglobulinNormal == "No")
        {
            ThyNormalNo_radioButton.IsChecked = true;
        }
        if (_thyroidFunction.IsT3Normal == "Yes")
        {
            T3NormalYes_radioButton.IsChecked = true;
        }
        else if (_thyroidFunction.IsT3Normal == "No")
        {
            T3NormalNo_radioButton.IsChecked = true;
        }
        if (_thyroidFunction.IsT4Normal == "Yes")
        {
            T4NormalYes_radioButton.IsChecked = true;
        }
        else if (_thyroidFunction.IsT4Normal == "No")
        {
            T4NormalNo_radioButton.IsChecked = true;
        }
        if (_thyroidFunction.IsTSHNormal == "Yes")
        {
            TshNormalYes_radioButton.IsChecked = true;
        }
        else if (_thyroidFunction.IsTSHNormal == "No")
        {
            TshNormalNo_radioButton.IsChecked = true;
        }
        this.AntiMicroComments_textBox.Text = _thyroidFunction.AntimicrosomalComment;
        this.AntiThyComments_textBox.Text = _thyroidFunction.AntithiroglobulinComment;
        this.T3Comments_textBox.Text = _thyroidFunction.T3Comment;
        this.T4Comments_textBox.Text = _thyroidFunction.T4Comment;
        this.TshComments_textBox.Text = _thyroidFunction.TSHComment;
    }





    private void Button_AddNewThyroidFunctions_Clicked(object sender, EventArgs e)
    {
        if (_layout_ParaclinicalTests.Children[0] is not AddNewParaclinicalThyroidFunctionsView)
        {
            _layout_ParaclinicalTests.Children.Clear();
            _layout_ParaclinicalTests.Children.Add(new AddNewParaclinicalThyroidFunctionsView(_layout_ParaclinicalTests, _RecivedId));
        }
    }

    private void Button_SaveThyroidFunctions_Clicked(object sender, EventArgs e)
    {
        if (thyroidFunction == null)
        {
            Navigation.PopAsync();
        }
        else if (setThyroid(thyroidFunction))
        {
            thyroidFunctionService.Update(thyroidFunction);
            Navigation.PopAsync();
        }
    }

    void OtherThyroidFunctions_combobox_SelectedIndexChanged_1(System.Object sender, System.EventArgs e)
    {
        foreach (var throidFunc in this._ThroidFuncs)
        {
            if (throidFunc.ExamDate != null && OtherThyroidFunctions_combobox.SelectedItem.ToString().Contains(throidFunc.Id.ToString() +
                ". " + throidFunc.ExamDate.ToString().Substring(0, throidFunc.ExamDate.ToString().IndexOf(" "))))
            {
                thyroidFunction = throidFunc;
                RadiobuttonCleaner.cleanRadiobuttons(MicroNormalYes_radioButton,
                        MicroNormalNo_radioButton, ThyNormalYes_radioButton, ThyNormalNo_radioButton, T3NormalYes_radioButton,
                        T3NormalNo_radioButton, T4NormalYes_radioButton, T4NormalNo_radioButton, TshNormalYes_radioButton, TshNormalNo_radioButton
                    );
                setFields(thyroidFunction);
            }
        }
    }
}

/*
 
        IThyroidFunctionService thyroidFunctionService ;
        string _RecivedId;
        List<ThyroidFunction> _ThroidFuncs; 
        List<string?> _ThroidsDates;
        public thyroidfunc(string _selectedpatientId)
        {
            InitializeComponent();
            _RecivedId = _selectedpatientId;
            thyroidFunctionService = InstanceFactory.GetInstance<IThyroidFunctionService>();
            _ThroidFuncs = new List<ThyroidFunction>();
            _ThroidFuncs = thyroidFunctionService.GetAllByPatientId(_RecivedId).Data;


            if (_ThroidFuncs.Count > 0)
            {
                _thyroidFunction = new ThyroidFunction();
                _ThroidsDates = new List<string?>();
                foreach (var bloodchemistry in _ThroidFuncs)
                {
                    if (bloodchemistry.ExamDate != null)
                    {
                        _ThroidsDates.Add(bloodchemistry.Id.ToString() +
                            ". " + bloodchemistry.ExamDate.ToString().Substring(0, 10));
                    }
                }
                this.OtherThyroidFunctions_combobox.DataSource = _ThroidsDates;
                _thyroidFunction = _ThroidFuncs[0];
                setFields();
            }  
        }
        public bool setThyroid()
        {
            _thyroidFunction.PatientCode = _RecivedId; 
            if (setDateFieldHelper.ValidateUnnullableDate(ThyroidExamDate_textBox))
            {
                _thyroidFunction.ExamDate = DateTime.Parse(ThyroidExamDate_textBox.Text);
            }
            else return false;
            _thyroidFunction.Antimicrosomal = AntiMicro_textBox.Text;
            _thyroidFunction.Antithiroglobulin = AntiThy_textBox.Text;
            _thyroidFunction.T3 = ThyT3_textBox.Text;
            _thyroidFunction.T4 = ThyT4_textBox.Text;
            _thyroidFunction.TSH = ThyTSH_textBox.Text;

            if (MicroNormalYes_radioButton.Checked)
            {
                _thyroidFunction.IsAntimicrosomalNormal = "Yes";
            }
            else if (MicroNormalNo_radioButton.Checked)
            {
                _thyroidFunction.IsAntimicrosomalNormal = "No";
            }
            if (ThyNormalYes_radioButton.Checked)
            {
                _thyroidFunction.IsAntithiroglobulinNormal = "Yes";
            }
            else if (ThyNormalNo_radioButton.Checked)
            {
                _thyroidFunction.IsAntithiroglobulinNormal = "No";
            }
            if (T3NormalYes_radioButton.Checked)
            {
                _thyroidFunction.IsT3Normal = "Yes";
            }
            else if (T3NormalNo_radioButton.Checked)
            {
                _thyroidFunction.IsT3Normal = "No";
            }
            if (T4NormalYes_radioButton.Checked)
            {
                _thyroidFunction.IsT4Normal = "Yes";
            }
            else if (T4NormalNo_radioButton.Checked)
            {
                _thyroidFunction.IsT4Normal = "No";
            }
            if (TshNormalYes_radioButton.Checked)
            {
                _thyroidFunction.IsTSHNormal = "Yes";
            }
            else if (TshNormalNo_radioButton.Checked)
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

        public void setFields()
        { 
            setDateFieldHelper.setMaskedTextboxDate(_thyroidFunction.ExamDate,
                ThyroidExamDate_textBox);
            this.AntiMicro_textBox.Text = _thyroidFunction.Antimicrosomal;
            this.AntiThy_textBox.Text = _thyroidFunction.Antithiroglobulin;
            this.ThyT3_textBox.Text = _thyroidFunction.T3;
            this.ThyT4_textBox.Text = _thyroidFunction.T4;
            this.ThyTSH_textBox.Text = _thyroidFunction.TSH;

            if (_thyroidFunction.IsAntimicrosomalNormal == "Yes")
            {
                MicroNormalYes_radioButton.Checked = true;
            }
            else if (_thyroidFunction.IsAntimicrosomalNormal == "No")
            {
                MicroNormalNo_radioButton.Checked = true;
            }
            if (_thyroidFunction.IsAntithiroglobulinNormal == "Yes")
            {
                ThyNormalYes_radioButton.Checked = true;
            }
            else if (_thyroidFunction.IsAntithiroglobulinNormal == "No")
            {
                ThyNormalNo_radioButton.Checked = true;
            }
            if (_thyroidFunction.IsT3Normal == "Yes")
            {
                T3NormalYes_radioButton.Checked = true;
            }
            else if (_thyroidFunction.IsT3Normal == "No")
            {
                T3NormalNo_radioButton.Checked = true;
            }
            if (_thyroidFunction.IsT4Normal == "Yes")
            {
                T4NormalYes_radioButton.Checked = true;
            }
            else if (_thyroidFunction.IsT4Normal == "No")
            {
                T4NormalNo_radioButton.Checked = true;
            }
            if (_thyroidFunction.IsTSHNormal == "Yes")
            {
                TshNormalYes_radioButton.Checked = true;
            }
            else if (_thyroidFunction.IsTSHNormal == "No")
            {
                TshNormalNo_radioButton.Checked = true;
            }
            this.AntiMicroComments_textBox.Text = _thyroidFunction.AntimicrosomalComment;
            this.AntiThyComments_textBox.Text = _thyroidFunction.AntithiroglobulinComment;
            this.T3Comments_textBox.Text = _thyroidFunction.T3Comment;
            this.T4Comments_textBox.Text = _thyroidFunction.T4Comment;
            this.TshComments_textBox.Text = _thyroidFunction.TSHComment;
        }

        private void hThyroidSave_Click(object sender, EventArgs e)
        {
            if (_thyroidFunction == null)
            {
                this.Hide();
            }
            else if (setThyroid())
            {
                thyroidFunctionService.Update(_thyroidFunction);
                this.Hide();
            }

        }

        private void OtherThyroidFunctions_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var throidFunc in this._ThroidFuncs)
            {
                if (throidFunc.ExamDate != null && OtherThyroidFunctions_combobox.SelectedItem.ToString().Contains(throidFunc.Id.ToString() +
                    ". " + throidFunc.ExamDate.ToString().Substring(0, throidFunc.ExamDate.ToString().IndexOf(" "))))
                {
                    _thyroidFunction = throidFunc;
                    RadiobuttonCleaner.cleanRadiobuttons(MicroNormalYes_radioButton,
                            MicroNormalNo_radioButton, ThyNormalYes_radioButton, ThyNormalNo_radioButton, T3NormalYes_radioButton,
                            T3NormalNo_radioButton, T4NormalYes_radioButton, T4NormalNo_radioButton, TshNormalYes_radioButton, TshNormalNo_radioButton
                        );
                    setFields();
                }
            }
        }

*/