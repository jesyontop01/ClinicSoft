﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using ClinicSoft.Core.Configuration;
using ClinicSoft.Security;
using ClinicSoft.Utilities;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ClinicSoft.Controllers
{
    [RequestFormSizeLimit(valueCountLimit: 100000, Order = 1)]
    [DanpheDataFilter()]
    [Route("api/[controller]")]
    public class BillingViewController : Controller
    {
        private readonly string config = null;
        public BillingViewController(IOptions<MyConfiguration> _config)
        {
            config = _config.Value.Connectionstring;

        }

        // GET: /<controller>/
        [DanpheViewFilter("billing-transaction-view")]
        public IActionResult BillingTransaction()
        {
            try
            {
                ViewData["ConnectionString"] = config;
                return View("BillingTransaction");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [DanpheViewFilter("billing-counteractivate-view")]
        public IActionResult CounterActivate()
        {
            try
            {
                ViewData["ConnectionString"] = config;
                return View("CounterActivate");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [DanpheViewFilter("billing-billorderrequest-view")]
        public IActionResult BillOrderRequest()
        {
            try
            {
                ViewData["ConnectionString"] = config;
                return View("BillOrderRequest");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [DanpheViewFilter("billing-billcancellationrequest-view")]
        public IActionResult BillCancellationRequest()
        {
            try
            {
                ViewData["ConnectionString"] = config;
                return View("BillCancellationRequest");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [DanpheViewFilter("billing-billrequest-view")]
        public IActionResult BillReturnRequest()
        {
            try
            {
                ViewData["ConnectionString"] = config;
                return View("BillReturnRequest");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [DanpheViewFilter("billing-settlements-bill-settlement-view")]
        public IActionResult BillSettlements()
        {
            try
            {
                ViewData["ConnectionString"] = config;
                return View("BillSettlements");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [DanpheViewFilter("billing-transactionitem-view")]
        public IActionResult BillingTransactionItem()
        {
            try
            {
                ViewData["ConnectionString"] = config;
                return View("BillingTransactionItem");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [DanpheViewFilter("billing-unpaidbills-view")]
        public IActionResult UnpaidBills()
        {
            try
            {
                ViewData["ConnectionString"] = config;
                return View("UnpaidBills");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [DanpheViewFilter("billing-duplicatebillprint-view")]
        public IActionResult DuplicateBillPrint()
        {
            try
            {
                ViewData["ConnectionString"] = config;
                return View("DuplicateBillPrint");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [DanpheViewFilter("billing-searchpatient-view")]
        public IActionResult BillingSearchPatient()
        {
            try
            {
                ViewData["ConnectionString"] = config;
                return View("BillingSearchPatient");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //[DanpheViewFilter("billing-deposit-view")]
        //public IActionResult BillingDeposit()
        //{
        //    try
        //    {
        //        ViewData["ConnectionString"] = config;
        //        return View("BillingDeposit");
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        [DanpheViewFilter("billing-receiptprint-view")]
        public IActionResult ReceiptPrint()
        {
            try
            {
                ViewData["ConnectionString"] = config;
                return View("ReceiptPrint");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [DanpheViewFilter("billing-view")]
        public IActionResult Billing()
        {
            try
            {
                return View("Billing");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [DanpheViewFilter("billing-editdoctor-view")]
        public IActionResult EditDoctor()
        {
            try
            {
                ViewData["ConnectionString"] = config;
                return View("EditDoctor");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
