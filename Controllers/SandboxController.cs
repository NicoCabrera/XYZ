using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XYZ.Models;

namespace XYZ.Controllers
{
    public class SandboxController : Controller
    {
        // GET: Sandbox
        public ActionResult Links()
        {
            return View();
        }

        public ActionResult ItemsViewer() {

            List<Persona> people = new List<Persona>() {
                new Persona() { age = 24, name= "Deku"},
                new Persona() { age = 21, name= "Kacchan"},
                new Persona() { age = 18, name= "Uraraka"},
                new Persona() { age = 30, name= "Midoriya"},
            };

            return View(people);
        }
    }
}