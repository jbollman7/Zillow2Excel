using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zillow2Excel.Models
{
    public class Root
    {
        public User user { get; set; }
        public MapState mapState { get; set; }
        public SearchPageSeoObject searchPageSeoObject { get; set; }
        public int requestId { get; set; }
        public Cat1 cat1 { get; set; }
        public CategoryTotals categoryTotals { get; set; }
    }
}
