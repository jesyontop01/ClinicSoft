using System;
using System.Collections.Generic;
using System.Data;
//using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicSoft.ServerModel;
using Microsoft.EntityFrameworkCore;

namespace ClinicSoft.DalLayer
{
    public class FractionDbContext : DbContext
    {
        public FractionDbContext()
        {
        }

        public FractionDbContext(DbContextOptions<FractionDbContext> options)
            : base(options)
        {
        }
        public DbSet<DesignationModel> Designation { get; set; }
        public DbSet<FractionCalculationModel> FractionCalculation { get; set; }
        public DbSet<BillingTransactionItemModel> BillingTransactionItems { get; set; }
        public DbSet<BillItemPrice> BillItemPrice { get; set; }
        public DbSet<FractionPercentModel> FractionPercent { get; set; }
        public DbSet<PatientModel> Patient { get; set; }
        public DbSet<EmployeeModel> Employee { get; set; }

        //public FractionDbContext(string conn) : base(conn)
        //{
        //    this.Configuration.LazyLoadingEnabled = true;
        //    this.Configuration.ProxyCreationEnabled = false;
        //}
        private string connStr = null;
        public FractionDbContext(string conn)
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
        public DataTable GetFractionApplicable()
        {
            DataTable result = DALFunctions.GetDataTableFromStoredProc("SP_FRC_GetFractionApplicableList", this);
            return result;
        }
        public DataTable GetFractionReportByItemList()
        {
            DataTable result = DALFunctions.GetDataTableFromStoredProc("SP_FRC_GetTotalFractionbyItem", this);
            return result;
        }
        public DataTable GetFractionReportByDoctorList(DateTime FromDate, DateTime ToDate)
        {
            List<SqlParameter> paramList = new List<SqlParameter>() { new SqlParameter("@FromDate", FromDate), new SqlParameter("@ToDate", ToDate) };
            DataTable result = DALFunctions.GetDataTableFromStoredProc("SP_FRC_GetTotalFractionbyDoctor", paramList,  this);
            return result;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DesignationModel>().ToTable("FRC_Designation");
            modelBuilder.Entity<FractionPercentModel>().ToTable("FRC_PercentSetting");
            modelBuilder.Entity<BillItemPrice>().ToTable("BIL_CFG_BillItemPrice");
            modelBuilder.Entity<PatientModel>().ToTable("PAT_Patient");


            modelBuilder.Entity<FractionCalculationModel>().ToTable("FRC_FractionCalculation");
            modelBuilder.Entity<BillingTransactionItemModel>().ToTable("BIL_TXN_BillingTransactionItems");
            modelBuilder.Entity<BillItemPrice>().ToTable("BIL_CFG_BillItemPrice");
            modelBuilder.Entity<PatientModel>().ToTable("PAT_Patient");

            modelBuilder.Entity<EmployeeModel>().ToTable("EMP_Employee");

        }


    }
}
