using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MATT.UI.UX.Controllers
{
    public class ProspectController : Controller
    {
        // GET: Prospect
        public ActionResult ProsPects()
        {
            return View();
        }

        public ActionResult Summary()
        {
            return View();
        }
    }
}