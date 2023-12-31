﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using ClinicSoft.Core.Configuration;
using ClinicSoft.ServerModel;
using ClinicSoft.DalLayer;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;
using ClinicSoft.Utilities;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Http.Features;
using ClinicSoft.CommonTypes;
// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860
//this is the cotroller
namespace ClinicSoft.Controllers
{

    [RequestFormSizeLimit(valueCountLimit: 100000, Order = 1)]
    [Route("api/[controller]")]
    public class DashboardController : CommonController
    {
        // GET: api/values
        private readonly string config = null;
        public DashboardController(IOptions<MyConfiguration> _config) : base(_config)
        {
            config = _config.Value.Connectionstring;
        }




        [HttpGet]
        public string Get(int patientId, int patientVisitId)
        {
            DanpheHTTPResponse<object> responseData = new DanpheHTTPResponse<object>();
            try
            {

                responseData.Status = "OK";
                responseData.Results = "Not implemented";


            }
            catch (Exception ex)
            {
                responseData.Status = "Failed";
                responseData.ErrorMessage = ex.Message + " exception details:" + ex.ToString();
            }

            return DanpheJSONConvert.SerializeObject(responseData, true);


        }
        [HttpPost]
        public PatientModel Post()
        {

            return null;
        }

        [HttpPut]
        public PatientModel Put(int patientId)
        {

            return null;

        }
        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
