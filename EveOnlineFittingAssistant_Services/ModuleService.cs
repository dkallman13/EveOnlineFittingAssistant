using EveOnlineFittingAssistant_Data;
using EveOnlineFittingAssistant_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveOnlineFittingAssistant_Services
{
    public class ModuleService
    {
        public bool CreateModule(ModuleModel module)
        {
            var entity = new Module(module.Slot, module.Powergrid, module.CPU, module.Name);
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Modules.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public bool CreateActiveModule(ActiveModuleModel module)
        {
            var entity = new ActiveModule(module.Slot, module.Powergrid, module.CPU, module.Name, module.CycleTime, module?.CapacitorUsage);
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Modules.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public bool CreateRepairModule(RepairModuleModel module)
        {
            var entity = new RepairModule(module.Slot, module.Powergrid, module.CPU, module.Name, module.CycleTime, module?.CapacitorUsage, module.RepairType, module.RepairAmount);
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Modules.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public bool CreateWeapon(WeaponModel weapon)
        {
            var entity = new Weapon(weapon.Slot, weapon.Powergrid, weapon.CPU, weapon.Name, weapon.CycleTime, weapon?.CapacitorUsage, weapon.TypeOfWeapon, weapon.DamageMultiplier);
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Modules.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<ModuleDetails> GetAllModules()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Modules
                    .Select(
                        e =>
                        new ModuleDetails()
                        {
                            ID = e.Id,
                            Slot = e.Slot,
                            CPU = e.CPU,
                            Powergrid = e.Powergrid,
                            Name = e.Name
                        }
                    );
                return query.ToList();
            }
        }
        public ModuleDetails GetModuleById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Modules
                    .Single(
                        e => e.Id == id
                    );
                return new ModuleDetails()
                {
                    ID = query.Id,
                    Slot = query.Slot,
                    CPU = query.CPU,
                    Name = query.Name,
                    Powergrid = query.Powergrid
                };
            }
        }

        public bool UpdateModule(int id, ModuleModel model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Modules.Single(e => e.Id == id);
                entity.Name = model.Name;
                entity.Powergrid = model.Powergrid;
                entity.Slot = model.Slot;
                entity.CPU = model.CPU;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool UpdateActiveModule(int id, ActiveModuleModel model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Modules.Single(e => e.Id == id);
                entity.Name = model.Name;
                entity.Powergrid = model.Powergrid;
                entity.Slot = model.Slot;
                entity.CPU = model.CPU;
                entity.CycleTime = model.CycleTime;
                entity.CapacitorUsage = model.CapacitorUsage;

                return ctx.SaveChanges() == 1;
            }
        }
        public bool UpdateRepairModule(int id, RepairModuleModel model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Modules.Single(e => e.Id == id);
                entity.Name = model.Name;
                entity.Powergrid = model.Powergrid;
                entity.Slot = model.Slot;
                entity.CPU = model.CPU;
                entity.CycleTime = model.CycleTime;
                entity.CapacitorUsage = model.CapacitorUsage;
                entity.RepairAmount = model.RepairAmount;
                entity.RepairType = model.RepairType;

                return ctx.SaveChanges() == 1;
            }
        }
        public bool UpdateWeapon(int id, WeaponModel model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Modules.Single(e => e.Id == id);
                entity.Name = model.Name;
                entity.Powergrid = model.Powergrid;
                entity.Slot = model.Slot;
                entity.CPU = model.CPU;
                entity.CycleTime = model.CycleTime;
                entity.CapacitorUsage = model.CapacitorUsage;
                entity.TypeOfWeapon = model.TypeOfWeapon;
                entity.DamageMultiplier = model.DamageMultiplier;

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
