using System;
using System.Linq;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Spreadsheet;
using MAUIUI.Business.Abstract;
using MAUIUI.Business.DependencyResoulver.AutofacResoulver;
using MAUIUI.Core.Entities;
using MAUIUI.Entities.Concrete;
using MAUIUI.Entities.DTOs;
using Microcharts;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SkiaSharp;
//using SoundAnalysis;

namespace MAUIUI.Views;

public partial class HomeView : ContentView
{


    User _user;
    IIdentificationService identificationService;
    //private string ImportPath;
    List<Identifications> Patients;

    public HomeView()
    {
        InitializeComponent();
        _user = new User();
        identificationService = InstanceFactory.GetInstance<IIdentificationService>();
        Patients = identificationService.GetAll().Data;
        ListView_Patients.ItemsSource = Patients;
        patientCountLabel.Text = "Patients (" + Patients.Count + ")";
        Patients.Sort((x, y) => x.SurName.CompareTo(y.SurName));
       

        List<IdentificationDetails> dr = new List<IdentificationDetails>();
        dr = identificationService.GetAllGenderCount().Data;
        List<ChartEntry> genderChartEntries = dr.Select(data => new ChartEntry(data.Count)
        {
            Label = data.Gender,
            Color = data.Gender == "Male" ? SkiaSharp.SKColor.Parse("#0B6E4F") : SkiaSharp.SKColor.Parse("#21D375"),
                }).ToList();
        GenderChart.Chart = new DonutChart()
        {
            Entries = genderChartEntries,

            HoleRadius = 0.5f,
            LabelMode = LabelMode.RightOnly,
            GraphPosition = GraphPosition.AutoFill,
            LabelTextSize = 35,

        };
        List<IdentificationDataGirdviewDetails> _Patients = new List<IdentificationDataGirdviewDetails>();
        _Patients = identificationService.GetAllToGirdView().Data;
        List<DateTime> birthDates = GenerateSampleBirthDates(_Patients);
        Dictionary<string, int> ageGroupCounts = CategorizeByAgeGroups(birthDates);
        List<ChartEntry> ageChartEntries = ageGroupCounts.Select(data => new ChartEntry(data.Value)
        {
            Label = data.Key.ToString(),
            Color = data.Key == "0-10" ? SkiaSharp.SKColor.Parse("#FF0400")
            : data.Key == "10-20" ? SkiaSharp.SKColor.Parse("#FF4000")
            : data.Key == "20-30" ? SkiaSharp.SKColor.Parse("#FF8000")
            : data.Key == "30-40" ? SkiaSharp.SKColor.Parse("#FFC000")
            : data.Key == "40-50" ? SkiaSharp.SKColor.Parse("#FFFF00")
            : data.Key == "50-60" ? SkiaSharp.SKColor.Parse("#0B6E4F")
            : SkiaSharp.SKColor.Parse("#80FF00")
                                    }).ToList();
        AgeChart.Chart = new DonutChart()
        {
            Entries = ageChartEntries,
            HoleRadius = 0.5f,
            LabelMode = LabelMode.RightOnly,
            GraphPosition = GraphPosition.AutoFill,
            LabelTextSize = 35,
        };
        IDiagnosisService diagnosisService = InstanceFactory.GetInstance<IDiagnosisService>();
        List<DiagnosisStatistic> dt = new List<DiagnosisStatistic>();
        dt = identificationService.GetAllConfirmedDiagnosisCount().Data;
        List<ChartEntry> MsClassificationChartEntries = dt.Select(data => new ChartEntry(data.ConfirmedDiagnosisCount)
        {
            Label = data.DiagnosisMSClassification,
            Color = data.DiagnosisMSClassification == "CIS" ? SkiaSharp.SKColor.Parse("#FF0400")
            : data.DiagnosisMSClassification == "RRMS" ? SkiaSharp.SKColor.Parse("#FF4000")
            : data.DiagnosisMSClassification == "SPMS" ? SkiaSharp.SKColor.Parse("#FF8000")
            : data.DiagnosisMSClassification == "PPMS" ? SkiaSharp.SKColor.Parse("#FFC000")
            : data.DiagnosisMSClassification == "RIS" ? SkiaSharp.SKColor.Parse("#FFFF00")
            : SkiaSharp.SKColor.Parse("#80FF00")
                                                    }).ToList();
        MsClassificationChart.Chart = new DonutChart()
        {
            Entries = MsClassificationChartEntries,
            HoleRadius = 0.5f,
            LabelMode = LabelMode.LeftAndRight,
            GraphPosition = GraphPosition.AutoFill,
            LabelTextSize = 35,
        };




        List<DateTime> ilnessDates = GenerateSampleIllnessStartDates(diagnosisService.GetAll().Data);
        Dictionary<string, int> durationGroupCounts = CategorizeByIllnessDuration(ilnessDates);


        List<ChartEntry> diagnosisChartEntries = new List<ChartEntry>();
        foreach (var duration in durationGroupCounts)
        {
            if (duration.Value > 0)
                diagnosisChartEntries.Add(new ChartEntry(duration.Value)
                {
                    Label = duration.Key,
                    ValueLabel = duration.Value.ToString(),
                    Color = duration.Value % 3 == 0 ? SkiaSharp.SKColor.Parse("#FF4000")
                    : duration.Value % 3 == 1 ? SkiaSharp.SKColor.Parse("#FF8000")
                    : SkiaSharp.SKColor.Parse("#FFC000")

                });
        }

        DiseasseChart.Chart = new Microcharts.PointChart()
        {
            Entries = diagnosisChartEntries,
            LabelTextSize = 35

        };




        ITreatmentMSSpecificService MSSpecificTreatmentService = InstanceFactory.GetInstance<ITreatmentMSSpecificService>();
        List<ChartEntry> MSSpecificTreatmentChartEntries = new List<ChartEntry>();
        List<MsSpecifikTreatmentChart> ds = MSSpecificTreatmentService.GetAllDiagnosisMGClassificationCount().Data;

        foreach (var item in ds)
        {
            if (item.DiagnosisMSClassification != null)
                MSSpecificTreatmentChartEntries.Add(new ChartEntry(item.DiagnosisMSClassificationConut)
                {
                    Label = item.DiagnosisMSClassification,
                    ValueLabel = item.DiagnosisMSClassificationConut.ToString(),
                    Color = item.DiagnosisMSClassificationConut % 3 == 0 ? SkiaSharp.SKColor.Parse("#FF4000")
                    : item.DiagnosisMSClassificationConut % 3 == 1 ? SkiaSharp.SKColor.Parse("#FF8000")
                    : SkiaSharp.SKColor.Parse("#FFC000")

                });
        }


        MSTreatementChart.Chart = new Microcharts.PointChart()
        {
            Entries = MSSpecificTreatmentChartEntries,
            LabelTextSize = 35

        };


        

    }

