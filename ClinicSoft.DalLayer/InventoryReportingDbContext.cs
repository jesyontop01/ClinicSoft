
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using ClinicSoft.ServerModel.ReportingModels;
//using System.Data.SqlClient;
using System.Data;
using ClinicSoft.ServerModel.InventoryModels.InventoryReportModel;
using Microsoft.EntityFrameworkCore;
using ClinicSoft.ServerModel.SystemAdminModels;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Microsoft.Extensions.Configuration;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Microsoft.Data.SqlClient;
namespace ClinicSoft.DalLayer
{
    public class InventoryReportingDbContext : DbContext
    {
        //private string connStr = null;
        //public InventoryReportingDbContext(string Conn) : base(Conn)
        //{
        //    connStr = Conn;
        //    this.Configuration.LazyLoadingEnabled = true;
        //    this.Configuration.ProxyCreationEnabled = false;
        //}
        private string connStr = null;
        public InventoryReportingDbContext( string conn)
        {
            connStr = conn;
        }
        // private readonly IConfiguration _configuration;
        // private readonly string _connectionString;
        // public IDbConnection CreateConnection()
        //=> new SqlConnection(_connectionString);
        //public InventoryReportingDbContext(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //    _connectionString = _configuration.GetConnectionString("DapperConnection");
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder

