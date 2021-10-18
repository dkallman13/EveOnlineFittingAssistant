using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveOnlineFittingAssistant_Data
{
    public class Module
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public SlotType Slot { get; set; }
        [Required]
        public double Powergrid { get; set; }
        [Required]
        public double CPU { get; set; }

        public double? CycleTime;
        public double? CapacitorUsage;

        public WeaponType? TypeOfWeapon;
        public double? DamageMultiplier;

        public double? RepairAmount;
        public RepairType? RepairType;

        public bool IsWeapon = false;
        public bool IsActiveModule = false;
        public bool IsRepairModule = false;

        public Module(SlotType slot, double power, double cpu)
        {
            Slot = slot;
            Powergrid = power;
            CPU = cpu;
        }

    }
    public enum SlotType { low, mid, high }
}
