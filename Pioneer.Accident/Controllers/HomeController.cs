using Pioneer.Accident.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pioneer.Accident.Controllers
{
    public class HomeController : Controller
    {
        protected AccidentService loanService = AccidentService.Create(Configuration.LiveConnectionString);
        public ActionResult Index()
        {
        
            return View();
        }
    }
}