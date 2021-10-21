using EveOnlineFittingAssistant_Data;
using EveOnlineFittingAssistant_Models;
using EveOnlineFittingAssistant_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EveOnlineFittingAssistant.Controllers
{
    public class ModuleController : Controller
    {
        private ModuleService CreateModuleService()
        {
            var moduleService = new ModuleService();
            return moduleService;
        }

        // GET: Module
        public ActionResult Index()
        {
            var service = CreateModuleService();
            var model = service.GetAllModules();
            return View(model);
        }
        //create the base module
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ModuleModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var service = CreateModuleService();
            service.CreateModule(model);
            return RedirectToAction("Index");
        }
        //create active
        public ActionResult CreateActive()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateActive(ActiveModuleModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var service = CreateModuleService();
            service.CreateActiveModule(model);
            return RedirectToAction("Index");
        }
        //create weapon
        public ActionResult CreateWeapon()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateWeapon(WeaponModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var service = CreateModuleService();
            service.CreateWeapon(model);
            return RedirectToAction("Index");
        }
        //create repair module
        public ActionResult CreateRepairModule()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateRepairModule(RepairModuleModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var service = CreateModuleService();
            service.CreateRepairModule(model);
            return RedirectToAction("Index");
        }

        public ActionResult UpdateModule()
        {
            return View();
        }
        [HttpPost]
        
        public ActionResult UpdateModule(ModuleModel model) 
        {
            int id = int.Parse(RouteData.Values["id"].ToString());
            model.Id = id;
            var service = CreateModuleService();
            if (service.UpdateModule(id, model))
            {
                TempData["SaveResult"] = "the module was updated";
                return RedirectToAction("index");
            }
            ModelState.AddModelError("", "the module was not updated.");
            return View(model);
        }
        public ActionResult UpdateRepairModule()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UpdateRepairModule(RepairModuleModel model)
        {
            int id = int.Parse(RouteData.Values["id"].ToString());
            var service = CreateModuleService();
            if (service.UpdateRepairModule(id, model))
            {
                TempData["SaveResult"] = "the module was updated";
                return RedirectToAction("index");
            }
            ModelState.AddModelError("", "the module was not updated.");
            return View(model);
        }
        public ActionResult UpdateActiveModule()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UpdateActiveModule(ActiveModuleModel model)
        {
            int id = int.Parse(RouteData.Values["id"].ToString());
            var service = CreateModuleService();
            if (service.UpdateActiveModule(id,model))
            {
                TempData["SaveResult"] = "the module was updated";
                return RedirectToAction("index");
            }
            ModelState.AddModelError("", "the module was not updated.");
            return View(model);
        }
        public ActionResult UpdateWeapon()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UpdateWeapon(WeaponModel model)
        {
            int id = int.Parse(RouteData.Values["id"].ToString());
            var service = CreateModuleService();
            if (service.UpdateWeapon(id, model))
            {
                TempData["SaveResult"] = "the weapon was updated";
                return RedirectToAction("index");
            }
            ModelState.AddModelError("", "the weapon was not updated.");
            return View(model);
        }
    }
}