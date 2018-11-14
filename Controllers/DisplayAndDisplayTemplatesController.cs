using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XYZ.Controllers
{
    public class DisplayAndDisplayTemplatesController : Controller
    {

        public ActionResult Display()
        {
            var rv = true;
            ViewBag.ReturnValue = true;
            return View(rv);
        }
    }
}