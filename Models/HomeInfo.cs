using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zillow2Excel.Models
{
    public class HomeInfo
    {
        public int zpid { get; set; }
        public string streetAddress { get; set; }
        public string zipcode { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public double price { get; set; }
        public object dateSold { get; set; }
        public object datePriceChanged { get; set; }
        public double bathrooms { get; set; }
        public double bedrooms { get; set; }
        public double livingArea { get; set; }
        public string homeType { get; set; }
        public string homeStatus { get; set; }
        public string imageLink { get; set; }
        public int daysOnZillow { get; set; }
        public bool isFeatured { get; set; }
        public bool shouldHighlight { get; set; }
        public int brokerId { get; set; }
        public int zestimate { get; set; }
        public int rentZestimate { get; set; }
        public ListingSubType listing_sub_type { get; set; }
        public bool isUnmappable { get; set; }
        public string mediumImageLink { get; set; }
        public bool isPreforeclosureAuction { get; set; }
        public string homeStatusForHDP { get; set; }
        public double priceForHDP { get; set; }
        public int priceChange { get; set; }
        public object timeOnZillow { get; set; }
        public string hiResImageLink { get; set; }
        public string watchImageLink { get; set; }
        public string tvImageLink { get; set; }
        public string tvCollectionImageLink { get; set; }
        public string tvHighResImageLink { get; set; }
        public string desktopWebHdpImageLink { get; set; }
        public bool isNonOwnerOccupied { get; set; }
        public bool isPremierBuilder { get; set; }
        public bool isZillowOwned { get; set; }
        public string currency { get; set; }
        public string country { get; set; }
        public double taxAssessedValue { get; set; }
        public double lotAreaValue { get; set; }
        public string lotAreaUnit { get; set; }
        public string priceReduction { get; set; }
    }
}
