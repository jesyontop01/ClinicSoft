using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicSoft.ServerModel;
using Microsoft.EntityFrameworkCore;

namespace ClinicSoft.DalLayer
{
    public class AppointmentDbContext : DbContext
    {
        public AppointmentDbContext()
        {
        }

        public AppointmentDbContext(DbContextOptions<AppointmentDbContext> options)
            : base(options)
        {
        }
        private string connStr = null;

        public AppointmentDbContext(string conn)
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
        public DbSet<AppointmentModel> Appointments { get; set; }
        public DbSet<VisitModel> Visit { get; set; }
        public DbSet<EmployeeModel> Employees { get; set; }
        //public AppointmentDbContext(string conn) : base(conn)
        //{
        //    this.Configuration.LazyLoadingEnabled = true;
        //    this.Configuration.ProxyCreationEnabled = false;
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppointmentModel>().ToTable("PAT_Appointment");
            modelBuilder.Entity<VisitModel>().ToTable("PAT_PatientVisits");
            modelBuilder.Entity<EmployeeModel>().ToTable("EMP_Employee");

        }

    }
}

