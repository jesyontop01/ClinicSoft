using ClinicSoft.Core.Caching;
using ClinicSoft.DalLayer.Models;
using ClinicSoft.DalLayer.ViewModels;
using DocumentFormat.OpenXml.InkML;
using Microsoft.AspNetCore.Routing;
//using ClinicSoft.Security;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace ClinicSoft.Services.Patient
{
    public class PatientService : IPatient, IDisposable
    {
        private readonly ClinicSoftContext _context;
        private static int cacheExpiryMinutes;
        static string Salt = "Danphesalt";
        public PatientService(ClinicSoftContext context, int cacheExpMinutes)
        {

            _context = context;
            cacheExpiryMinutes = cacheExpMinutes;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose resources when needed
            }
        }
        
        public  List<RbacApplication> GetAllApplications()
        {
            List<RbacApplication> retList = (List<RbacApplication>)DanpheCache.Get("RBAC-Apps-All");
            if (retList == null)
            {
                //RbacDbContext dbContext = new RbacDbContext(connStringName);
                retList = _context.RbacApplications.ToList();
                DanpheCache.Add("RBAC-Apps-All", retList, cacheExpiryMinutes);
            }
            return retList;
        }
        public List<RbacUser> GetAllUsers()
        {
            List<RbacUser> retList = (List<RbacUser>)DanpheCache.Get("RBAC-Users-All");
            if (retList == null)
            {
                retList = _context.RbacUsers.ToList();
                DanpheCache.Add("RBAC-Users-All", retList, cacheExpiryMinutes);
            }
            return retList;
        }
        //This method return All Permissions without checking user and other thing
        //It checks cache if list is in chache then it takes from cache else get all permission from db        
        public  List<RbacPermission> GetAllPermissions()
        {
            List<RbacPermission> retList = (List<RbacPermission>)DanpheCache.Get("RBAC-Perms-All");
            if (retList == null)
            {
                //RbacDbContext dbContext = new RbacDbContext(connStringName);
                retList = _context.RbacPermissions.ToList();
                DanpheCache.Add("RBAC-Perms-All", retList, cacheExpiryMinutes);
            }
            return retList;

        }

        //This method returns List of Roles
        public  List<RbacRole> GetAllRoles()
        {
            List<RbacRole> retList = (List<RbacRole>)DanpheCache.Get("RBAC-Roles-All");
            if (retList == null)
            {
                retList = _context.RbacRoles.ToList();
                DanpheCache.Add("RBAC-Roles-All", retList, cacheExpiryMinutes);
            }
            return retList;
        }
        //This method returns all Userand Role mapping
        public  List<RbacMapUserRole> GetAllUserRoleMaps()
        {
            List<RbacMapUserRole> retList = (List<RbacMapUserRole>)DanpheCache.Get("RBAC-UserRoleMaps-All");
            if (retList == null)
            {
                //RbacDbContext dbContext = new RbacDbContext(connStringName);
                retList = _context.RbacMapUserRoles.ToList();
                DanpheCache.Add("RBAC-UserRoleMaps-All", retList, cacheExpiryMinutes);
            }

            return retList;
        }
        //Method return all rolepermission mapping list
        public  List<RbacMapRolePermission> GetAllRolePermissionMaps()
        {
            List<RbacMapRolePermission> retList = (List<RbacMapRolePermission>)DanpheCache.Get("RBAC-RolePermissionMaps-All");
            if (retList == null)
            {
                retList = _context.RbacMapRolePermissions.ToList();
                DanpheCache.Add("RBAC-RolePermissionMaps-All", retList, cacheExpiryMinutes);
            }
            return retList;
        }

        //This get all routes from db
        public  List<RbacRouteConfig> GetAllRoutes()
        {
            List<RbacRouteConfig> retList = (List<RbacRouteConfig>)DanpheCache.Get("RBAC-Routes-All");
            if (retList == null)
            {
                //RbacDbContext dbContext = new RbacDbContext(connStringName);
                retList = _context.RbacRouteConfigs.ToList();
                DanpheCache.Add("RBAC-Routes-All", retList, cacheExpiryMinutes);
            }
            return retList;

        }

        //This get all routes from db
        public  List<RbacRouteConfig> GetAllNewUserRoutes(int landingRouteId)
        {
            List<RbacRouteConfig> retList = (List<RbacRouteConfig>)DanpheCache.Get("RBAC-Routes-All");
            if (retList == null)
            {
                //RbacDbContext dbContext = new RbacDbContext(connStringName);
                retList = _context.RbacRouteConfigs.Where(x => x.RouteId.Equals(landingRouteId)).ToList();
                DanpheCache.Add("RBAC-Routes-All", retList, cacheExpiryMinutes);
            }
            return retList;

        }
        //don't get hidden routes if it's set to false.
        public  List<RbacRouteConfig> GetRoutesForUser(int userId, bool getHiearrchy)
        {
            List<RbacRouteConfig> allRoutes = new List<RbacRouteConfig>();
            List<RoutesModel> allRoutesVm = new List<RoutesModel>();
          var childRouteVm = new RoutesModel();

            List<RbacPermission> userAllPerms = GetUserAllPermissions(userId);
            //allRoutes = (from route in GetAllRoutes()
            //             join perm in userAllPerms
            //             on route.PermissionId equals perm.PermissionId
            //             where route.IsActive == true
            //             select route).Distinct().OrderBy(r => r.DisplaySeq).ToList();
            allRoutes = GetAllRoutes()
                   .Join(userAllPerms,
                         route => route.PermissionId,
                         perm => perm.PermissionId,
                         (route, perm) => new { Route = route, Permission = perm })
                   .Where(rp => rp.Route.IsActive.Value)
                   .Select(rp => rp.Route)
                   .Distinct()
                   .OrderBy(r => r.DisplaySeq)
                   .ToList();

            if (getHiearrchy)
            {
                //don't get hidden routes if it's set to false.
                List<RbacRouteConfig> parentRoutes = allRoutes.Where(a => a.ParentRouteId == null && a.DefaultShow == true).ToList();

                foreach (var route in parentRoutes)
                {
                    childRouteVm.ChildRoutes = GetChildRouteHierarchy(allRoutes, route);
                    //route.ChildRoutes = GetChildRouteHierarchy(allRoutes, route);
                }

                return parentRoutes;
            }
            else
            {
                return allRoutes.ToList();
            }
        }
        //don't get hidden routes if it's set to false.


        //don't get hidden routes if it's set to false.
        //public List<RbacRouteConfig> GetRoutesForNewUser(int userId, bool getHiearrchy)
        //{
        //    List<RbacRouteConfig> allRoutes = new List<RbacRouteConfig>();

        //    List<RbacPermission> userAllPerms = GetUserAllPermissions(userId);
        //    allRoutes = (from route in GetAllRoutes()
        //                 join perm in userAllPerms
        //                 on route.PermissionId equals perm.PermissionId
        //                 where route.IsActive == true
        //                 select route).Distinct().OrderBy(r => r.DisplaySeq).ToList();

        //    if (getHiearrchy)
        //    {
        //        //don't get hidden routes if it's set to false.
        //        List<RbacRouteConfig> parentRoutes = allRoutes.Where(a => a.ParentRouteId == null && a.DefaultShow == true).ToList();

        //        foreach (var route in parentRoutes)
        //        {
        //            route.ChildRoutes = GetChildRouteHierarchy(allRoutes, route);
        //        }

        //        return parentRoutes;
        //    }
        //    else
        //    {
        //        return allRoutes.ToList();
        //    }
        //}
        public List<RoutesModel> GetRoutesForNewUser(int userId, bool getHierarchy)
        {
            List<RbacRouteConfig> allRoutes = new List<RbacRouteConfig>();
            List<RoutesModel> allRoutesVm = new List<RoutesModel>();

            List<RbacPermission> userAllPerms = GetUserAllPermissions(userId);
            allRoutes = (from route in GetAllRoutes()
                         join perm in userAllPerms
                         on route.PermissionId equals perm.PermissionId
                         where route.IsActive == true
                         select route).Distinct().OrderBy(r => r.DisplaySeq).ToList();

            foreach (var item in allRoutes)
            {
                RoutesModel routesModel = new RoutesModel
                {
                    // Set properties of routesModel using values from 'item'
                    RouteId = item.RouteId,
                    ParentRouteId = item.ParentRouteId,
                    RouterLink = item.RouterLink,
                    DisplayName = item.RouteName,
                    UrlFullPath = item.UrlFullPath,
                    ChildRoutes = GetChildRouteHierarchy(allRoutes, item),
                };

                allRoutesVm.Add(routesModel);
            }

            if (getHierarchy)
            {
                //don't get hidden routes if it's set to false.
                List<RbacRouteConfig> parentRoutes = allRoutes.Where(a => a.ParentRouteId == null && a.DefaultShow == true).ToList();

                foreach (var route in parentRoutes)
                {
                    RoutesModel routesModel = new RoutesModel
                    {
                        RouteId = route.RouteId,
                        ChildRoutes = GetChildRouteHierarchy(allRoutes, route),
                    };

                    allRoutesVm.Add(routesModel);
                }

                return allRoutesVm;
            }
            else
            {
                return allRoutesVm;
            }
        }

        //public List<RoutesModel> GetRoutesForNewUser(int userId, bool getHiearrchy)
        //{
        //    List<RbacRouteConfig> allRoutes = new List<RbacRouteConfig>();
        //    List<RoutesModel> allRoutesVm = new List<RoutesModel>();

        //    List<RbacPermission> userAllPerms = GetUserAllPermissions(userId);
        //    allRoutes = (from route in GetAllRoutes()
        //                 join perm in userAllPerms
        //                 on route.PermissionId equals perm.PermissionId
        //                 where route.IsActive == true
        //                 select route).Distinct().OrderBy(r => r.DisplaySeq).ToList();
        //    foreach (var item in allRoutes)
        //    {
        //        RoutesModel routesModel = new RoutesModel
        //        {
        //            // Set properties of routesModel using values from 'item'
        //            RouteId = item.RouteId,
        //            ParentRouteId = item.ParentRouteId,
        //            RouterLink = item.RouterLink,
        //            DisplayName = item.RouteName,
        //            UrlFullPath = item.UrlFullPath,
        //            ChildRoutes = GetChildRouteHierarchy(allRoutes, item),
        //        };

        //        allRoutesVm.Add(routesModel);
        //    }
        //    if (getHiearrchy)
        //    {
        //        //don't get hidden routes if it's set to false.
        //        List<RbacRouteConfig> parentRoutes = allRoutes.Where(a => a.ParentRouteId == null && a.DefaultShow == true).ToList();

        //        foreach (var route in parentRoutes)
        //        {
        //            RoutesModel routesModel = new RoutesModel
        //            {
        //                RouteId = route.RouteId,
        //             ChildRoutes = GetChildRouteHierarchy(allRoutes, route),

        //            };
        //        }

        //        return parentRoutes;
        //    }
        //    else
        //    {
        //        return allRoutes.ToList();
        //    }
        //}
        //don't get hidden routes if it's set to false.
        //private  List<RbacRouteConfig> GetChildRouteHierarchy(List<RbacRouteConfig> searchList, RbacRouteConfig route)
        //{
        //    List<RoutesModel> allRoutesVm = new List<RoutesModel>();

        //    //don't get hidden routes if it's set to false.
        //    List<RbacRouteConfig> childRoutes = searchList.Where(a => a.ParentRouteId == route.RouteId).Distinct().ToList();
        //    if (childRoutes == null || childRoutes.Count == 0)
        //    {
        //        return null;
        //    }

        //    foreach (var item in childRoutes)
        //    {
        //        item.ChildRoutes = GetChildRouteHierarchy(searchList, item);
        //    }

        //    return childRoutes;
        //}
        private List<RoutesModel> GetChildRouteHierarchy(List<RbacRouteConfig> searchList, RbacRouteConfig route)
        {
            List<RoutesModel> allRoutesVm = new List<RoutesModel>();

            //don't get hidden routes if it's set to false.
           var childRoutes = searchList.Where(a => a.ParentRouteId == route.RouteId).Distinct().ToList();
            foreach (var item in childRoutes)
            {
                RoutesModel routesModel = new RoutesModel
                {
                    // Set properties of routesModel using values from 'item'
                    RouteId = item.RouteId,
                    ParentRouteId = item.ParentRouteId,
                    RouterLink = item.RouterLink,
                    DisplayName = item.RouteName,
                    UrlFullPath = item.UrlFullPath,
                    ChildRoutes = GetChildRouteHierarchy(searchList, item),
                 };
            
                allRoutesVm.Add(routesModel);
             }
                if (childRoutes == null || childRoutes.Count == 0)
            {
                return null;
            }

          

            return allRoutesVm;
        }
        public  bool IsValidUser(string userName, string password)
        {
            var email = userName.Split('@')[0];
            //username is not case-sensitive but password is
            List<RbacUser> allUsrs = GetAllUsers();
            RbacUser usr = allUsrs.Where(a => a.UserName.ToLower() == userName.ToLower() || a.UserName == email && a.Password == a.Password)
                           .Select(a => a).FirstOrDefault();
            if (usr != null)
                return true;
            else
                return false;
        }
        public  RbacUser GetUser(string userName, string password)
        {
            var email = userName.Split('@')[0];
            //username is not case-sensitive but password is
            List<RbacUser> allUsrs = GetAllUsers();
            RbacUser usr = allUsrs.Where(a => a.UserName.ToLower() == userName.ToLower() || a.UserName == email && a.Password == EncryptPassword(password))
                          .Select(a => a).FirstOrDefault();
            //sending a clone so that my current object won't be modified outside.
            if (usr != null)
                return (RbacUser)usr.Clone();
            //don't clone if user is null (nullreferenceException)
            else return usr;
        }

        public  RbacUser GetUser(string userName)
        {
            var email = userName.Split('@')[0];
            //username is not case-sensitive but password is
            List<RbacUser> allUsrs = GetAllUsers();
            RbacUser usr = allUsrs.Where(a => a.UserName.ToLower() == userName.ToLower() || a.UserName == email)
                          .Select(a => a).FirstOrDefault();
            //sending a clone so that my current object won't be modified outside.
            if (usr != null)
                return (RbacUser)usr.Clone();
            //don't clone if user is null (nullreferenceException)
            else return usr;
        }
        public  RbacUser GetUser(int userId)
        {
            //username is not case-sensitive but password is
            List<RbacUser> allUsrs = GetAllUsers();
            RbacUser usr = allUsrs.Where(a => a.UserId == userId)
                          .Select(a => a).FirstOrDefault();
            //sending a clone so that my current object won't be modified outside.
            if (usr != null)
                return (RbacUser)usr.Clone();
            //don't clone if user is null (nullreferenceException)
            else return usr;
        }
        public  bool UserHasPermission(int userId, string applicationCode, string permissionName)
        {
            RbacApplication currApplication = GetAllApplications()
                                    .Where(a => a.ApplicationCode == applicationCode).FirstOrDefault();
            if (currApplication != null)
            {
                //filter from all permissions of current user.
                List<RbacPermission> userPerms = (from uPerm in GetUserAllPermissions(userId)
                                                  where uPerm.PermissionName == permissionName
                                                  && uPerm.ApplicationId == currApplication.ApplicationId
                                                  select uPerm).ToList();
                if (userPerms != null && userPerms.Count > 0)
                {
                    return true;
                }
            }
            return false;
        }
        public  bool UserHasPermissionId(int UserId, int PermissionId)
        {
            //filter from all permissions of current user.
            List<RbacPermission> userPermissions = (from userPermission in GetUserAllPermissions(UserId)
                                                    where userPermission.PermissionId == PermissionId
                                                    select userPermission).ToList();
            if (userPermissions != null && userPermissions.Count > 0)
            {
                return true;
            }
            return false;
        }
        public  List<RbacPermission> GetUserAllPermissions(int userId)
        {
            List<RbacPermission> retList = (List<RbacPermission>)DanpheCache.Get("RBAC-UserPermissions-UserId" + userId);
            if (retList == null)
            {
                var isUsrSysAdmin = UserIsSuperAdmin(userId);
                //return all permissions if current user is systemadmin.
                if (isUsrSysAdmin)
                {
                    retList = GetAllPermissions();
                }
                else
                {
                    retList = (from urole in GetAllUserRoleMaps()
                               where urole.UserId == userId && urole.IsActive == true
                               join role in GetAllRoles()
                               on urole.RoleId equals role.RoleId
                               join rolePmap in GetAllRolePermissionMaps()
                               on urole.RoleId equals rolePmap.RoleId
                               join perm in GetAllPermissions()
                                on rolePmap.PermissionId equals perm.PermissionId
                               where rolePmap.IsActive == true
                               //join app in RBAC.GetAllApplications()
                               //on perm.ApplicationId equals app.ApplicationId
                               //where app.IsActive == true
                               select perm).ToList();
                }
                DanpheCache.Add("RBAC-UserPermissions-UserId" + userId, retList, cacheExpiryMinutes);
            }
            return retList;

        }

        public  bool UserIsSuperAdmin(int userId)
        {
            return (from usRole in GetAllUserRoleMaps()
                    where usRole.UserId == userId
                    join role in GetAllRoles()
                    on usRole.RoleId equals role.RoleId
                    where role.IsSysAdmin == true
                    select role).Count() > 0;
        }

        public  bool UserHasRoleId(int UserId, int RoleId)
        {
            //filter from all roles of current user.
            List<RbacRole> userRoles = (from userRole in GetUserAllRoles(UserId)
                                        where userRole.RoleId == RoleId
                                        select userRole).ToList();
            if (userRoles != null && userRoles.Count > 0)
            {
                return true;
            }
            return false;
        }
        public RbacMapUserRole GetUserRoleMap(int userid)
        {
            var result = new RbacMapUserRole();
            if (userid > 0)
            {
                //RbacDbContext rbacDbcontxt = new RbacDbContext(connStringName);

                var resultMap = _context.RbacMapUserRoles.Where(u => u.UserId == userid).FirstOrDefault();
                if (resultMap != null)
                {

                }
                else
                {
                    var results = new RbacMapUserRole();

                    _context.RbacMapUserRoles.Add(result);
                    _context.SaveChanges();
                }
                RbacMapUserRole userRoleMap = new RbacMapUserRole();

            }
            return result;
        }
        public  List<RbacRole> GetUserAllRoles(int userid)
        {
            List<RbacRole> retList = new List<RbacRole>();
            List<RbacRole> allRoles = GetAllRoles();
            List<RbacMapUserRole> allUsrRoleMap = GetAllUserRoleMaps();

            //return only roles which are mapped to this user.
            retList = (from role in allRoles
                       join map in allUsrRoleMap
                       on role.RoleId equals map.RoleId
                       where map.UserId == userid
                       select role).Distinct().ToList();

            if (retList == null || retList.Count == 0)
            {
                return retList;
            }

            return retList;
        }

        public  string GetPermissionNameById( int CurrentVerifiersPermissionId)
        {
            return _context.RbacPermissions.Where(p => p.PermissionId == CurrentVerifiersPermissionId).Select(p => p.PermissionName).FirstOrDefault();
        }
        public  RbacUser UpdateDefaultPasswordOfUser(string userName, string password, string confirmpassword)
        {


            //RbacDbContext rbacDbcontxt = new RbacDbContext(connStringName);
            List<RbacUser> alluser = GetAllUsers();
            RbacUser usr = alluser.Where(a => a.UserName.ToLower() == userName.ToLower() && a.Password == EncryptPassword(password))
                          .Select(a => a).FirstOrDefault();

            ////this condition is for that if user has enter wrong current password 
            if (usr == null)
            {
                return null;
            }
            else
            {
                usr.Password = EncryptPassword(confirmpassword);
                usr.ModifiedOn = DateTime.Now;
                usr.ModifiedBy = usr.EmployeeId;
                usr.NeedsPasswordUpdate = false;
                _context.Entry(usr).State = EntityState.Modified;
                _context.SaveChanges();

                return usr;
            }

        }
        /// <summary>
        /// this method is used for Current inputed password decryption
        /// </summary>

        public  RbacUser CreateUser(RbacUser user)
        {
            //RbacDbContext rbacDbcontxt = new RbacDbContext(connStringName);

            RbacUser result = new RbacUser();
            RbacMapUserRole roleMap = new RbacMapUserRole();

            if (user != null)
            {
                string username = user.Email.Split('@')[0];
                result.EmployeeId = user.EmployeeId;
                result.Email = user.Email;
                result.Password = EncryptPassword(user.Password);
                result.UserName = username;
                result.CreatedOn = DateTime.Now;
                result.IsActive = true;
                result.LandingPageRouteId = user.LandingPageRouteId;
                result.CreatedBy = user.CreatedBy;

                _context.RbacUsers.Add(result);
                _context.SaveChanges();

                var defaultRole = _context.RbacRoles.Where(r => r.RoleName.Equals("User")).FirstOrDefault();

                //if (rbacDbcontxt.SaveChanges() > 0)
                //{
                result = _context.RbacUsers.Where(u => u.Email == user.Email).FirstOrDefault();
                if (defaultRole != null)
                {
                    roleMap.RoleId = defaultRole.RoleId;//assign default user role to a new user
                }

                roleMap.UserId = result.UserId;
                roleMap.IsActive = true;


                //foreach (var item in results.User)
                //{
                //    item.UserId = result.UserId;
                //    item.UserName = result.UserName;
                //    item.CreatedBy = result.CreatedBy; item.CreatedOn = DateTime.Now; item.IsActive = true;
                //}
                roleMap.CreatedBy = user.CreatedBy.Value;
                roleMap.CreatedOn = DateTime.Now;
                //results.User

                _context.RbacMapUserRoles.Add(roleMap);
                _context.SaveChanges();
                //CreateRole(rbacRole, rbacDbcontxt);
                // }

            }


            return result;
        }
        public static string EncryptPassword(string Password)
        {
            string encryptedPwd = string.Empty;
            byte[] data = UTF8Encoding.UTF8.GetBytes(Password);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Salt));
                using (TripleDESCryptoServiceProvider tripdes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripdes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    encryptedPwd = Convert.ToBase64String(results, 0, results.Length);

                }
            }
            return encryptedPwd;
        }


        /// <summary>
        /// this method is used for Current inputed password decryption
        /// </summary>

        public static string DecryptPassword(string Password)
        {
            string decryptedPwd = string.Empty;

            try
            {
                byte[] data = Convert.FromBase64String(Password);

                // Rest of the decryption logic...
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Salt));
                    using (TripleDESCryptoServiceProvider tripdes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform transform = tripdes.CreateDecryptor();
                        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                        decryptedPwd = UTF8Encoding.UTF8.GetString(results);
                    }
                }
            }
            catch (FormatException)
            {
                // The input is not a valid Base64 string
                // Perform alternative processing here if needed
                byte[] bytes = Encoding.UTF8.GetBytes(Password);
                decryptedPwd = Encoding.UTF8.GetString(bytes);
            }

            return decryptedPwd;
        }


        public static string DecryptPasswords(string Password)
        {
            string decryptedPwd = string.Empty;

            try
            {
                byte[] data = Convert.FromBase64String(Password);
                if (data == null)
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(Password);
                    string base64String = Convert.ToBase64String(bytes);
                    data = Convert.FromBase64String(base64String);

                }

                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Salt));
                    using (TripleDESCryptoServiceProvider tripdes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform transform = tripdes.CreateDecryptor();
                        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                        decryptedPwd = UTF8Encoding.UTF8.GetString(results);
                    }
                }
            }
            catch (FormatException ex)
            {

                // Handle the exception when the input is not a valid Base64 string
                // You can log the error or take appropriate action
                Console.WriteLine("Error: Invalid Base64 string.");
                Console.WriteLine(ex.Message);
            }

            return decryptedPwd;
        }

        //public static string DecryptPassword(string Password)
        //{
        //    string decryptedPwd = string.Empty;

        //    byte[] data = Convert.FromBase64String(Password);



        //    using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
        //    {
        //        byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Salt));
        //        using (TripleDESCryptoServiceProvider tripdes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
        //        {
        //            ICryptoTransform transform = tripdes.CreateDecryptor();
        //            byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
        //            decryptedPwd = UTF8Encoding.UTF8.GetString(results);
        //        }
        //    }
        //    return decryptedPwd;
        //}

        /// <summary>
        ///    Adds the given role into RbacRole table.
        /// </summary>
        /// <param name="rbacRole">Expects RbacRole Object</param>
        /// <param name="rbacDbContext">The dbContext used for the request</param>
        /// <returns> return the Role id of the created role.</returns>
        public  int CreateRole(RbacRole rbacRole)
        {
            try
            {
                _context.RbacRoles.Add(rbacRole);
                _context.SaveChanges();
                return rbacRole.RoleId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        ///    Adds the given permission into permission table.
        /// </summary>
        /// <param name="rbacPermission">Expects RBACPermission Object</param>
        /// <param name="rbacDbContext">The dbContext used for the request</param>
        /// <returns> returns the permission id of the created permission.</returns>
        public  int CreatePermission(RbacPermission rbacPermission)
        {
            try
            {
                _context.RbacPermissions.Add(rbacPermission);
                _context.SaveChanges();
                return rbacPermission.PermissionId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ActivateDeactivateRolePermissionMap(RbacMapRolePermission role, Boolean Status, RbacUser currentUser)
        {
            _context.RbacMapRolePermissions.Attach(role);
            _context.Entry(role).State = EntityState.Modified;
            _context.Entry(role).Property(x => x.IsActive).IsModified = true;
            _context.Entry(role).Property(x => x.ModifiedBy).IsModified = true;
            _context.Entry(role).Property(x => x.ModifiedOn).IsModified = true;
            role.IsActive = Status;
            role.ModifiedBy = currentUser.EmployeeId;
            role.ModifiedOn = DateTime.Now;
            _context.SaveChanges();
        }

        /// <summary>
        /// Creates the role permission mapping in the table.
        /// </summary>
        /// <param name="PermissionId">The permission id of the view,button,function etc.</param>
        /// <param name="RoleId">The role id of the role that can access the given permission</param>
        /// <param name="currentUser">The user creating the mapping</param>
        /// <param name="rbacDbContext">The Db context for the request</param>
        public  void MapRoleWithPermission(int PermissionId, int RoleId, RbacUser currentUser)
        {
            //check whether such mapping has been created already and deactivated.
            var MapRolePermission = _context.RbacMapRolePermissions.FirstOrDefault(a => a.PermissionId == PermissionId && a.RoleId == RoleId && a.IsActive == false);
            if (MapRolePermission != null)
            {
                MapRolePermission.IsActive = true;
                MapRolePermission.ModifiedBy = currentUser.EmployeeId;
                MapRolePermission.ModifiedOn = DateTime.Now;
                _context.SaveChanges();
            }
            else
            {
                MapRolePermission = new RbacMapRolePermission();
                MapRolePermission.PermissionId = PermissionId;
                MapRolePermission.RoleId = RoleId;
                MapRolePermission.CreatedBy = currentUser.EmployeeId.Value;
                MapRolePermission.CreatedOn = DateTime.Now;
                MapRolePermission.IsActive = true;
                _context.RbacMapRolePermissions.Add(MapRolePermission);
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Activate/Deactivate Permission
        /// </summary>
        /// <param name="rbacPermission">The Permission on which the action is done</param>
        /// <param name="currentUser">The requesting user</param>
        /// <param name="rbacDbContext">The db context for the request</param>
        public  void ActivateDeactivatePermission(RbacPermission rbacPermission, Boolean Status, RbacUser currentUser)
        {

            try
            {
                _context.RbacPermissions.Attach(rbacPermission);
                _context.Entry(rbacPermission).State = EntityState.Modified;
                _context.Entry(rbacPermission).Property(x => x.IsActive).IsModified = true;
                _context.Entry(rbacPermission).Property(x => x.ModifiedBy).IsModified = true;
                _context.Entry(rbacPermission).Property(x => x.ModifiedOn).IsModified = true;
                rbacPermission.IsActive = Status;
                rbacPermission.ModifiedBy = currentUser.EmployeeId;
                rbacPermission.ModifiedOn = DateTime.Now;
                _context.SaveChanges();

                // also activate all the role permission map of this permission
                List<RbacMapRolePermission> RolePermissionMapList = _context.RbacMapRolePermissions.Where(a => a.PermissionId == rbacPermission.PermissionId).ToList();

                if (RolePermissionMapList.Count() > 0)
                {
                    foreach (RbacMapRolePermission rolePermissionMap in RolePermissionMapList)
                    {
                        ActivateDeactivateRolePermissionMap(rolePermissionMap, Status, currentUser);
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<int> GetAllRoleIdsByPermissionId(int permissionId)
        {
            return _context.RbacMapRolePermissions
                .Where(rpm => rpm.PermissionId.Value == permissionId && rpm.IsActive.Value)
                .Select(rpm => rpm.RoleId.Value)
                .ToList();
        }

        public EmpEmployee GetEmployee(RbacUser user)
        {
            throw new NotImplementedException();
        }
    }
}
