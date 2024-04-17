using MAUIUI.Business.Abstract;
using MAUIUI.Business.DependencyResoulver.AutofacResoulver;
using MAUIUI.Entities.Concrete;
using MAUIUI.Helpers;

namespace MAUIUI.Views;

public partial class ParaclinicalEvokedPotentialsView : ContentView
{
    private readonly StackLayout _layout_ParaclinicalTests;
    IEvokedPotentielService _evokedPotentielService;
    string _RecivedId;
    List<EvokedPotentiel> _evokedPotentiels;
    EvokedPotentiel evokedPotentiel;
    List<string?> _CSFDates;

    public ParaclinicalEvokedPotentialsView(StackLayout layout_ParaclinicalTests, string _selectedPatientId)
    {
        InitializeComponent();
        _layout_ParaclinicalTests = layout_ParaclinicalTests;
        _RecivedId = _selectedPatientId;
        _evokedPotentielService = InstanceFactory.GetInstance<IEvokedPotentielService>();
        _evokedPotentiels = new List<EvokedPotentiel>();
        _evokedPotentiels = _evokedPotentielService.GetAllByPatientId(_RecivedId).Data;
        if (_evokedPotentiels.Count > 0)
        {
            _CSFDates = new List<string?>();
            evokedPotentiel = new EvokedPotentiel();
            foreach (var Evockedtest in _evokedPotentiels)
            {
                if (Evockedtest.ExameDate.ToString() != null)
                {
                    _CSFDates.Add(Evockedtest.Id.ToString() + ". " + Evockedtest.ExameDate.ToString().Substring(0, 10));
                }
            }

            evokedPotentiel = _evokedPotentiels[0];
            this.OtherEvokedPotentials_combobox.ItemsSource = _CSFDates;

            setFields(evokedPotentiel);
        }

    }



     
    private void setFields(EvokedPotentiel _evokedPotentiel)
    {
        setDateFieldHelper.setMaskedTextboxDate(_evokedPotentiel.ExameDate,
            EvokedExamDate_textBox);
        if (_evokedPotentiel.VEPRight == "Normal")
        {
            RightVEPNormal_checkBox.IsChecked = true;
        }
        else if (_evokedPotentiel.VEPRight == "Abnormal")
        {
            RightVEPAnormal_checkBox.IsChecked = true;
        }
        if (_evokedPotentiel.VEPLeft == "Normal")
        {
            LeftVEPNormal_checkBox.IsChecked = true;
        }
        else if (_evokedPotentiel.VEPLeft == "Abnormal")
        {
            LeftVEPAnormal_checkBox.IsChecked = true;
        }


        this.RightVEPAmplitude_textBox.Text = _evokedPotentiel.VEPRightAmplitude;
        this.LeftVEPAmplitude_textBox.Text = _evokedPotentiel.VEPLeftAmplitude;
        this.RightVEPMsec_textBox.Text = _evokedPotentiel.VEPRightMesc;
        this.LeftVEPMsec_textBox.Text = _evokedPotentiel.VEPLeftMesc;
        this.NormalRangeForMsec_textBox.Text = _evokedPotentiel.VEPMescRange;
        this.TotalRangeForMsec_textBox.Text = _evokedPotentiel.VEPMescRangeTotal;

        if (_evokedPotentiel.BAEPRight == "Normal")
        {
            RightBAEPNormal_checkBox.IsChecked = true;
        }
        else if (_evokedPotentiel.BAEPRight == "Abnormal")
        {
            RightBAEPAbnormal_checkBox.IsChecked = true;
        }
        if (_evokedPotentiel.BAEPLeft == "Normal")
        {
            LeftBAEPNormal_checkBox.IsChecked = true;
        }
        else if (_evokedPotentiel.BAEPLeft == "Abnormal")
        {
            LeftBAEPAbnormal_checkBox.IsChecked = true;
        }


        if (_evokedPotentiel.RightSEPUpperExtrimity == "Normal")
        {
            RightUPSEPNormal_checkBox.IsChecked = true;
        }
        else if (_evokedPotentiel.RightSEPUpperExtrimity == "Abnormal")
        {
            RightUPSEPAbnormal_checkBox.IsChecked = true;
        }
        if (_evokedPotentiel.RightSEPLowerExtrimity == "Normal")
        {
            RightLowerSEPNormal_checkBox.IsChecked = true;
        }
        else if (_evokedPotentiel.RightSEPLowerExtrimity == "Abnormal")
        {
            RightLowerSEPAbnormal_checkBox.IsChecked = true;
        }
        if (_evokedPotentiel.LeftSEPLowerExtrimity == "Normal")
        {
            LeftLowerSEPNormal_checkBox.IsChecked = true;
        }
        else if (_evokedPotentiel.LeftSEPLowerExtrimity == "Abnormal")
        {
            LeftLowerSEPAbnormal_checkBox.IsChecked = true;
        }
        if (_evokedPotentiel.LeftSEPUpperExtrimity == "Normal")
        {
            LeftUPSEPNormal_checkBox.IsChecked = true;
        }
        else if (_evokedPotentiel.LeftSEPUpperExtrimity == "Abnormal")
        {
            LeftUPSEPAbnormal_checkBox.IsChecked = true;
        }


        if (_evokedPotentiel.RightMEPUpperExtrimity == "Normal")
        {
            RightUpMEPNormal_checkBox.IsChecked = true;
        }
        else if (_evokedPotentiel.RightMEPUpperExtrimity == "Abnormal")
        {
            RightUpMEPAbnormal_checkBox.IsChecked = true;
        }
        if (_evokedPotentiel.RightMEPLowerExtrimity == "Normal")
        {
            RightLowerMEPNormal_checkBox.IsChecked = true;
        }
        else if (_evokedPotentiel.RightMEPLowerExtrimity == "Abnormal")
        {
            RightLowerMEPAbnormal_checkBox.IsChecked = true;
        }
        if (_evokedPotentiel.LeftMEPLowerExtrimity == "Normal")
        {
            LeftLowerMEPNormal_checkBox.IsChecked = true;
        }
        else if (_evokedPotentiel.LeftMEPLowerExtrimity == "Abnormal")
        {
            LeftLowerMEPAbnormal_checkBox.IsChecked = true;
        }
        if (_evokedPotentiel.LeftMEPUpperExtrimity == "Normal")
        {
            LeftUPMEPNormal_checkBox.IsChecked = true;
        }
        else if (_evokedPotentiel.LeftMEPUpperExtrimity == "Abnormal")
        {
            LeftUPMEPAbnormal_checkBox.IsChecked = true;
        }
        this.Remarks_textBox.Text = _evokedPotentiel.Remarks;
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

      




    private void Button_SaveEvokedPotentials_Clicked(object sender, EventArgs e)
    {
        
        if (evokedPotentiel == null)
        {
            Navigation.PopAsync();
        }
        else if (setCsf(evokedPotentiel))
        {
            _evokedPotentielService.Update(evokedPotentiel);
            Navigation.PopAsync();
        }

    }

    private void Button_AddNewEvokedPotentials_Clicked(object sender, EventArgs e)
    {
        if (_layout_ParaclinicalTests.Children[0] is not AddNewParaclinicalEvokedPotentialsView)
        {
            _layout_ParaclinicalTests.Children.Clear();
            _layout_ParaclinicalTests.Children.Add(new AddNewParaclinicalEvokedPotentialsView(_layout_ParaclinicalTests, _RecivedId));
        }
    }

    void OtherEvokedPotentials_combobox_SelectedIndexChanged(System.Object sender, System.EventArgs e)
    {

        foreach (var evockedTest in _evokedPotentiels)
        {
            if (evockedTest.ExameDate != null && OtherEvokedPotentials_combobox.SelectedItem.ToString().Contains(evockedTest.Id.ToString() +
                ". " + evockedTest.ExameDate.ToString().Substring(0, evockedTest.ExameDate.ToString().IndexOf(" "))))
            {
                evokedPotentiel = evockedTest;
                RadiobuttonCleaner.cleanRadiobuttons(
                    LeftVEPAnormal_checkBox, RightVEPAnormal_checkBox, LeftVEPNormal_checkBox, RightVEPNormal_checkBox,
                    LeftBAEPAbnormal_checkBox, LeftBAEPNormal_checkBox, RightBAEPNormal_checkBox, RightBAEPAbnormal_checkBox,
                    LeftLowerSEPAbnormal_checkBox, LeftLowerSEPNormal_checkBox, RightLowerSEPNormal_checkBox, RightLowerSEPAbnormal_checkBox,
                    LeftUPSEPAbnormal_checkBox, LeftUPSEPNormal_checkBox, RightUPSEPNormal_checkBox, RightUPSEPAbnormal_checkBox,
                    LeftLowerMEPAbnormal_checkBox, LeftLowerMEPNormal_checkBox, RightLowerMEPNormal_checkBox, RightLowerMEPAbnormal_checkBox,
                    LeftUPMEPAbnormal_checkBox, LeftUPMEPNormal_checkBox, RightUpMEPNormal_checkBox, RightUpMEPAbnormal_checkBox

                    );
                setFields(evokedPotentiel);
            }
        }
    }
}