using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult FormLogin()
        {
            clsStudent s;
           
            clsMain M = new clsMain();
            List<clsStudent> ls = new List<clsStudent>();
            s = new clsStudent();
                s.SID = 1; //set
                s.Name = "lyleangseng";
                s.Gender = "female";
            ls.Add(s);

            //int a = s.SID; //read data 
            s.SID = 2;
            s.Name = "ahjaleang";
            s.Gender = "F";
            ls.Add(s);

        
            s.SID = 2;
            s.Name = "ahjaleang";
            s.Gender = "F";
            ls.Add(s);


            List<clsPerson> lp = new List<clsPerson>();
            clsPerson p;
            p = new clsPerson();
            p.PID = 10;
            p.Pname = "lylaxa";
            p.Age = 20;

            lp.Add(p);
            M.student = ls;
            M.person = lp;

            return View(M); //send list to view for display 
        }
    }
}
