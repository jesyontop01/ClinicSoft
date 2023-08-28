using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicSoft.ServerModel;
using ClinicSoft.ServerModel.NotificationModels;
using Microsoft.EntityFrameworkCore;

namespace ClinicSoft.DalLayer
{
    public class NotiFicationDbContext : DbContext
    {
        
        public DbSet<NotificationViewModel> Notifications { get; set; }
        public DbSet<VisitModel> PatientVisits { get; set; }

        private string connStr = null;
        public NotiFicationDbContext(string conn)
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
            modelBuilder.Entity<NotificationViewModel>().ToTable("CORE_Notification");
            modelBuilder.Entity<VisitModel>().ToTable("PAT_PatientVisits");
        }
    }
}
