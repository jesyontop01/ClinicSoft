using System;
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
// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ClinicSoft.Controllers
{
    [RequestFormSizeLimit(valueCountLimit: 100000, Order = 1)]
    [DanpheDataFilter()]
    [Route("api/[controller]")]
    public class EmployeeViewController : Controller
    {
        private readonly string config = null;
        public EmployeeViewController(IOptions<MyConfiguration> _config)
        {
            config = _config.Value.Connectionstring;

        }

        public IActionResult UserProfile()
        {
            try
            {
                ViewData["ConnectionString"] = config;
                return View("UserProfile");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IActionResult ChangePassword()
        {
            try
            {
                ViewData["ConnectionString"] = config;
                return View("ChangePassword");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        

        public IActionResult ProfileMain()
        {
            try
            {
                ViewData["ConnectionString"] = config;
                return View("ProfileMain");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IActionResult ChangeProfile()
        {
            try
            {
                ViewData["ConnectionString"] = config;
                return View("ChangeProfile");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
    }
}

