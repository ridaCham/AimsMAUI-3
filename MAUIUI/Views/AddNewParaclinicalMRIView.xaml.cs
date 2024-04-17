using MAUIUI.Business.Abstract;
using MAUIUI.Business.DependencyResoulver.AutofacResoulver;
using MAUIUI.Entities.Concrete;
using MAUIUI.Helpers;

namespace MAUIUI.Views;


public partial class AddNewParaclinicalMRIView : ContentView
{
    private string MRIPhotoPath;
    private readonly StackLayout _layout_ParaclinicalTests;


    IParatestMRIService _ParatestMRIService;
    //IParatestMRIImageService _ParatestMRIImageService;
    string _RecivedId;
    List<ParatestMRI> _ParatestMRIs;
    ParatestMRI _paratestMRI;
    //ParatestMRIImage _mriImage;
    List<string?> _CSFDates;
    string ImageExtenssion;
    string ImagePath;

    public AddNewParaclinicalMRIView(StackLayout layout_ParaclinicalTests, string _selectedPatientId)
    {
        InitializeComponent();
        _layout_ParaclinicalTests = layout_ParaclinicalTests;
        _RecivedId = _selectedPatientId;
        _paratestMRI = new ParatestMRI();
        _ParatestMRIService = InstanceFactory.GetInstance<IParatestMRIService>();
        //_ParatestMRIImageService = InstanceFactory.GetInstance<IParatestMRIImageService>();
        _ParatestMRIs = new List<ParatestMRI>();
        //_mriImage = new ParatestMRIImage();
        //_ParatestMRIs = _ParatestMRIService.GetAllByPatientId(_RecivedId).Data;
    }

    private async void AddPhotoParaclinicalMRI_Clicked(object sender, EventArgs e)
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
        if (setCsf(_paratestMRI))
        {
            _ParatestMRIService.Add(_paratestMRI);
            if (ImageExtenssion != null)
            {
                _paratestMRI.ImagePath = "MRIImages/" + _paratestMRI.PatientCode + "-" + _paratestMRI.Id + ImageExtenssion;
                File.Copy(ImagePath, _paratestMRI.ImagePath);
                _ParatestMRIService.Update(_paratestMRI);
            }


            if (_layout_ParaclinicalTests.Children[0] is not ParaclinicalMRIView)
            {
                _layout_ParaclinicalTests.Children.Clear();
                _layout_ParaclinicalTests.Children.Add(new ParaclinicalMRIView(_layout_ParaclinicalTests, "ASSA"));
            }

        }


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


        _paratestMRI.T1Detail = setDateFieldHelper.getPickerValue(T1_comboBox, _paratestMRI.T1Detail);
        _paratestMRI.T2Detail = setDateFieldHelper.getPickerValue(T2_comboBox, _paratestMRI.T2Detail);
        _paratestMRI.CNSRegion = setDateFieldHelper.getPickerValue(CNSRegion_comboBox, _paratestMRI.CNSRegion); 
        _paratestMRI.T1GadoliniumDetail = setDateFieldHelper.getPickerValue(T1Gadolinium_comboBox, _paratestMRI.T1GadoliniumDetail);

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


}