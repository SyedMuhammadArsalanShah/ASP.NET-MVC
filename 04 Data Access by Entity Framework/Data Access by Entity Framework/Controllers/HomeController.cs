using Data_Access_by_Entity_Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Data_Access_by_Entity_Framework.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int Id)
        {

            StudentContext obj = new StudentContext();
            Student st = obj.student.Single(x => x.Id==Id);





            return View(st);
        }
    }
}