                .UseSqlServer(connStr);


        }
        #region Current Stock Level Report
        public List<CurrentStockLevel> CurrentStockLevelReport(string ItemName)
        {
            if (ItemName == null || ItemName == " ")
            {
                //using (var connection = _connectionString.CreateConnection())
                //{
                //    var companies = await connection.QueryAsync<Company>(query);
                //    return companies.ToList();
                //}
                //var Data = Database.SqlQuery<CurrentStockLevel>("exec SP_Report_Inventory_CurrentStockLevel @ItemName",
                //  new SqlParameter("@ItemName", DBNull.Value)).ToList();
                //return Data.ToList<CurrentStockLevel>();
                var currentStockLevel = new List<CurrentStockLevel>();

                using (var connection = Database.GetDbConnection() as SqlConnection)
                {
                    if (connection != null)
                    {
                        connection.Open();

                        using (var command = connection.CreateCommand())
                        {
                            command.CommandText = "SP_Report_Inventory_CurrentStockLevel";
                            command.CommandType = CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("@ItemName", DBNull.Value);

                            using (var reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    var stockLevel = new CurrentStockLevel
                                    {

                                        // Map properties from reader to your custom model
                                        // e.g., PropertyName = reader.GetDataType(columnIndex)
                                    };

                                    currentStockLevel.Add(stockLevel);
                                }
                            }
                        }
                    }
                    return currentStockLevel;
                }

            }
            else
            {
                var currentStockLevel = new List<CurrentStockLevel>();

                //var Data = Database.SqlQuery<CurrentStockLevel>("exec SP_Report_Inventory_CurrentStockLevel @ItemName",
                //new SqlParameter("@ItemName", ItemName)).ToList();
                //return Data.ToList<CurrentStockLevel>();
                using (var connection = Database.GetDbConnection() as SqlConnection)
                {
                    if (connection != null)
                    {
                        connection.Open();

                        using (var command = connection.CreateCommand())
                        {
                            command.CommandText = "SP_Report_Inventory_CurrentStockLevel";
                            command.CommandType = CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("@ItemName", ItemName);

                            using (var reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    var stockLevel = new CurrentStockLevel
                                    {

                                        // Map properties from reader to your custom model
                                        // e.g., PropertyName = reader.GetDataType(columnIndex)
                                    };

                                    currentStockLevel.Add(stockLevel);
                                }
                            }
                        }
                    }
                    return currentStockLevel;
                }
            }

        }
        #endregion

        #region Current Stock Level Report with Item Id
        public DataTable CurrentStockLevelReportByItemId(string storeIds)
        {
            List<SqlParameter> paramList = new List<SqlParameter>() { new SqlParameter("@StoreIds", storeIds) };
            foreach (SqlParameter parameter in paramList)
            {
                if (parameter.Value == null)
                {
                    parameter.Value = "";
                }
            }
            DataTable purchaseItems = DALFunctions.GetDataTableFromStoredProc("SP_Report_INV_CurrentStockLevel", paramList, this);
            return purchaseItems;
        }
        #endregion
        #region Current Stock Level Item Details with item id and store id
        public DataTable CurrentStockItemDetailsByStoreId(string storeIds, int ItemId)
        {
            List<SqlParameter> paramList = new List<SqlParameter>() { new SqlParameter("@StoreIds", storeIds),
                                                                      new SqlParameter("@ItemId", ItemId) };
            foreach (SqlParameter parameter in paramList)
            {
                if (parameter.Value == null)
                {
                    parameter.Value = "";
                }
            }
            DataTable purchaseItems = DALFunctions.GetDataTableFromStoredProc("SP_Report_INV_CurrentStockItemDetails_By_StoreId", paramList, this);
            return purchaseItems;
        }
        #endregion

        #region Write Off Report

        public List<CurrentWriteOff> CurrentWriteOffReport(int ItemId)
        {
            var phrmInvoice = new List<CurrentWriteOff>();

            using (var connection = Database.GetDbConnection() as SqlConnection)
            {
                if (connection != null)
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "SP_Report_Inventory_WriteOffReport";
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@ItemId", ItemId);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var phrmDetail = new CurrentWriteOff
                                {

                                    // Map properties from reader to your custom model
                                    // e.g., PropertyName = reader.GetDataType(columnIndex)
                                };

                                phrmInvoice.Add(phrmDetail);
                            }
                        }
                    }
                }
            }

            return phrmInvoice;
        }
        //public List<CurrentWriteOff> CurrentWriteOffReport(int ItemId)
        //{
        //    var Data = Database.SqlQuery<CurrentWriteOff>("exec SP_Report_Inventory_WriteOffReport @ItemId",
        //        new SqlParameter("@ItemId", ItemId)).ToList();
        //    return Data.ToList<CurrentWriteOff>();
        //}
        #endregion

        #region Return To Vendor Report
        public List<ReturnToVendor> ReturnToVendorReport(int VendorId)
        {
            var phrmInvoice = new List<ReturnToVendor>();

            using (var connection = Database.GetDbConnection() as SqlConnection)
            {
                if (connection != null)
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "SP_Report_Inventory_ReturnToVendorReport";
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@VendorId", VendorId);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var phrmDetail = new ReturnToVendor
                                {

                                    // Map properties from reader to your custom model
                                    // e.g., PropertyName = reader.GetDataType(columnIndex)
                                };

                                phrmInvoice.Add(phrmDetail);
                            }
                        }
                    }
                }
            }

            return phrmInvoice;
        }

        //public List<ReturnToVendor> ReturnToVendorReport(int VendorId)
        //{
        //    var Data = Database.SqlQuery<ReturnToVendor>("exec SP_Report_Inventory_ReturnToVendorReport @VendorId",
        //        new SqlParameter("@VendorId", VendorId)).ToList();
        //    return Data.ToList<ReturnToVendor>();
        //}
        #endregion

        #region Daily item dispatch report

        public List<DailyItemDispatchModel> DailyItemDispatchReport(DateTime FromDate, DateTime ToDate, int StoreId)
        {
            var phrmInvoice = new List<DailyItemDispatchModel>();

            using (var connection = Database.GetDbConnection() as SqlConnection)
            {
                if (connection != null)
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        if (StoreId == 0)
                        {
                            command.CommandText = "SP_Report_Inventory_DailyItemsDispatchReport";
                            command.CommandType = CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("@FromDate", FromDate);
                            command.Parameters.AddWithValue("@ToDate", ToDate);
                        }
                        else
                        {
                            command.CommandText = "SP_Report_Inventory_DailyItemsDispatchReport";
                            command.CommandType = CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("@FromDate", FromDate);
                            command.Parameters.AddWithValue("@ToDate", ToDate);
                            command.Parameters.AddWithValue("@StoreId", StoreId);
                        }
                
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var phrmDetail = new DailyItemDispatchModel
                                {

                                    // Map properties from reader to your custom model
                                    // e.g., PropertyName = reader.GetDataType(columnIndex)
                                };

                                phrmInvoice.Add(phrmDetail);
                            }
                        }
                    }
                }
            }

            return phrmInvoice;
        }
        //public List<DailyItemDispatchModel> DailyItemDispatchReport(DateTime FromDate, DateTime ToDate, int StoreId)
        //{
        //    if (StoreId == 0)
        //    {
        //        var Data = Database.SqlQuery<DailyItemDispatchModel>("exec SP_Report_Inventory_DailyItemsDispatchReport @FromDate,@ToDate",
        //        new SqlParameter("@FromDate", FromDate),
        //        new SqlParameter("@ToDate", ToDate)
        //        ).ToList();
        //        return Data.ToList<DailyItemDispatchModel>();
        //    }
        //    else
        //    {
        //        var Data = Database.SqlQuery<DailyItemDispatchModel>("exec SP_Report_Inventory_DailyItemsDispatchReport @FromDate,@ToDate,@StoreId",
        //        new SqlParameter("@FromDate", FromDate),
        //        new SqlParameter("@ToDate", ToDate),
        //        new SqlParameter("@StoreId", StoreId)
        //        ).ToList();
        //        return Data.ToList<DailyItemDispatchModel>();
        //    }

        //}
        #endregion

        #region INV Purchase Items Report
        public DataTable INVPurchaseItemsReport(DateTime FromDate, DateTime ToDate, int FiscalYearId, string ItemIds)
        {
            List<SqlParameter> paramList = new List<SqlParameter>() {
                                                                new SqlParameter("@FromDate", FromDate),
                                                                new SqlParameter("@ToDate", ToDate),
                                                                new SqlParameter("@FiscalYearId",FiscalYearId),
                                                                new SqlParameter("@ItemIds", ItemIds),
                                                                    };
            foreach (SqlParameter parameter in paramList)
            {
                if (parameter.Value == null)
                {
                    parameter.Value = "";
                }
            }
            DataTable purchaseItems = DALFunctions.GetDataTableFromStoredProc("SP_Report_Inventory_PurchaseItemsReport", paramList, this);
            return purchaseItems;
        }
        #endregion
        #region Purchase Order report
        public List<PurchaseOrderModel> PurchaseOrderReport(DateTime FromDate, DateTime ToDate, object StoreId)
        {
            var phrmInvoice = new List<PurchaseOrderModel>();

            using (var connection = Database.GetDbConnection() as SqlConnection)
            {
                if (connection != null)
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "SP_Report_Inventory_PurchaseOrderSummeryReport";
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@FromDate", FromDate);
                        command.Parameters.AddWithValue("@ToDate", ToDate);
                        command.Parameters.AddWithValue("@StoreId", (StoreId != null ? StoreId : DBNull.Value));
                   
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var phrmDetail = new PurchaseOrderModel
                                {

                                    // Map properties from reader to your custom model
                                    // e.g., PropertyName = reader.GetDataType(columnIndex)
                                };

                                phrmInvoice.Add(phrmDetail);
                            }
                        }
                    }
                }
            }

            return phrmInvoice;
        }

        //public List<PurchaseOrderModel> PurchaseOrderReport(DateTime FromDate, DateTime ToDate, object StoreId)
        //{
        //    //if (OrderNumber == 0)
        //    //{
        //        var Data = Database.SqlQuery<PurchaseOrderModel>("exec SP_Report_Inventory_PurchaseOrderSummeryReport @FromDate,@ToDate,@StoreId",
        //    new SqlParameter("@FromDate", FromDate),
        //    new SqlParameter("@ToDate", ToDate),
        //    new SqlParameter("@StoreId", (StoreId != null ? StoreId : DBNull.Value))
        //    ).ToList();
        //        return Data.ToList<PurchaseOrderModel>();
        //    //}
        //    //else
        //    //{
        //    //    var Data = Database.SqlQuery<PurchaseOrderModel>("exec SP_Report_Inventory_PurchaseOrderSummeryReport @FromDate,@ToDate,@OrderNumber",
        //    //    new SqlParameter("@FromDate", FromDate),
        //    //    new SqlParameter("@ToDate", ToDate),
        //    //    new SqlParameter("@OrderNumber", OrderNumber)
        //    //    ).ToList();
        //    //    return Data.ToList<PurchaseOrderModel>();
        //    //}

        //}
        #endregion

        #region CancelledPOandGRReports
        public List<GoodsReceiptModel> CancelledPOandGRReports(DateTime FromDate, DateTime ToDate, bool isGR)
        {
            var phrmInvoice = new List<GoodsReceiptModel>();

            using (var connection = Database.GetDbConnection() as SqlConnection)
            {
                if (connection != null)
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        if (isGR == true)
                        {
                            command.CommandText = "SP_Report_Inventory_CancelGoodsReceiptReport";
                            command.CommandType = CommandType.StoredProcedure;


                            command.Parameters.AddWithValue("@FromDate", FromDate);
                            command.Parameters.AddWithValue("@ToDate", ToDate);

                            using (var reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    var phrmDetail = new GoodsReceiptModel
                                    {

                                        // Map properties from reader to your custom model
                                        // e.g., PropertyName = reader.GetDataType(columnIndex)
                                    };

                                    phrmInvoice.Add(phrmDetail);
                                }
                            }
                        
                        }
                        else
                        {
                            command.CommandText = "SP_Report_Inventory_CancelPurchaseOrderReport";
                            command.CommandType = CommandType.StoredProcedure;


                            command.Parameters.AddWithValue("@FromDate", FromDate);
                            command.Parameters.AddWithValue("@ToDate", ToDate);

                            using (var reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    var phrmDetail = new GoodsReceiptModel
                                    {

                                        // Map properties from reader to your custom model
                                        // e.g., PropertyName = reader.GetDataType(columnIndex)
                                    };

                                    phrmInvoice.Add(phrmDetail);
                                }
                            }
                          
                        }
                        //command.CommandText = "SP_Report_Inventory_PurchaseOrderSummeryReport";
                        //command.CommandType = CommandType.StoredProcedure;

                    }
                }
            }

            return phrmInvoice;
        }

        #endregion
        #region GoodReceipt Evaluation

        public List<GoodsReceiptEvaluationModel> GoodReceiptEvaluationReport(DateTime? FromDate, DateTime? ToDate, string TransactionType, int? GoodReceiptNo)
        {
            var phrmInvoice = new List<GoodsReceiptEvaluationModel>();

            using (var connection = Database.GetDbConnection() as SqlConnection)
            {
                if (connection != null)
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        
                            command.CommandText = "SP_Report_Inventory_CancelGoodsReceiptReport";
                            command.CommandType = CommandType.StoredProcedure;

               
                            command.Parameters.AddWithValue("@GoodReceiptNo", (object)GoodReceiptNo ?? DBNull.Value);
                            command.Parameters.AddWithValue("@FromDate", (object)FromDate ?? DBNull.Value);
                            command.Parameters.AddWithValue("@ToDate", (object)ToDate ?? DBNull.Value);
                            command.Parameters.AddWithValue("@TransactionType", (object)TransactionType ?? DBNull.Value);

                            using (var reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    var phrmDetail = new GoodsReceiptEvaluationModel
                                    {

                                        // Map properties from reader to your custom model
                                        // e.g., PropertyName = reader.GetDataType(columnIndex)
                                    };

                                    phrmInvoice.Add(phrmDetail);
                                }
                            }


                    }
                }
            }

            return phrmInvoice;
        }

        //public List<GoodsReceiptEvaluationModel> GoodReceiptEvaluationReport(DateTime? FromDate, DateTime? ToDate, string TransactionType, int? GoodReceiptNo)
        //{
        //    var Data = Database.SqlQuery<GoodsReceiptEvaluationModel>("exec SP_Report_Inventory_GoodReceiptEvaluation @GoodReceiptNo, @FromDate, @ToDate, @TransactionType",
        //        new SqlParameter("@GoodReceiptNo", (object)GoodReceiptNo ?? DBNull.Value),
        //        new SqlParameter("@FromDate", (object)FromDate ?? DBNull.Value),
        //        new SqlParameter("@ToDate", (object)ToDate ?? DBNull.Value),
        //        new SqlParameter("@TransactionType", (object)TransactionType ?? DBNull.Value)
        //        ).ToList();
        //    return Data.ToList<GoodsReceiptEvaluationModel>();
        //}
        #endregion

        #region Inventory Summary Report
        public DataTable InventorySummaryReport(DateTime FromDate, DateTime ToDate, int FiscalYearId)
        {


            List<SqlParameter> paramList = new List<SqlParameter>() {
                                                                new SqlParameter("@FromDate", FromDate),
                                                                new SqlParameter("@ToDate", ToDate),
                                                                new SqlParameter("@FiscalYearId", FiscalYearId)
                                                                    };
            foreach (SqlParameter parameter in paramList)
            {
                if (parameter.Value == null)
                {
                    parameter.Value = "";
                }
            }
            DataTable purchaseItems = DALFunctions.GetDataTableFromStoredProc("SP_INV_RPT_GetInventorySummary", paramList, this);
            return purchaseItems;

        }
        #endregion

        #region Inventory Valuation
        public DataTable InventoryValuation()
        {
            DataTable invValuationData = DALFunctions.GetDataTableFromStoredProc("SP_Report_Inventory_InventoryValuation", this);
            return invValuationData;
        }
        #endregion

        #region Comparison Purchaseorder & GoodsReceipt
        public DataTable ComparisonPOGR()
        {
            DataTable cmpPOGR = DALFunctions.GetDataTableFromStoredProc("SP_Report_Inventory_ComparePoAndGR", this);
            return cmpPOGR;
        }
        #endregion

        #region PurchaseReport
        public DataTable PurchaseReports()
        {
            DataTable PurRep = DALFunctions.GetDataTableFromStoredProc("SP_Report_Inventory_Purchase", this);
            return PurRep;
        }
        #endregion
        #region Fixed Assets report


        public List<FixedAssetsModel> FixedAssetsReport(DateTime FromDate, DateTime ToDate)
        {
            var phrmInvoice = new List<FixedAssetsModel>();

            using (var connection = Database.GetDbConnection() as SqlConnection)
            {
                if (connection != null)
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {

                        command.CommandText = "SP_Report_Inventory_FixedAssets";
                        command.CommandType = CommandType.StoredProcedure;


                        command.Parameters.AddWithValue("@FromDate", FromDate);
                        command.Parameters.AddWithValue("@ToDate", ToDate);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var phrmDetail = new FixedAssetsModel
                                {

                                    // Map properties from reader to your custom model
                                    // e.g., PropertyName = reader.GetDataType(columnIndex)
                                };

                                phrmInvoice.Add(phrmDetail);
                            }
                        }


                    }
                }
            }

            return phrmInvoice;
        }

        //public List<FixedAssetsModel> FixedAssetsReport(DateTime FromDate, DateTime ToDate)
        //{

        //    var Data = Database.SqlQuery<FixedAssetsModel>("exec SP_Report_Inventory_FixedAssets @FromDate,@ToDate",
        //    new SqlParameter("@FromDate", FromDate),
        //    new SqlParameter("@ToDate", ToDate)
        //    ).ToList();
        //    return Data.ToList<FixedAssetsModel>();


        //}
        #endregion

        #region Fixed Assets  Movement report
        public List<FixedAssetsMovementModel> FixedAssetsMovementReport(DateTime FromDate, DateTime ToDate, object EmployeeId, object DepartmentId, object ItemId, object ReferenceNumber)
        {
            var phrmInvoice = new List<FixedAssetsMovementModel>();

            using (var connection = Database.GetDbConnection() as SqlConnection)
            {
                if (connection != null)
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {

                        command.CommandText = "SP_Report_Inventory_FixedAssetsMovement";
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@FromDate", FromDate);
                        command.Parameters.AddWithValue("@ToDate", ToDate);
                        command.Parameters.AddWithValue("@EmployeeId", (EmployeeId != null ? EmployeeId : DBNull.Value));
                        command.Parameters.AddWithValue("@DepartmentId", (DepartmentId != null ? DepartmentId : DBNull.Value));
                        command.Parameters.AddWithValue("@ItemId", (ItemId != null ? ItemId : DBNull.Value));
                        command.Parameters.AddWithValue("@ReferenceNumber", (ReferenceNumber != null ? ReferenceNumber : DBNull.Value));
                       

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var phrmDetail = new FixedAssetsMovementModel
                                {

                                    // Map properties from reader to your custom model
                                    // e.g., PropertyName = reader.GetDataType(columnIndex)
                                };

                                phrmInvoice.Add(phrmDetail);
                            }
                        }


                    }
                }
            }

            return phrmInvoice;
        }
        //public List<FixedAssetsMovementModel> FixedAssetsMovementReport(DateTime FromDate, DateTime ToDate, object EmployeeId, object DepartmentId, object ItemId, object ReferenceNumber)
        //{
        //    var Data = Database.SqlQuery<FixedAssetsMovementModel>("exec SP_Report_Inventory_FixedAssetsMovement @FromDate,@ToDate,@EmployeeId,@DepartmentId,@ItemId,@ReferenceNumber",
        //    new SqlParameter("@FromDate", FromDate),
        //    new SqlParameter("@ToDate", ToDate),
        //    new SqlParameter("@EmployeeId", (EmployeeId != null ? EmployeeId : DBNull.Value)),
        //    new SqlParameter("@DepartmentId", (DepartmentId != null ? DepartmentId : DBNull.Value)),
        //    new SqlParameter("@ItemId", (ItemId != null ? ItemId : DBNull.Value)),
        //    new SqlParameter("@ReferenceNumber", (ReferenceNumber != null ? ReferenceNumber : DBNull.Value))
        //    ).ToList();
        //    return Data.ToList<FixedAssetsMovementModel>();


        //}
        #endregion

        #region Depatment Detail Stock Ledger Report
        public List<DetailStockLedgerModel> DepartmentDetailStockLedgerReport(DateTime FromDate, DateTime ToDate, int? ItemId, int selectedStoreId)
        {
            var phrmInvoice = new List<DetailStockLedgerModel>();

            using (var connection = Database.GetDbConnection() as SqlConnection)
            {
                if (connection != null)
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {

                        command.CommandText = "SP_Report_Inventory_DetailedStockLedger";
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@FromDate", FromDate);
                        command.Parameters.AddWithValue("@ToDate", ToDate);
                        command.Parameters.AddWithValue("@ItemId", (Object)ItemId ?? DBNull.Value);
                        command.Parameters.AddWithValue("@StoreId", selectedStoreId);
                       

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var phrmDetail = new DetailStockLedgerModel
                                {

                                    // Map properties from reader to your custom model
                                    // e.g., PropertyName = reader.GetDataType(columnIndex)
                                };

                                phrmInvoice.Add(phrmDetail);
                            }
                        }


                    }
                }
            }

            return phrmInvoice;
        }

        //public List<DetailStockLedgerModel> DepartmentDetailStockLedgerReport(DateTime FromDate, DateTime ToDate, int? ItemId, int selectedStoreId)
        //{
        //    //var uptoDateTimeStr = UpToDate.ToString("yyyy-MM-dd");
        //    var Data = Database.SqlQuery<DetailStockLedgerModel>("exec SP_Report_Inventory_DetailedStockLedger @FromDate,@ToDate,@ItemId,@StoreId",
        //    new SqlParameter("@FromDate", FromDate),
        //    new SqlParameter("@ToDate", ToDate),
        //    new SqlParameter("@ItemId", (Object)ItemId ?? DBNull.Value),
        //    new SqlParameter("@StoreId", selectedStoreId)
        //    ).ToList();

        //    return Data.ToList<DetailStockLedgerModel>();


        //}
        #endregion
        #region Quotion Rates report
        public DataTable QuotationRatesReport(int PurchaseOrderId)
        {
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("@PurchaseOrderId", PurchaseOrderId)
            };
            foreach (SqlParameter parameter in paramList)
            {
                if (parameter.Value == null)
                {
                    parameter.Value = "";
                }
            }
            var Data = DALFunctions.GetDataTableFromStoredProc("SP_Report_Quotation_Rates", paramList, this);
            return Data;
        }
        #endregion
        public List<ApprovedMaterialStockRegisterModel> ApprovedMaterialStockRegisterReport(DateTime FromDate, DateTime ToDate)
        {
            var phrmInvoice = new List<ApprovedMaterialStockRegisterModel>();

            using (var connection = Database.GetDbConnection() as SqlConnection)
            {
                if (connection != null)
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "SP_Report_Inventory_FixedAssets";
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@FromDate", FromDate);
                        command.Parameters.AddWithValue("@ToDate", ToDate);
                        //command.Parameters.AddWithValue("@LogType", LogType);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var phrmDetail = new ApprovedMaterialStockRegisterModel
                                {

                                    // Map properties from reader to your custom model
                                    // e.g., PropertyName = reader.GetDataType(columnIndex)
                                };

                                phrmInvoice.Add(phrmDetail);
                            }
                        }
                    }
                }
            }

            return phrmInvoice;
        }
        //public List<ApprovedMaterialStockRegisterModel> ApprovedMaterialStockRegisterReport(DateTime FromDate, DateTime ToDate)
        //{
        //    var Data = Database.SqlQuery<ApprovedMaterialStockRegisterModel>("exec SP_Report_Inventory_FixedAssets @FromDate,@ToDate",
        //    new SqlParameter("@FromDate", FromDate),
        //    new SqlParameter("@ToDate", ToDate)
        //    ).ToList();
        //    return Data.ToList<ApprovedMaterialStockRegisterModel>();
        //}
        #region DispatchDetail

        public List<DispatchDetailModel> DispatchDetail(int dispatchId)
        {
            var phrmInvoice = new List<DispatchDetailModel>();

            using (var connection = Database.GetDbConnection() as SqlConnection)
            {
                if (connection != null)
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "SP_Report_Inventory_FixedAssets";
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@DispatchId", dispatchId);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var phrmDetail = new DispatchDetailModel
                                {

                                    // Map properties from reader to your custom model
                                    // e.g., PropertyName = reader.GetDataType(columnIndex)
                                };

                                phrmInvoice.Add(phrmDetail);
                            }
                        }
                    }
                }
            }

            return phrmInvoice;
        }
        //public List<DispatchDetailModel> DispatchDetail(int dispatchId)
        //{
        //    var Data = Database.SqlQuery<DispatchDetailModel>("exec SP_Report_Dispatch_Details @DispatchId",
        //        new SqlParameter("@DispatchId", dispatchId)).ToList();
        //    return Data.ToList();
        //}
        #endregion

        #region  Vendor Transaction Report
        public DataTable VendorTransactionReport(int? fiscalYearId, int VendorId)
        {
            List<SqlParameter> paramList = new List<SqlParameter>() {
                 new SqlParameter("@fiscalYearId", fiscalYearId),
                new SqlParameter("@VendorId", VendorId),
                 //new SqlParameter("@Status", Status)
            };

            foreach (SqlParameter parameter in paramList)
            {
                if (parameter.Value == null)
                {
                    parameter.Value = "";
                }
            }
            DataTable stockItems = DALFunctions.GetDataTableFromStoredProc("SP_Report_Inventory_VendorTransactionReport", paramList, this);
            return stockItems;
        }
        #endregion

        #region  Vendor Transaction Details
        public DataTable VendorTransactionReportData(int? fiscalYearId, int VendorId)
        {
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("@fiscalYearId", fiscalYearId),
                new SqlParameter("@VendorId", VendorId),
                 //new SqlParameter("@Status", Status)
            };

            foreach (SqlParameter parameter in paramList)
            {
                if (parameter.Value == null)
                {
                    parameter.Value = "";
                }
            }
            DataTable stockItems = DALFunctions.GetDataTableFromStoredProc("SP_Report_Inventory_VendorTransactionDetails", paramList, this);
            return stockItems;
        }
        #endregion

        #region Item Management Detail Report
        public DataTable ItemMgmtDetail()
        {
            DataTable ItmMgmt = DALFunctions.GetDataTableFromStoredProc("SP_Report_Inventory_ItemMgmtDetail", this);
            return ItmMgmt;
        }
        #endregion
        #region SubstoreStockReport


        //public SubstoreReportViewModel SubstoreStockReport(int StoreId, int ItemId)
        //{
        //    SubstoreReportViewModel SubstoreStockReport = new SubstoreReportViewModel();

        //    SubstoreStockReport.InventoryTotal = Database.SqlQuery<SubstoreGetAllModel>("exec SP_Report_Inventory_SubstoreGetAll @StoreId,@ItemId",
        //       new SqlParameter("@StoreId", StoreId),
        //        new SqlParameter("@ItemId", ItemId)).FirstOrDefault();
        //    SubstoreStockReport.InventoryItemTotal = Database.SqlQuery<SubstoreGetAllBasedOnItemIdModel>("exec SP_Report_Inventory_SubstoreGetAllBasedOnItemId @StoreId,@ItemId",
        //       new SqlParameter("@StoreId", StoreId),
        //        new SqlParameter("@ItemId", ItemId)).ToList();
        //    SubstoreStockReport.InventoryStoreTotal = Database.SqlQuery<SubstoreGetAllBasedOnStoreIdModel>("exec SP_Report_Inventory_SubstoreGetAllBasedOnStoreId @StoreId,@ItemId",
        //       new SqlParameter("@StoreId", StoreId),
        //        new SqlParameter("@ItemId", ItemId)).ToList();
        //    return SubstoreStockReport;
        //}
        #endregion
        #region inventory purchase summary report 
        public DataTable InvPurchaseSummaryReport(DateTime FromDate, DateTime ToDate,int VendorId)
        {
            List<SqlParameter> paramList = new List<SqlParameter>() {
                                                                new SqlParameter("@FromDate", FromDate),
                                                                new SqlParameter("@ToDate", ToDate),
                                                                new SqlParameter("@VendorId",VendorId)
                                                                   };
            foreach (SqlParameter parameter in paramList)
            {
                if (parameter.Value == null)
                {
                    parameter.Value = "";
                }
            }
            DataTable purchaseSummaryTbl = DALFunctions.GetDataTableFromStoredProc("SP_Report_Inventory_PurchaseSummary", paramList, this);
            return purchaseSummaryTbl;

        }
        #endregion

        #region inventory purchase return to supplier report 
        //public List<ReturnToVendorItems> ReturnToSupplierReport(DateTime FromDate, DateTime ToDate, object VendorId, object ItemId, object batchNumber, object goodReceiptNumber,object creditNoteNumber)
        //{
        //    var Data = Database.SqlQuery<ReturnToVendorItems>("exec SP_Report_Inventory_ReturnToSupplierReport @FromDate,@ToDate,@VendorId,@ItemId,@batchNumber,@goodReceiptNumber,@creditNoteNumber",
        //    new SqlParameter("@FromDate", FromDate),
        //    new SqlParameter("@ToDate", ToDate),
        //    new SqlParameter("@VendorId", (VendorId != null ? VendorId : DBNull.Value)),
        //    new SqlParameter("@ItemId", (ItemId != null ? ItemId : DBNull.Value)),
        //    new SqlParameter("@batchNumber", (batchNumber != null ? batchNumber : DBNull.Value)),
        //    new SqlParameter("@goodReceiptNumber", (goodReceiptNumber != null ? goodReceiptNumber : DBNull.Value)),
        //    new SqlParameter("@creditNoteNumber", (creditNoteNumber != null ? creditNoteNumber : DBNull.Value))
        //    ).ToList();
        //    return Data.ToList<ReturnToVendorItems>();
        //}
        #endregion

        #region Supplier Wise Stock

        public List<SupplierWiseStockModel> SupplierWiseStockReport(DateTime FromDate, DateTime ToDate, object VendorId, object StoreId, object ItemId)
        {
            var phrmInvoice = new List<SupplierWiseStockModel>();

            using (var connection = Database.GetDbConnection() as SqlConnection)
            {
                if (connection != null)
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "SP_Report_Inventory_SupplierWiseStock";
                        command.CommandType = CommandType.StoredProcedure;
              
                        command.Parameters.AddWithValue("@FromDate", FromDate);
                        command.Parameters.AddWithValue("@ToDate", ToDate);
                        command.Parameters.AddWithValue("@VendorId", (VendorId != null ? VendorId : DBNull.Value));
                        command.Parameters.AddWithValue("@StoreId", (StoreId != null ? StoreId : DBNull.Value));
                        command.Parameters.AddWithValue("@ItemId", (ItemId != null ? ItemId : DBNull.Value));

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var phrmDetail = new SupplierWiseStockModel
                                {

                                    // Map properties from reader to your custom model
                                    // e.g., PropertyName = reader.GetDataType(columnIndex)
                                };

                                phrmInvoice.Add(phrmDetail);
                            }
                        }
                    }
                }
            }

            return phrmInvoice;
        }
        //public List<SupplierWiseStockModel> SupplierWiseStockReport(DateTime FromDate, DateTime ToDate, object VendorId, object StoreId, object ItemId)
        //{
        //    var Data = Database.SqlQuery<SupplierWiseStockModel>("exec SP_Report_Inventory_SupplierWiseStock @FromDate,@ToDate,@VendorId,@StoreId,@ItemId",
        //    new SqlParameter("@FromDate", FromDate),
        //    new SqlParameter("@ToDate", ToDate),
        //    new SqlParameter("@VendorId", (VendorId!= null ? VendorId : DBNull.Value)),
        //    new SqlParameter("@StoreId", (StoreId != null ? StoreId : DBNull.Value)),
        //    new SqlParameter("@ItemId", (ItemId != null ? ItemId : DBNull.Value))
        //    ).ToList();
        //    return Data.ToList<SupplierWiseStockModel>();
        //}
        #endregion
        #region Expiry Item Report        
        public DataTable ExpiryItemReport(int? ItemId, int? StoreId, DateTime FromDate, DateTime ToDate)
        {
            List<SqlParameter> paramList = new List<SqlParameter>()
            {
                new SqlParameter("@ItemId", ItemId),
                 new SqlParameter("@StoreId", StoreId),
                  new SqlParameter("@FromDate", FromDate),
                   new SqlParameter("@ToDate", ToDate)
            };

            DataTable expiryItem = DALFunctions.GetDataTableFromStoredProc("SP_Report_Inventory_ExpiryItemReport", paramList, this);

            return expiryItem;
        }
        #endregion

        #region Supplier Information Report 
        public DataTable INVSupplierInformationReport()
        {
            DataTable doctorRevenue = DALFunctions.GetDataTableFromStoredProc("SP_INVReport_SupplierInfoReport", this);
            return doctorRevenue;
        }
        #endregion
    }

}
