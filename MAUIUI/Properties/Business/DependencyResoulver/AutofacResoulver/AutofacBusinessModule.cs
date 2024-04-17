using System;
using Autofac;
using MAUIUI.Business.Abstract;
using MAUIUI.Business.Concrete;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.DataAccess.Concrete;

namespace MAUIUI.Business.DependencyResoulver.AutofacResoulver
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {


            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<UserDal>().As<IuserDal>().SingleInstance();
            builder.RegisterType<EvokedPotentielManager>().As<IEvokedPotentielService>().SingleInstance();
            builder.RegisterType<EvokedPotentielDal>().As<IEvokedPotentielDal>().SingleInstance();
            //builder.RegisterType<ParatestMRIImageManager>().As<IParatestMRIImageService>().SingleInstance();
            //builder.RegisterType<ParatestMRIImageDal>().As<IParatestMRIImageDal>().SingleInstance();
            builder.RegisterType<ParatestMRIManager>().As<IParatestMRIService>().SingleInstance();
            builder.RegisterType<ParatestMRIDal>().As<IParatestMRIDal>().SingleInstance();

            builder.RegisterType<FaceToFaceTestManager>().As<IFaceToFaceTestService>().SingleInstance();
            builder.RegisterType<FaceToFaceTestDal>().As<IFaceToFaceTestDal>().SingleInstance();
            builder.RegisterType<DijitalTestManager>().As<IDijitalTestService>().SingleInstance();
            builder.RegisterType<DijitalTestDal>().As<IDijitalTestDal>().SingleInstance();
            builder.RegisterType<AddNewFamilyHistoryManager>().As<IAddNewFamilyHistoryService>().SingleInstance();
            builder.RegisterType<AddNewFamilyHistoryDal>().As<IAddNewFamilyHistoryDal>().SingleInstance();


            builder.RegisterType<EdssManager>().As<IEdssService>().SingleInstance();
            builder.RegisterType<EdssDal>().As<IEdssDal>().SingleInstance();


            builder.RegisterType<IdentificationManager>().As<IIdentificationService>().SingleInstance();
            builder.RegisterType<IdentificationDal>().As<IIdentificationDal>().SingleInstance();

            builder.RegisterType<AutoAntiBodyTestManager>().As<IAutoAntiBodyTestService>().SingleInstance();
            builder.RegisterType<AutoAntiBodyTestDal>().As<IAutoAntiBodyTestDal>().SingleInstance();
            builder.RegisterType<BloodChemistryManager>().As<IBloodChemistryService>().SingleInstance();
            builder.RegisterType<BloodChemistryDal>().As<IBloodChemistryDal>().SingleInstance();
            builder.RegisterType<Covid19Manager>().As<ICovid19Service>().SingleInstance();
            builder.RegisterType<Covid19Dal>().As<ICovid19Dal>().SingleInstance();
            builder.RegisterType<DiagnosisManager>().As<IDiagnosisService>().SingleInstance();
            builder.RegisterType<DiagnosisDal>().As<IDiagnosisDal>().SingleInstance();
            builder.RegisterType<GeneralNotesManager>().As<IGeneralNotesService>().SingleInstance();
            builder.RegisterType<GeneralNotesDal>().As<IGeneralNotesDal>().SingleInstance();
            builder.RegisterType<LaboratoryTestsNotesManager>().As<ILaboratoryTestsNotesService>().SingleInstance();
            builder.RegisterType<LaboratoryTestsNotesDal>().As<ILaboratoryTestsNotesDal>().SingleInstance();
            builder.RegisterType<GeneticTestManager>().As<IGenetic_TestService>().SingleInstance();
            builder.RegisterType<Genetic_TestDal>().As<IGenetic_TestDal>().SingleInstance();
            builder.RegisterType<HaematologyManager>().As<IHaematologyService>().SingleInstance();
            builder.RegisterType<HaematologyDal>().As<IHaematologyDal>().SingleInstance();
            builder.RegisterType<OutcomeManager>().As<IOutcomeService>().SingleInstance();
            builder.RegisterType<OutcomeDal>().As<IOutcomeDal>().SingleInstance();

            builder.RegisterType<HerpesZosterManager>().As<IHerpesZosterService>().SingleInstance();
            builder.RegisterType<HerpesZosterDal>().As<IHerpesZosterDal>().SingleInstance();
            builder.RegisterType<ImmunosuppressionManager>().As<IImmunosuppressionService>().SingleInstance();
            builder.RegisterType<ImmunosuppressionDal>().As<IImmunosuppressionDal>().SingleInstance();

            builder.RegisterType<MalignancyManager>().As<IMalignancyService>().SingleInstance();
            builder.RegisterType<MalignancyDal>().As<IMalignancyDal>().SingleInstance();
            builder.RegisterType<MedicalHistoryManager>().As<IMedicalHistoryService>().SingleInstance();
            builder.RegisterType<MedicalHistoryDal>().As<IMedicalHistoryDal>().SingleInstance();

            builder.RegisterType<OtherMedicalConditionManager>().As<IOtherMedicalConditionService>().SingleInstance();
            builder.RegisterType<OtherMedicalConditionDal>().As<IOtherMedicalConditionDal>().SingleInstance();

            builder.RegisterType<PregnancyManager>().As<IPregnancyService>().SingleInstance();
            builder.RegisterType<PregnancyDal>().As<IPregnancyDal>().SingleInstance();

            builder.RegisterType<RelapseManager>().As<IRelapseService>().SingleInstance();
            builder.RegisterType<RelapseDal>().As<IRelapseDal>().SingleInstance();
            builder.RegisterType<SerologicalTestManager>().As<ISerologicalTestService>().SingleInstance();
            builder.RegisterType<SerologicalTestDal>().As<ISerologicalTestDal>().SingleInstance();


            builder.RegisterType<ThyroidFunctionManager>().As<IThyroidFunctionService>().SingleInstance();
            builder.RegisterType<ThyroidFunctionDal>().As<IThyroidFunctionDal>().SingleInstance();
            builder.RegisterType<TreatmentManager>().As<ITreatmentService>().SingleInstance();
            builder.RegisterType<TreatmentDal>().As<ITreatmentDal>().SingleInstance();

            builder.RegisterType<TreatmentSymptomaticManager>().As<ITreatmentSymptomaticService>().SingleInstance();
            builder.RegisterType<TreatmentSymptomaticDal>().As<ITreatmentSymptomaticDal>().SingleInstance();


            builder.RegisterType<CSFManager>().As<ICSFService>().SingleInstance();
            builder.RegisterType<CSFDal>().As<ICSFDal>().SingleInstance();

            builder.RegisterType<TreatmentMSSpecificManager>().As<ITreatmentMSSpecificService>().SingleInstance();
            builder.RegisterType<TreatmentMSSpecificDal>().As<ITreatmentMSSpecificDal>().SingleInstance();

            builder.RegisterType<TreatmentYogaManager>().As<ITreatmentYogaService>().SingleInstance();
            builder.RegisterType<TreatmentYogaDal>().As<ITreatmentYogaDal>().SingleInstance();

            builder.RegisterType<TreatmentPsychotherapyManager>().As<ITreatmentPsychotherapyService>().SingleInstance();
            builder.RegisterType<TreatmentPsychotherapyDal>().As<ITreatmentPsychotherapyDal>().SingleInstance();

            builder.RegisterType<TreatmentPhysiotherapyManager>().As<ITreatmentPhysiotherapyService>().SingleInstance();
            builder.RegisterType<TreatmentPhysiotherapyDal>().As<ITreatmentPhysiotherapyDal>().SingleInstance();

            builder.RegisterType<TreatmentNeuropsychManager>().As<ITreatmentNeuropsychService>().SingleInstance();
            builder.RegisterType<TreatmentNeuropsychDal>().As<ITreatmentNeuropsychDal>().SingleInstance();

            builder.RegisterType<TreatmentPilatesManager>().As<ITreatmentPilatesService>().SingleInstance();
            builder.RegisterType<TreatmentPilatesDal>().As<ITreatmentPilatesDal>().SingleInstance();

            builder.RegisterType<Vaccine_Manager>().As<IVaccine_Service>().SingleInstance();
            builder.RegisterType<Vaccine_Dal>().As<IVaccine_Dal>().SingleInstance();


            builder.RegisterType<FluVaccine_Manager>().As<IFluVaccine_Service>().SingleInstance();
            builder.RegisterType<FluVaccine_Dal>().As<IFluVaccine_Dal>().SingleInstance();


            builder.RegisterType<HepatityBVaccine_Manager>().As<IHepatityBVaccine_Service>().SingleInstance();
            builder.RegisterType<HepatitisBVaccine_Dal>().As<IHepatitisBVaccine_Dal>().SingleInstance();


            builder.RegisterType<HepatityAVaccine_Manager>().As<IHepatityAVaccine_Service>().SingleInstance();
            builder.RegisterType<HepatitisAVaccine_Dal>().As<IHepatitisAVaccine_Dal>().SingleInstance();


            builder.RegisterType<Covid19Vaccine_Manager>().As<ICovid19Vaccine_Service>().SingleInstance();
            builder.RegisterType<Covid19Vaccine_Dal>().As<ICovid19Vaccine_Dal>().SingleInstance();


            builder.RegisterType<OtherVaccine_Manager>().As<IOtherVaccine_Service>().SingleInstance();
            builder.RegisterType<OtherVaccine_Dal>().As<IOtherVaccine_Dal>().SingleInstance();
            builder.RegisterType<VisitManager>().As<IVisitService>().SingleInstance();
            builder.RegisterType<VisitDal>().As<IVisitDal>().SingleInstance();


        }
    }
}

