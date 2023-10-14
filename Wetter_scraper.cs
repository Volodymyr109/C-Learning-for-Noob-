using HtmlAgilityPack;
using System;
using System.Net.Http;

namaspace lernen 
{
    class Program 
    {
        static void Main(String[] args) 
        {   
            //request
            string url = "https://www.ndr.de/nachrichten/wetter/wetter1524_ort-68_region-de_stadt-Osnabrueck.html";
            var httpClient = new httpClient();
            var html = httpClient.GetStringAsync(url).Result;
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            //get daten, temperature and date
            var temperature = htmlDocument.DocumentNode.SelectSingleNode("//span[@class='text']");
            var temp = temperature.InnerText.Trim();
            var date = htmlDocument.DocumentNode.SelectSingleNode("//div[@class='tile']");
            var day = date.InnerText.Trim();
            //Console.WriteLine("Temperature: " + temp + " on " + day);
            
            string directoryPath = @"D:\C sharp\lernen\"; // Passe dies an den gewünschten Verzeichnispfad an
            string fileName = "WeatherData.xlsx";
            // Speichern der Excel-Datei
            SaveToExcel(Path.Combine(directoryPath, fileName), temp, day);
            Console.ReadLine();
        }

        static void SaveToExcel(string temperature, string date)
        {
            var excelPackage = new ExcelPackage();
            var excelWorksheet = excelPackage.Workbook.Worksheets.Add("WeatherData");

            excelWorksheet.Cells["A1"].Value = "Temperature";
            excelWorksheet.Cells["A2"].Value = temperature;
            excelWorksheet.Cells["B1"].Value = "Date";
            excelWorksheet.Cells["B2"].Value = date;

            var fileInfo = new FileInfo(filePath);
            excelPackage.SaveAs(fileInfo);
        }
    }
}
