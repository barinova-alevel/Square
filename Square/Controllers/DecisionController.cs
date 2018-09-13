using SquarerLogic.Models;
using SquarerLogic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Square.Controllers
{
    public class DecisionController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Input model)
        {
            ICalculateService service = new CalculateService();
            service.Calculate(model);
            return View(model);
        }
    }
}