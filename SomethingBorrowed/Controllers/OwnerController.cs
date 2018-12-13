using SomethingBorrowed.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SomethingBorrowed.Controllers
{
    public class OwnerController : Controller
    {
        private BridalContext db = new BridalContext();

        // GET: Owner
        public ActionResult Index()
        {
            return View(db.Owners.ToList());
        }
    }
}