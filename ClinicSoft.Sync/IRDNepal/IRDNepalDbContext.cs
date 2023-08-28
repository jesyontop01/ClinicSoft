﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicSoft.Sync.IRDNepal.Models;
using ClinicSoft.ServerModel;
using Microsoft.EntityFrameworkCore;

namespace ClinicSoft.Sync.IRDNepal
{
    class IRDNepalDbContext : DbContext
    {
        private readonly string connStr;
        public IRDNepalDbContext(string conn) 
        {
            connStr = conn;
            //this.Configuration.LazyLoadingEnabled = true;
            //this.Configuration.ProxyCreationEnabled = false;
        }


        //public DbSet<IRD_Common_InvoiceModel> IrdCommonInvoiceSets { get; set; }
        public DbSet<BillingTransactionModel> BillingTransactions { get; set; }
        public DbSet<BillInvoiceReturnModel> BillInvoiceReturns { get; set; }
        public DbSet<PatientModel> Patients { get; set; }
        public DbSet<BillingFiscalYear> BillingFiscalYears { get; set; }
        public DbSet<TaxModel> Taxes { get; set; }
        public DbSet<IRDLogModel> IRDLog { get; set; }
        public DbSet<PHRMInvoiceTransactionModel> PhrmInvoiceSale { get; set; }
        public DbSet<PHRMInvoiceReturnItemsModel> PhrmInvoiceReturnItems { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<IRD_Common_InvoiceModel>().ToTable("IRD_Sync_Invoices_Common");
            modelBuilder.Entity<BillingTransactionModel>().ToTable("BIL_TXN_BillingTransaction");
            modelBuilder.Entity<BillInvoiceReturnModel>().ToTable("BIL_TXN_InvoiceReturn");
            modelBuilder.Entity<PatientModel>().ToTable("PAT_Patient");
            modelBuilder.Entity<BillingFiscalYear>().ToTable("BIL_CFG_FiscalYears");
            modelBuilder.Entity<TaxModel>().ToTable("MST_Tax");
            modelBuilder.Entity<IRDLogModel>().ToTable("IRD_Log");
            modelBuilder.Entity<PHRMInvoiceTransactionModel>().ToTable("PHRM_TXN_Invoice");
            modelBuilder.Entity<PHRMInvoiceReturnItemsModel>().ToTable("PHRM_TXN_InvoiceReturnItems");
        }

    }
}
