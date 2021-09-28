using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Traditional_approach_in_MVC_to_get_Table.Models;

namespace Traditional_approach_in_MVC_to_get_Table.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            TraditionalBusinessLayer obj = new TraditionalBusinessLayer();
            List<Student> list = obj.Companies.ToList();
            return View(list);

            return View();
        }
    }
}