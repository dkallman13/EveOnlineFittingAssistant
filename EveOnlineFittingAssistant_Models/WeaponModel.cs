using EveOnlineFittingAssistant_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveOnlineFittingAssistant_Models
{
    public class WeaponModel
    {
        public int Id { get; set; }
        public SlotType Slot { get; set; }
        public double CPU { get; set; }
        public double Powergrid { get; set; }
        public double CycleTime { get; set; }
        public double CapacitorUsage { get; set; }
        public WeaponType TypeOfWeapon { get; set; }
        public double DamageMultiplier { get; set; }
    }
}
