using Model_Introduction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Model_Introduction.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
      
            public ActionResult IndexModel()
            {
                Students st = new Students()
                {
                    id = 0,
                    Name = "Arsalan Shah",
                    Cnic = "123456789"
                };


                return View(st);
            }

    }
}