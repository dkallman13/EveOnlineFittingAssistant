using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveOnlineFittingAssistant_Data
{
    public class RepairModule : ActiveModule
    {
        [Required]
        public RepairType RepairType { get; set; }

        [Required]
        public double RepairAmount { get; set; }

        public bool IsRepairModule = true;

        public RepairModule(SlotType slot, double power, double cpu, double cycle, double? capusage, RepairType type, double amount) : base(slot, power, cpu, cycle, capusage)
        {
            RepairType = type;
            RepairAmount = amount;
        }
    }
    public enum RepairType { Shield, Armor }
}
