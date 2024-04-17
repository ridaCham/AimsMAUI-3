using MAUIUI.Business.Abstract;
using MAUIUI.Business.DependencyResoulver.AutofacResoulver;
using MAUIUI.Entities.Concrete;
using MAUIUI.Helpers;

namespace MAUIUI.Views;

public partial class ParaclinicalMRIView : ContentView
{
    private string MRIPhotoPath;


    IParatestMRIService _ParatestMRIService;
    string _RecivedId;
    List<ParatestMRI> _ParatestMRIs;
    ParatestMRI paratestMRI;
    List<string?> _CSFDates;

    private readonly StackLayout _layout_ParaclinicalTests;

    public ParaclinicalMRIView(StackLayout layout_ParaclinicalTests, string _selectedPatientId)
    {
        InitializeComponent();
        _layout_ParaclinicalTests = layout_ParaclinicalTests;
        _RecivedId = _selectedPatientId;
        _ParatestMRIService = InstanceFactory.GetInstance<IParatestMRIService>();
        _ParatestMRIs = new List<ParatestMRI>();
        _ParatestMRIs = _ParatestMRIService.GetAllByPatientId(_RecivedId).Data;


        if (_ParatestMRIs.Count > 0)
        {
            paratestMRI = new ParatestMRI();
            _CSFDates = new List<string?>();
            foreach (var bloodchemistry in _ParatestMRIs)
            {
                if (bloodchemistry.ParatestmriExamDate != null)
                {
                    _CSFDates.Add(bloodchemistry.Id.ToString() +
                        ". " + bloodchemistry.ParatestmriExamDate.ToString().Substring(0, 10));
                }
            }
            this.Othermri_combobox.ItemsSource = _CSFDates;
            paratestMRI = _ParatestMRIs[0];
            setFields(paratestMRI);
        }
    }


    private async void ShowPhotoParaclinicalMRI_Clicked(object sender, EventArgs e)
    {
        try
        {
            var file = await FilePicker.PickAsync();
            if (file != null)
            {
                MRIPhotoPath = file.FullPath;
            }
        }
        catch (Exception ex)
        {
            // Hata durumunda i�lemler
        }
    }

    private void Button_SaveParaclinicalMRI_Clicked(object sender, EventArgs e)
    {
        if (paratestMRI == null)
        {
            Navigation.PopAsync();
        }
        else if (setCsf(paratestMRI))
        {
            _ParatestMRIService.Update(paratestMRI);
            Navigation.PopAsync();
        }
    }







