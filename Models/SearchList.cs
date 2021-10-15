using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zillow2Excel.Models
{
    public class SearchList
    {
        public int expansionDistance { get; set; }
        public string staticBaseUrl { get; set; }
        public object zeroResultsFilters { get; set; }
        public object message { get; set; }
        public AdsConfig adsConfig { get; set; }
        public int totalResultCount { get; set; }
        public int resultsPerPage { get; set; }
        public int totalPages { get; set; }
        public int displayResultsCount { get; set; }
        public string listResultsTitle { get; set; }
        public List<ResultContext> resultContexts { get; set; }
        public string pageRules { get; set; }
    }
}
