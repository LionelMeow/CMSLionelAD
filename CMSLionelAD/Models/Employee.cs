using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CMSLionelAD.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }

        [Required]
        public string EmployeeName { get; set; }

        [Required]
        public string EmployeePassword { get; set; }
    }
}