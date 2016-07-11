using System.Linq;
using System.Web.Mvc;
using AutoTecEditor.Models;

namespace AutoTecEditor.Controllers
{
    public class ModelsController : AutoTecBaseController
    {
        // GET: Brands
        public ActionResult Index()
        {
            ViewBag.dataSource = AtContext.Models.ToList();
            return View();
        }

        public ActionResult Update(Model value)
        {
            var original = AtContext.Models.Find(value.Id);

            if (original != null)
            {
                AtContext.Entry(original).CurrentValues.SetValues(value);
                AtContext.SaveChanges();
            }

            var data = AtContext.Models.ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Insert(Model value)
        {
            AtContext.Models.Add(value);
            AtContext.SaveChanges();
            var data = AtContext.Models.ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Remove(int key)
        {
            AtContext.Models.Remove(new Model { Id = key});
            AtContext.SaveChanges();
            var data = AtContext.Models.ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}
