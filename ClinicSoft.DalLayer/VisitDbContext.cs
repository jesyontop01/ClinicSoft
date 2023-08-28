﻿using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Audit.EntityFramework;
using ClinicSoft.ServerModel;
using Microsoft.EntityFrameworkCore;

namespace ClinicSoft.DalLayer
{
    public class VisitDbContext : AuditDbContext
    {
        private string connStr = null;
        public VisitDbContext(string conn)
        {
            connStr = conn;
        }
        public VisitDbContext()
        {
        }

        public VisitDbContext(DbContextOptions<VisitDbContext> options)
            : base(options)
        {
        }
        public DbSet<VisitModel> Visits { get; set; }
        public DbSet<EmployeeModel> Employees { get; set; }

        //ashim: 22Aug2018 : moved from PatientDbContext. Now Visit Create is using VisitDbContext instead of PatientDbContext
        public DbSet<BillingTransactionModel> BillingTransactions { get; set; }
        public DbSet<BillingTransactionItemModel> BillingTransactionsItems { get; set; }
        public DbSet<LabRequisitionModel> LabRequisitions { get; set; } // Hom 30 Jan'19
        public DbSet<ImagingRequisitionModel> RadiologyImagingRequisitions { get; set; }// Hom 30 Jan'19
        //start: sud-14May for InvoiceReturn of VisitModule -- needs revision.
        public DbSet<BillInvoiceReturnModel> BillReturns { get; set; }
        //end: sud-14May for InvoiceReturn of VisitModule -- needs revision.

        public DbSet<CountrySubDivisionModel> CountrySubdivisions { get; set; }//sud:14May'18
        public DbSet<CountryModel> Countries { get; set; }//sud:14May'18

        public DbSet<ServiceDepartmentModel> ServiceDepartments { get; set; }
        public List<VitalsModel> Vitals { get; set; }

       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(connStr);

            base.OnConfiguring(optionsBuilder);
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
            modelBuilder.Entity<LabRequisitionModel>().ToTable("LAB_TestRequisition");
            modelBuilder.Entity<ServiceDepartmentModel>().ToTable("BIL_MST_ServiceDepartment");
            modelBuilder.Entity<BillingTransactionModel>().ToTable("BIL_TXN_BillingTransaction");
            modelBuilder.Entity<BillingTransactionItemModel>().ToTable("BIL_TXN_BillingTransactionItems");
            modelBuilder.Entity<ImagingRequisitionModel>().ToTable("RAD_PatientImagingRequisition");
            modelBuilder.Entity<BillingTransactionItemModel>()
                  .HasOne<BillingTransactionModel>(s => s.BillingTransaction) // Address entity requires Patient
                  .WithMany(s => s.BillingTransactionItems) // Patient entity includes many Addresses entities
                   .HasForeignKey(s => s.BillingTransactionId);

            modelBuilder.Entity<BillInvoiceReturnModel>().ToTable("BIL_TXN_InvoiceReturn");//added sud: 14May--needs revision
            modelBuilder.Entity<CountrySubDivisionModel>().ToTable("MST_CountrySubDivision");//added sud: 14May

            modelBuilder.Entity<CountryModel>().ToTable("MST_Country");//added: sud:3June'18
            modelBuilder.Entity<VitalsModel>().ToTable("CLN_PatientVitals");

        }
        public DbSet<PatientModel> Patients { get; set; }
        public DbSet<AdmissionModel> Admissions { get; set; }
        public DbSet<DepartmentModel> Departments { get; set; }
        public DbSet<BillItemPrice> BillItemPrice { get; set; }
    }

}
