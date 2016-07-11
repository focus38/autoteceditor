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
        public JsonResult Modifications()
        {
            var modifs = AtContext.Modifications.ToList();
            return Json(modifs, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult ModificationsView()
        {
            var res = (from m in AtContext.Modifications
                join l in AtContext.Models on m.ModelId equals l.Id
                join b in AtContext.Brands on l.BrandId equals b.Id
                select new
                {
                    m.Id,
                    BrandName = b.Name,
                    ModelName = l.Name,
                    ModifName = m.Name, m.StartProdYear, m.EndProdYear
                }).AsEnumerable().Select(p => new
                {
                    ModificationId = p.Id,
                    ModificationName =
                        $"{p.BrandName} {p.ModelName} ({p.ModifName} {p.StartProdYear} - {p.EndProdYear})"
                });
            return Json(res, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Services()
        {
            var res = AtContext.Services.Select(p => new
            {
                ServiceId = p.Id,
                ServiceName = p.Name
            });
            return Json(res, JsonRequestBehavior.AllowGet);
        }

        public JsonResult WorkTypes()
        {
            var res = AtContext.WorkTypes.Select(p => new
            {
                WorkTypeId = p.Id,
                WorkTypeName = p.Name
            });
            return Json(res, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index()
        {
            var model = new IndexViewModel
            {
                Brands = AtContext.Brands.ToList()
            };
            return View(model);
        }
    }
}