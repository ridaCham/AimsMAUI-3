using ClosedXML.Excel;
using MAUIUI.Business.Abstract;
using MAUIUI.Business.DependencyResoulver.AutofacResoulver;
using MAUIUI.Core.Entities;
using MAUIUI.DataAccess.Concrete;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Views;

public partial class HomePage : ContentPage
{
    User _user;
    public HomePage(User user)
	{
		InitializeComponent();
        HomeContent.Children.Clear();
        _user = user;
        HomeContent.Children.Add(new HomeView());

    }

    private void Button_Home_Clicked(object sender, EventArgs e)
    {
        if (HomeContent.Children.Count > 0 && HomeContent.Children[0] is HomeView)
        {

        }
        else
        {
            HomeContent.Children.Clear();
            var HomeView = new HomeView();
            HomeContent.Children.Add(HomeView);
        }
    }

    private void Button_Patients_Clicked(object sender, EventArgs e)
    {
        if(HomeContent.Children.Count > 0 && HomeContent.Children[0] is PatientsView) {

        }
        else
        {
            HomeContent.Children.Clear();
            var PatientsView = new PatientsView(_user);
            HomeContent.Children.Add(PatientsView);
        }
        
    }

    private void Button_Statistics_Clicked(object sender, EventArgs e)
    {
        if (HomeContent.Children.Count > 0 && HomeContent.Children[0] is StatisticsView)
        {

        }
        else
        {
            HomeContent.Children.Clear();
            var StatisticsView = new StatisticsView(_user);
            HomeContent.Children.Add(StatisticsView);
        }
    }

    private void Button_Analysis_Clicked(object sender, EventArgs e)
    {
        if (HomeContent.Children.Count > 0 && HomeContent.Children[0] is AnalysisView)
        {

        }
        else
        {
            HomeContent.Children.Clear();
            var AnalysisView = new AnalysisView();
            HomeContent.Children.Add(AnalysisView);
        }
    }


    private async void Button_Import_Clicked(object sender, EventArgs e)
    {
        var dataFile = await FilePicker.PickAsync();
        //Filter = "Excel Workbook|*.xlsx|CSV File|*.csv" })
        {
            if (dataFile != null)
            {
                try
                {
                    string selectedFilePath = dataFile.FullPath;
                    import();
                    if (File.Exists(selectedFilePath))
                    {
                        addNewFamilyHistoryService.importRecords(selectedFilePath, "AddNewFamilyHistory");
                        autoAntiBodyTestService.importRecords(selectedFilePath, "AutoAntiBodyTests");
                        bloodChemistryService.importRecords(selectedFilePath, "BloodChemistries");
                        covid19Service.importRecords(selectedFilePath, "Covid19");
                        covid19Vaccine_Service.importRecords(selectedFilePath, "Covid19Vaccine");
                        _CSFService.importRecords(selectedFilePath, "CSFs");
                        diagnosisService.importRecords(selectedFilePath, "Diagnosisses");
                        digitalTestService.importRecords(selectedFilePath, "DijitalTests");
                        _edssService.importRecords(selectedFilePath, "Edss");
                        _evokedPotentielService.importRecords(selectedFilePath, "EvokedPotentiels");
                        faceToFaceTestService.importRecords(selectedFilePath, "FaceToFaceTests");
                        FluvaccineService.importRecords(selectedFilePath, "FluVaccine");
                        genelNotesService.importRecords(selectedFilePath, "GeneralNotes");
                        genetic_TestService.importRecords(selectedFilePath, "GeneticTests");
                        haematologyService.importRecords(selectedFilePath, "Haematologies");
                        HepatityAvaccineService.importRecords(selectedFilePath, "HepatitisAVaccine");
                        HepatityBvaccineService.importRecords(selectedFilePath, "HepatitisBVaccine");
                        herpesZosterService.importRecords(selectedFilePath, "HerpesZosters");
                        _identificationManager.importRecords(selectedFilePath, "Identifications");
                        _immunosuppressionManager.importRecords(selectedFilePath, "Immunosuppressions");
                        laboratoryTestsNotesService.importRecords(selectedFilePath, "LaboratoryTestsNotes");
                        malignancyService.importRecords(selectedFilePath, "Malignancies");
                        medicalHistoryService.importRecords(selectedFilePath, "MedicalHistories");
                        NeuropsychService.importRecords(selectedFilePath, "Neuropsychtrainings");
                        otherMedicalConditionService.importRecords(selectedFilePath, "OtherMedicalConditions");
                        OthervaccineService.importRecords(selectedFilePath, "OtherVaccine");
                        _outcomeService.importRecords(selectedFilePath, "Outcomes");
                        _ParatestMRIService.importRecords(selectedFilePath, "ParatestMRI");
                        PhysiotherapyService.importRecords(selectedFilePath, "Physiotherapies");
                        PilatesService.importRecords(selectedFilePath, "Pilates");
                        pregnancyService.importRecords(selectedFilePath, "Pregnancies");
                        PsychotherapyService.importRecords(selectedFilePath, "Psychotherapies");
                        relapsesService.importRecords(selectedFilePath, "Relapses");
                        serologicalTestService.importRecords(selectedFilePath, "SerologicalTests");
                        thyroidFunctionService.importRecords(selectedFilePath, "ThyroidFunctions");
                        MSSpecificService.importRecords(selectedFilePath, "TreatmentMSSpecifics");
                        treatmentService.importRecords(selectedFilePath, "Treatments");
                        SymptomaticService.importRecords(selectedFilePath, "TreatmentSymptomatics");
                        vaccineService.importRecords(selectedFilePath, "Vaccines");
                        visitService.importRecords(selectedFilePath, "Visits");
                        YogaService.importRecords(selectedFilePath, "Yogas");

                        DisplayAlert("Attension", "Data was imported successfully! ", "Ok");
                    }
                }
                catch (Exception ex)
                {
                    DisplayAlert("Error", ex.Message, "Ok");
                }

            }
        }
    }

