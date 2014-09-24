using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAuthTest.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public User (int uId,string uName, string uRole) { 

         Id = uId;
         Name = uName;
         Role = uRole;

        }
    }
}