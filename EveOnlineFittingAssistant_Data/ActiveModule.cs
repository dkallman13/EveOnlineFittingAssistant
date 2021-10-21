using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveOnlineFittingAssistant_Data
{
    public class ActiveModule : Module
    {

        public bool IsActiveModule = true;

        //in Seconds
        [Required]
        public double CycleTime { get; set; }

        public double CapacitorUsage { get; set; }

        public ActiveModule() { }
        public ActiveModule(SlotType slot, double power, double cpu,  string name, double cycle, double? capusage) : base(slot, power, cpu, name)
        {
            CycleTime = cycle;
            CapacitorUsage = (double) capusage;
        }
    }
}