    private void setFields(ParatestMRI _paratestMRI)
    {
        setDateFieldHelper.setMaskedTextboxDate(_paratestMRI.ParatestmriExamDate,
            ParatestmriExamDate_textBox);


        setDateFieldHelper.setPicker(T1_comboBox, _paratestMRI.T1Detail); 
        setDateFieldHelper.setPicker(T2_comboBox, _paratestMRI.T2Detail);
        setDateFieldHelper.setPicker(CNSRegion_comboBox, _paratestMRI.CNSRegion);

        setDateFieldHelper.setPicker(T1Gadolinium_comboBox, _paratestMRI.T1GadoliniumDetail);
        this.NbOfT2_textBox.Text = _paratestMRI.NbOfT2;
        this.NbOfT1_textBox.Text = _paratestMRI.NbOfT1;
        this.NbOfNew_textBox.Text = _paratestMRI.NbOfNew;
        this.NbOfGd_textBox.Text = _paratestMRI.NbOfGd;

        if (_paratestMRI.T1 == "Yes")
        {
            T1_checkBox.IsChecked = true;
        }
        else T1_checkBox.IsChecked = false;

        if (_paratestMRI.T1Gadolinium == "Yes")
        {
            T1Gadolinium_checkBox.IsChecked = true;
        }
        else T1Gadolinium_checkBox.IsChecked = false;
        if (_paratestMRI.T2 == "Yes")
        {
            T2_checkBox.IsChecked = true;
        }
        else T2_checkBox.IsChecked = false;
        this.Remarks_textBox.Text = _paratestMRI.Remarks;
    }
    private bool setCsf(ParatestMRI _paratestMRI)
    {
        _paratestMRI.PatientCode = _RecivedId;

        if (setDateFieldHelper.ValidateUnnullableDate(ParatestmriExamDate_textBox)==null)
        {
            _paratestMRI.ParatestmriExamDate = ParatestmriExamDate_textBox.Date;
        }
        else return false;
        _paratestMRI.NbOfNew = this.NbOfNew_textBox.Text;
        _paratestMRI.NbOfGd = this.NbOfGd_textBox.Text;
        _paratestMRI.NbOfT1 = this.NbOfT1_textBox.Text;
        _paratestMRI.NbOfT2 = this.NbOfT2_textBox.Text;


        _paratestMRI.T1Detail =setDateFieldHelper.getPickerValue(T1_comboBox, _paratestMRI.T1Detail);
        _paratestMRI.T2Detail = setDateFieldHelper.getPickerValue(T2_comboBox, _paratestMRI.T2Detail);
        _paratestMRI.CNSRegion = setDateFieldHelper.getPickerValue(CNSRegion_comboBox, _paratestMRI.CNSRegion);

        _paratestMRI.T1GadoliniumDetail = setDateFieldHelper.getPickerValue(T1Gadolinium_comboBox, _paratestMRI.T1GadoliniumDetail);
        //_paratestMRI.CNSRegion = this.CNSRegion_comboBox.Title;
        //_paratestMRI.T2Detail = this.T2_comboBox.Title;
        //_paratestMRI.T1Detail = this.T1_comboBox.Title;
        //_paratestMRI.T1GadoliniumDetail = this.T1Gadolinium_comboBox.Title;

        if (T1_checkBox.IsChecked)
        {
            _paratestMRI.T1 = "Yes";
        }
        else _paratestMRI.T1 = "No";
        if (T1Gadolinium_checkBox.IsChecked)
        {
            _paratestMRI.T1Gadolinium = "Yes";
        }
        else _paratestMRI.T1Gadolinium = "No";
        if (T2_checkBox.IsChecked)
        {
            _paratestMRI.T2 = "Yes";
        }
        else _paratestMRI.T2 = "No";

        _paratestMRI.Remarks = this.Remarks_textBox.Text;
        return true;
    }


    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {/*
        foreach (var mri in this._ParatestMRIs)
        {
            if (mri.ParatestmriExamDate != null && Othermri_combobox.SelectedItem.ToString().Contains(mri.Id.ToString() +
                ". " + mri.ParatestmriExamDate.ToString().Substring(0, mri.ParatestmriExamDate.ToString().IndexOf(" "))))
            {
                _paratestMRI = mri;
                setFields();
            }
        }*/
    }

    private void Button_AddNewParaclinicalMRI_Clicked(object sender, EventArgs e)
    {
        if (_layout_ParaclinicalTests.Children[0] is not AddNewParaclinicalMRIView)
        {
            _layout_ParaclinicalTests.Children.Clear();
            _layout_ParaclinicalTests.Children.Add(new AddNewParaclinicalMRIView(_layout_ParaclinicalTests, _RecivedId));
        }
    }

    void Othermri_combobox_SelectedIndexChanged(System.Object sender, System.EventArgs e)
    {
        foreach (var mri in this._ParatestMRIs)
        {
            if (mri.ParatestmriExamDate != null && Othermri_combobox.SelectedItem.ToString().Contains(mri.Id.ToString() +
                ". " + mri.ParatestmriExamDate.ToString().Substring(0, mri.ParatestmriExamDate.ToString().IndexOf(" "))))
            {
                paratestMRI = mri;
                setFields(paratestMRI);
            }
        }
    }
}





