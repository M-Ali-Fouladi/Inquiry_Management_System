using System;
using System.Linq;
using System.Web.Security;
using CustomMembershipEF.Contexts;
using CustomMembershipEF.Entities;
using CustomMembershipEF.Models;
namespace CustomMembershipEF.Infrastructure
{
    public class CustomRoleProvider : RoleProvider
    {
        UsersContext db = new UsersContext();
        Model1 db2 = new Model1();
        public override bool IsUserInRole(string username, string roleName)
        {
            
            using (var LabEntities = new Models.Model1())
            {
                var user = LabEntities.tbl_Admin.SingleOrDefault(u => u.AdminUserName == username);
                if (user == null)
                    return false;

                tbl_Admin ur = db2.tbl_Admin.Where(q => q.AdminID == user.AdminID).Select(q => q).FirstOrDefault();
                return ur != null && db2.tbl_Admin.Where(q => q.GroupID == user.GroupID).Select(u => u.tbl_AdminGroup).Any(r => r.GroupName == roleName);
            }
        }

        public override string[] GetRolesForUser(string username)
        {
           
                var user = db2.tbl_Admin.SingleOrDefault(u => u.AdminUserName == username);
                if (user == null)
                    return new string[]{};
                tbl_Admin ur = db2.tbl_Admin.Where(q => q.AdminID == user.AdminID).Select(q => q).FirstOrDefault();

                return ur == null ? new string[] { } : db2.tbl_Admin.Where(q=>q.AdminID==user.AdminID).Select(u => u.tbl_AdminGroup).Select(u => u.GroupName).ToArray();
            
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            using (var Labcontext = new Models.Model1())
            {
                return Labcontext.tbl_AdminGroup.Select(r => r.GroupName).ToArray();
            }
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string ApplicationName { get; set; }
        
    }
}