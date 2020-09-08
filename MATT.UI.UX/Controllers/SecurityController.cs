using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MATT.UI.UX.Controllers
{
    public class SecurityController : Controller
    {
        // GET: Security
        public ActionResult AddUser()
        {
            return View();
        }

        public ActionResult UsersList()
        {
            return View();
        }
        public ActionResult ChangePassword()
        {
            return View();
        }
    }
}