using EveOnlineFittingAssistant_Models;
using EveOnlineFittingAssistant_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EveOnlineFittingAssistant.Controllers
{
    public class ShipController : Controller
    {
        private ShipService CreateShipService()
        {
            var shipService = new ShipService();
            return shipService;
        }
        // GET: Ship
        public ActionResult Index()
        {
            var service = CreateShipService();
            var model = service.GetAllShips();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ShipModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var service = CreateShipService();
            service.Create(model);
            return RedirectToAction("Index");
        }
        public ActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Update( ShipModel model)
        {
            int id = int.Parse(RouteData.Values["id"].ToString());
            if (!ModelState.IsValid) return View(model);
            var service = CreateShipService();
            if (service.UpdateShip(id, model))
            {
                TempData["SaveResult"] = "the module was updated";
                return RedirectToAction("index");
            }
            ModelState.AddModelError("", "the module was not updated.");
            return View(model);
        }
    }
}