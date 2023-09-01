using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicSoft.ServerModel;
using ClinicSoft.ServerModel.ClinicalModels;
using Microsoft.EntityFrameworkCore;

namespace ClinicSoft.DalLayer
{
    public class DoctorsDbContext : DbContext
    {
        public DoctorsDbContext()
        {
        }

        public DoctorsDbContext(DbContextOptions<DoctorsDbContext> options)
            : base(options)
        {
        }
        public DbSet<VisitModel> Visits { get; set; }
        public DbSet<EmployeeModel> Employees { get; set; }
        public DbSet<PatientModel> Patients { get; set; }
        public DbSet<AdmissionModel> Admissions { get; set; }
        public DbSet<DepartmentModel> Departments { get; set; }
        public DbSet<BillItemPrice> BillItemPrice { get; set; }
        public DbSet<VisitSummaryModel> VisitSummary { get; set; }
        public DbSet<TemplateNoteModel> TemplateNotes { get; set; }
        //public DoctorsDbContext(string conn) : base(conn)
        //{
        //    this.Configuration.LazyLoadingEnabled = true;
        //    this.Configuration.ProxyCreationEnabled = false;
        //}
        private string connStr = null;

        public DoctorsDbContext(string conn)
        {
            connStr = conn;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder

                .UseSqlServer(connStr);


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<PatientModel>().ToTable("PAT_Patient");
            modelBuilder.Entity<VisitModel>().ToTable("PAT_PatientVisits");
            modelBuilder.Entity<AdmissionModel>().ToTable("ADT_PatientAdmission");

            // Patient and visit mappings
            modelBuilder.Entity<VisitModel>()
                   .HasOne<PatientModel>(a => a.Patient)
                   .WithMany(a => a.Visits)
                    .HasForeignKey(s => s.PatientId);



            //Admission and visit

            modelBuilder.Entity<AdmissionModel>()
                .HasKey(t => t.PatientVisitId);
            modelBuilder.Entity<VisitModel>()
                .HasOne<AdmissionModel>(a => a.Admission)
                .WithOne(a => a.Visit);

            modelBuilder.Entity<EmployeeModel>().ToTable("EMP_Employee");
            modelBuilder.Entity<DepartmentModel>().ToTable("MST_Department");
            modelBuilder.Entity<BillItemPrice>().ToTable("BIL_CFG_BillItemPrice");
            modelBuilder.Entity<VisitSummaryModel>().ToTable("DOC_TXN_VisitSummary");
            modelBuilder.Entity<TemplateNoteModel>().ToTable("CLN_Template");
        }

    }

}

