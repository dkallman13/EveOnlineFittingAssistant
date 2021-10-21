using EveOnlineFittingAssistant_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveOnlineFittingAssistant_Models
{
    public class FitModel
    {
        public int Id { get; set; }
        public int ShipId { get; set; }
        public List<Module> HighModules { get; set; }
        public List<Module> MidModules { get; set; }
        public List<Module> LowModules { get; set; }
    }
}
