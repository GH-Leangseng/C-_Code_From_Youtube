using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace web_MVC_basic.Models
{
    //map with table name tblEmployee in SQL server
    [Table("Employee")] 
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public int departmentId { get; set; }
    }
}