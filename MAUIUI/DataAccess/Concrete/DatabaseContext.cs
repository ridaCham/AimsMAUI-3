using MAUIUI.Core.Entities;
using MAUIUI.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace MAUIUI.DataAccess.Concrete
{
    public class DatabaseContext : DbContext
    {
        //adaphaa
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=E:\\MasaüstüE\\data.sqlite");
            // optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=E:\\MASAÜSTÜE\\STAJ\\ADAPHA\\HAFTA10\\AIMS\\MBG\\AAIMSDB.MDF;Trusted_Connection=true");
        }*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                if (Device.RuntimePlatform!= Device.WinUI)
                {
                    if (File.Exists("..//Aims.db"))
                    {
                        optionsBuilder.UseSqlite("Data Source=..//Aims.db");
                    }
                }
                else optionsBuilder.UseSqlite("Data Source=C:\\AAims_db\\Aims.db");
            }
        }
        public DbSet<AutoAntiBodyTest> AutoAntiBodyTests { get; set; }
        public DbSet<BloodChemistry> BloodChemistries { get; set; }
        public DbSet<Identifications> Identifications { get; set; }
        public DbSet<Outcome> Outcomes { get; set; }
        public DbSet<ParatestMRI> ParatestMRI { get; set; }
        //public DbSet<ParatestMRIImage> MRIImages { get; set; }
        public DbSet<AddNewFamilyHistory> AddNewFamilyHistory { get; set; }
        public DbSet<Covid19> Covid19 { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CSF> CSFs { get; set; }
        public DbSet<Edss> Edss { get; set; }
        public DbSet<EvokedPotentiel> EvokedPotentiels { get; set; }
        public DbSet<FaceToFaceTest> FaceToFaceTests { get; set; }
        public DbSet<DijitalTest> DijitalTests { get; set; }
        public DbSet<LaboratoryTestsNotes> LaboratoryTestsNotes { get; set; }
        public DbSet<Genetic_Test> GeneticTests { get; set; }
        public DbSet<GeneralNotes> GeneralNotes { get; set; }
        public DbSet<Diagnosis> Diagnosisses { get; set; }
        public DbSet<Haematology> Haematologies { get; set; }
        public DbSet<Immunosuppression> Immunosuppressions { get; set; }
        public DbSet<SerologicalTest> SerologicalTests { get; set; }
        public DbSet<ThyroidFunction> ThryroidFunctions { get; set; }
        public DbSet<HerpesZoster> HerpesZosters { get; set; }
        public DbSet<Malignancy> Malignancies { get; set; }
        public DbSet<MedicalHistory> MedicalHistories { get; set; }
        public DbSet<OtherMedicalCondition> OtherMedicalConditions { get; set; }
        public DbSet<Pregnancy> Pregnancies { get; set; }
        public DbSet<Relapse> Relapses { get; set; }
        public DbSet<Treatment> Treatments { get; set; }
        public DbSet<TreatmentMSSpecific> TreatmentMSSpecifics { get; set; }
        public DbSet<TreatmentYoga> Yogas { get; set; }
        public DbSet<TreatmentPilates> Pilates { get; set; }
        public DbSet<TreatmentNeuropsych> Neuropsychtrainings { get; set; }
        public DbSet<TreatmentPhysiotherapy> Physiotherapies { get; set; }
        public DbSet<TreatmentPsychotherapy> Psychotherapies { get; set; }
        public DbSet<TreatmentSymptomatic> TreatmentSymptomatics { get; set; }
        public DbSet<FluVaccine> FluVaccine { get; set; }
        public DbSet<HepatitisAVaccine> HepatitisAVaccine { get; set; }
        public DbSet<HepatitisBVaccine> HepatitisBVaccine { get; set; }
        public DbSet<Covid19Vaccine> Covid19Vaccine { get; set; }
        public DbSet<OtherVaccine> OtherVaccine { get; set; }
        public DbSet<Vaccine_> Vaccines { get; set; }
        public DbSet<Visit> Visits { get; set; }




    }
}