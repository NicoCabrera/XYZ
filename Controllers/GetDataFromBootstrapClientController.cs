using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XYZ.Controllers
{
    public class GetDataFromBootstrapClientController : Controller
    {

        public ActionResult DropDownList()
        {
            ViewBag.itemList = GetListItemListForSelectComponent();
            return View();
        }


        private List<SelectListItem> GetListItemListForSelectComponent() {

            List<SelectListItem> list = new List<SelectListItem>()
            {
                new SelectListItem(){
                    Text = "Si",
                    Value = "1"
                },
                new SelectListItem(){
                    Text = "No",
                    Value = "0"
                }
            };

            return list;
        }
    }
}