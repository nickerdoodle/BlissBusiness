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
        {
            return View();
        }
    }
}