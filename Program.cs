using System;
using System.Collections.Generic;
using Zillow2Excel.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace Zillow2Excel
{
    class Program
    {
        static void Main(string[] args)
        {
            //var urlList = getUrls();
            var url = "https://www.zillow.com/search/GetSearchPageState.htm?searchQueryState=%7B%22pagination%22%3A%" +
                "7B%7D%2C%22usersSearchTerm%22%3A%2266502%22%2C%22mapBounds%22%3A%7B%22west%22%3A-96.66085356030118%" +
                "2C%22east%22%3A-96.46821515051153%2C%22south%22%3A39.14477025574213%2C%22north%22%3A39.202965046712" +
                "855%7D%2C%22isMapVisible%22%3Atrue%2C%22filterState%22%3A%7B%22sortSelection%22%3A%7B%22value%22%3A" +
                "%22globalrelevanceex%22%7D%2C%22isAllHomes%22%3A%7B%22value%22%3Atrue%7D%2C%22isTownhouse%22%3A%7B%" +
                "22value%22%3Afalse%7D%2C%22isMultiFamily%22%3A%7B%22value%22%3Afalse%7D%2C%22isCondo%22%3A%7B%22valu" +
                "e%22%3Afalse%7D%2C%22isLotLand%22%3A%7B%22value%22%3Afalse%7D%2C%22isApartment%22%3A%7B%22value%22%3" +
                "Afalse%7D%2C%22isManufactured%22%3A%7B%22value%22%3Afalse%7D%2C%22isApartmentOrCondo%22%3A%7B%22valu" +
                "e%22%3Afalse%7D%2C%22price%22%3A%7B%22max%22%3A205000%7D%2C%22monthlyPayment%22%3A%7B%22max%22%3A498" +
                "%7D%7D%2C%22isListVisible%22%3Atrue%2C%22mapZoom%22%3A14%7D&wants={%22cat1%22:[%22listResults%22,%22" +
                "mapResults%22],%22cat2%22:[%22total%22]}&requestId=12";

            using HttpClient client = new HttpClient();
            var response = client.GetAsync(url).Result;
            List<ListResult> homeList;
            if (response.IsSuccessStatusCode)
            {
                var content = response.Content;
                var resultString = content.ReadAsStringAsync().Result;
                Root json = JsonConvert.DeserializeObject<Root>(resultString);
                homeList = json.cat1.searchResults.listResults;

            }
            else
                throw new HttpRequestException();

            var populate = Export.PopulateDataTable(homeList);
            string filepath = "C:\\Users\\joseph.bollman\\Documents\\testy.xlsx";
            Export.WriteDataToExcel(filepath, populate);
        }
        public static List<String> getUrls()
        {
            var urlList = new List<string>();
            var url1 = "https://www.zillow.com/search/GetSearchPageState.htm?searchQueryState=%7B%22pagination%" +
                "       22%3A%7B%7D%2C%22usersSearchTerm%22%3A%2266502%22%2C%22mapBounds%22%3A%7B%22west%22%3A-" +
                "96.67815707738947%2C%22east%22%3A-96.48551866759982%2C%22south%22%3A39.1687965927096%2C%22north" +
                "%22%3A39.21851365805834%7D%2C%22isMapVisible%22%3Atrue%2C%22filterState%22%3A%7B%22price%22%3A" +
                "%7B%22min%22%3A0%2C%22max%22%3A180000%7D%2C%22monthlyPayment%22%3A%7B%22min%22%3A0%2C%22max%22" +
                "%3A437%7D%2C%22beds%22%3A%7B%22min%22%3A3%7D%2C%22baths%22%3A%7B%22min%22%3A1%7D%2C%22sqft%22%" +
                "3A%7B%22min%22%3A1250%7D%2C%22isAllHomes%22%3A%7B%22value%22%3Atrue%7D%2C%22isCondo%22%3A%7B%" +
                "22value%22%3Afalse%7D%2C%22isMultiFamily%22%3A%7B%22value%22%3Afalse%7D%2C%22isManufactured%22%" +
                "3A%7B%22value%22%3Afalse%7D%2C%22isLotLand%22%3A%7B%22value%22%3Afalse%7D%2C%22isTownhouse%22%3A" +
                "%7B%22value%22%3Afalse%7D%2C%22isApartment%22%3A%7B%22value%22%3Afalse%7D%2C%22isApartmentOrCondo" +
                "%22%3A%7B%22value%22%3Afalse%7D%7D%2C%22isListVisible%22%3Atrue%2C%22mapZoom%22%3A14%7D&wants=" +
                "{%22cat1%22:[%22listResults%22,%22mapResults%22],%22cat2%22:[%22total%22]}&requestId=11";
            urlList.Add(url1);
            var url2 = "https://www.zillow.com/search/GetSearchPageState.htm?searchQueryState=%7B%22pagination%22" +
                "%3A%7B%7D%2C%22usersSearchTerm%22%3A%2266502%22%2C%22mapBounds%22%3A%7B%22west%22%3A-96.63133643" +
                "68255%2C%22east%22%3A-96.53501723193068%2C%22south%22%3A39.17083945091163%2C%22north%22%3A39.195" +
                "70165829261%7D%2C%22isMapVisible%22%3Atrue%2C%22filterState%22%3A%7B%22price%22%3A%7B%22min%22%3" +
                "A0%2C%22max%22%3A180000%7D%2C%22monthlyPayment%22%3A%7B%22min%22%3A0%2C%22max%22%3A437%7D%2C%22b" +
                "eds%22%3A%7B%22min%22%3A3%7D%2C%22baths%22%3A%7B%22min%22%3A1%7D%2C%22sqft%22%3A%7B%22min%22%3A1" +
                "250%7D%2C%22isAllHomes%22%3A%7B%22value%22%3Atrue%7D%2C%22isCondo%22%3A%7B%22value%22%3Afalse%7D" +
                "%2C%22isMultiFamily%22%3A%7B%22value%22%3Afalse%7D%2C%22isManufactured%22%3A%7B%22value%22%3Afal" +
                "se%7D%2C%22isLotLand%22%3A%7B%22value%22%3Afalse%7D%2C%22isTownhouse%22%3A%7B%22value%22%3Afalse" +
                "%7D%2C%22isApartment%22%3A%7B%22value%22%3Afalse%7D%2C%22isApartmentOrCondo%22%3A%7B%22value%22%" +
                "3Afalse%7D%7D%2C%22isListVisible%22%3Atrue%2C%22mapZoom%22%3A15%7D&wants={%22cat1%22:[%22listRes" +
                "ults%22,%22mapResults%22],%22cat2%22:[%22total%22]}&requestId=12";
            urlList.Add(url2);
            return urlList;

        }
    }
}
