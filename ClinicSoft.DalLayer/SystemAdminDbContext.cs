using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicSoft.ServerModel;
//using System.Data.Entity;
using System.Data.SqlClient;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace ClinicSoft.DalLayer
{
    public class SystemAdminDbContext : DbContext
    {
        public SystemAdminDbContext()
        {
        }

        public SystemAdminDbContext(DbContextOptions<SystemAdminDbContext> options)
            : base(options)
        {
        }
        public DbSet<DatabaseLogModel> DatabaseLog { get; set; }
        public DbSet<AdminParametersModel> AdminParameters { get; set; }
        public DbSet<LoginInformationModel> LoginInformation { get; set; }
        public DbSet<CookieAuthInfoModel> CookieInformation { get; set; }
        public DbSet<AuditTableDisplayName> AuditTableDisplayNames { get; set; }

        private string connStr = null;
        public SystemAdminDbContext(string conn)
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
            modelBuilder.Entity<DatabaseLogModel>().ToTable("SysAdmin_DBLog");
            modelBuilder.Entity<AdminParametersModel>().ToTable("SysAdmin_Parameters");
            modelBuilder.Entity<LoginInformationModel>().ToTable("DanpheLogInInformation");
            modelBuilder.Entity<CookieAuthInfoModel>().ToTable("Danphe_CookieAuthInfo");
            modelBuilder.Entity<AuditTableDisplayName>().ToTable("tbl_AuditTableDisplayName");
        }

      
    }
}
