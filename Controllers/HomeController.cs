using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XYZ.Models;
using XYZ.Services;

namespace XYZ.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Custom() {
            Persona persona = new PersonaService().getPersona();
            return View(persona);
        }



        // ActionResult es la clase base de valores de retorno para las response

        /* https://docs.microsoft.com/en-us/dotnet/api/system.web.mvc.actionresult?view=aspnet-mvc-5.2 */

        public JsonResult JSON() {
            Persona p1 = new Persona() { name = "nicolas", age = 30 };

            return Json(p1, JsonRequestBehavior.AllowGet);
            
        }

        public JavaScriptResult Javascript() {

            return JavaScript("alert('Hola mundo!')");

        }

        public RedirectToRouteResult Redirect() {

            return RedirectToAction("JSON", "Home");
        }

        [HttpPost]
        public JsonResult getJsonByPostRequest() {

            return Json("Hello world");
        }




      
    }
}