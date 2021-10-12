using _11_Auth_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace _11_Auth_MVC.Controllers
{
    public class UserController : Controller
    {
       
        Db obj = new Db();
        // GET: SignUp
        public ActionResult Index()
        {
            return View();

        }


        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(Signup model)
        {
            Signup s = new Signup();
            s.Name = model.Name;
            s.Email = model.Email;
            s.CurrentPassword = model.CurrentPassword;
            s.ComparedPassword = model.ComparedPassword;
            obj.Signups.Add(s);
            obj.SaveChanges();
            return RedirectToAction("Login");
        }
        public ActionResult Login()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Login(Signup model)
        {
            Signup s = obj.Signups.Where(a => a.Email.Equals(model.Email) && a.CurrentPassword.Equals(model.CurrentPassword)).SingleOrDefault();
            if (s != null)
            {
                //HttpCookie hc1 = new HttpCookie("UserID", s.Id.ToString());
                //Response.Cookies.Add(hc1);
                //HttpCookie hc2 = new HttpCookie("UserEmail", s.Email.ToString());
                //Response.Cookies.Add(hc2);
                //Response.Cookies["UserID"].Value = s.Id.ToString();
                //Response.Cookies["UserEmail"].Value = s.Email.ToString();
                //HttpCookie hc1 = new HttpCookie("UserID", s.Id.ToString());
                //hc1.Expires = DateTime.Now.AddSeconds(10);
                //Response.Cookies.Add(hc1);
                //HttpCookie hc2 = new HttpCookie("UserEmail", s.Email.ToString());
                //hc2.Expires = DateTime.Now.AddSeconds(10);
                // Response.Cookies.Add(hc2);


                Session["UserID"] = s.Email.ToString();
                Session["UserEmail"] = s.Email.ToString();
                return RedirectToAction("UserDashboard");

            }


            return View();

        }
        public ActionResult UserDashboard()
        {
            return View();
        }

        public ActionResult Logout()
        {

            Session.Abandon();
            FormsAuthentication.SignOut();

            return RedirectToAction("Login");
        }
    }
}