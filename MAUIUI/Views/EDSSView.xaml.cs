using MAUIUI.Views;
using DocumentFormat.OpenXml.Drawing;
namespace MAUIUI.Views;

public partial class EDSSView : ContentView
{
    public Button _activatedButtonLayoutSymptoms;
    private EDSSPyramidalInfoView _pyramidalInfoView;
    private EDSSCerebellarInfoView _cerebellarInfoView;
    private EDSSBrainstemInfoView _brainstemInfoView;
    private EDSSSensoryInfoView _sensoryInfoView;
    private EDSSBowelInfoView _bowelInfoView;
    private EDSSVisualInfoView _visualInfoView;
    private EDSSMentalInfoView _mentalInfoView;
    private EDSSAmbulationInfoView _ambulationInfoView;


    public EDSSView()
	{
		InitializeComponent();

        _pyramidalInfoView = new EDSSPyramidalInfoView();
        _cerebellarInfoView = new EDSSCerebellarInfoView();
        _brainstemInfoView = new EDSSBrainstemInfoView();
        _sensoryInfoView = new EDSSSensoryInfoView();
        _bowelInfoView = new EDSSBowelInfoView();
        _visualInfoView = new EDSSVisualInfoView();
        _mentalInfoView = new EDSSMentalInfoView();
        _ambulationInfoView = new EDSSAmbulationInfoView();

    }

    private void button_PyramidalInfo_Clicked(object sender, EventArgs e)
    {
        ChangeContentLayoutInformation(_pyramidalInfoView, button_PyramidalInfo);
    }

    private void button_CerebellarInfo_Clicked(object sender, EventArgs e)
    {
        ChangeContentLayoutInformation(_cerebellarInfoView, button_CerebellarInfo);
    }

    private void button_BrainstemInfo_Clicked(object sender, EventArgs e)
    {
        ChangeContentLayoutInformation(_brainstemInfoView, button_BrainstemInfo);
    }

    private void button_SensoryInfo_Clicked(object sender, EventArgs e)
    {
        ChangeContentLayoutInformation(_sensoryInfoView, button_SensoryInfo);
    }

    private void button_BowelInfo_Clicked(object sender, EventArgs e)
    {
        ChangeContentLayoutInformation(_bowelInfoView, button_BowelInfo);
    }

    private void button_VisualInfo_Clicked(object sender, EventArgs e)
    {
        ChangeContentLayoutInformation(_visualInfoView, button_VisualInfo);
    }

    private void button_MentalInfo_Clicked(object sender, EventArgs e)
    {
        ChangeContentLayoutInformation(_mentalInfoView, button_MentalInfo);
    }

    private void button_AmbulationInfo_Clicked(object sender, EventArgs e)
    {
        ChangeContentLayoutInformation(_ambulationInfoView, button_AmbulationInfo);
    }

    private void ChangeContentLayoutInformation(ContentView contentView, Button contentButton)
    {
        if (layout_Information.Children.Count == 0)
        {
            layout_Information.Children.Add(contentView);
            ButtonActivating(contentButton, true);
            _activatedButtonLayoutSymptoms = contentButton;
        }
        else if (layout_Information.Children[0].GetType() != contentView.GetType())
        {
            ButtonActivating(contentButton, true);
            ButtonActivating(_activatedButtonLayoutSymptoms, false);
            _activatedButtonLayoutSymptoms = contentButton;

            layout_Information.Children.Clear();
            layout_Information.Children.Add(contentView);
        }
        else
        {
            ButtonActivating(_activatedButtonLayoutSymptoms, false);
            layout_Information.Children.Clear();
        }
    }

    private void ButtonActivating(Button button, bool isActivated)
    {
        if(isActivated)
        {
            button.BackgroundColor = Colors.Gray;
        }
        else
        {
            button.BackgroundColor = Colors.IndianRed;
        }
        
    }
}

