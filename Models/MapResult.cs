using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zillow2Excel.Models
{
    public class MapResult
    {
        public string zpid { get; set; }
        public string price { get; set; }
        public string priceLabel { get; set; }
        public int? beds { get; set; }
        public double? baths { get; set; }
        public int? area { get; set; }
        public LatLong latLong { get; set; }
        public string statusType { get; set; }
        public string statusText { get; set; }
        public bool isFavorite { get; set; }
        public bool isUserClaimingOwner { get; set; }
        public bool isUserConfirmedClaim { get; set; }
        public string imgSrc { get; set; }
        public bool hasImage { get; set; }
        public bool visited { get; set; }
        public string listingType { get; set; }
        public VariableData variableData { get; set; }
        public HdpData hdpData { get; set; }
        public string detailUrl { get; set; }
        public string pgapt { get; set; }
        public string sgapt { get; set; }
        public bool has3DModel { get; set; }
        public bool hasVideo { get; set; }
        public bool isHomeRec { get; set; }
        public string address { get; set; }
        public bool hasAdditionalAttributions { get; set; }
        public bool isFeaturedListing { get; set; }
        public object availabilityDate { get; set; }
    }
}
