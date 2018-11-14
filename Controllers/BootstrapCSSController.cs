using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XYZ.Models;

namespace XYZ.Controllers
{
    public class BootstrapCSSController : Controller
    {

        public ActionResult Buttons() {

            return View();
        }

        public ActionResult Tables() {

            List<Persona> people = new List<Persona>() {
                new Persona() { age = 24, name= "Deku"},
                new Persona() { age = 21, name= "Kacchan"},
                new Persona() { age = 18, name= "Uraraka"},
                new Persona() { age = 30, name= "Midoriya"},
            };

            return View(people);
        }

        public ActionResult GridSystem() {


            return View();
        }


        public ActionResult Forms() {


            return View();
        }

    }
}