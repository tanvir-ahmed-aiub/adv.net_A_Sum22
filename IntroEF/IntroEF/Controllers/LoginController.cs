using IntroEF.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace IntroEF.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Customer c)
        {
            var db = new ProductDB_sm22Entities();
            var user = (from e in db.Customers
                        where e.Mobile.Equals(c.Mobile) &&
                        e.Password.Equals(c.Password)
                        select e).SingleOrDefault();
            if (user != null) {
                FormsAuthentication.SetAuthCookie("data", true);
                //Session["user_mobile"] = user.Mobile;
                return RedirectToAction("Index", "Home");
            }
            TempData["Msg"] = "Username and Password is invalid";
            return View();

        }
        public ActionResult Logout() {
            Session.Remove("user_mobile");
            Session.RemoveAll();
            return RedirectToAction("Index");
        }

    }
}