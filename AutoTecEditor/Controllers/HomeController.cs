using System.Linq;
using System.Web.Mvc;
using AutoTecEditor.Models;

namespace AutoTecEditor.Controllers
{
    public class HomeController : AutoTecBaseController
    {
        public ActionResult Index()
        {
            var brandList = AtContext.Brands.Where(p => !string.IsNullOrEmpty(p.Name));
            var model = new IndexViewModel
            {
                Brands = brandList.ToList()
            };
            return View(model);
        }
    }
}