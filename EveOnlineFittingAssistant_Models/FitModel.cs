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
        public List<int> HighModuleIds { get; set; }
        public List<int> MidModuleIds { get; set; }
        public List<int> LowModuleIds { get; set; }
    }
}
