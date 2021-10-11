using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveOnlineFittingAssistant_Data
{
    public class Ship
    {
        [Key]
        public int Id { get; set; }
        [Required]
        
        public int LowSlotNumber { get; set; }
        [Required]
        public int MidSlotNumber { get; set; }
        [Required]
        public int HighSlotNumber { get; set; }
        [Required]
        public double Powergrid { get; set; }
        [Required]
        public double CPU { get; set; }
        [Required]
        public double CapacitorCapacity { get; set; }
        [Required]
        public double CapacitorRechargeTime { get; set; }
        public int WeaponMounts { get; set; }
        [Required]
        public double CargoSpace { get; set; }
        [Required]
        public double Speed { get; set; }

    }
}