/*

    
        double funcValue = 0;
string _selectedId;
Edss _edss;
IEdssService _edssService;
DateTime? _date;
private float Total;
int zeroCouter = 0;
int oneCounter = 0;
int twoCounter = 0;
int threeCounter = 0;
int fourCounter = 0;
int fiveCounter = 0;
int sixCounter = 0;

public edss(string selectedId, DateTime? date)
{
    InitializeComponent();
    _selectedId = selectedId;
    _date = date;
    _edssService = InstanceFactory.GetInstance<IEdssService>();
    _edss = new Edss();
    if (_edssService.GetByPatientId(_selectedId, _date).Data != null)
    {
        _edss = _edssService.GetByPatientId(_selectedId, _date).Data;
    }
    setDateFieldHelper.setMaskedTextboxDate(_date,
        EdssDate_textBox);
    if (_edss != null)
    {
        setFields();
    }
}


void FunctionalEDSS()
{
    if (ambulationControl(this.Ambulation4_radiobutton, Ambulation5_radiobutton, Ambulation6_radiobutton,
        Ambulation7_radiobutton, Ambulation8_radiobutton, Ambulation9_radiobutton,
        Ambulation10_radiobutton, Ambulation11_radiobutton, Ambulation12_radiobutton,
        Ambulation13_radiobutton, Ambulation14_radiobutton, Ambulation15_radiobutton))
    {
        if (zeroCouter == 7)
        {
            funcValue = 0;
        }
        if (oneCounter == 1)
        {
            funcValue = 1;
        }
        if (oneCounter > 1)
        {
            funcValue = 1.5;
        }
        if (twoCounter == 0 && threeCounter == 1)
        {
            funcValue = 3;
        }
        if (twoCounter == 0 && threeCounter == 2)
        {
            funcValue = 3.5;
        }
        if (twoCounter == 0 && threeCounter == 0 && fourCounter == 1)
        {
            funcValue = 4;
        }
        if (twoCounter == 1)
        {
            funcValue = 2;
            if (threeCounter == 1)
            {
                funcValue = 3.5;
            }

        }
        if (twoCounter == 2)
        {
            funcValue = 2.5;
            if (threeCounter == 1)
            {
                funcValue = 3.5;
            }
        }
        if (twoCounter == 4 || twoCounter == 3)
        {
            funcValue = 3;
        }
        if (twoCounter == 5)
        {
            funcValue = 3.5;
        }
        if (twoCounter == 7 || twoCounter == 6)
        {
            funcValue = 4;
        }
        if (threeCounter == 3 || threeCounter == 4)
        {
            funcValue = 4;
        }
        if (threeCounter == 5)
        {
            funcValue = 4.5;
        }
        if (threeCounter == 1 && fourCounter == 1)
        {
            funcValue = 4.5;
        }
        if (threeCounter == 2 && fourCounter == 1)
        {
            funcValue = 4.5;
        }
        if (threeCounter == 6 || fourCounter == 7)
        {
            funcValue = 5;
        }
        if (fourCounter > 1)
        {
            funcValue = 5;
        }
        if (fiveCounter > 0 || sixCounter > 0)
        {
            funcValue = 5;
        }

        zeroCouter = 0;
        oneCounter = 0;
        twoCounter = 0;
        threeCounter = 0;
        fourCounter = 0;
        fiveCounter = 0;
        sixCounter = 0;
    }

    if (Ambulation3_radiobutton.Checked)
    {
        funcValue = 5;
    }
    if (Ambulation2_radiobutton.Checked)
    {
        funcValue = 4.5;
    }

}
bool ambulationControl(params RadioButton[] ambs)
{
    foreach (var item in ambs)
    {
        if (item.Checked)
        {
            return false;
        }
    }
    return true;
}
public bool setEdss()
{

    _edss.PatientCode = _selectedId;
    if (setDateFieldHelper.ValidateUnnullableDate(EdssDate_textBox))
    {
        _edss.Date = DateTime.Parse(EdssDate_textBox.Text);
    }
    else return false;
    _edss.Remarks = this.EdssRemarks_textBox.Text;
    if (this.Pyramidal0_radiobutton.Checked)
    {
        _edss.Pyramidal = 0;
        zeroCouter += 1;
    }
    else if (this.Pyramidal1_radiobutton.Checked)
    {
        _edss.Pyramidal = 1;
        oneCounter += 1;
    }
    else if (this.Pyramidal2_radiobutton.Checked)
    {
        _edss.Pyramidal = 2;
        twoCounter++;
    }
    else if (this.Pyramidal3_radiobutton.Checked)
    {
        _edss.Pyramidal = 3; threeCounter++;
    }
    else if (this.Pyramidal4_radiobutton.Checked)
    {
        _edss.Pyramidal = 4; fourCounter++;
    }
    else if (this.Pyramidal5_radiobutton.Checked)
    {
        _edss.Pyramidal = 5; fiveCounter++;
    }
    else if (this.Pyramidal6_radiobutton.Checked)
    {
        _edss.Pyramidal = 6; sixCounter++;
    }
    if (this.Cerebellar0_radiobutton.Checked)
    {
        _edss.Cerebellar = 0;
        zeroCouter += 1;
    }
    else if (this.Cerebellar1_radiobutton.Checked)
    {
        _edss.Cerebellar = 1;
        oneCounter += 1;
    }
    else if (this.Cerebellar2_radiobutton.Checked)
    {
        _edss.Cerebellar = 2; twoCounter++;
    }
    else if (this.Cerebellar3_radiobutton.Checked)
    {
        _edss.Cerebellar = 3; threeCounter++;
    }
    else if (this.Cerebellar4_radiobutton.Checked)
    {
        _edss.Cerebellar = 4; fourCounter++;
    }
    else if (this.Cerebellar5_radiobutton.Checked)
    {
        _edss.Cerebellar = 5; fiveCounter++;
    }
    if (this.Ambulation0_radiobutton.Checked)
    {
        _edss.Ambilation = 0;
    }
    else if (this.Ambulation1_radiobutton.Checked)
    {
        _edss.Ambilation = 1;
    }
    else if (this.Ambulation2_radiobutton.Checked)
    {
        _edss.Ambilation = 2; funcValue = 4.5;
    }
    else if (this.Ambulation3_radiobutton.Checked)
    {
        _edss.Ambilation = 3; funcValue = 5;
    }
    else if (this.Ambulation4_radiobutton.Checked)
    {
        _edss.Ambilation = 4; funcValue = 5.5;
    }
    else if (this.Ambulation5_radiobutton.Checked)
    {
        _edss.Ambilation = 5; funcValue = 6;
    }
    else if (this.Ambulation6_radiobutton.Checked)
    {
        _edss.Ambilation = 6; funcValue = 6;
    }
    else if (this.Ambulation10_radiobutton.Checked)
    {
        _edss.Ambilation = 10; funcValue = 7;
    }
    else if (this.Ambulation11_radiobutton.Checked)
    {
        _edss.Ambilation = 11; funcValue = 7.5;
    }
    else if (this.Ambulation12_radiobutton.Checked)
    {
        _edss.Ambilation = 12; funcValue = 8;
    }
    else if (this.Ambulation9_radiobutton.Checked)
    {
        _edss.Ambilation = 9; funcValue = 6.5;
    }
    else if (this.Ambulation8_radiobutton.Checked)
    {
        _edss.Ambilation = 8; funcValue = 6.5;
    }
    else if (this.Ambulation7_radiobutton.Checked)
    {
        _edss.Ambilation = 7; funcValue = 6;
    }
    else if (this.Ambulation13_radiobutton.Checked)
    {
        _edss.Ambilation = 13; funcValue = 8.5;
    }
    else if (this.Ambulation14_radiobutton.Checked)
    {
        _edss.Ambilation = 14; funcValue = 9;
    }
    else if (this.Ambulation15_radiobutton.Checked)
    {
        _edss.Ambilation = 15; funcValue = 9.5;
    }
    if (this.Brainstem0_radiobutton.Checked)
    {
        _edss.Brainstem = 0;
        zeroCouter += 1;
    }
    else if (this.Brainstem1_radiobutton.Checked)
    {
        _edss.Brainstem = 1;
        oneCounter += 1;
    }
    else if (this.Brainstem2_radiobutton.Checked)
    {
        _edss.Brainstem = 2; twoCounter++;
    }
    else if (this.Brainstem3_radiobutton.Checked)
    {
        _edss.Brainstem = 3; threeCounter++;
    }
    else if (this.Brainstem4_radiobutton.Checked)
    {
        _edss.Brainstem = 4; fourCounter++;
    }
    else if (this.Brainstem5_radiobutton.Checked)
    {
        _edss.Brainstem = 5; fiveCounter++;
    }


    if (this.BowelBladder0_radiobutton.Checked)
    {
        _edss.Bowel = 0;
        zeroCouter += 1;
    }
    else if (this.BowelBladder1_radiobutton.Checked)
    {
        _edss.Bowel = 1;
        oneCounter += 1;
    }
    else if (this.BowelBladder2_radiobutton.Checked)
    {
        _edss.Bowel = 2; twoCounter++;
    }
    else if (this.BowelBladder3_radiobutton.Checked)
    {
        _edss.Bowel = 3; threeCounter++;
    }
    else if (this.BowelBladder4_radiobutton.Checked)
    {
        _edss.Bowel = 4; threeCounter++;
    }
    else if (this.BowelBladder5_radiobutton.Checked)
    {
        _edss.Bowel = 5; fourCounter++;
    }
    else if (this.BowelBladder6_radiobutton.Checked)
    {
        _edss.Bowel = 6; fiveCounter++;
    }


    if (this.Sensory0_radiobutton.Checked)
    {
        _edss.Sensory = 0;
        zeroCouter += 1;
    }
    else if (this.Sensory1_radiobutton.Checked)
    {
        _edss.Sensory = 1;
        oneCounter += 1;
    }
    else if (this.Sensory2_radiobutton.Checked)
    {
        _edss.Sensory = 2; twoCounter++;
    }
    else if (this.Sensory3_radiobutton.Checked)
    {
        _edss.Sensory = 3; threeCounter++;
    }
    else if (this.Sensory4_radiobutton.Checked)
    {
        _edss.Sensory = 4; fourCounter++;
    }
    else if (this.Sensory5_radiobutton.Checked)
    {
        _edss.Sensory = 5; fiveCounter++;
    }
    else if (this.Sensory6_radiobutton.Checked)
    {
        _edss.Sensory = 6; sixCounter++;
    }

    if (this.Visual0_radiobutton.Checked)
    {
        _edss.Visual = 0;
        zeroCouter += 1;
    }
    else if (this.Visual1_radiobutton.Checked)
    {
        _edss.Visual = 1;
        oneCounter += 1;
    }
    else if (this.Visual2_radiobutton.Checked)
    {
        _edss.Visual = 2; twoCounter++;
    }
    else if (this.Visual3_radiobutton.Checked)
    {
        _edss.Visual = 3; twoCounter++;
    }
    else if (this.Visual4_radiobutton.Checked)
    {
        _edss.Visual = 4; threeCounter++;
    }
    else if (this.Visual5_radiobutton.Checked)
    {
        _edss.Visual = 5; threeCounter++;
    }
    else if (this.Visual6_radiobutton.Checked)
    {
        _edss.Visual = 6; fourCounter++;
    }



    if (this.Mental0_radiobutton.Checked)
    {
        _edss.Mental = 0;
        zeroCouter += 1;
    }
    else if (this.Mental1_radiobutton.Checked)
    {
        _edss.Mental = 1;
        oneCounter += 1;
    }
    else if (this.Mental2_radiobutton.Checked)
    {
        _edss.Mental = 2;
    }
    else if (this.Mental3_radiobutton.Checked)
    {
        _edss.Mental = 3;
    }
    else if (this.Mental4_radiobutton.Checked)
    {
        _edss.Mental = 4;
    }
    else if (this.Mental5_radiobutton.Checked)
    {
        _edss.Mental = 5;
    }
    if (Total_combox.SelectedIndex != -1)
        _edss.Total = float.Parse(Total_combox.Text);
    if (Total != null)
    {
        _edss.Total = Total;
    }
    return true;
}

public void setFields()
{
    this.EdssRemarks_textBox.Text = _edss.Remarks;
    if (_edss.Total != null)
        this.Total_combox.Text = _edss.Total.ToString();
    else
    {
        Total_combox.SelectedIndex = -1;
    }

    if (_edss.Pyramidal == 0)
    {
        this.Pyramidal0_radiobutton.Checked = true;
    }
    else if (_edss.Pyramidal == 1)
    {
        this.Pyramidal1_radiobutton.Checked = true;
    }
    else if (_edss.Pyramidal == 2)
    {
        this.Pyramidal2_radiobutton.Checked = true;
    }
    else if (_edss.Pyramidal == 3)
    {
        this.Pyramidal3_radiobutton.Checked = true;
    }
    else if (_edss.Pyramidal == 4)
    {
        this.Pyramidal4_radiobutton.Checked = true;
    }
    else if (_edss.Pyramidal == 5)
    {
        this.Pyramidal5_radiobutton.Checked = true;
    }
    else if (_edss.Pyramidal == 6)
    {
        this.Pyramidal6_radiobutton.Checked = true;
    }
    else
    {
        this.Pyramidal0_radiobutton.Checked = false;
        this.Pyramidal1_radiobutton.Checked = false;
        this.Pyramidal2_radiobutton.Checked = false;
        this.Pyramidal3_radiobutton.Checked = false;
        this.Pyramidal4_radiobutton.Checked = false;
        this.Pyramidal4_radiobutton.Checked = false;
        this.Pyramidal5_radiobutton.Checked = false;
        this.Pyramidal6_radiobutton.Checked = false;
    }

    if (_edss.Cerebellar == 0)
    {
        this.Cerebellar0_radiobutton.Checked = true;
    }
    else if (_edss.Cerebellar == 1)
    {
        this.Cerebellar1_radiobutton.Checked = true;
    }
    else if (_edss.Cerebellar == 2)
    {
        this.Cerebellar2_radiobutton.Checked = true;
    }
    else if (_edss.Cerebellar == 3)
    {
        this.Cerebellar3_radiobutton.Checked = true;
    }
    else if (_edss.Cerebellar == 4)
    {
        this.Cerebellar4_radiobutton.Checked = true;
    }
    else if (_edss.Cerebellar == 5)
    {
        this.Cerebellar5_radiobutton.Checked = true;
    }
    else
    {
        this.Cerebellar0_radiobutton.Checked = false;
        this.Cerebellar1_radiobutton.Checked = false;
        this.Cerebellar2_radiobutton.Checked = false;
        this.Cerebellar3_radiobutton.Checked = false;
        this.Cerebellar4_radiobutton.Checked = false;
        this.Cerebellar5_radiobutton.Checked = false;
    }

    if (_edss.Ambilation == 0)
    {
        this.Ambulation0_radiobutton.Checked = true;
    }
    else if (_edss.Ambilation == 1)
    {
        this.Ambulation1_radiobutton.Checked = true;
    }
    else if (_edss.Ambilation == 2)
    {
        this.Ambulation2_radiobutton.Checked = true;
    }
    else if (_edss.Ambilation == 3)
    {
        this.Ambulation3_radiobutton.Checked = true;
    }
    else if (_edss.Ambilation == 4)
    {
        this.Ambulation4_radiobutton.Checked = true;
    }
    else if (_edss.Ambilation == 5)
    {
        this.Ambulation5_radiobutton.Checked = true;
    }
    else if (_edss.Ambilation == 6)
    {
        this.Ambulation6_radiobutton.Checked = true;
    }
    else if (_edss.Ambilation == 7)
    {
        this.Ambulation7_radiobutton.Checked = true;
    }
    else if (_edss.Ambilation == 8)
    {
        this.Ambulation8_radiobutton.Checked = true;
    }
    else if (_edss.Ambilation == 9)
    {
        this.Ambulation9_radiobutton.Checked = true;
    }
    else if (_edss.Ambilation == 10)
    {
        this.Ambulation10_radiobutton.Checked = true;
    }
    else if (_edss.Ambilation == 11)
    {
        this.Ambulation11_radiobutton.Checked = true;
    }
    else if (_edss.Ambilation == 12)
    {
        this.Ambulation12_radiobutton.Checked = true;
    }
    else if (_edss.Ambilation == 13)
    {
        this.Ambulation13_radiobutton.Checked = true;
    }
    else if (_edss.Ambilation == 14)
    {
        this.Ambulation14_radiobutton.Checked = true;
    }
    else if (_edss.Ambilation == 15)
    {
        this.Ambulation15_radiobutton.Checked = true;
    }
    else
    {
        this.Ambulation12_radiobutton.Checked = false;
        this.Ambulation0_radiobutton.Checked = false;
        this.Ambulation1_radiobutton.Checked = false;
        this.Ambulation2_radiobutton.Checked = false;
        this.Ambulation3_radiobutton.Checked = false;
        this.Ambulation4_radiobutton.Checked = false;
        this.Ambulation5_radiobutton.Checked = false;
        this.Ambulation6_radiobutton.Checked = false;
        this.Ambulation7_radiobutton.Checked = false;
        this.Ambulation8_radiobutton.Checked = false;
        this.Ambulation9_radiobutton.Checked = false;
        this.Ambulation10_radiobutton.Checked = false;
        this.Ambulation11_radiobutton.Checked = false;
        this.Ambulation13_radiobutton.Checked = false;
        this.Ambulation14_radiobutton.Checked = false;
        this.Ambulation15_radiobutton.Checked = false;
    }
    if (_edss.Brainstem == 0)
    {
        this.Brainstem0_radiobutton.Checked = true;
    }
    else if (_edss.Brainstem == 1)
    {
        this.Brainstem1_radiobutton.Checked = true;
    }
    else if (_edss.Brainstem == 2)
    {
        this.Brainstem2_radiobutton.Checked = true;
    }
    else if (_edss.Brainstem == 3)
    {
        this.Brainstem3_radiobutton.Checked = true;
    }
    else if (_edss.Brainstem == 4)
    {
        this.Brainstem4_radiobutton.Checked = true;
    }
    else if (_edss.Brainstem == 5)
    {
        this.Brainstem5_radiobutton.Checked = true;
    }
    else
    {
        this.Brainstem0_radiobutton.Checked = false;
        this.Brainstem1_radiobutton.Checked = false;
        this.Brainstem2_radiobutton.Checked = false;
        this.Brainstem3_radiobutton.Checked = false;
        this.Brainstem4_radiobutton.Checked = false;
        this.Brainstem5_radiobutton.Checked = false;
    }

    if (_edss.Bowel == 0)
    {
        this.BowelBladder0_radiobutton.Checked = true;
    }
    else if (_edss.Bowel == 1)
    {
        this.BowelBladder1_radiobutton.Checked = true;
    }
    else if (_edss.Bowel == 2)
    {
        this.BowelBladder2_radiobutton.Checked = true;
    }
    else if (_edss.Bowel == 3)
    {
        this.BowelBladder3_radiobutton.Checked = true;
    }
    else if (_edss.Bowel == 4)
    {
        this.BowelBladder4_radiobutton.Checked = true;
    }
    else if (_edss.Bowel == 5)
    {
        this.BowelBladder5_radiobutton.Checked = true;
    }
    else if (_edss.Bowel == 6)
    {
        this.BowelBladder6_radiobutton.Checked = true;
    }
    else
    {
        this.BowelBladder0_radiobutton.Checked = false;
        this.BowelBladder1_radiobutton.Checked = false;
        this.BowelBladder2_radiobutton.Checked = false;
        this.BowelBladder3_radiobutton.Checked = false;
        this.BowelBladder4_radiobutton.Checked = false;
        this.BowelBladder5_radiobutton.Checked = false;
        this.BowelBladder6_radiobutton.Checked = false;
    }

    if (_edss.Sensory == 0)
    {
        this.Sensory0_radiobutton.Checked = true;
    }
    else if (_edss.Sensory == 1)
    {
        this.Sensory1_radiobutton.Checked = true;
    }
    else if (_edss.Sensory == 2)
    {
        this.Sensory2_radiobutton.Checked = true;
    }
    else if (_edss.Sensory == 3)
    {
        this.Sensory3_radiobutton.Checked = true;
    }
    else if (_edss.Sensory == 4)
    {
        this.Sensory4_radiobutton.Checked = true;
    }
    else if (_edss.Sensory == 5)
    {
        this.Sensory5_radiobutton.Checked = true;
    }
    else if (_edss.Sensory == 6)
    {
        this.Sensory6_radiobutton.Checked = true;
    }
    else
    {
        this.Sensory0_radiobutton.Checked = false;
        this.Sensory1_radiobutton.Checked = false;
        this.Sensory2_radiobutton.Checked = false;
        this.Sensory3_radiobutton.Checked = false;
        this.Sensory4_radiobutton.Checked = false;
        this.Sensory5_radiobutton.Checked = false;
        this.Sensory6_radiobutton.Checked = false;
    }

    if (_edss.Visual == 0)
    {
        this.Visual0_radiobutton.Checked = true;
    }
    else if (_edss.Visual == 1)
    {
        this.Visual1_radiobutton.Checked = true;
    }
    else if (_edss.Visual == 2)
    {
        this.Visual2_radiobutton.Checked = true;
    }
    else if (_edss.Visual == 3)
    {
        this.Visual3_radiobutton.Checked = true;
    }
    else if (_edss.Visual == 4)
    {
        this.Visual4_radiobutton.Checked = true;
    }
    else if (_edss.Visual == 5)
    {
        this.Visual5_radiobutton.Checked = true;
    }
    else if (_edss.Visual == 6)
    {
        this.Visual6_radiobutton.Checked = true;
    }
    else
    {
        this.Visual0_radiobutton.Checked = false;
        this.Visual1_radiobutton.Checked = false;
        this.Visual2_radiobutton.Checked = false;
        this.Visual3_radiobutton.Checked = false;
        this.Visual4_radiobutton.Checked = false;
        this.Visual5_radiobutton.Checked = false;
        this.Visual6_radiobutton.Checked = false;
    }
    if (_edss.Mental == 0)
    {
        this.Mental0_radiobutton.Checked = true;
    }
    else if (_edss.Mental == 1)
    {
        this.Mental1_radiobutton.Checked = true;
    }
    else if (_edss.Mental == 2)
    {
        this.Mental2_radiobutton.Checked = true;
    }
    else if (_edss.Mental == 3)
    {
        this.Mental3_radiobutton.Checked = true;
    }
    else if (_edss.Mental == 4)
    {
        this.Mental4_radiobutton.Checked = true;
    }
    else if (_edss.Mental == 5)
    {
        this.Mental5_radiobutton.Checked = true;
    }
    else
    {
        this.Mental0_radiobutton.Checked = false;
        this.Mental1_radiobutton.Checked = false;
        this.Mental2_radiobutton.Checked = false;
        this.Mental3_radiobutton.Checked = false;
        this.Mental4_radiobutton.Checked = false;
        this.Mental5_radiobutton.Checked = false;

    }

}


private void hSave_Click(object sender, EventArgs e)
{
    _edss = _edssService.GetByPatientId(_selectedId, _date).Data;
    if (_edss == null)
    {
        _edss = new Edss();
        if (setEdss())
        {
            _edssService.Add(_edss);
            this.Hide();
        }

    }
    else if (_edss != null && setEdss())
    {
        _edssService.Update(_edss);
        this.Hide();
    }
}
private void EdssDate_textBox_Click(object sender, EventArgs e)
{
    EdssDate_textBox.Select(0, 0);
}

private void Total_combox_SelectedIndexChanged(object sender, EventArgs e)
{
    Total = float.Parse(Total_combox.Text);
}


private void panel6_MouseClick(object sender, MouseEventArgs e)
{
    setEdss();
    FunctionalEDSS();
    Total_combox.Text = funcValue.ToString();
}

*/