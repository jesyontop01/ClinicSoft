using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicSoft.Controllers.Emergency
{
    
    public class EmergencyViewController : Controller
    {
        public IActionResult EmergencyMain()
        {
            try
            {
                return View("~/Views/EmergencyView/EmergencyMain.cshtml");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}