    private List<DateTime> GenerateSampleIllnessStartDates(List<Diagnosis> diag)
    {
        // Simulated illness start date data (replace with actual data)
        List<DateTime> illnessStartDates = new List<DateTime>();
        foreach (var item in diag)
        {
            if (item.ConfirmedDiagnosisDate != null && identificationService.GetByPatientId(item.PatientCode).Data.Deleted == 0)

                illnessStartDates.Add(DateTime.Parse(item.ConfirmedDiagnosisDate));
        }
        return illnessStartDates;
    }
    private Dictionary<string, int> CategorizeByIllnessDuration(List<DateTime> illnessStartDates)
    {
        Dictionary<string, int> illnessDurationCounts = new Dictionary<string, int>{
            { "0-1 year", 0 },
            { "1-3 years", 0 },
            { "3-5 years", 0 },
            { "5-10 years", 0 },
            { "10-20 years", 0 },
            { "20+ years", 0 }
        };

        DateTime currentDate = DateTime.Now;

        foreach (DateTime illnessStartDate in illnessStartDates)
        {
            TimeSpan illnessDuration = currentDate - illnessStartDate;
            int years = (int)(illnessDuration.TotalDays / 365);  // Convert days to years

            if (years >= 0 && years<= 1)
                illnessDurationCounts["0-1 year"]++;
            else if (years <= 3)
                illnessDurationCounts["1-3 years"]++;
            else if (years <= 5)
                illnessDurationCounts["3-5 years"]++;
            else if (years <= 10)
                illnessDurationCounts["5-10 years"]++;
            else if (years <= 20)
                illnessDurationCounts["10-20 years"]++;
            else
                illnessDurationCounts["20+ years"]++;
        }

        return illnessDurationCounts;
    }




