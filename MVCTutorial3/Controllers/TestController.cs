using MVCTutorial3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial3.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {

            MVCTutorial2Entities db = new MVCTutorial2Entities();
            List<Employee> list = db.Employees.ToList();
            EmployeeViewModel em = new EmployeeViewModel();
            List<EmployeeViewModel> employee = list.Select(x => new EmployeeViewModel
            {
               
                Emri = x.Emri,
                EmployeeId=x.EmployeeId
                
            }).ToList();
            return View(employee);
        }
        public ActionResult EmployeeDetail(int EmployeeId)
        {
            MVCTutorial2Entities db = new MVCTutorial2Entities();
            Employee em = db.Employees.SingleOrDefault(x => EmployeeId == x.EmployeeId);
            EmployeeViewModel employee = new EmployeeViewModel();
            employee.Emri = em.Emri;
            employee.EmployeeId = em.EmployeeId;
            employee.Address = em.Address;
            employee.DepartmentId = em.DepartmentId;
            employee.DepartmentName = em.Department.DepartmentName;

            return View(employee);

        }
    }
}