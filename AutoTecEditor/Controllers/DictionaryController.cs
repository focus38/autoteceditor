using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoTecEditor.Models;

namespace AutoTecEditor.Controllers
{
    public class DictionaryController : AutoTecBaseController
    {
        // GET: Dictionary
        public JsonResult GetModifications()
        {
            var modifs = AtContext.Modifications.ToList();
            return Json(modifs, JsonRequestBehavior.AllowGet);
        }
    }
}