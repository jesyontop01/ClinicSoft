using ClinicSoft.ServerModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSoft.DalLayer
{
    public class QueueManagementDbContext : DbContext
    {
        private string connStr = null;
        public QueueManagementDbContext(string conn)
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
        public DbSet<DepartmentModel> Department { get; set; }
        public DbSet<VisitModel> Visits { get; set; }
        public DbSet<PatientModel> Patients { get; set; }
        public DbSet<EmployeeModel> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeModel>().ToTable("EMP_Employee");
            modelBuilder.Entity<DepartmentModel>().ToTable("MST_Department");
            modelBuilder.Entity<PatientModel>().ToTable("PAT_Patient");
            modelBuilder.Entity<VisitModel>().ToTable("PAT_PatientVisits");
            modelBuilder.Entity<VisitModel>()
            .HasOne<PatientModel>(a => a.Patient)
            .WithMany(a => a.Visits)
            .HasForeignKey(s => s.PatientId);
            modelBuilder.Entity<VisitModel>()
            .HasOne<AdmissionModel>(a => a.Admission)
            .WithOne(a => a.Visit);
        }
    }
}
