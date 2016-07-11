using System.Linq;
using System.Web.Mvc;
using AutoTecEditor.Models;

namespace AutoTecEditor.Controllers
{
    public class BrandsController : AutoTecBaseController
    {
        // GET: Brands
        public ActionResult Index()
        {
            ViewBag.brandDataSource = AtContext.Brands.ToList();
            return View();
        }

        [HttpGet]
        public JsonResult List()
        {
            var res = AtContext.Brands.ToList();
            return Json(res, JsonRequestBehavior.AllowGet);
        }


        public ActionResult Update(Brand value)
        {
            var original = AtContext.Brands.Find(value.Id);

            if (original != null)
            {
                AtContext.Entry(original).CurrentValues.SetValues(value);
                AtContext.SaveChanges();
            }

            ViewBag.dataSource = AtContext.Brands.ToList();
            return View("Index");
        }
        public ActionResult Insert(Brand value)
        {
            AtContext.Brands.Add(value);
            AtContext.SaveChanges();

            ViewBag.dataSource = AtContext.Brands.ToList();
            return View("Index");
        }
        public ActionResult Remove(int key)
        {
            AtContext.Brands.Remove(new Brand {Id = key});
            AtContext.SaveChanges();

            ViewBag.dataSource = AtContext.Brands.ToList();
            return View("Index");
        }
    }
}
