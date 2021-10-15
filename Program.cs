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
            var UrlList = Import.ImportCsv("C:\\Users\\joseph.bollman\\test.csv");
            foreach (var url in UrlList)
            {
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
        }
    }
}
