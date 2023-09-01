﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using ClinicSoft.ServerModel.PharmacyModels;
using ClinicSoft.Services.Pharmacy.Rack;
using ClinicSoft.ViewModel.Pharmacy;

namespace ClinicSoft.Controllers.Pharmacy.Dashboard
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class PharmacyDashboardController : Controller
    { 
        public IRackService rackService;
        public PharmacyDashboardController(IRackService _rackService)
        {
            rackService = _rackService;
        }

        // GET: api/pharmacyRack
        [HttpGet]
        //[Produces("application/json")]  // this always force to json format
        public IActionResult GetAll()
        {
            return Ok(rackService.ListRack());
        }

        // GET api/pharmacyRack/id
        //[HttpGet("{id:int}")]     //  to route only id is int
        //[HttpGet("{id = 231}")]   // assign default value if value of id is not provided
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(rackService.GetRack(id));
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]PHRMRackModel value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(rackService.AddRack(value));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]RackViewModel value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            value.RackId = id;
            rackService.UpdateRack(value);
            return Ok(rackService.GetRack(id));

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            rackService.DeleteRack(id);
        }

        //[HttpGet("~/clinicsoft/api/GetParentRack")]
        //public IActionResult GetParentRackList()
        //{
        //    return Ok(rackService.GetParentRack());
        //}

        //[HttpGet("~/clinicsoft/api/GetDrugList/{rackId}")]
        //public IActionResult GetDrugList(int rackId)
        //{
        //    return Ok(rackService.GetDrugList(rackId));
        //}
    }
}
