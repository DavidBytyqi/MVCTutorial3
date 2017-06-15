using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTutorial3.Models
{
    public class EmployeeViewModel
    {

        public int EmployeeId { get; set; }
        public string Emri { get; set; }
        public int DepartmentId { get; set; }
        public string Address { get; set; }
        public string DepartmentName { get; set; }

        public virtual Department Department { get; set; }
    }
}