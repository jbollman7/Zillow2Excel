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
            //Create outfilepath
            string filepath = @"C:\Users\joseph.bollman\output.xlsx";
            //Export.CreateFile(filepath);
            string[] Urls = System.IO.File.ReadAllLines(@"C:\Users\joseph.bollman\urlList.txt");
            foreach (var url in Urls)
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
                Export.WriteDataToExcel(filepath, populate, "Manhattan");
            }
        }
    }
}
