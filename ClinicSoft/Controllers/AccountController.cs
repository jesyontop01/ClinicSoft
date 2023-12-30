using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
//using ClinicSoft.Security;
using Microsoft.Extensions.Options;
using ClinicSoft.Core.Configuration;
using Microsoft.AspNetCore.Http;
using ClinicSoft.Utilities;
using Newtonsoft.Json;
using ClinicSoft.CommonTypes;
using System.IO;
using ClinicSoft.Core;
using ClinicSoft.Core.Parameters;
//using Audit.WebApi;
using ClinicSoft.ServerModel;
using ClinicSoft.DalLayer;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Google.Apis.Drive.v3.Data;
using ClinicSoft.Services.Patient;
//using ClinicSoft.DalLayer.Models;
using ClinicSoft.Security;

namespace ClinicSoft.Controllers
{
    //IMPORTANT: AccountController shouldn't inherit from CommonController, since in this case, we have to allow anonymous authentication.
    public class AccountController : Controller
    {

        DanpheHTTPResponse<object> responseData = new DanpheHTTPResponse<object>();
        private readonly string connString = null;
        private readonly string connStringAdmin = null;
        private readonly string applicationVersionNum = null;
        const string SessionEmail = "userEmail";
         string SessionRoles = "";
         string SessionLastName = string.Empty;
        //private readonly IPatient _patient;
        public AccountController(IOptions<MyConfiguration> _config)
        {
            connString = _config.Value.Connectionstring;
            connStringAdmin = _config.Value.ConnectionStringAdmin;
            applicationVersionNum = _config.Value.ApplicationVersionNum;
            //_patient = patient;
        }

