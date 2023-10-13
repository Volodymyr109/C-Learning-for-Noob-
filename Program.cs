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
            Console.WriteLine("Temperature: " + temp + " on " + day);
            Console.ReadLine();
        }
    }
}
