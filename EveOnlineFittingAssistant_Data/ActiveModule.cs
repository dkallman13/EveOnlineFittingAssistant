﻿using System;
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

        public ActiveModule(SlotType slot, double power, double cpu, double cycle) : base(slot, power, cpu)
        {
            CycleTime = cycle;
        }
        public ActiveModule(SlotType slot, double power, double cpu, double cycle, double capusage) : base(slot, power, cpu)
        {
            CycleTime = cycle;
            CapacitorUsage = capusage;
        }
    }
}