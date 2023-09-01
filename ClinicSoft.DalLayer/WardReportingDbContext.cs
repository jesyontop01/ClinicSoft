using System;
using System.Collections.Generic;
//using System.Data.Entity;
//using System.Data.SqlClient;
using System.Linq;
using ClinicSoft.ServerModel;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ClinicSoft.ServerModel.ReportingModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
namespace ClinicSoft.DalLayer
{
    public class WardReportingDbContext : DbContext
    {
        public WardReportingDbContext()
        {
        }

        public WardReportingDbContext(DbContextOptions<WardReportingDbContext> options)
            : base(options)
        {
        }
        private string connStr = null;
        public WardReportingDbContext(string conn)
        {
            connStr = conn;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder

                .UseSqlServer(connStr);


        }

        #region WARD Stock Items Report        
        public DataTable WARDStockItemsReport(int ItemId,int StoreId)
        {
            List<SqlParameter> paramList = new List<SqlParameter>() { new SqlParameter("@ItemId", ItemId),new SqlParameter("@StoreId", StoreId) };
            foreach (SqlParameter parameter in paramList)
            {
                if (parameter.Value == null)
                {
                    parameter.Value = "";

                }
            }
            DataTable stockItems = DALFunctions.GetDataTableFromStoredProc("SP_WardReport_StockReport", paramList, this);
            return stockItems;
        }
        #endregion

        #region WARD Requisition DataTable
        public DataTable WARDRequisitionReport(DateTime FromDate, DateTime ToDate,int StoreId)
        {
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("@FromDate", FromDate),
                 new SqlParameter("@ToDate", ToDate),
                 new SqlParameter("@StoreId", StoreId)

            };

            foreach (SqlParameter parameter in paramList)
            {
                if (parameter.Value == null)
                {
                    parameter.Value = "";

                }
            }
            DataTable stockItems = DALFunctions.GetDataTableFromStoredProc("SP_WardReport_RequisitionReport", paramList, this);
            return stockItems;
        }
        #endregion

        #region WARD Breakage DataTable
        public DataTable WARDBreakageReport(DateTime FromDate, DateTime ToDate,int StoreId)
        {
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("@FromDate", FromDate),
                 new SqlParameter("@ToDate", ToDate),
                 new SqlParameter("@StoreId", StoreId)
            };

            foreach (SqlParameter parameter in paramList)
            {
                if (parameter.Value == null)
                {
                    parameter.Value = "";

                }
            }
            DataTable stockItems = DALFunctions.GetDataTableFromStoredProc("SP_WardReport_BreakageReport", paramList, this);
            return stockItems;
        }
        #endregion

        #region WARD Consumption DataTable
        public DataTable WARDConsumptionReport(DateTime FromDate, DateTime ToDate,int StoreId)
        {
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("@FromDate", FromDate),
                 new SqlParameter("@ToDate", ToDate),
                 new SqlParameter("@StoreId", StoreId)
            };

            foreach (SqlParameter parameter in paramList)
            {
                if (parameter.Value == null)
                {
                    parameter.Value = "";

                }
            }
            DataTable stockItems = DALFunctions.GetDataTableFromStoredProc("SP_WardReport_ConsumptionReport", paramList, this);
            return stockItems;
        }
        #endregion



        #region WARD Internal Consumption DataTable
        public DataTable WARDInteranlConsumptionReport(DateTime FromDate, DateTime ToDate, int StoreId)
        {
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("@FromDate", FromDate),
                 new SqlParameter("@ToDate", ToDate),
                 new SqlParameter("@StoreId", StoreId)
            };

            foreach (SqlParameter parameter in paramList)
            {
                if (parameter.Value == null)
                {
                    parameter.Value = "";

                }
            }
            DataTable stockItems = DALFunctions.GetDataTableFromStoredProc("SP_WardReport_InternalConsumptionReport", paramList, this);
            return stockItems;
        }
        #endregion

        #region WARD Transfer DataTable
        public DataTable WARDTransferReport(DateTime FromDate, DateTime ToDate,int StoreId)
        {
            List<SqlParameter> paramList = new List<SqlParameter>() {
                 new SqlParameter("@FromDate", FromDate),
                 new SqlParameter("@ToDate", ToDate),
                 new SqlParameter("@StoreId", StoreId)
            };

            foreach (SqlParameter parameter in paramList)
            {
                if (parameter.Value == null)
                {
                    parameter.Value = "";

                }
            }
            DataTable stockItems = DALFunctions.GetDataTableFromStoredProc("SP_WardReport_TransferReport", paramList, this);
            return stockItems;
        }
        #endregion

        ///WARD INVENTORY REPORT
        #region WARD Inventory Requisition and Dispatch Report
        public DataTable RequisitionDispatchReport(DateTime FromDate, DateTime ToDate,int StoreId)
        {
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("@FromDate", FromDate),
                 new SqlParameter("@ToDate", ToDate),
                 new SqlParameter("@StoreId", StoreId)
            };

            foreach (SqlParameter parameter in paramList)
            {
                if (parameter.Value == null)
                {
                    parameter.Value = "";

                }
            }
            DataTable stockItems = DALFunctions.GetDataTableFromStoredProc("SP_WardInv_Report_RequisitionDispatchReport", paramList, this);
            return stockItems;
        }
        #endregion

        #region WARD Inventory Transfer Report
        public DataTable TransferReport(DateTime FromDate, DateTime ToDate,int StoreId)
        {
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("@FromDate", FromDate),
                 new SqlParameter("@ToDate", ToDate),
                 new SqlParameter("@StoreId", StoreId)
            };

            foreach (SqlParameter parameter in paramList)
            {
                if (parameter.Value == null)
                {
                    parameter.Value = "";

                }
            }
            DataTable stockItems = DALFunctions.GetDataTableFromStoredProc("SP_WardInv_Report_TransferReport", paramList, this);
            return stockItems;
        }
        #endregion

        #region WARD Inventory Consumption Report
        public DataTable ConsumptionReport(DateTime FromDate, DateTime ToDate, int StoreId)
        {
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("@FromDate", FromDate),
                 new SqlParameter("@ToDate", ToDate),
                 new SqlParameter("@StoreId", StoreId)
            };

            foreach (SqlParameter parameter in paramList)
            {
                if (parameter.Value == null)
                {
                    parameter.Value = "";

                }
            }
            DataTable stockItems = DALFunctions.GetDataTableFromStoredProc("SP_WardInv_Report_ConsumptionReport", paramList, this);
            return stockItems;
        }
        #endregion
    }
}
