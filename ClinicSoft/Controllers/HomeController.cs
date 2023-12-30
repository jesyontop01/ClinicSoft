using ClinicSoft.Core.Configuration;
using ClinicSoft.Models;
using ClinicSoft.Security;
using ClinicSoft.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Diagnostics;

namespace ClinicSoft.Controllers
{
    //[RequestFormSizeLimit(valueCountLimit: 100000, Order = 1)]
    //[Route("~/api/[controller]")]
    public class HomeController : Controller
    {

        private readonly string connString = null;
        public HomeController(IOptions<MyConfiguration> _config)
        {
            connString = _config.Value.Connectionstring;

        }

        public IActionResult Index()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                //Redirect to Login page If user is not login                           
                return RedirectToAction("Login", "Account");

            }
        }
        //move it out of patientcontroller to Maincontroller or something..
        public IActionResult AppMain()
        {
            try
            {
                RbacUser currentUser = HttpContext.Session.Get<RbacUser>("currentuser");
                ViewData["currentuser"] = currentUser;
                //getting only the root level routes for this view.//set getHierarchy = true for AppMain (special condition.)
                ViewData["validroutes"] = RBAC.GetRoutesForUser(currentUser.UserId, getHiearrchy: true);
                var result = RBAC.GetRoutesForUser(currentUser.UserId, getHiearrchy: true);
                foreach (var route in result)
                {
                    Console.WriteLine("This is the routes " + route);
                }
                return View();
            }
            catch (Exception ex)
            {
                //throw ex;
                //Redirect to Login page If user is not login                           
                return RedirectToAction("Login", "Account");
            }
        }
        public IActionResult ChangePassword()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public FileStreamResult GetUserManual()
        {
            FileStream usrManual = new FileStream("wwwroot\\fileuploads\\DanpheEMR_UserManual.pdf", FileMode.Open);
            return new FileStreamResult(usrManual, "application/pdf");
        }


    }
    //public class HomeController : Controller
    //{
    //    private readonly ILogger<HomeController> _logger;

    //    public HomeController(ILogger<HomeController> logger)
    //    {
    //        _logger = logger;
    //    }

    //    public IActionResult Index()
    //    {
    //        return View();
    //    }

    //    public IActionResult Privacy()
    //    {
    //        return View();
    //    }

    //    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    //    public IActionResult Error()
    //    {
    //        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    //    }
    //}
}