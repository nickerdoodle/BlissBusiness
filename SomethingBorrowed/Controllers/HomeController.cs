using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SomethingBorrowed.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Schedule()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection form, bool rememberMe = false)
        {
            String email = form["Email address"].ToString();
            String password = form["Password"].ToString();

            var currentUser = db.Database.SqlQuery<Users>(
            "Select * " +
            "FROM Users " +
            "WHERE UserID = '" + email + "' AND " +
            "UserPassword = '" + password + "'");

            if (currentUser.Count() > 0)
            {
                FormsAuthentication.SetAuthCookie(email, rememberMe);
                return RedirectToAction("Index", "Home", new { userlogin = email });
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Login(FormCollection form, bool rememberMe = false)
        {
            String email = form["Email address"].ToString();
            String password = form["Password"].ToString();



            //var currentUser = db.Database.SqlQuery<Users>(
            //    "Select * " +
            //    "FROM Users " +
            //    "WHERE UserID = '" + email + "' AND " +
            //    "UserPassword = '" + password + "'");

            //if (currentUser.Count() > 0)
            //{
            //    FormsAuthentication.SetAuthCookie(email, rememberMe);
            //    return RedirectToAction("Index", "Home", new { userlogin = email });
            //}
            //else
            //{
                return View();
            //}
        }

    }
}