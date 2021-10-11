using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveOnlineFittingAssistant_Data
{
    public class Fit
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ShipId { get; set; }
        public List<int> HighModuleIds { get; set; }
        public List<int> MidModuleIds { get; set; }
        public List<int> LowModuleIds { get; set; }
        public virtual Ship Ship { get; set; }
        public virtual List<Module> HighModules { get; set; }
        public virtual List<Module> MidModules { get; set; }
        public virtual List<Module> LowModules { get; set; }

    }
}
