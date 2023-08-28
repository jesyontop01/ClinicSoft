﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Options;
using ClinicSoft.Core.Configuration;
using Microsoft.AspNetCore.Mvc;
using ClinicSoft.DalLayer;
using ClinicSoft.CommonTypes;
using System.Linq;
using System;

using ClinicSoft.ServerModel.InventoryModels.InventoryReportModel;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ClinicSoft.Utilities;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ClinicSoft.ServerModel.ReportingModels;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ClinicSoft.ServerModel.InventoryReportModel;



namespace ClinicSoft.Controllers
{
    public class AssetReportsController : CommonController
    {
        private static IWebHostEnvironment  _environment;
        readonly DanpheHTTPResponse<object> responseData = new DanpheHTTPResponse<object>();
        public AssetReportsController(IWebHostEnvironment  env, IOptions<MyConfiguration> _config) : base(_config)
        {
            _environment = env;
        }

        [HttpGet("GetAllEmployeeList")]
        public IActionResult GetAllEmployeeList()
        {
            try
            {
                var inventoryDbContext = new InventoryDbContext(connString);
                var userList = (from user in inventoryDbContext.Employees
                                join assetholder in inventoryDbContext.AssetLocationHistory on user.EmployeeId equals assetholder.OldAssetHolderId
                                select new
                                {
                                    EmployeeId = user.EmployeeId,
                                    FullName = user.FullName
                                }).Distinct().ToList();
                responseData.Status = "OK";
                responseData.Results = userList;
                return Ok(responseData);
            }
            catch (Exception ex)
            {
                responseData.Status = "Failed";
                responseData.ErrorMessage = ex.ToString();
                return BadRequest(responseData);
            }
        }

        [HttpGet("GetAllDepartments")]
        public IActionResult GetAllDepartments()
        {
            try
            {
                var inventoryDbContext = new InventoryDbContext(connString);
                var departmentsList = (from dep in inventoryDbContext.StoreMasters
                                       where dep.Category == "substore"
                                       select new
                                       {
                                           DepartmentId = dep.StoreId,
                                           DepartmentName = dep.Name
                                       }).ToList();
                responseData.Status = "OK";
                responseData.Results = departmentsList;
                return Ok(responseData);
            }
            catch (Exception ex)
            {
                responseData.Status = "Failed";
                responseData.ErrorMessage = ex.ToString();
                return BadRequest(responseData);
            }
        }

        [HttpGet("GetAllItems")]
        public IActionResult GetAllItems()
        {
            try
            {
                var inventoryDbContext = new InventoryDbContext(connString);
                var departmentsList = (from itm in inventoryDbContext.Items
                                       where itm.ItemType == "Capital Goods"
                                       select new 
                                       {
                                           ItemId = itm.ItemId,
                                           ItemName = itm.ItemName
                                       }).ToList();
                responseData.Status = "OK";
                responseData.Results = departmentsList;
                return Ok(responseData);
            }
            catch (Exception ex)
            {
                responseData.Status = "Failed";
                responseData.ErrorMessage = ex.ToString();
                return BadRequest(responseData);
            }
        }
    }
}
