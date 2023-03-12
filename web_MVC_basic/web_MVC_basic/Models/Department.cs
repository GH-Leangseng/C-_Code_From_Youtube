using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace web_MVC_basic.Models
{
    [Table("Department")]
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Employee> Employyes_List { get; set; }
    }
}