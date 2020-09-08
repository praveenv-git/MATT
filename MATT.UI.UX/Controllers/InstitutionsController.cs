using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MATT.UI.UX.Controllers
{
    public class InstitutionsController : Controller
    {
        // GET: Institutions
        public ActionResult InstitutionsList()
        {
            return View();
        }

        public ActionResult NewInstitution()
        {
            return View();
        }
    }
}