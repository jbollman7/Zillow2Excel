using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zillow2Excel.Models
{
    public class MapState
    {
        public object customRegionPolygonWkt { get; set; }
        public object schoolPolygonWkt { get; set; }
        public bool isCurrentLocationSearch { get; set; }
        public UserPosition userPosition { get; set; }
        public object regionBounds { get; set; }
    }
}
