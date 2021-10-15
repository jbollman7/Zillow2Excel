using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zillow2Excel
{
    class Import
    {
        public static List<String> ImportCsv(string filePath)
        {
            var reader = new StreamReader(File.OpenRead(filePath));
            var urlList = new List<string>();
            var iteration = 0;
            while (!reader.EndOfStream)
            {
                var lines = reader.ReadLine().Split(',');
                urlList.Add(lines[iteration]);
                iteration++;
            }
            return urlList;
        }
    }
}
