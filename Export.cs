using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Zillow2Excel.Models;
using ClosedXML.Excel;
using System.IO;

namespace Zillow2Excel
{
    class Export
    {
        public static DataTable CreateDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("zpid", typeof(System.Int32));
            dataTable.Columns.Add("beds", typeof(System.Double));
            dataTable.Columns.Add("baths", typeof(System.Double));
            dataTable.Columns.Add("livingarea", typeof(double));
            dataTable.Columns.Add("homeType", typeof(System.String));
            dataTable.Columns.Add("taxAssessedValue", typeof(double));
            dataTable.Columns.Add("lotSize", typeof(double));
            dataTable.Columns.Add("priceListed", typeof(double));
            dataTable.Columns.Add("priceEstimate", typeof(double));
            dataTable.Columns.Add("rentEstimate", typeof(double));
            dataTable.Columns.Add("rentToPricepercent", typeof(double));
            dataTable.Columns.Add("GrossRentMultiplier", typeof(double));
            dataTable.Columns.Add("daysOnZillow", typeof(System.Int32));
            dataTable.Columns.Add("linkToListing", typeof(System.String));
            return dataTable;
        }
        public static DataTable PopulateDataTable(List<ListResult> listResult)
        {
            var dt = CreateDataTable();
            foreach (var i in listResult)
            {
                var row = dt.NewRow();
                int? rentEstimate = i.hdpData.homeInfo.rentZestimate;
                _ = rentEstimate ?? 1; //this prevents dividing by zero calamities
                int? priceEstimate = i.hdpData.homeInfo.zestimate;
                _ = priceEstimate ?? 1;
                var priceListed = i.hdpData.homeInfo.price;
                row["zpid"] = i.hdpData.homeInfo.zpid;
                row["beds"] = i.hdpData.homeInfo.bedrooms;
                row["baths"] = i.hdpData.homeInfo.bathrooms;
                row["livingarea"] = i.hdpData.homeInfo.livingArea;
                row["homeType"] = i.hdpData.homeInfo.homeType;
                row["taxAssessedValue"] = i.hdpData.homeInfo.taxAssessedValue;
                row["lotSize"] = i.hdpData.homeInfo.lotAreaValue;
                row["priceListed"] = priceListed;
                row["priceEstimate"] = priceEstimate;
                row["rentEstimate"] = rentEstimate;
                row["rentToPricepercent"] = (rentEstimate / priceListed);
                row["GrossRentMultiplier"] = (priceListed / rentEstimate) / 12;
                row["daysOnZillow"] = i.hdpData.homeInfo.daysOnZillow;
                row["linkToListing"] = i.detailUrl;
                dt.Rows.Add(row);

            }
            return dt;

        }
        public static void WriteDataToExcel(string filepath, DataTable completedDatatable, string workSheetName)
        {
            //int rowToAppend = 1;
            using (XLWorkbook Workbook = new XLWorkbook())
            {

                Workbook.Worksheets.Add(completedDatatable, workSheetName);
                //int rowToAppend = WorkSheet.LastRowUsed().RowNumber();
                //IXLCell CellForNewData = WorkSheet.Cell(rowToAppend, 1); //row and column to start on
                //CellForNewData.InsertTable(completedDatatable);
                Workbook.SaveAs(filepath);
            }
        }

        public static void CreateFile(string filepath)
        {
            string fileInfo = System.IO.Path.Combine(filepath);
            if (!System.IO.File.Exists(filepath))
                //Directory.CreateDirectory(fileInfo);
                File.Create(fileInfo);
        }

    }
}
