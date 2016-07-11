using System.Linq;
using System.Web.Mvc;
using AutoTecEditor.Models;

namespace AutoTecEditor.Controllers
{
    public class ServicePlanController : AutoTecBaseController
    {
        // GET: ServicePlan
        public ActionResult Index()
        {
            ViewBag.servicePlanDataSource = AtContext.ServicePlanEvents.ToList();
            return View();
        }

        [HttpGet]
        public JsonResult List()
        {
            var res = AtContext.ServicePlanEvents.ToList();
            return Json(res, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Update(ServicePlanEvent value)
        {
            var original = AtContext.ServicePlanEvents.Find(value.Id);

            if (original != null)
            {
                AtContext.Entry(original).CurrentValues.SetValues(value);
                AtContext.SaveChanges();
            }

            ViewBag.dataSource = AtContext.ServicePlanEvents.ToList();
            return View("Index");
        }
        public ActionResult Insert(ServicePlanEvent value)
        {
            AtContext.ServicePlanEvents.Add(value);
            AtContext.SaveChanges();

            ViewBag.dataSource = AtContext.ServicePlanEvents.ToList();
            return View("Index");
        }
        public ActionResult Remove(int key)
        {
            AtContext.ServicePlanEvents.Remove(new ServicePlanEvent { Id = key });
            AtContext.SaveChanges();

            ViewBag.dataSource = AtContext.ServicePlanEvents.ToList();
            return View("Index");
        }
    }
}