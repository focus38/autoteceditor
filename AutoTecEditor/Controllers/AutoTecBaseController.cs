using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoTecEditor.DAL;

namespace AutoTecEditor.Controllers
{
    public class AutoTecBaseController : Controller
    {
        protected AutoTecContext AtContext = new AutoTecContext();
    }
}