    private Dictionary<string, int> CategorizeByAgeGroups(List<DateTime> birthDates)
    {
        Dictionary<string, int> ageGroupCounts = new Dictionary<string, int>
        {
        { "0-10", 0 },
        { "10-20", 0 },
        { "20-30", 0 },
        { "30-40", 0 },
        { "40-50", 0 },
        { "50-60", 0 },
        { "70+", 0 }
    };

        DateTime currentDate = DateTime.Now;

        foreach (DateTime birthDate in birthDates)
        {
            int age = currentDate.Year - birthDate.Year;

            if (age >= 0 && age<= 10)
                ageGroupCounts["0-10"]++;
            else if (age <= 20)
                ageGroupCounts["10-20"]++;
            else if (age <= 30)
                ageGroupCounts["20-30"]++;
            else if (age <= 40)
                ageGroupCounts["30-40"]++;
            else if (age <= 50)
                ageGroupCounts["40-50"]++;
            else if (age <= 60)
                ageGroupCounts["50-60"]++;
            else
                ageGroupCounts["70+"]++;
        }

        return ageGroupCounts;
    }





    private List<DateTime> GenerateSampleBirthDates(List<IdentificationDataGirdviewDetails> _Patients)
    {
        List<DateTime> birthDates = new List<DateTime>();
        foreach (var item in _Patients)
        {
            birthDates.Add(DateTime.Parse(item.BirthDate));
        }
        return birthDates;
    }




}

