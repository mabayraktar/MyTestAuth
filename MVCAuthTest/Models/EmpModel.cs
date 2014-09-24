using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAuthTest.Models
{
    public class EmpModel
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Salary { get; set; }

        public EmpModel(string empName, int empId,int empSalary)
        {

            Name = empName;
            Id = empId;
            Salary = empSalary;
        }
    
    }
}