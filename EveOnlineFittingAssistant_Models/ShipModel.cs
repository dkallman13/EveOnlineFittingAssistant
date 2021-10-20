using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveOnlineFittingAssistant_Models
{
    public class ShipModel
    {
        public int Id { get; set; }
        public int LowSlotNumber { get; set; }
        public int MidSlotNumber { get; set; }
        public int HighSlotNumber { get; set; }
        public double Powergrid { get; set; }
        public double CPU { get; set; }
        public double CapacitorCapacity { get; set; }
        public double CapacitorRechargeTime { get; set; }
        public int WeaponMounts { get; set; }
        public double CargoSpace { get; set; }
        public double Speed { get; set; }
    }
}
