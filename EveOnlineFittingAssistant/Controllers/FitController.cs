using EveOnlineFittingAssistant_Models;
using EveOnlineFittingAssistant_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EveOnlineFittingAssistant.Controllers
{
    public class FitController : Controller
    {
        private FitService CreateFitService()
        {
            var fitservice = new FitService();
            return fitservice;
        }
        // GET: Fit
        public ActionResult Index()
        {
            var service = CreateFitService();
            var model = service.GetAllFits();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FitModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var service = CreateFitService();
            service.Create(model);
            return RedirectToAction("Index");
        }
        public ActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Update(FitModel model)
        {
            int id = int.Parse(RouteData.Values["id"].ToString());
            if (!ModelState.IsValid) return View(model);
            var service = CreateFitService();
            if (service.UpdateFit(id, model))
            {
                TempData["SaveResult"] = "the module was updated";
                return RedirectToAction("index");
            }
            ModelState.AddModelError("", "the module was not updated.");
            return View(model);
        }
    }
}