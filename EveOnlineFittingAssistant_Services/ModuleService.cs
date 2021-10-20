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
            var entity = new Module(module.Slot, module.Powergrid, module.CPU);
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Modules.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public bool CreateActiveModule(ActiveModuleModel module)
        {
            var entity = new ActiveModule(module.Slot, module.Powergrid, module.CPU, module.CycleTime, module?.CapacitorUsage);
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Modules.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public bool CreateRepairModule(RepairModuleModel module)
        {
            var entity = new RepairModule(module.Slot, module.Powergrid, module.CPU, module.CycleTime, module?.CapacitorUsage, module.RepairType, module.RepairAmount);
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Modules.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public bool CreateWeapon(WeaponModel weapon)
        {
            var entity = new Weapon(weapon.Slot, weapon.Powergrid, weapon.CPU, weapon.CycleTime, weapon?.CapacitorUsage, weapon.TypeOfWeapon, weapon.DamageMultiplier);
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
                            IsActiveModule = e.IsActiveModule,
                            IsRepairModule = e.IsRepairModule,
                            IsWeapon = e.IsWeapon
                        }
                    );
                return query.ToArray();
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
                    Powergrid = query.Powergrid,
                    IsActiveModule = query.IsActiveModule,
                    IsRepairModule = query.IsRepairModule,
                    IsWeapon = query.IsWeapon
                };
            }
        }

        public bool UpdateModule(ModuleModel model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Modules.Single(e => e.Id == model.Id);

                entity.Powergrid = model.Powergrid;
                entity.Slot = model.Slot;
                entity.CPU = model.CPU;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool UpdateActiveModule(ActiveModuleModel model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Modules.Single(e => e.Id == model.Id);

                entity.Powergrid = model.Powergrid;
                entity.Slot = model.Slot;
                entity.CPU = model.CPU;
                entity.CycleTime = model.CycleTime;
                entity.CapacitorUsage = model.CapacitorUsage;

                return ctx.SaveChanges() == 1;
            }
        }
        public bool UpdateRepairModule(RepairModuleModel model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Modules.Single(e => e.Id == model.Id);

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
        public bool UpdateWeapon(WeaponModel model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Modules.Single(e => e.Id == model.Id);

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
