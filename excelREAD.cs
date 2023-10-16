using System;
using System.Collections.Generic;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
using System.Collections;
using System.Globalization;

public class Rechnung
{
    public int KundenNr { get; set; }
    public int ArtikelNr { get; set; }
    public int Anzahl { get; set; }
}


public class RechnungCSVReader
{
    public List<Rechnung> ReadRechnungenFromCSV(string filePath)
    {
        try
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                var records = csv.GetRecords<Rechnung>().ToList();
                return records;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Fehler beim Lesen der Datei: {ex.Message}");
            return new List<Rechnung>();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var csvFilePath = "Rechnung.csv";
        var reader = new RechnungCSVReader();
        var rechnungen = reader.ReadRechnungenFromCSV(csvFilePath);
        
    }
}
