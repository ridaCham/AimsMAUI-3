using MAUIUI.Business.Abstract;
using MAUIUI.Business.DependencyResoulver.AutofacResoulver;
using MAUIUI.Entities.Concrete;
using MAUIUI.Helpers;

namespace MAUIUI.Views;

public partial class AddNewParaclinicalEvokedPotentialsView : ContentView
{
    private readonly StackLayout _layout_ParaclinicalTests; 
    IEvokedPotentielService _evokedPotentielService;
    string _RecivedId;
    List<EvokedPotentiel> _evokedPotentiels;
    EvokedPotentiel _evokedPotentiel;
    List<string?> _CSFDates;
    public AddNewParaclinicalEvokedPotentialsView(StackLayout layout_ParaclinicalTests, string _selectedPatientId)
    {
        InitializeComponent();
        _layout_ParaclinicalTests = layout_ParaclinicalTests;


        _RecivedId = _selectedPatientId;
        _evokedPotentielService = InstanceFactory.GetInstance<IEvokedPotentielService>();
        _evokedPotentiels = new List<EvokedPotentiel>();
        _evokedPotentiel = new EvokedPotentiel();

    }

    private void button_Save_Click(object sender, EventArgs e)
    {
       
    }
    private void Button_SaveEvokedPotentials_Clicked(object sender, EventArgs e)
    {
        if (setCsf(_evokedPotentiel))
        {
            _evokedPotentielService.Add(_evokedPotentiel);
            _layout_ParaclinicalTests.Children.Clear();
            _layout_ParaclinicalTests.Children.Add(new ParaclinicalEvokedPotentialsView(_layout_ParaclinicalTests, _RecivedId));
        }
    }



    private bool setCsf(EvokedPotentiel _evokedPotentiel)
    {
        _evokedPotentiel.PatientCode = _RecivedId;
        if (setDateFieldHelper.ValidateUnnullableDate(EvokedExamDate_textBox) == null)
        {
            _evokedPotentiel.ExameDate = EvokedExamDate_textBox.Date;
        }
        else return false;

        if (RightVEPNormal_checkBox.IsChecked)
        {
            _evokedPotentiel.VEPRight = "Normal";
        }
        else if (RightVEPAnormal_checkBox.IsChecked)
        {
            _evokedPotentiel.VEPRight = "Abnormal";
        }
        if (LeftVEPNormal_checkBox.IsChecked)
        {
            _evokedPotentiel.VEPLeft = "Normal";
        }
        else if (LeftVEPAnormal_checkBox.IsChecked)
        {
            _evokedPotentiel.VEPLeft = "Abnormal";
        }


        _evokedPotentiel.VEPRightAmplitude = this.RightVEPAmplitude_textBox.Text;
        _evokedPotentiel.VEPLeftAmplitude = this.LeftVEPAmplitude_textBox.Text;
        _evokedPotentiel.VEPRightMesc = this.RightVEPMsec_textBox.Text;
        _evokedPotentiel.VEPLeftMesc = this.LeftVEPMsec_textBox.Text;
        _evokedPotentiel.VEPMescRange = this.NormalRangeForMsec_textBox.Text;
        _evokedPotentiel.VEPMescRangeTotal = this.TotalRangeForMsec_textBox.Text;

        if (RightBAEPNormal_checkBox.IsChecked)
        {
            _evokedPotentiel.BAEPRight = "Normal";
        }
        else if (RightBAEPAbnormal_checkBox.IsChecked)
        {
            _evokedPotentiel.BAEPRight = "Abnormal";
        }
        if (LeftBAEPNormal_checkBox.IsChecked)
        {
            _evokedPotentiel.BAEPLeft = "Normal";
        }
        else if (LeftBAEPAbnormal_checkBox.IsChecked)
        {
            _evokedPotentiel.BAEPLeft = "Abnormal";
        }


        if (RightUPSEPNormal_checkBox.IsChecked)
        {
            _evokedPotentiel.RightSEPUpperExtrimity = "Normal";
        }
        else if (RightUPSEPAbnormal_checkBox.IsChecked)
        {
            _evokedPotentiel.RightSEPUpperExtrimity = "Abnormal";
        }
        if (RightLowerSEPNormal_checkBox.IsChecked)
        {
            _evokedPotentiel.RightSEPLowerExtrimity = "Normal";
        }
        else if (RightLowerSEPAbnormal_checkBox.IsChecked)
        {
            _evokedPotentiel.RightSEPLowerExtrimity = "Abnormal";
        }
        if (LeftLowerSEPNormal_checkBox.IsChecked)
        {
            _evokedPotentiel.LeftSEPLowerExtrimity = "Normal";
        }
        else if (LeftLowerSEPAbnormal_checkBox.IsChecked)
        {
            _evokedPotentiel.LeftSEPLowerExtrimity = "Abnormal";
        }
        if (LeftUPSEPNormal_checkBox.IsChecked)
        {
            _evokedPotentiel.LeftSEPUpperExtrimity = "Normal";
        }
        else if (LeftUPSEPAbnormal_checkBox.IsChecked)
        {
            _evokedPotentiel.LeftSEPUpperExtrimity = "Abnormal";
        }


        if (RightUpMEPNormal_checkBox.IsChecked)
        {
            _evokedPotentiel.RightMEPUpperExtrimity = "Normal";
        }
        else if (RightUpMEPAbnormal_checkBox.IsChecked)
        {
            _evokedPotentiel.RightMEPUpperExtrimity = "Abnormal";
        }
        if (RightLowerMEPNormal_checkBox.IsChecked)
        {
            _evokedPotentiel.RightMEPLowerExtrimity = "Normal";
        }
        else if (RightLowerMEPAbnormal_checkBox.IsChecked)
        {
            _evokedPotentiel.RightMEPLowerExtrimity = "Abnormal";
        }
        if (LeftLowerMEPNormal_checkBox.IsChecked)
        {
            _evokedPotentiel.LeftMEPLowerExtrimity = "Normal";
        }
        else if (LeftLowerMEPAbnormal_checkBox.IsChecked)
        {
            _evokedPotentiel.LeftMEPLowerExtrimity = "Abnormal";
        }
        if (LeftUPMEPNormal_checkBox.IsChecked)
        {
            _evokedPotentiel.LeftMEPUpperExtrimity = "Normal";
        }
        else if (LeftUPMEPAbnormal_checkBox.IsChecked)
        {
            _evokedPotentiel.LeftMEPUpperExtrimity = "Abnormal";
        }

        _evokedPotentiel.Remarks = this.Remarks_textBox.Text;
        return true;
    }



}