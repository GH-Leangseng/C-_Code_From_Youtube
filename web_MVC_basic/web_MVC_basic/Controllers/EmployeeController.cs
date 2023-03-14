using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web_MVC_basic.Models;

namespace web_MVC_basic.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Details(int id)
        {
            //Set value list
            //List<Employee> lsEmployee = new List<Employee>();
            //lsEmployee.Add(new Employee { City = "Phnom Penh", Name = "hong", Gender = "M", EmployeeID = 1 });
            //lsEmployee.Add(new Employee { City = "Tek", Name = "baby", Gender = "F", EmployeeID = 2 });
            //lsEmployee.Add(new Employee { City = "kompong thom", Name = "sma", Gender = "M", EmployeeID = 3 });
            //lsEmployee.Add(new Employee { City = "Phnom Penh", Name = "Kingkong", Gender = "F", EmployeeID = 4 });
            //lsEmployee.Add(new Employee { City = "KPC", Name = "hengleang", Gender = "M", EmployeeID = 5 });
            //lsEmployee.Add(new Employee { City = "kompong lsoum", Name = "hongMeng", Gender = "F", EmployeeID = 6 });

            EmployeeContext employeeContext = new EmployeeContext();
            Employee emp = employeeContext.Employees.Single(map => map.EmployeeID == id); //select employee with ID 


            return View(emp);
        }
        public ActionResult Index(int departmentId)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<Employee> employees = employeeContext.Employees.Where(emp=>emp.departmentId == departmentId).ToList(); //List 
            return View(employees);
        }
    }
}