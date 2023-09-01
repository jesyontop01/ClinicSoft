using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using ClinicSoft.Core.Configuration;
using ClinicSoft.Security;
using ClinicSoft.Utilities;

namespace ClinicSoft.Controllers
{
    [RequestFormSizeLimit(valueCountLimit: 100000, Order = 1)]
    [DanpheDataFilter()]
    [Route("api/[controller]")]
    public class DashboardViewController : Controller
    {
        private readonly string config = null;
        public DashboardViewController(IOptions<MyConfiguration> _config)
        {
            config = _config.Value.Connectionstring;
        }
        public IActionResult DashBoardStatistics()
        {
            return View();
        }
     

    }
}
