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
    }
}