using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zillow2Excel.Models
{
    public class User
    {
        public bool isLoggedIn { get; set; }
        public bool hasHousingConnectorPermission { get; set; }
        public int savedSearchCount { get; set; }
        public int savedHomesCount { get; set; }
        public object personalizedSearchGaDataTag { get; set; }
        public string personalizedSearchTraceID { get; set; }
        public int searchPageRenderedCount { get; set; }
        public string guid { get; set; }
        public string zuid { get; set; }
        public bool isBot { get; set; }
        public bool userSpecializedSEORegion { get; set; }
    }
}