    private async void Button_Export_Clicked(object sender, EventArgs e)
    {
        using (DatabaseContext context = new DatabaseContext())
        {
            var sfd = await FilePicker.PickAsync();
            //sfd.ContentType = "Excel Workbook (*.xlsx)|*.xlsx; CSV File (*.csv)|*.csv";

            if (sfd != null)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    using (var workbook = new XLWorkbook())
                    {
                        try
                        {
                            var dbSet1 = context.Set<AddNewFamilyHistory>();
                            var records1 = dbSet1.ToList();
                            ExportRecordsToExcel(workbook, "AddNewFamilyHistory", records1);
                            var dbSet2 = context.Set<AutoAntiBodyTest>();
                            var records2 = dbSet2.ToList();
                            ExportRecordsToExcel(workbook, "AutoAntiBodyTests", records2);
                            var dbSet3 = context.Set<BloodChemistry>();
                            var records3 = dbSet3.ToList();
                            ExportRecordsToExcel(workbook, "BloodChemistries", records3);
                            var dbSet6 = context.Set<Covid19>();
                            var records6 = dbSet6.ToList();
                            ExportRecordsToExcel(workbook, "Covid19", records6);
                            var dbSet23 = context.Set<CSF>();
                            var records23 = dbSet23.ToList();
                            ExportRecordsToExcel(workbook, "CSFs", records23);
                            var dbSet17 = context.Set<Diagnosis>();
                            var records17 = dbSet17.ToList();
                            ExportRecordsToExcel(workbook, "Diagnosisses", records17);
                            var dbSet7 = context.Set<DijitalTest>();
                            var records7 = dbSet7.ToList();
                            ExportRecordsToExcel(workbook, "DijitalTests", records7);
                            var dbSet20 = context.Set<Edss>();
                            var records20 = dbSet20.ToList();
                            ExportRecordsToExcel(workbook, "Edss", records20);
                            var dbSet22 = context.Set<EvokedPotentiel>();
                            var records22 = dbSet22.ToList();
                            ExportRecordsToExcel(workbook, "EvokedPotentiels", records22);
                            var dbSet8 = context.Set<FaceToFaceTest>();
                            var records8 = dbSet8.ToList();
                            ExportRecordsToExcel(workbook, "FaceToFaceTests", records8);
                            var dbSet16 = context.Set<GeneralNotes>();
                            var records16 = dbSet16.ToList();
                            ExportRecordsToExcel(workbook, "GeneralNotes", records16);
                            var dbSet18 = context.Set<Genetic_Test>();
                            var records18 = dbSet18.ToList();
                            ExportRecordsToExcel(workbook, "GeneticTests", records18);
                            var dbSet19 = context.Set<Haematology>();
                            var records19 = dbSet19.ToList();
                            ExportRecordsToExcel(workbook, "Haematologies", records19);
                            var dbSet28 = context.Set<HerpesZoster>();
                            var records28 = dbSet28.ToList();
                            ExportRecordsToExcel(workbook, "HerpesZosters", records28);
                            var dbSet4 = context.Set<Identifications>();
                            var records4 = dbSet4.ToList();
                            ExportRecordsToExcel(workbook, "Identifications", records4);
                            var dbSet21 = context.Set<Immunosuppression>();
                            var records21 = dbSet21.ToList();
                            ExportRecordsToExcel(workbook, "Immunosuppressions", records21);
                            var dbSet15 = context.Set<LaboratoryTestsNotes>();
                            var records15 = dbSet15.ToList();
                            ExportRecordsToExcel(workbook, "LaboratoryTestsNotes", records15);
                            var dbSet31 = context.Set<Malignancy>();
                            var records31 = dbSet31.ToList();
                            ExportRecordsToExcel(workbook, "Malignancies", records31);
                            var dbSet32 = context.Set<MedicalHistory>();
                            var records32 = dbSet32.ToList();
                            ExportRecordsToExcel(workbook, "MedicalHistories", records32);
                            var dbSet36 = context.Set<OtherMedicalCondition>();
                            var records36 = dbSet36.ToList();
                            ExportRecordsToExcel(workbook, "OtherMedicalConditions", records36);
                            var dbSet5 = context.Set<Outcome>();
                            var records5 = dbSet5.ToList();
                            ExportRecordsToExcel(workbook, "Outcomes", records5);
                            var dbSet37 = context.Set<Pregnancy>();
                            var records37 = dbSet37.ToList();
                            ExportRecordsToExcel(workbook, "Pregnancies", records37);
                            var dbSet24 = context.Set<ParatestMRI>();
                            var records24 = dbSet24.ToList();
                            ExportRecordsToExcel(workbook, "ParatestMRI", records24);
                            var dbSet39 = context.Set<Relapse>();
                            var records39 = dbSet39.ToList();
                            ExportRecordsToExcel(workbook, "Relapses", records39);
                            var dbSet25 = context.Set<SerologicalTest>();
                            var records25 = dbSet25.ToList();
                            ExportRecordsToExcel(workbook, "SerologicalTests", records25);
                            var dbSet27 = context.Set<ThyroidFunction>();
                            var records27 = dbSet27.ToList();
                            ExportRecordsToExcel(workbook, "ThyroidFunctions", records27);
                            var dbSet43 = context.Set<Treatment>();
                            var records43 = dbSet43.ToList();
                            ExportRecordsToExcel(workbook, "Treatments", records43);
                            var dbSet45 = context.Set<TreatmentNeuropsych>();
                            var records45 = dbSet45.ToList();
                            ExportRecordsToExcel(workbook, "Neuropsychtrainings", records45);
                            var dbSet26 = context.Set<TreatmentPhysiotherapy>();
                            var records26 = dbSet26.ToList();
                            ExportRecordsToExcel(workbook, "Physiotherapies", records26);
                            var dbSet29 = context.Set<TreatmentPilates>();
                            var records29 = dbSet29.ToList();
                            ExportRecordsToExcel(workbook, "Pilates", records29);
                            var dbSet33 = context.Set<TreatmentPsychotherapy>();
                            var records33 = dbSet33.ToList();
                            ExportRecordsToExcel(workbook, "Psychotherapies", records33);
                            var dbSet34 = context.Set<TreatmentMSSpecific>();
                            var records34 = dbSet34.ToList();
                            ExportRecordsToExcel(workbook, "TreatmentMSSpecifics", records34);
                            var dbSet35 = context.Set<TreatmentSymptomatic>();
                            var records35 = dbSet35.ToList();
                            ExportRecordsToExcel(workbook, "TreatmentSymptomatics", records35);
                            var dbSet38 = context.Set<TreatmentYoga>();
                            var records38 = dbSet38.ToList();
                            ExportRecordsToExcel(workbook, "Yogas", records38);
                            var dbSet40 = context.Set<Vaccine_>();
                            var records40 = dbSet40.ToList();
                            ExportRecordsToExcel(workbook, "Vaccines", records40);
                            var dbSet9 = context.Set<Visit>();
                            var records9 = dbSet9.ToList();
                            ExportRecordsToExcel(workbook, "Visits", records9);
                            var dbSet100 = context.Set<FluVaccine>();
                            var records100 = dbSet100.ToList();
                            ExportRecordsToExcel(workbook, "FluVaccine", records100);
                            var dbSet101 = context.Set<Covid19Vaccine>();
                            var records101 = dbSet101.ToList();
                            ExportRecordsToExcel(workbook, "Covid19Vaccine", records101);
                            var dbSet102 = context.Set<HepatitisAVaccine>();
                            var records102 = dbSet102.ToList();
                            ExportRecordsToExcel(workbook, "HepatitisAVaccine", records102);
                            var dbSet103 = context.Set<HepatitisBVaccine>();
                            var records103 = dbSet103.ToList();
                            ExportRecordsToExcel(workbook, "HepatitisBVaccine", records103);
                            var dbSet104 = context.Set<OtherVaccine>();
                            var records104 = dbSet104.ToList();
                            ExportRecordsToExcel(workbook, "OtherVaccine", records104);


                            workbook.SaveAs(sw.BaseStream);
                            DisplayAlert("Attension", "Data was exported successfully! ", "Ok");
                        }
                        catch (Exception ex)
                        {
                            DisplayAlert("Error", ex.Message, "Ok");
                        }
                    }
                }
            }


        }

    }


    private static void ExportRecordsToExcel<T>(IXLWorkbook workbook, string entityName, List<T> records)
    {
        var worksheet = workbook.Worksheets.Add(entityName);

        var properties = typeof(T).GetProperties();

        for (int columnIndex = 1; columnIndex <= properties.Length; columnIndex++)
        {
            worksheet.Cell(1, columnIndex).Value = properties[columnIndex - 1].Name;
        }

        for (int rowIndex = 1; rowIndex <= records.Count; rowIndex++)
        {
            for (int columnIndex = 1; columnIndex <= properties.Length; columnIndex++)
            {
                var value = properties[columnIndex - 1].GetValue(records[rowIndex - 1])?.ToString();
                worksheet.Cell(rowIndex + 1, columnIndex).Value = value;
            }
        }
    }


    void import()
    {
        _identificationManager = InstanceFactory.GetInstance<IIdentificationService>();
        faceToFaceTestService = InstanceFactory.GetInstance<IFaceToFaceTestService>();
        digitalTestService = InstanceFactory.GetInstance<IDijitalTestService>();
        vaccineService = InstanceFactory.GetInstance<IVaccine_Service>();
        treatmentService = InstanceFactory.GetInstance<ITreatmentService>();
        thyroidFunctionService = InstanceFactory.GetInstance<IThyroidFunctionService>();

        serologicalTestService = InstanceFactory.GetInstance<ISerologicalTestService>();
        relapsesService = InstanceFactory.GetInstance<IRelapseService>();
        pregnancyService = InstanceFactory.GetInstance<IPregnancyService>();
        _outcomeService = InstanceFactory.GetInstance<IOutcomeService>();
        _ParatestMRIService = InstanceFactory.GetInstance<IParatestMRIService>();
        _evokedPotentielService = InstanceFactory.GetInstance<IEvokedPotentielService>();
        _CSFService = InstanceFactory.GetInstance<ICSFService>();
        otherMedicalConditionService = InstanceFactory.GetInstance<IOtherMedicalConditionService>();
        genelNotesService = InstanceFactory.GetInstance<IGeneralNotesService>();
        addNewFamilyHistoryService = InstanceFactory.GetInstance<IAddNewFamilyHistoryService>();
        medicalHistoryService = InstanceFactory.GetInstance<IMedicalHistoryService>();
        malignancyService = InstanceFactory.GetInstance<IMalignancyService>();
        laboratoryTestsNotesService = InstanceFactory.GetInstance<ILaboratoryTestsNotesService>();
        _immunosuppressionManager = InstanceFactory.GetInstance<IImmunosuppressionService>();
        herpesZosterService = InstanceFactory.GetInstance<IHerpesZosterService>();
        haematologyService = InstanceFactory.GetInstance<IHaematologyService>();
        _edssService = InstanceFactory.GetInstance<IEdssService>();
        diagnosisService = InstanceFactory.GetInstance<IDiagnosisService>();
        covid19Vaccine_Service = InstanceFactory.GetInstance<ICovid19Vaccine_Service>();
        covid19Service = InstanceFactory.GetInstance<ICovid19Service>();
        bloodChemistryService = InstanceFactory.GetInstance<IBloodChemistryService>();
        autoAntiBodyTestService = InstanceFactory.GetInstance<IAutoAntiBodyTestService>();
        YogaService = InstanceFactory.GetInstance<ITreatmentYogaService>();
        SymptomaticService = InstanceFactory.GetInstance<ITreatmentSymptomaticService>();
        PsychotherapyService = InstanceFactory.GetInstance<ITreatmentPsychotherapyService>();
        PilatesService = InstanceFactory.GetInstance<ITreatmentPilatesService>();
        PhysiotherapyService = InstanceFactory.GetInstance<ITreatmentPhysiotherapyService>();
        NeuropsychService = InstanceFactory.GetInstance<ITreatmentNeuropsychService>();
        MSSpecificService = InstanceFactory.GetInstance<ITreatmentMSSpecificService>();
        OthervaccineService = InstanceFactory.GetInstance<IOtherVaccine_Service>();
        HepatityBvaccineService = InstanceFactory.GetInstance<IHepatityBVaccine_Service>();
        HepatityAvaccineService = InstanceFactory.GetInstance<IHepatityAVaccine_Service>();
        FluvaccineService = InstanceFactory.GetInstance<IFluVaccine_Service>();
        visitService = InstanceFactory.GetInstance<IVisitService>();
        genetic_TestService = InstanceFactory.GetInstance<IGenetic_TestService>();
    }
    
    public ITreatmentYogaService YogaService;
    public ITreatmentSymptomaticService SymptomaticService;
    public ITreatmentPsychotherapyService PsychotherapyService;
    public ITreatmentPilatesService PilatesService;
    public ITreatmentPhysiotherapyService PhysiotherapyService;
    public ITreatmentNeuropsychService NeuropsychService;
    public ITreatmentMSSpecificService MSSpecificService;
    public ICovid19Vaccine_Service covid19Vaccine_Service;
    private IFaceToFaceTestService faceToFaceTestService;
    private IDijitalTestService digitalTestService;
    private IVaccine_Service vaccineService;
    private IOtherVaccine_Service OthervaccineService;
    private IFluVaccine_Service FluvaccineService;
    private IHepatityAVaccine_Service HepatityAvaccineService;
    private IHepatityBVaccine_Service HepatityBvaccineService;
    private ITreatmentService treatmentService;
    private IThyroidFunctionService thyroidFunctionService;
    private IIdentificationService _identificationManager;
    private ISerologicalTestService serologicalTestService;
    private IRelapseService relapsesService;
    private IPregnancyService pregnancyService;
    private IOutcomeService _outcomeService;
    private IParatestMRIService _ParatestMRIService;
    private IEvokedPotentielService _evokedPotentielService;
    private ICSFService _CSFService;
    private IOtherMedicalConditionService otherMedicalConditionService;
    private IGeneralNotesService genelNotesService;
    private IAddNewFamilyHistoryService addNewFamilyHistoryService;
    private IMedicalHistoryService medicalHistoryService;
    private IMalignancyService malignancyService;
    private ILaboratoryTestsNotesService laboratoryTestsNotesService;
    private IImmunosuppressionService _immunosuppressionManager;
    private IHerpesZosterService herpesZosterService;
    private IHaematologyService haematologyService;
    private IEdssService _edssService;
    private IDiagnosisService diagnosisService;
    private ICovid19Service covid19Service;
    private IBloodChemistryService bloodChemistryService;
    private IAutoAntiBodyTestService autoAntiBodyTestService;
    IGenetic_TestService genetic_TestService;
    IVisitService visitService;






}