using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zillow2Excel.Models
{
    public class SearchResults
    {
        public List<ListResult> listResults { get; set; }
        public string resultsHash { get; set; }
        public int homeRecCount { get; set; }
        public int showForYouCount { get; set; }
        public List<MapResult> mapResults { get; set; }
        public List<object> relaxedResults { get; set; }
        public string relaxedResultsHash { get; set; }
    }
}
