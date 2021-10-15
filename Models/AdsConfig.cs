using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zillow2Excel.Models
{
    public class AdsConfig
    {
        public string navAdSlot { get; set; }
        public string displayAdSlot { get; set; }
        public Targets targets { get; set; }
        public bool needsUpdate { get; set; }
    }
}