/* 
 * <?xml version="1.0" encoding="utf-8" ?>
<ContentView xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:micro="clr-namespace:Microcharts.Maui;assembly=Microcharts.Maui"
             x:Class="MAUIUI.Views.HomeView"        
             HorizontalOptions="FillAndExpand"
             VerticalOptions="FillAndExpand"
             Padding="10">

    <Grid HorizontalOptions="FillAndExpand" VerticalOptions="FillAndExpand" RowSpacing="10">
        <Grid.RowDefinitions>
            <RowDefinition Height="*" />
            <RowDefinition Height="10*" />
            <RowDefinition Height="25*" />
        </Grid.RowDefinitions>
            
            
        <Label Grid.Row="0" x:Name="patientCountLabel" Text="Patients (123)" />
        <ListView Grid.Row="1" x:Name="ListView_Patients" BackgroundColor="#c8d1db" SeparatorColor="Black">
            <ListView.ItemTemplate>
                <DataTemplate>
                    <ViewCell>
                        <Grid Padding="10" HorizontalOptions="FillAndExpand">
                            <Grid.RowDefinitions>
                                <RowDefinition Height="Auto"/>
                            </Grid.RowDefinitions>
                            <Grid.ColumnDefinitions>
                                <ColumnDefinition Width="*"/>
                                <ColumnDefinition Width="*"/>
                                <ColumnDefinition Width="*"/>
                                <ColumnDefinition Width="*"/>
                            </Grid.ColumnDefinitions>
                            <Label Text="{Binding Name}" FontAttributes="Bold"  WidthRequest="100"/>
                            <Label Grid.Row="0" Grid.Column="1" Text="{Binding SurName}"  WidthRequest="100"/>
                            <Label Grid.Row="0" Grid.Column="2" Text="{Binding BirthDate}"  WidthRequest="100"/>
                            <Label Grid.Row="0" Grid.Column="3" Text="{Binding Gender}"  WidthRequest="100"/>
                            <BoxView Grid.Row="0" Grid.Column="0" Grid.ColumnSpan="4" HeightRequest="1" BackgroundColor="Black" VerticalOptions="End" Margin="0,0,0,0"/>
                        </Grid>
                    </ViewCell>
                </DataTemplate>
            </ListView.ItemTemplate>
        </ListView>


        <Grid Grid.Row="2" HorizontalOptions="FillAndExpand" VerticalOptions="FillAndExpand" RowSpacing="10"  >
            <Grid.RowDefinitions>
                <RowDefinition Height="*" />
                <RowDefinition Height="*" />
            </Grid.RowDefinitions>
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="*"/>
                <ColumnDefinition Width="*"/>
                <ColumnDefinition Width="*"/>
            </Grid.ColumnDefinitions>
            
                <micro:ChartView x:Name="GenderChart1"/>
            <Border Grid.Row="0" Grid.Column="0" StrokeShape="RoundRectangle 10" Background="Black" >
                <micro:ChartView x:Name="GenderChart"/>
            </Border>
            <Border Grid.Row="0" Grid.Column="2" StrokeShape="RoundRectangle 10" Background="Black" >
                <micro:ChartView x:Name="MSTreatementChart"/>
            </Border>
            <Border Grid.Row="0"  Grid.Column="1" StrokeShape="RoundRectangle 10" Background="Black" >
                <micro:ChartView x:Name="AgeChart" />
            </Border>
            <Border Grid.Row="1" Grid.Column="0" StrokeShape="RoundRectangle 10" Background="Black" >
                <micro:ChartView x:Name="DiseasseChart"/>
            </Border>
            <Border Grid.Row="1" Grid.Column="1" StrokeShape="RoundRectangle 10" Background="Black" >
                <micro:ChartView x:Name="MsClassificationChart"/>
            </Border>
            <Border Grid.Row="1" Grid.Column="2" StrokeShape="RoundRectangle 10" Background="Black" > 
            </Border>

        </Grid>

    </Grid>
 

    </Grid>
 
</ContentView>
using System;
using System.Linq;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Spreadsheet;
using MAUIUI.Business.Abstract;
using MAUIUI.Business.DependencyResoulver.AutofacResoulver;
using MAUIUI.Core.Entities;
using MAUIUI.Entities.Concrete;
using MAUIUI.Entities.DTOs;
using Microcharts;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SkiaSharp;
//using SoundAnalysis;

namespace MAUIUI.Views;

public partial class HomeView : ContentView
{


    User _user;
    IIdentificationService identificationService;
    //private string ImportPath;
    List
<Identifications>Patients;

    public HomeView()
    {
        InitializeComponent(); 
        _user = new User();
        identificationService = InstanceFactory.GetInstance
    <IIdentificationService>();
        Patients = identificationService.GetAll().Data;
        ListView_Patients.ItemsSource = Patients;
        patientCountLabel.Text = "Patients (" + Patients.Count + ")";
        Patients.Sort((x, y) => x.SurName.CompareTo(y.SurName));


        List
        <IdentificationDetails>dr = new List
            <IdentificationDetails>();
        dr = identificationService.GetAllGenderCount().Data;
        List
                <ChartEntry>genderChartEntries = dr.Select(data => new ChartEntry(data.Count)
        {
            Label = data.Gender,
            Color = data.Gender == "Male" ? SkiaSharp.SKColor.Parse("#0B6E4F") : SkiaSharp.SKColor.Parse("#21D375"),
        }).ToList();
        GenderChart.Chart = new DonutChart() {
            Entries = genderChartEntries,

            HoleRadius = 0.5f,
            LabelMode = LabelMode.RightOnly,
            GraphPosition = GraphPosition.AutoFill,
            LabelTextSize = 35,
            
        };
        List
                    <IdentificationDataGirdviewDetails>_Patients = new List
                        <IdentificationDataGirdviewDetails>();
        _Patients = identificationService.GetAllToGirdView().Data;
        List
                            <DateTime>birthDates = GenerateSampleBirthDates(_Patients);
        Dictionary
                                <string, int>ageGroupCounts = CategorizeByAgeGroups(birthDates);
        List
                                    <ChartEntry>ageChartEntries = ageGroupCounts.Select(data => new ChartEntry(data.Value)
        {
            Label = data.Key.ToString(),
            Color = data.Key == "0-10" ? SkiaSharp.SKColor.Parse("#FF0400")
            : data.Key == "10-20" ? SkiaSharp.SKColor.Parse("#FF4000")
            : data.Key == "20-30" ? SkiaSharp.SKColor.Parse("#FF8000")
            : data.Key == "30-40" ? SkiaSharp.SKColor.Parse("#FFC000")
            : data.Key == "40-50" ? SkiaSharp.SKColor.Parse("#FFFF00")
            : data.Key == "50-60" ? SkiaSharp.SKColor.Parse("#0B6E4F")
            :  SkiaSharp.SKColor.Parse("#80FF00")
        }).ToList();
        AgeChart.Chart = new DonutChart() { Entries = ageChartEntries,
            HoleRadius = 0.5f,
            LabelMode = LabelMode.RightOnly,
            GraphPosition = GraphPosition.AutoFill,
            LabelTextSize = 35,
        };
        IDiagnosisService diagnosisService = InstanceFactory.GetInstance
                                        <IDiagnosisService>();
        List
                                            <DiagnosisStatistic>dt = new List
                                                <DiagnosisStatistic>();
        dt = identificationService.GetAllConfirmedDiagnosisCount().Data;
        List
                                                    <ChartEntry>MsClassificationChartEntries = dt.Select(data => new ChartEntry(data.ConfirmedDiagnosisCount)
        {
            Label = data.DiagnosisMSClassification,
            Color = data.DiagnosisMSClassification == "CIS" ? SkiaSharp.SKColor.Parse("#FF0400")
            : data.DiagnosisMSClassification == "RRMS" ? SkiaSharp.SKColor.Parse("#FF4000")
            : data.DiagnosisMSClassification == "SPMS" ? SkiaSharp.SKColor.Parse("#FF8000")
            : data.DiagnosisMSClassification == "PPMS" ? SkiaSharp.SKColor.Parse("#FFC000")
            : data.DiagnosisMSClassification == "RIS" ? SkiaSharp.SKColor.Parse("#FFFF00")
            : SkiaSharp.SKColor.Parse("#80FF00")
        }).ToList();
        MsClassificationChart.Chart = new DonutChart()
        {
            Entries = MsClassificationChartEntries,
            HoleRadius = 0.5f,
            LabelMode = LabelMode.LeftAndRight,
            GraphPosition = GraphPosition.AutoFill,
            LabelTextSize = 35,
        };




        List
                                                        <DateTime>ilnessDates = GenerateSampleIllnessStartDates(diagnosisService.GetAll().Data);
        Dictionary
                                                            <string, int>durationGroupCounts = CategorizeByIllnessDuration(ilnessDates);


        List
                                                                <ChartEntry>diagnosisChartEntries = new List
                                                                    <ChartEntry>();
        foreach (var duration in durationGroupCounts)
        {
            if (duration.Value > 0)
                diagnosisChartEntries.Add(new ChartEntry(duration.Value) {
                    Label= duration.Key,
                    ValueLabel= duration.Value.ToString(),
                    Color = duration.Value%3==0? SkiaSharp.SKColor.Parse("#FF4000")
                    : duration.Value % 3 == 1  ? SkiaSharp.SKColor.Parse("#FF8000")
                    :  SkiaSharp.SKColor.Parse("#FFC000")

                });
        }

        DiseasseChart.Chart = new Microcharts.PointChart()
        {
            Entries = diagnosisChartEntries,
            LabelTextSize = 35

        };




        ITreatmentMSSpecificService MSSpecificTreatmentService = InstanceFactory.GetInstance
                                                                        <ITreatmentMSSpecificService>();
        List
                                                                            <ChartEntry>MSSpecificTreatmentChartEntries = new List
                                                                                <ChartEntry>();
        List
                                                                                    <MsSpecifikTreatmentChart>ds = MSSpecificTreatmentService.GetAllDiagnosisMGClassificationCount().Data;

        foreach (var item in ds)
        {
            if (item.DiagnosisMSClassification != null)
                MSSpecificTreatmentChartEntries.Add(new ChartEntry(item.DiagnosisMSClassificationConut)
                {
                    Label = item.DiagnosisMSClassification, 
                    ValueLabel = item.DiagnosisMSClassificationConut.ToString(),
                    Color = item.DiagnosisMSClassificationConut % 3 == 0 ? SkiaSharp.SKColor.Parse("#FF4000")
                    : item.DiagnosisMSClassificationConut % 3 == 1 ? SkiaSharp.SKColor.Parse("#FF8000")
                    : SkiaSharp.SKColor.Parse("#FFC000")

                });
        }


        MSTreatementChart.Chart = new Microcharts.PointChart()
        {
            Entries = MSSpecificTreatmentChartEntries,
            LabelTextSize = 35

        };




    }

    private List
                                                                                        <DateTime>GenerateSampleIllnessStartDates(List
                                                                                            <Diagnosis>diag)
    {
        // Simulated illness start date data (replace with actual data)
        List
                                                                                                <DateTime>illnessStartDates = new List
                                                                                                    <DateTime>();
        foreach (var item in diag)
        {
            if (item.ConfirmedDiagnosisDate != null && identificationService.GetByPatientId(item.PatientCode).Data.Deleted == 0)

                illnessStartDates.Add(DateTime.Parse(item.ConfirmedDiagnosisDate));
        }
        return illnessStartDates;
    }
    private Dictionary
                                                                                                        <string, int>CategorizeByIllnessDuration(List
                                                                                                            <DateTime>illnessStartDates)
    {
        Dictionary
                                                                                                                <string, int>illnessDurationCounts = new Dictionary
                                                                                                                    <string, int>
                                                                                                                        {
            { "0-1 year", 0 },
            { "1-3 years", 0 },
            { "3-5 years", 0 },
            { "5-10 years", 0 },
            { "10-20 years", 0 },
            { "20+ years", 0 }
        };

        DateTime currentDate = DateTime.Now;

        foreach (DateTime illnessStartDate in illnessStartDates)
        {
            TimeSpan illnessDuration = currentDate - illnessStartDate;
            int years = (int)(illnessDuration.TotalDays / 365);  // Convert days to years

            if (years >= 0 && years
                                                                                                                        <= 1)
                illnessDurationCounts["0-1 year"]++;
            else if (years <= 3)
                illnessDurationCounts["1-3 years"]++;
            else if (years <= 5)
                illnessDurationCounts["3-5 years"]++;
            else if (years <= 10)
                illnessDurationCounts["5-10 years"]++;
            else if (years <= 20)
                illnessDurationCounts["10-20 years"]++;
            else
                illnessDurationCounts["20+ years"]++;
        }

        return illnessDurationCounts;
    }




    private Dictionary<string, int>CategorizeByAgeGroups(List
                                                                                                                            <DateTime>birthDates)
    {
        Dictionary
                                                                                                                                <string, int>ageGroupCounts = new Dictionary
                                                                                                                                    <string, int>
                                                                                                                                        {
        { "0-10", 0 },
        { "10-20", 0 },
        { "20-30", 0 },
        { "30-40", 0 },
        { "40-50", 0 },
        { "50-60", 0 },
        { "70+", 0 }
    };

        DateTime currentDate = DateTime.Now;

        foreach (DateTime birthDate in birthDates)
        {
            int age = currentDate.Year - birthDate.Year;

            if (age >= 0 && age
                                                                                                                                        <= 10)
                ageGroupCounts["0-10"]++;
            else if (age <= 20)
                ageGroupCounts["10-20"]++;
            else if (age <= 30)
                ageGroupCounts["20-30"]++;
            else if (age <= 40)
                ageGroupCounts["30-40"]++;
            else if (age <= 50)
                ageGroupCounts["40-50"]++;
            else if (age <= 60)
                ageGroupCounts["50-60"]++;
            else
                ageGroupCounts["70+"]++;
        }

        return ageGroupCounts;
    }
    private List<DateTime>GenerateSampleBirthDates(List
                                                                                                                                            <IdentificationDataGirdviewDetails>_Patients)
    {
        List
                                                                                                                                                <DateTime>birthDates = new List
                                                                                                                                                    <DateTime>();
        foreach (var item in _Patients)
        {
            birthDates.Add(DateTime.Parse(item.BirthDate));
        }
        return birthDates;
    }




}
*/







