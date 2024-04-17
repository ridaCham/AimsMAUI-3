namespace MAUIUI.Views;

public partial class HerpesZosterPage : ContentPage
{
     string _patientCode;

    public HerpesZosterPage(string patientCode)
    {
        InitializeComponent();
        _patientCode = patientCode;

        ChangeEnabled_DeathDate();
    }

    private void RadioButton_Death_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        ChangeEnabled_DeathDate();
    }

    private void ChangeEnabled_DeathDate()
    {
        //if (RadioButton_Death.IsChecked)
        //{
        //    Entry_DeathDate.IsEnabled = true;
        //    Entry_DeathDate.BackgroundColor = Colors.White;
        //}
        //else
        //{
        //    Entry_DeathDate.IsEnabled = false;
        //    Entry_DeathDate.BackgroundColor = Colors.DarkGray;
        //    Entry_DeathDate.Text = "";
        //}
    }

    private void Button_Save_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void Button_AddNew_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AddNewHerpesZosterPage(_patientCode));
    }
}

/*
 



        IHerpesZosterService herpesZosterService;
        string _RecivedId;
        public herpeszoster(string _selectedpatientId)
        {
            InitializeComponent();
            _RecivedId = _selectedpatientId;
            herpesZosterService = InstanceFactory.GetInstance<IHerpesZosterService>();
            _herpesZosterList = new List<HerpesZoster>();
            _herpesZosterList = herpesZosterService.GetAllByPatientId(_RecivedId).Data;

            if (_herpesZosterList.Count > 0)
            { 
                _herpesZoster = new HerpesZoster();
                _herpesZosterDates = new List<string?>();
                foreach (var covid in _herpesZosterList)
                {
                    if (covid.DateOfDiagnosis != null)
                    {
                        _herpesZosterDates.Add(covid.Id.ToString() +
                            ". " + covid.DateOfDiagnosis.ToString().Substring(0, 10));
                    }
                }

                this.OtherHerpesZoster_combobox.DataSource = _herpesZosterDates;
                _herpesZoster = _herpesZosterList[0];
                setFields();
            } 
        }
        
        public bool setHerpesZoster()
        {

            _herpesZoster.PatientCode = _RecivedId;
            if (setDateFieldHelper.ValidateUnnullableDate(HerpesDateofDiagnosisDate_textBox))
            {
                _herpesZoster.DateOfDiagnosis = DateTime.Parse(HerpesDateofDiagnosisDate_textBox.Text);
            }
            else return false;

            if (setDateFieldHelper.ValidateNullableDate(HerpesOutcomeDate_textBox))
            {
                _herpesZoster.OutcomeDate = HerpesOutcomeDate_textBox.Text == "  .  ." ? null : DateTime.Parse(HerpesOutcomeDate_textBox.Text);
            }
            else return false;
            _herpesZoster.TreatmentModality = InputValidator.CaseFormatter(HerpesZosterTreatmnet_textBox.Text);
            if (OutUnknown_radioButton.Checked)
            {
                _herpesZoster.Outcome = "Unknown";
            }
            else if (OutRemission_radioButton.Checked)
            {
                _herpesZoster.Outcome = "Remission";
            }
            else if (Outngoing_radioButton.Checked)
            {
                _herpesZoster.Outcome = "Ongoing";
            }
            else if (OutDeath_radioButton.Checked)
            {
                _herpesZoster.Outcome = "Death";
            }


            _herpesZoster.Remarks = InputValidator.CaseFormatter(HerpesZosterRemarks_textBox.Text);
            return true;
        }
        public void setFields()
        {
            setDateFieldHelper.setMaskedTextboxDate(_herpesZoster.DateOfDiagnosis,
                HerpesDateofDiagnosisDate_textBox);
            this.HerpesZosterTreatmnet_textBox.Text = _herpesZoster.TreatmentModality;
            if (_herpesZoster.Outcome == "Unknown")
            {
                OutUnknown_radioButton.Checked = true;
            }
            else if (_herpesZoster.Outcome == "Remission")
            {
                OutRemission_radioButton.Checked = true;
            }
            else if (_herpesZoster.Outcome == "Ongoing")
            {
                Outngoing_radioButton.Checked = true;
            }
            else if (_herpesZoster.Outcome == "Death")
            {
                OutDeath_radioButton.Checked = true;
            }

            setDateFieldHelper.setMaskedTextboxDate(_herpesZoster.OutcomeDate,
                HerpesOutcomeDate_textBox);
            this.HerpesZosterRemarks_textBox.Text = _herpesZoster.Remarks;
        }

        private void OtherHerpesZoster_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var herpesZoster in _herpesZosterList)
            {
                string value = herpesZoster.Id.ToString() + ". " + herpesZoster.DateOfDiagnosis.ToString();

                if (herpesZoster.DateOfDiagnosis != null &&
                    value.Contains(OtherHerpesZoster_combobox.SelectedItem.ToString()))
                {
                    this._herpesZoster = herpesZoster;
                    setFields();
                }
            }
        }


        private void button_Save_Click(object sender, EventArgs e)
        {
            if (_herpesZoster == null)
            {
                this.Hide();
            }
            else if (setHerpesZoster() &&
                setDateFieldHelper.ValidateStartEndDate(this.HerpesDateofDiagnosisDate_textBox, this.HerpesOutcomeDate_textBox))
            {
                herpesZosterService.Update(_herpesZoster);
                this.Hide();
            }
        }

        private void herpeszoster_Load_1(object sender, EventArgs e)
        {
            if (OutDeath_radioButton.Checked)
            {
                HerpesOutcomeDate_textBox.Enabled = true;
                label7.Enabled = true;
            }
            else
            {

                HerpesOutcomeDate_textBox.Enabled = false;
                label7.Enabled = false;
                HerpesOutcomeDate_textBox.Text = "";
            }
        }
*/