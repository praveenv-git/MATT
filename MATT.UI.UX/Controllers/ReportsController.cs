using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MATT.UI.UX.Controllers
{
    public class ReportsController : Controller
    {
        // GET: Reports
        public ActionResult AAByInstitution()
        {
            return View();
        }

        public ActionResult AdminUsage()
        { return View(); }

        public ActionResult Appendices()
        {
            return View();
        }
        public ActionResult ArticulationAgreement()
        {
            return View();
        }
        public ActionResult ManualPDFRefresh()
        {
            return View();
        }
    }
}