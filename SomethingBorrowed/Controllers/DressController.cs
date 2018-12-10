using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SomethingBorrowed.Controllers
{
    public class DressController : Controller
    {
        // GET: Dress
        public ActionResult Index()
        {
            return View();
        }

<<<<<<< HEAD
        public ActionResult Create()
=======
        public ActionResult CreateNew()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult Details()
        {
            return View();
        }

        public ActionResult Delete()
>>>>>>> 86fd3926a47d73ac6a446d764211e03023633146
        {
            return View();
        }
    }
}