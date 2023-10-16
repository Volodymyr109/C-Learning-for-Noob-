using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;

public class KundenModel
{
    public int KundenNr { get; set; }
    public string Name { get; set; }
    public string Strasse { get; set; }
    public string Ort { get; set; }
}
class reader
{
    static void Main(string[] args)
    {
        var kunden = ReadCsvFile<KundenModel>("Kunden.csv");

        foreach (var kunde in kunden)
        {
            Console.WriteLine($"KundenNr: {kunde.KundenNr}, Name: {kunde.Name}, Strasse: {kunde.Strasse}, Ort: {kunde.Ort}");
        }
    }
    static List<T> ReadCsvFile<T>(string filePath)
    {
        using (var reader = new StreamReader(filePath))
        using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
        {
            return csv.GetRecords<T>().ToList();
        }
    }
}