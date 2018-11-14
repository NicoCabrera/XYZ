using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XYZ.Controllers
{
    public class InterviewController : Controller
    {
        // GET: Interview
        public ActionResult Test()
        {
            ViewBag.message = "Hola desde el controlador Entrevista";
            return View();
        }
    }
}