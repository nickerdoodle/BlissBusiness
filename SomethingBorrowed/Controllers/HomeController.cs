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

        [Authorize]
        public ActionResult Index()
        {
            IEnumerable<Login> user =
                db.Database.SqlQuery<Login>(
            "Select Email,Password,OwnerID" +
            "FROM Login" +
            "Order by Email");

            return View(user);
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

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection form, bool rememberMe = false)
        {
            String email = form["Email Address"].ToString();
            String password = form["Password"].ToString();

            db.Database.SqlQuery<Login>(
            "INSERT INTO Login(Email,Password,OwnerID)" +
            "VALUES('"+email+"', '"+password+"', 3); " );

            FormsAuthentication.SetAuthCookie(email, rememberMe);
            return RedirectToAction("Index", "Home");

        }

    }
}