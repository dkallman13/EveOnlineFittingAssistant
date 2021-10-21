using EveOnlineFittingAssistant_Data;
using EveOnlineFittingAssistant_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveOnlineFittingAssistant_Services
{
    public class ShipService
    {
        public bool Create(ShipModel ship)
        {
            var entity = new Ship()
            {
                LowSlotNumber = ship.LowSlotNumber,
                MidSlotNumber = ship.MidSlotNumber,
                HighSlotNumber = ship.HighSlotNumber,
                Powergrid = ship.Powergrid,
                CPU = ship.CPU,
                CapacitorCapacity = ship.CapacitorCapacity,
                CapacitorRechargeTime = ship.CapacitorRechargeTime,
                WeaponMounts = ship.WeaponMounts,
                CargoSpace = ship.CargoSpace,
                Speed = ship.Speed
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Ships.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<ShipModel> GetAllShips()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Ships
                    .Select(
                        e =>
                        new ShipModel()
                        {
                            Id = e.Id,
                            LowSlotNumber = e.LowSlotNumber,
                            MidSlotNumber = e.MidSlotNumber,
                            HighSlotNumber = e.HighSlotNumber,
                            Powergrid = e.Powergrid,
                            CPU = e.CPU,
                            CapacitorCapacity = e.CapacitorCapacity,
                            CapacitorRechargeTime = e.CapacitorRechargeTime,
                            WeaponMounts = e.WeaponMounts,
                            CargoSpace = e.CargoSpace,
                            Speed = e.Speed
                        }
                    );
                return query.ToList();
            }
        }
        public ShipModel GetShipById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var ship =
                    ctx
                    .Ships
                    .Single(
                        e => e.Id == id
                    );
                return new ShipModel
                {
                    Id = ship.Id,
                    LowSlotNumber = ship.LowSlotNumber,
                    MidSlotNumber = ship.MidSlotNumber,
                    HighSlotNumber = ship.HighSlotNumber,
                    Powergrid = ship.Powergrid,
                    CPU = ship.CPU,
                    CapacitorCapacity = ship.CapacitorCapacity,
                    CapacitorRechargeTime = ship.CapacitorRechargeTime,
                    WeaponMounts = ship.WeaponMounts,
                    CargoSpace = ship.CargoSpace,
                    Speed = ship.Speed
                };
            }
        }
        public bool UpdateShip(int id, ShipModel model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var ship = ctx.Ships.Single(e => e.Id == id);

                ship.Powergrid = model.Powergrid;
                ship.CPU = model.CPU;
                ship.HighSlotNumber = model.HighSlotNumber;
                ship.MidSlotNumber = model.MidSlotNumber;
                ship.LowSlotNumber = model.LowSlotNumber;
                ship.CapacitorCapacity = model.CapacitorCapacity;
                ship.CapacitorRechargeTime = model.CapacitorRechargeTime;
                ship.WeaponMounts = model.WeaponMounts;
                ship.CargoSpace = model.CargoSpace;
                ship.Speed = model.Speed;

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
