using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAuthTest.Models
{
    public class DeptModel
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public DeptModel(string deptName, int deptId)
        {

            Name = deptName;
            Id = deptId;
        }
    }
}