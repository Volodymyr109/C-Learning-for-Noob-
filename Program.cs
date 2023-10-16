using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace readingDataFromCsv
{

    public class RechnungModel
{
    public int KundenNr { get; set; }
    public int ArtikelNr { get; set; }
    public int Anzahl { get; set; }
}
    internal class Program
    {
static void Main(string[] args)
{
    var csvPath = @"D:\Aufgabe NICETEC\Rechnung.csv";
    using (var reader = new StreamReader(csvPath))
    {
        while (reader.EndOfStream == false)
        {
            var content = reader.ReadLine();
            var cells = content.Split(',').ToList();
            if (RowHasData(cells))
            {
                if (cells.Count >= 3) // Überprüfe, ob die Zeile mindestens 3 Werte hat (KundenNr, ArtikelNr, Anzahl).
                {
                    // Extrahiere die Werte aus den Zellen.
                    int kundenNr = Convert.ToInt32(cells[0]);
                    int artikelNr = Convert.ToInt32(cells[1]);
                    int anzahl = Convert.ToInt32(cells[2]);

                    // Erstelle eine Instanz deiner Modelklasse und fülle sie mit den Daten.
                    var rechnung = new RechnungModel
                    {
                        KundenNr = kundenNr,
                        ArtikelNr = artikelNr,
                        Anzahl = anzahl
                    };

                    // Hier kannst du die Daten aus der Zeile verwenden, z.B. ausgeben.
                    Console.WriteLine($"KundenNr: {rechnung.KundenNr}, ArtikelNr: {rechnung.ArtikelNr}, Anzahl: {rechnung.Anzahl}");
                }
            }
        }
    }
}
    }
}

//         static bool RowHasData(List<string> cells)
//         {
//             return cells.Any(x => x.Length > 0);
//         }
//     }
// }
// using System;
// using System.Collections.Generic;
// using System.Globalization;
// using System.IO;
// using CsvHelper;
// using CsvHelper.Configuration;

// public class RechnungModel
// {
//     public int KundenNr { get; set; }
//     public int ArtikelNr { get; set; }
//     public int Anzahl { get; set; }
// }

// public class KundenModel 
// {
//     public int KundenNr { get; set; }
//     public string Name { get; set; }
//     public string Strasse { get; set; }
//     public string Ort { get; set; }
// }

// public class ArtikelModel
// {
//     public int ArtikelNr { get; set; } 
//     public string Name { get; set; }
//     public float Preis { get; set; }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         string rechnungCsvFilePath = "Rechnung.csv";
//         string kundenCsvFilePath = "Kunden.csv";
//         string artikelCsvFilePath = "Artikel.csv";

//         var rechnungen = ReadCsvFile<RechnungModel>(rechnungCsvFilePath);
//         var kunden = ReadCsvFile<KundenModel>(kundenCsvFilePath);
//         var artikel = ReadCsvFile<ArtikelModel>(artikelCsvFilePath);

//         Console.WriteLine("Rechnungen:");
//         foreach (var rechnung in rechnungen)
//         {
//             Console.WriteLine($"KundenNr: {rechnung.KundenNr}, ArtikelNr: {rechnung.ArtikelNr}, Anzahl: {rechnung.Anzahl}");
//         }

//         Console.WriteLine("\nKunden:");
//         foreach (var kunde in kunden)
//         {
//             Console.WriteLine($"KundenNr: {kunde.KundenNr}, Name: {kunde.Name}, Strasse: {kunde.Strasse}, Ort: {kunde.Ort}");
//         }

//         Console.WriteLine("\nArtikel:");
//         foreach (var artikelEntry in artikel)
//         {
//             Console.WriteLine($"ArtikelNr: {artikelEntry.ArtikelNr}, Name: {artikelEntry.Name}, Preis: {artikelEntry.Preis}");
//         }
//     }

//     static List<T> ReadCsvFile<T>(string filePath)
//     {
//         using (var reader = new StreamReader(filePath))
//         using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
//         {
//             return csv.GetRecords<T>().ToList();
//         }
//     }
// }