using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using MVCAuthTest.Models;
namespace MVCAuthTest
{
    public class MyRoleProvider:RoleProvider
    {
        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override string ApplicationName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetRolesForUser(string username)
        {

            string[] roles = new string[1] { "" };
            List<UserModel> lUser = new List<UserModel>();
            lUser.Add(new UserModel(0, "Ahmet", "123456", "A"));
            lUser.Add(new UserModel(1, "Mehmet", "123456", "A"));
            lUser.Add(new UserModel(2, "Ali", "123456", "V"));
            lUser.Add(new UserModel(3, "Derya", "123456", "V"));
            lUser.Add(new UserModel(4, "Hilal", "123456", "V"));
            foreach (var u in lUser){
             if (u.Name == username) {            
                 roles[0] =  u.Role ;              
              }
            }
            return roles;         
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}