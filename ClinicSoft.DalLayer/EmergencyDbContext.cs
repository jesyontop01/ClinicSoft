using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicSoft.ServerModel;
//using System.Data.Entity;
using ClinicSoft.ServerModel.EmergencyModels;
using Microsoft.EntityFrameworkCore;

namespace ClinicSoft.DalLayer
{
    public class EmergencyDbContext: DbContext
    {
        public EmergencyDbContext()
        {
        }

        public EmergencyDbContext(DbContextOptions<EmergencyDbContext> options)
            : base(options)
        {
        }
        public DbSet<EmergencyPatientModel> EmergencyPatient { get; set; }
        public DbSet<PatientModel> Patient { get; set; }
        public DbSet<VisitModel> Visits { get; set; }
        public DbSet<CountryModel> Country { get; set; }
        public DbSet<CountrySubDivisionModel> CountrySubDivision { get; set; }
        public DbSet<EmployeeModel> Employee { get; set; }
        public DbSet<AdmissionModel> Admissions { get; set; }
        //public DbSet<DischargeSummaryModel> DischargeSummary { get; set; }
        public DbSet<ServiceDepartmentModel> ServiceDepartment { get; set; }
        public DbSet<BillingTransactionItemModel> BillingTransactionItems { get; set; }
        public DbSet<BillItemPrice> BillItemPrice { get; set; }
        public DbSet<BillingCounter> BillingCounter { get; set; }
        public DbSet<DepartmentModel> Departments { get; set; }
        public DbSet<EmergencyDischargeSummaryModel> DischargeSummary { get; set; }
        public DbSet<VitalsModel> Vitals { get; set; }
        public DbSet<LabRequisitionModel> LabRequisitions { get; set; }
        public DbSet<ImagingRequisitionModel> ImagingRequisitions { get; set; }
        public DbSet<MembershipTypeModel> MembershipTypes { get; set; }
        public DbSet<PatientMembershipModel> PatientMemberships { get; set; }
        public DbSet<AdminParametersModel> AdminParameters { get; set; }
        public DbSet<ModeOfArrival> ModeOfArrival { get; set; }
        public DbSet<EmergencyPatientCases> PatientCases { get; set; }
        public DbSet<UploadConsentForm> Consentform { get; set; }

        public DbSet<MunicipalityModel> Municipalities { get; set; }
        //public EmergencyDbContext(string conn) : base(conn)
        //{
        //    this.Configuration.LazyLoadingEnabled = true;
        //    this.Configuration.ProxyCreationEnabled = false;
        //}
        private string connStr = null;
        public EmergencyDbContext(string conn)
        {
            connStr = conn;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(connStr);

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ModeOfArrival>().ToTable("ER_ModeOfArrival");
            modelBuilder.Entity<AdminParametersModel>().ToTable("CORE_CFG_Parameters");
            modelBuilder.Entity<EmergencyPatientModel>().ToTable("ER_Patient");
            modelBuilder.Entity<PatientModel>().ToTable("PAT_Patient");
            modelBuilder.Entity<VisitModel>().ToTable("PAT_PatientVisits");
            modelBuilder.Entity<CountryModel>().ToTable("MST_Country");
            modelBuilder.Entity<CountrySubDivisionModel>().ToTable("MST_CountrySubDivision");
            //modelBuilder.Entity<DischargeSummaryModel>().ToTable("ADT_DischargeSummary");
            modelBuilder.Entity<AdmissionModel>().ToTable("ADT_PatientAdmission");
            modelBuilder.Entity<DepartmentModel>().ToTable("MST_Department");
            // Patient and visit mappings
            modelBuilder.Entity<VisitModel>()
                   .HasOne<PatientModel>(a => a.Patient)
                   .WithMany(a => a.Visits)
                    .HasForeignKey(s => s.PatientId);
            modelBuilder.Entity<EmployeeModel>().ToTable("EMP_Employee");
            modelBuilder.Entity<ServiceDepartmentModel>().ToTable("BIL_MST_ServiceDepartment");
            modelBuilder.Entity<BillingTransactionItemModel>().ToTable("BIL_TXN_BillingTransactionItems");
            modelBuilder.Entity<BillItemPrice>().ToTable("BIL_CFG_BillItemPrice");
            modelBuilder.Entity<BillingCounter>().ToTable("BIL_CFG_Counter");
            modelBuilder.Entity<EmergencyDischargeSummaryModel>().ToTable("ER_DischargeSummary");
            modelBuilder.Entity<VitalsModel>().ToTable("CLN_PatientVitals");
            modelBuilder.Entity<LabRequisitionModel>().ToTable("LAB_TestRequisition");
            modelBuilder.Entity<ImagingRequisitionModel>().ToTable("RAD_PatientImagingRequisition");
            modelBuilder.Entity<MembershipTypeModel>().ToTable("PAT_CFG_MembershipType");
            modelBuilder.Entity<PatientMembershipModel>().ToTable("PAT_PatientMembership");
            modelBuilder.Entity<EmergencyPatientCases>().ToTable("ER_Patient_Cases");
            modelBuilder.Entity<UploadConsentForm>().ToTable("ER_FileUploads");
            modelBuilder.Entity<MunicipalityModel>().ToTable("MST_Municipality");
        }
    }
}
