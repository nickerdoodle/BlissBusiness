using SomethingBorrowed.DAL;
using SomethingBorrowed.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SomethingBorrowed.Controllers
{
    public class HomeController : Controller
    {
        private BridalContext db = new BridalContext();
        
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

            var currentUser = db.Database.SqlQuery<Login>(
            "Select * " +
            "FROM Login " +
            "WHERE Email = '" + email + "' AND " +
            "Password = '" + password + "'");

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

        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FormCollection form, bool rememberMe = false)
        {
            String email = form["Email Address"].ToString();
            String password = form["Password"].ToString();

            db.Database.ExecuteSqlCommand(
            "INSERT INTO Login(Email,Password)" +
            " VALUES('" + email + "', '" + password + "'); " );

            FormsAuthentication.SetAuthCookie(email, rememberMe);
            return RedirectToAction("Index", "Home");

        }

    }
}