using ClinicSoft.DalLayer.Models;
using ClinicSoft.DalLayer.ViewModels;

namespace ClinicSoft.Services.Patient
{
    public interface IPatient
    {
        void ActivateDeactivatePermission(RbacPermission rbacPermission, bool Status, RbacUser currentUser);
        void ActivateDeactivateRolePermissionMap(RbacMapRolePermission role, bool Status, RbacUser currentUser);
        int CreatePermission(RbacPermission rbacPermission);
        int CreateRole(RbacRole rbacRole);
        RbacUser CreateUser(RbacUser user);
        EmpEmployee GetEmployee(RbacUser user);
        List<RbacApplication> GetAllApplications();
        List<RbacRouteConfig> GetAllNewUserRoutes(int landingRouteId);
        List<RbacPermission> GetAllPermissions();
        List<int> GetAllRoleIdsByPermissionId(int permissionId);
        List<RbacMapRolePermission> GetAllRolePermissionMaps();
        List<RbacRole> GetAllRoles();
        List<RbacRouteConfig> GetAllRoutes();
        List<RbacMapUserRole> GetAllUserRoleMaps();
        List<RbacUser> GetAllUsers();
        string GetPermissionNameById(int CurrentVerifiersPermissionId);
        List<RoutesModel> GetRoutesForNewUser(int userId, bool getHierarchy);
        List<RbacRouteConfig> GetRoutesForUser(int userId, bool getHiearrchy);
        RbacUser GetUser(int userId);
        RbacUser GetUser(string userName);
        RbacUser GetUser(string userName, string password);
        List<RbacPermission> GetUserAllPermissions(int userId);
        List<RbacRole> GetUserAllRoles(int userid);
        RbacMapUserRole GetUserRoleMap(int userid);
        bool IsValidUser(string userName, string password);
        void MapRoleWithPermission(int PermissionId, int RoleId, RbacUser currentUser);
        bool UserHasPermission(int userId, string applicationCode, string permissionName);
        bool UserHasPermissionId(int UserId, int PermissionId);
        bool UserHasRoleId(int UserId, int RoleId);
        bool UserIsSuperAdmin(int userId);
    }
}
