using EveOnlineFittingAssistant_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveOnlineFittingAssistant_Models
{
    public class ModuleModel
    {
        public int Id { get; set; }
        public SlotType Slot { get; set; }
        public double CPU { get; set; }
        public double Powergrid { get; set; }
    }
}
