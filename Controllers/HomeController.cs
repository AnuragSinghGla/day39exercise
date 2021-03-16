using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppDay39Exercise1.Models;

namespace WebAppDay39Exercise1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Display()
        {
            List<Emps> emp = new List<Emps>
            {
        new Emps{EId=1,EName="Mohan",EDesign="HR",EDOJ=DateTime.Now},
        new Emps{EId=2,EName="Mohani",EDesign="HR",EDOJ=DateTime.Now},
          new Emps{EId=3,EName="Mohanram",EDesign="HR",EDOJ=DateTime.Now}

};

            return View();
        }
           
        }
    }

