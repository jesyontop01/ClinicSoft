﻿using ClinicSoft.CommonTypes;
using ClinicSoft.Core.Configuration;
using ClinicSoft.Security;
using ClinicSoft.ServerModel;
using ClinicSoft.Services;
using ClinicSoft.Services.Dispensary;
using ClinicSoft.Services.FileUpload;
using ClinicSoft.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Data.SqlClient;

namespace ClinicSoft.Controllers.Dispensary
{
    [RequestFormSizeLimit(valueCountLimit: 1000000, Order = 1)]
    [DanpheDataFilter()]
    [Route("clinicsoft/api/[controller]")]
    public class DispensaryController : Controller
    {
        private IDispensaryService _dispensaryService;
        private readonly IOptions<MyConfiguration> configuration;
        private readonly ICustomFileUploadService _customFile;
        public DanpheHTTPResponse<object> responseData = new DanpheHTTPResponse<object>();
        public DispensaryController(IDispensaryService dispensaryService,  IOptions<MyConfiguration> configuration,
            ICustomFileUploadService customFile)
        {
            _dispensaryService = dispensaryService;
            this.configuration = configuration;
            _customFile = customFile;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                responseData.Results = _dispensaryService.GetAllDispensaries();
                responseData.Status = "OK";
            }
            catch (Exception ex)
            {
                responseData.Status = "Failed";
                responseData.ErrorMessage = ex.Message + " exception details:" + ex.ToString();
            }
            return Ok(responseData);
        }
        [HttpGet("GetAllPharmacyStores")]
        public IActionResult GetAllPharmacyStores()
        {
            try
            {
                responseData.Results = _dispensaryService.GetAllPharmacyStores();
                responseData.Status = "OK";
            }
            catch (Exception ex)
            {
                responseData.Status = "Failed";
                responseData.ErrorMessage = ex.Message + " exception details:" + ex.ToString();
            }
            return Ok(responseData);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                responseData.Results = _dispensaryService.GetDispensary(id);
                responseData.Status = "OK";
            }
            catch (Exception ex)
            {
                responseData.Status = "Failed";
                responseData.ErrorMessage = ex.Message + " exception details:" + ex.ToString();
            }
            return Ok(responseData);
        }

        [HttpPost]
        public IActionResult Post([FromBody] PHRMStoreModel value)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                if (value != null)
                {
                    RbacUser currentUser = HttpContext.Session.Get<RbacUser>("currentuser");
                    value.CreatedBy = currentUser.EmployeeId;
                    value.Category = Enums.ENUM_StoreCategory.Dispensary;
                    var dispensaryResponse = _dispensaryService.AddDispensary(value);
                    responseData.Results = dispensaryResponse;
                    responseData.Status = "OK";
                }
            }
            catch (Exception ex)
            {
                responseData.Status = "Failed";
                responseData.ErrorMessage = ex.Message + " exception details:" + ex.ToString();
            }
            return Ok(responseData);
        }
        [HttpPut]
        public IActionResult UpdateDispensary([FromBody] PHRMStoreModel value)
        {
            try
            {
                responseData.Results = _dispensaryService.UpdateDispensary(value);
                responseData.Status = "OK";
            }
            catch (Exception ex)
            {
                responseData.Status = "Failed";
                responseData.ErrorMessage = ex.Message;
            }
            return Ok(responseData);
        }
        [HttpPut("{id}")]
        public IActionResult ActivateDeactivateDispensary(int id)
        {
            try
            {
                responseData.Results = _dispensaryService.ActivateDeactivateDispensary(id);
                responseData.Status = "OK";
            }
            catch (Exception ex)
            {
                responseData.Status = "Failed";
                responseData.ErrorMessage = ex.Message;
            }
            return Ok(responseData);
        }

        [HttpGet("TestFileUpload")]
        public async Task<IActionResult> TestFileUpload()
        {
           
           // var googleDriveServce = new GoogleDriveFileUploadService(configuration);
          var response =  await _customFile.UploadFileAsync("SomeLabReport");
           // var response = googleDriveServce.UploadNewFile("SomeLabReport");
            return Ok(response);
        }
        [HttpGet("TestFileUpdate/{FileId}")]
        public IActionResult TestFileUpload(string FileId)
        {
            //var googleDriveServce = new GoogleDriveFileUploadService(configuration);
            //var response = googleDriveServce.UpdateFileById(FileId, "SomeLabReport");
            var response = _customFile.UploadFileByIdAsync(FileId, "SomeLabReport");
            return Ok(response);
        }

    }
}
