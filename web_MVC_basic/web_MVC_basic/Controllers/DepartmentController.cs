using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web_MVC_basic.Models;

namespace web_MVC_basic.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {

            //Employee emp = new Employee
            //{
            //    Name = "Lyleangseng1",
            //    Gender = "F",
            //    City = "PP",
            //    EmployeeID = 22,
            //};
            //List < Employee > le = new List<Employee>();
            //le.Add(emp);

            //Department dep = new Department();
            //dep.Name = "Doctor";
            //dep.ID = 1;
            //dep.Employyes_List = le;

            EmployeeContext employeeContext = new EmployeeContext();
            List<Department> Departments =  employeeContext.departments.ToList();
            return View(Departments);
        }
    }
}