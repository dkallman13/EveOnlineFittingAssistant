using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveOnlineFittingAssistant_Data
{
    public class Weapon : ActiveModule
    {
        [Required]
        public WeaponType TypeOfWeapon { get; set; }

        [Required]
        public double DamageMultiplier { get; set; }

        public bool IsWeapon = true;
        public Weapon() { }
        public Weapon(SlotType slot, double power, double cpu, double cycle, double? capusage, WeaponType type, double mult) : base(slot, power, cpu, cycle, capusage)
        {
            TypeOfWeapon = type;
            DamageMultiplier = mult;
        }
    }
    public enum WeaponType { Missile, Laser, Projectile, Hybrid, EntropicDesintigrator, VortronProjector}
}