        public IActionResult LicenseExpired()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        //[AuditApi(EventTypeName = "Login",
        //IncludeHeaders = true, IncludeResponseHeaders = true, IncludeResponseBody = true, IncludeRequestBody = true, IncludeModelState = true)]
        public IActionResult Login(string returnUrl = null)
        {
            setVersionNumber();



            //start: sud:16Jul'19-- If One user is already logged in - (check from session) - Load home index page directly. 
            RbacUser currentUser = HttpContext.Session.Get<RbacUser>("currentuser");
            if (currentUser != null && currentUser.UserId != 0)
            {
                return RedirectToAction("Index", "Home");
            }
            //end: sud:16Jul'19-- If One user is already logged in - (check from session) - Load home index page directly.


            if (!string.IsNullOrEmpty(Request.Cookies["uRef"]))
            {
                SystemAdminDbContext adminDbContext = new SystemAdminDbContext(connStringAdmin);

                var selector = Convert.ToInt64(Request.Cookies["uRef"]);
                var validatorWithSalt = Request.Cookies["uData"] + Request.Cookies["uRef"];
                var hashedValidator = ComputeSha256Hash(validatorWithSalt);

                //To make sure that only one UserId will be selected at a time
                var userIdList = (from sysAuthInfo in adminDbContext.CookieInformation
                                  where sysAuthInfo.Selector == selector
                                  && sysAuthInfo.HashedToken == hashedValidator
                                  select sysAuthInfo.UserId).ToList();


                if (userIdList.Count == 1)
                {
                    RbacUser validUser = RBAC.GetUser(userIdList[0]);
                    LoginViewModel model = new LoginViewModel();
                    model.UserName = validUser.UserName;

                    //seting session for current valid user
                    if (validUser != null)
                    {
                        //Check user status is Active or not, If user is InActive then return to login page
                        if (validUser.IsActive == false)
                        {
                            RemoveRememberMeCookie();
                            RemoveSessionValues();
                            ViewData["status"] = "user-inactive";
                            return View(model);
                        }

                        validUser.Password = "";

                        UpdateRememberMeCookie(selector);
                        SetSessionVariable(validUser);
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    RemoveRememberMeCookie();
                    RemoveSessionValues();
                    return View();
                }
            }




            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        //[AuditApi(EventTypeName = "Login",
        //IncludeHeaders = true, IncludeResponseHeaders = true, IncludeResponseBody = true, IncludeRequestBody = true, IncludeModelState = true)]
        public IActionResult Login(LoginViewModel model)
        {
            //setVersionNumber();
            if (ModelState.IsValid)
            {

                SystemAdminDbContext adminDbContext = new SystemAdminDbContext(connStringAdmin);
                RbacDbContext rbacdbContext = new RbacDbContext(connString);
                RbacUser validUser = new RbacUser();
                var active = AuthenticateUser.AuthLogin(model.UserName, model.Password);// check AD
                var rolesString = string.Empty;

                if (active != null)
                {
                    //if (active.Result.Contains("dvErr"))
                    //{
                    //    ViewData["status"] = "login-failed";
                    //    return View();

                    //}
                    //else
                    //{
                    if (!model.UserName.Contains("@waec.org.ng"))
                    {
                        model.UserName = model.UserName + "@waec.org.ng";
                    }
                    validUser = RBAC.GetUser(model.UserName);
                    //validUser = RBAC.GetUser(model.UserName, model.Password);
                    if (validUser != null)
                    {
                        RbacUser result = new RbacUser();
                        var employeeRc = rbacdbContext.Employees.Where(a => a.Email == model.UserName).FirstOrDefault();
                        if (employeeRc != null && validUser == null)
                        {
                            result.EmployeeId = employeeRc.EmployeeId;
                            string username = employeeRc.Email.Split('@')[0];
                            result.EmployeeId = employeeRc.EmployeeId;
                            result.Email = employeeRc.Email;
                            result.Password = model.Password;
                            result.UserName = username;
                            RBAC.CreateUser(result);
                            validUser = RBAC.GetUser(model.UserName, model.Password);
                             rolesString = string.Join(",", validUser.Roles);
                            if (validUser != null)
                            {
                                if (validUser.LandingPageRouteId == 21)
                                {

                                    HttpContext.Session.SetString(SessionRoles, rolesString);
                                    return View("Index", "Patient");
                                }
                            }
                          

                            HttpContext.Session.SetString(SessionRoles, rolesString);
                            return RedirectToAction("Index", "Home");
                        }
                        else if (employeeRc == null && validUser == null)
                        {
                            ViewData["userEmail"] = model.UserName;
                            HttpContext.Session.SetString(SessionEmail, model.UserName);
                            //var rolesString = string.Join(",", validUser.Roles);

                            //HttpContext.Session.SetString(SessionRoles, rolesString);
                            return RedirectToAction("UpdateProfile", "Account");
                        }
                    }
                    else
                    {
                        ViewData["status"] = "attempt-failed";
                        return View(model);
                    }

                    // }
                }

                LoginInformationModel LoginInfo = new LoginInformationModel();


                //seting session for current valid user
                if (validUser != null)
                {
                    //Check user status is Active or not, If user is InActive then return to login page
                    if (validUser.IsActive == false)
                    {
                        ViewData["status"] = "user-inactive";
                        return View(model);
                    }
                    validUser.Password = "";

                    LoginInfo.EmployeeId = validUser.EmployeeId;
                    LoginInfo.ActionName = "login";
                    LoginInfo.CreatedOn = System.DateTime.Now;
                    LoginInfo.UserName = validUser.UserName;
                    adminDbContext.LoginInformation.Add(LoginInfo);
                    adminDbContext.SaveChanges();
                    if (validUser.Roles.Count > 1)
                    {
                        rolesString = string.Join(",", validUser.Roles.Select(roleName => roleName));

                    }
                    else 
                    {
                        rolesString = validUser.Roles.FirstOrDefault().RoleName; 

                    }


                    SetSessionVariable(validUser);

                    if (model.RememberMe)
                    {
                        DateTime centuryBegin = new DateTime(2001, 1, 1);
                        DateTime currentDate = DateTime.Now;
                        //Generate unique tick to make it a selector
                        long ticksElapsed = currentDate.Ticks - centuryBegin.Ticks;

                        SetRememberMeCookieVariable(ticksElapsed, validUser.UserId);
                    }
                    //var auditScope = this.GetCurrentAuditScope();
                    //if (auditScope != null)
                    //{
                    //    // password = ""
                    //    ((DanpheEMR.Security.LoginViewModel)((Audit.WebApi.AuditEventWebApi)auditScope.Event).Action.ActionParameters["model"]).Password = "";
                    //    // formvariable = null
                    //    ((Audit.WebApi.AuditEventWebApi)auditScope.Event).Action.FormVariables = null;
                    //    // request body URL, replace password with *****
                    //    var url = ((Audit.WebApi.AuditEventWebApi)auditScope.Event).Action.RequestBody.Value;
                    //    Regex yourRegex = new Regex(@"password=([^\&]+)");
                    //    string replacedURL = yourRegex.Replace(url.ToString(), "password=*****");
                    //    ((Audit.WebApi.AuditEventWebApi)auditScope.Event).Action.RequestBody.Value = replacedURL;
                    //}
                    if (validUser != null)
                    {
                        if (validUser.LandingPageRouteId == 21)
                        {
                            
                            HttpContext.Session.SetString("UserRole", rolesString);
                            return RedirectToAction("Index", "Patient");

                        }
                    }
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    LoginInfo.ActionName = "invalid-login-attempt";
                    LoginInfo.EmployeeId = null;
                    LoginInfo.CreatedOn = System.DateTime.Now;
                    LoginInfo.UserName = model.UserName;
                    adminDbContext.LoginInformation.Add(LoginInfo);
                    adminDbContext.SaveChanges();
                }



                ViewData["status"] = "login-failed";
                return View(model);
            }
            //If we got this far, something failed, redisplay form
            return View(model);
        }

        public IActionResult UpdateProfile()
        {
            ViewBag.Email = HttpContext.Session.GetString(SessionEmail);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateProfile(EmployeeProfileVM profileVM)
        {
            RbacDbContext rbacdbContext = new RbacDbContext(connString);

            EmployeeModel newUser = new EmployeeModel();
            var validUser = rbacdbContext.Employees.Where(a => a.EmployeeId == profileVM.EmployeeId).Select(a => a).FirstOrDefault();

            if (validUser == null)
            {
                newUser.FirstName = profileVM.FirstName;
                newUser.LastName = profileVM.LastName;
                newUser.Email = profileVM.Email;
                newUser.LPNo = profileVM.LPNo;
                newUser.Phone = profileVM.Phone;
                newUser.Email = profileVM.Email;
                newUser.CreatedOn = System.DateTime.Now;
                rbacdbContext.Employees.Add(newUser);
                var res = rbacdbContext.SaveChanges();
                var userExist = RBAC.GetUser(profileVM.Email);

                if (res > 0 && userExist == null)
                {
                    RbacUser result = new RbacUser();
                    var createdUser = rbacdbContext.Employees.Where(a => a.Email == profileVM.Email).Select(a => a).FirstOrDefault();
                    var defaultLandingRoute = rbacdbContext.Routes.Where(a => a.DisplayName.Equals("Patient"))
                                                .FirstOrDefault();
                    if (defaultLandingRoute != null)
                    {
                        result.LandingPageRouteId = defaultLandingRoute.RouteId;// set a default user landing page
                    }
                    result.Email = profileVM.Email;
                    result.EmployeeId = createdUser.EmployeeId;
                    result.UserName = profileVM.UserName;
                    result.Password = "user";
                    result.CreatedBy = 1;
                    result.CreatedOn = DateTime.Now;
                    result.IsActive = true;
                    result.EmployeeId = createdUser.EmployeeId;


                    //validUser = rbacdbContext.Employees.Where(a =>a.Email == profileVM.Email).Select(a => a).FirstOrDefault();
                    //if (validUser != null) {
                    //    validUser.EmployeeId

                    //}
                    RBAC.CreateUser(result);
                    return RedirectToAction("Index", "Home");


                }


            }
            return View();
        }
        public IActionResult CreateProfile()
        {

            return View();
        }


        //[HttpPost]
        //[AllowAnonymous]
        //[ValidateAntiForgeryToken]
        //[AuditApi(EventTypeName = "Logout",
        //IncludeHeaders = true, IncludeResponseHeaders = true, IncludeResponseBody = true, IncludeRequestBody = true, IncludeModelState = true)]
        public IActionResult Logout(string returnUrl = null)
        {
            setVersionNumber();
            //HttpContext.Session.Set<RbacUser>("currentuser", null);   
            //Remove all sessin variable values
            SystemAdminDbContext adminDbContext = new SystemAdminDbContext(connStringAdmin);
            RbacUser currentUser = HttpContext.Session.Get<RbacUser>("currentuser");
            LoginInformationModel LoginInfo = new LoginInformationModel();

            //once logged out currentuser gets null, so don't go inside if it's null..
            if (currentUser != null)
            {
                LoginInfo.EmployeeId = currentUser.EmployeeId;
                LoginInfo.UserName = currentUser.UserName;
                LoginInfo.ActionName = "logout";
                LoginInfo.CreatedOn = System.DateTime.Now;
                adminDbContext.LoginInformation.Add(LoginInfo);
                adminDbContext.SaveChanges();
            }



            RemoveRememberMeCookie();
            RemoveSessionValues();
            //HttpContext.Session.Remove("currentuser");
            LoginViewModel newLogin = new LoginViewModel();
            ViewData["status"] = "logout-success";



            return View("Login", newLogin);
        }

        //Action for return to PageNotFound page
        public IActionResult PageNotFound()
        {
            try
            {
                //remove all session variable values
                //RemoveSessionValues();
                LoginViewModel newLogin = new LoginViewModel();
                return View("PageNotFound");
            }
            catch (Exception ex)
            { throw ex; }
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }

        public IActionResult ChangePassword()
        {
            //RbacUser validUser = RBAC.GetUser(chmodel.UserName, chmodel.Password);
            //string str = Request.Form.Keys.First<string>();
            Stream req = Request.Body;
            req.Seek(0, System.IO.SeekOrigin.Begin);
            string str = new StreamReader(req).ReadToEnd();
            ChangePasswordViewModel chmodel = JsonConvert.DeserializeObject<ChangePasswordViewModel>(str);
            RbacUser updatepass = RBAC.UpdateDefaultPasswordOfUser(chmodel.UserName, chmodel.Password, chmodel.ConfirmPassword);

            if (updatepass != null)
            {
                updatepass.NeedsPasswordUpdate = false;

                //Update property for Current Session as well. 
                RbacUser currentUser = HttpContext.Session.Get<RbacUser>("currentuser");
                currentUser.NeedsPasswordUpdate = false;
                HttpContext.Session.Set<RbacUser>("currentuser", currentUser);

                //RemoveRememberMeCookie();
                //RemoveSessionValues();
                responseData.Status = "OK";
                responseData.Results = null; ////Assigning Result to NULL because we Don't have to Show Password of User in Client side (i.e Client Debugging Side)
                var s = Json(DanpheJSONConvert.SerializeObject(responseData, true));

                return s;
            }
            else
            {
                responseData.Status = "Failed";
                responseData.ErrorMessage = "Current Password is Wrong";
                var s = Json(DanpheJSONConvert.SerializeObject(responseData, true));

                return s;
            }

        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult UnAuthorizeAccess(string returnUrl = null)
        {
            return View();
        }

        #region Set all session variable values
        //This method set session variable i.e.current login user, permissions for current login
        public void SetSessionVariable(RbacUser currentValidUser)
        {
            try
            {
                //set currentuser 
                HttpContext.Session.Set<RbacUser>("currentuser", currentValidUser);
                RbacUser currentUser = HttpContext.Session.Get<RbacUser>("currentuser");
                if (currentUser != null)
                {
                    //Get all valid permission for input user                      
                    List<RbacPermission> validPermissionList = RBAC.GetUserAllPermissions(currentUser.UserId).ToList();
                    //List<RbacRole> validRoles = 
                    //Set permission session variable value for logged in user
                    HttpContext.Session.Set<List<RbacPermission>>("validpermissionlist", validPermissionList);

                    //Get all valid permission for input user                      
                    List<RbacRole> validUsrRoles = RBAC.GetUserAllRoles(currentUser.UserId);
                    //List<RbacRole> validRoles = 
                    //Set permission session variable value for logged in user
                    HttpContext.Session.Set<List<RbacRole>>("user-roles", validUsrRoles);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Set Cookie variable values
        public void SetRememberMeCookieVariable(long selector, int userId)
        {
            try
            {
                SystemAdminDbContext sysDbContext = new SystemAdminDbContext(connStringAdmin);

                CookieAuthInfoModel authModel = new CookieAuthInfoModel();

                //Generate unique string associated with selector --called Validator
                Guid gd = Guid.NewGuid();

                string GuidString = Convert.ToBase64String(gd.ToByteArray());
                GuidString = GuidString.Replace("=", "");
                GuidString = GuidString.Replace("+", "");

                //tick is also used as a salt
                var GuidStrWithSalt = GuidString + selector.ToString();

                //generate Hash of the Validator, that can be used as a token
                string msgDigest = ComputeSha256Hash(GuidStrWithSalt);

                authModel.Selector = selector;
                authModel.HashedToken = msgDigest;
                authModel.UserId = userId;
                authModel.Expires = System.DateTime.Now.AddYears(2);

                sysDbContext.CookieInformation.Add(authModel);
                sysDbContext.SaveChanges();

                Response.Cookies.Append("uRef", selector.ToString(),
                    new Microsoft.AspNetCore.Http.CookieOptions
                    {
                        Expires = authModel.Expires
                    });
                Response.Cookies.Append("uData", GuidString, new Microsoft.AspNetCore.Http.CookieOptions
                {
                    Expires = authModel.Expires
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion



        #region Removing all session variables
        //This method remove all session variable values
        //Mostly called when logout user

        public void RemoveSessionValues()
        {
            //it clears all session variable 
            HttpContext.Session.Clear();
            ////Remove currentuser values
            //HttpContext.Session.Remove("currentuser");
            ////Remove All Permission from session variable
            //HttpContext.Session.Remove("validpermissionlist");
            ////Remove all RouteList
            //HttpContext.Session.Remove("validRouteList");
            //HttpContext.Session.Remove("activeBillingCounter");
        }
        #endregion

        #region Removing cookie
        public void RemoveRememberMeCookie()
        {
            Response.Cookies.Delete("uData");
            Response.Cookies.Delete("uRef");
        }
        #endregion

        #region Update cookie
        public void UpdateRememberMeCookie(long selector)
        {
            SystemAdminDbContext sysDbContext = new SystemAdminDbContext(connStringAdmin);

            CookieAuthInfoModel authModel = (from sysAuthInfo in sysDbContext.CookieInformation
                                             where sysAuthInfo.Selector == selector
                                             select sysAuthInfo).FirstOrDefault();


            //Generate unique string associated with selector --called Validator
            Guid gd = Guid.NewGuid();

            string GuidString = Convert.ToBase64String(gd.ToByteArray());
            GuidString = GuidString.Replace("=", "");
            GuidString = GuidString.Replace("+", "");

            //tick is also used as a salt
            var GuidStrWithSalt = GuidString + selector.ToString();

            //generate Hash of the Validator, that can be used as a token
            string msgDigest = ComputeSha256Hash(GuidStrWithSalt);

            authModel.HashedToken = msgDigest;

            sysDbContext.Entry(authModel).Property(x => x.HashedToken).IsModified = true;

            Response.Cookies.Delete("uData");
            Response.Cookies.Append("uData", GuidString, new Microsoft.AspNetCore.Http.CookieOptions
            {
                Expires = authModel.Expires
            });

            sysDbContext.SaveChanges();

        }
        #endregion

        #region create Hash of the Given string
        static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        #endregion

        public void setVersionNumber()
        {
            ViewData["applicationVersionNum"] = applicationVersionNum;
        }


    }
}