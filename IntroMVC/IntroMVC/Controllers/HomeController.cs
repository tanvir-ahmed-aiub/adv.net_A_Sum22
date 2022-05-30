using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Login() {
            ViewBag.University = "AIUB";
            return View();
        }
        public ActionResult Dashboard() {
            ViewBag.Name = "Tanvir Ahmed";
            ViewBag.Id = "12121";
             
            //ViewData["Fname"] = "Tanvir";
           return View();
        }
        public ActionResult About() {
            //return Redirect("/home/dashboard");
            TempData["Msg"] = "Redirected from About";
            return RedirectToAction("Login");  //to redirect /home/login
            //return RedirectToAction("Dashboard", "Profie"); //to redirect /profile/dashboard

        }
    }
}