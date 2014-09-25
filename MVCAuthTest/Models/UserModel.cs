using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAuthTest.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public UserModel (int uId,string uName, string uPass,string uRole) { 

         Id = uId;
         Name = uName;
         Password = uPass;
         Role = uRole;

        }
        public UserModel(int uId, string uName, string uPass)
        {

            Id = uId;
            Name = uName;
            Password = uPass;
            Role = "";
        }
    }
}