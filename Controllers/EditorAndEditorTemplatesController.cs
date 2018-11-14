using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XYZ.Models;

namespace XYZ.Controllers
{
    public class EditorAndEditorTemplatesController : Controller
    {


        public ActionResult Editor()
        {
            Persona persona = new Persona() { name = "Nicolas", age = 30, birthdate = new DateTime(1988, 05, 04) };
            return View(persona);
        }
    }
}