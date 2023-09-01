﻿using System;
using Microsoft.AspNetCore.Mvc;
using ClinicSoft.ServerModel;
using ClinicSoft.Utilities;
using ClinicSoft.CommonTypes;
using ClinicSoft.Services;
using ClinicSoft.Security;

namespace ClinicSoft.Controllers
{
    [Route("api/[controller]")]
    public class FractionCalculationController : Controller
    {

        public IFractionCalculationService _FractionCalculationService;
        public DanpheHTTPResponse<object> responseData = new DanpheHTTPResponse<object>();

        public FractionCalculationController( IFractionCalculationService FractionCalculationService) 
        {
            _FractionCalculationService = FractionCalculationService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {

            try
            {
                responseData.Results = _FractionCalculationService.ListFractionCalculation();
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
                responseData.Results = _FractionCalculationService.GetFractionCalculation(id);
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
        public IActionResult Post([FromBody]FractionCalculationModel[] value)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                RbacUser currentUser = HttpContext.Session.Get<RbacUser>("currentuser");
                //value.CreatedBy = currentUser.EmployeeId;
                //responseData.Results = _FractionCalculationService.GetFractionCalculation(value.FractionCalculationId);
                responseData.Results = _FractionCalculationService.AddFractionCalculation(value);
                responseData.Status = "OK";
            }
            catch (Exception ex)
            {
                responseData.Status = "Failed";
                responseData.ErrorMessage = ex.Message + " exception details:" + ex.ToString();
            }
            return Ok(responseData);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]FractionCalculationModel value)
        {            
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                value.FractionCalculationId = id;
                _FractionCalculationService.UpdateFractionCalculation(value);
                responseData.Results = _FractionCalculationService.GetFractionCalculation(id);
                responseData.Status = "OK";
            }
            catch (Exception ex)
            {
                responseData.Status = "Failed";
                responseData.ErrorMessage = ex.Message + " exception details:" + ex.ToString();
            }
            return Ok(responseData);
        }

        [HttpGet("~/clinicsoft/api/GetFractionTxnList")]
        public IActionResult GetFractionTxnList()
        {
            return Ok(_FractionCalculationService.GetFractionTxnList());
        }
        [HttpGet("~/clinicsoft/api/GetFractionReportByItemList")]
        public IActionResult GetFractionReportByItemList()
        {
            return Ok(_FractionCalculationService.GetFractionReportByItemList());
        }
        [HttpGet("~/clinicsoft/api/GetFractionReportByDoctorList/{FromDate}/{ToDate}")]
        public IActionResult GetFractionReportByDoctorList(DateTime FromDate, DateTime ToDate)
        {
            return Ok(_FractionCalculationService.GetFractionReportByDoctorList(FromDate, ToDate));
        }
    }
}
