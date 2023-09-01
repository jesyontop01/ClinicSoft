using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicSoft.ServerModel;
//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace ClinicSoft.DalLayer
{
    public class DicomDbContext : DbContext
    {
        //public DicomDbContext(string conn) : base(conn)
        //{
        //    this.Configuration.LazyLoadingEnabled = true;
        //    this.Configuration.ProxyCreationEnabled = false;
        //}
        public DicomDbContext()
        {
        }

        public DicomDbContext(DbContextOptions<DicomDbContext> options)
            : base(options)
        {
        }
        private string connStr = null;
        public DicomDbContext(string conn)
        {
            connStr = conn;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder

                .UseSqlServer(connStr);


        }
        public DbSet<PatientStudyModel> PatientStudies { get; set; }
        public DbSet<DicomFileInfoModel> DicomFiles { get; set; }
        public DbSet<SeriesInfoModel> Series { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PatientStudyModel>().ToTable("DCM_PatientStudy");
            modelBuilder.Entity<DicomFileInfoModel>().ToTable("DCM_DicomFiles");
            modelBuilder.Entity<SeriesInfoModel>().ToTable("DCM_Series");
        }
    }
}
