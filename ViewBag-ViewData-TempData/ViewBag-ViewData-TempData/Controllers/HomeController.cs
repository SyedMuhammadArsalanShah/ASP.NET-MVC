using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewBag_ViewData_TempData.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult IndexViewBag()
        {
            ViewBag.Namestudent = "Arsalan";

            ViewBag.list = new List<string>() {
            "arsalan", "Mustafa","Shoaib","Azhan","Zaran"
            };
            return View();

        }
        public ActionResult IndexViewData()
        {
            ViewData["Name"] = "Shoaib";

            ViewData["list"] = new List<string>() {
            "arsalan", "Mustafa","Shoaib","Azhan","Zaran"
            };
            return View();
        }

        public ActionResult IndexTempData()
        {
            TempData["Name"] = "Mustafa";

            TempData["list"] = new List<string>() {
            "arsalan", "Mustafa","Shoaib","Azhan","Zaran"
            };


                return View();
            // or you can redirect  with tempdata 

            //  return RedirectToAction("About");

        }
        public ActionResult About()
        {
            TempData["Name"] = "Azhan";



            return View();

        }
    }
}
    
