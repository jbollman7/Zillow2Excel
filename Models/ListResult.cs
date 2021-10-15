using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zillow2Excel.Models
{
    public class ListResult
    {
        public string zpid { get; set; }
        public string id { get; set; }
        public object providerListingId { get; set; }
        public string imgSrc { get; set; }
        public bool hasImage { get; set; }
        public string detailUrl { get; set; }
        public string statusType { get; set; }
        public string statusText { get; set; }
        public string countryCurrency { get; set; }
        public string price { get; set; }
        public int unformattedPrice { get; set; }
        public string address { get; set; }
        public string addressStreet { get; set; }
        public string addressCity { get; set; }
        public string addressState { get; set; }
        public string addressZipcode { get; set; }
        public bool isUndisclosedAddress { get; set; }
        public int beds { get; set; }
        public double baths { get; set; }
        public int? area { get; set; }
        public LatLong latLong { get; set; }
        public bool isZillowOwned { get; set; }
        public VariableData variableData { get; set; }
        public object badgeInfo { get; set; }
        public HdpData hdpData { get; set; }
        public bool isSaved { get; set; }
        public bool isUserClaimingOwner { get; set; }
        public bool isUserConfirmedClaim { get; set; }
        public string pgapt { get; set; }
        public string sgapt { get; set; }
        public int? zestimate { get; set; }
        public bool shouldShowZestimateAsPrice { get; set; }
        public bool has3DModel { get; set; }
        public bool hasVideo { get; set; }
        public bool isHomeRec { get; set; }
        public string info3String { get; set; }
        public string brokerName { get; set; }
        public bool hasAdditionalAttributions { get; set; }
        public bool isFeaturedListing { get; set; }
        public object availabilityDate { get; set; }
        public bool list { get; set; }
        public bool relaxed { get; set; }
    }
}
