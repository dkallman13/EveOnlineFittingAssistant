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

        public SlotType Slot { get; set; }
        public double Powergrid { get; set; }
        public double CPU { get; set; }
        public bool IsWeapon = false;
        public bool IsActiveModule = false;
        public bool IsRepairModule = false;

    }
    public enum SlotType { low, mid, high }
}
