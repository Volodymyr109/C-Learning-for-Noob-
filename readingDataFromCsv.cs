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

// namespace readingDataFromCsv
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             string filePath = @"D:\Aufgabe NICETEC\Rechnung.csv";
//             try{
//                 using (StreamReader reader = new StreamReader(filePath))
//                 {
//                     string line;
//                     while((line = reader.ReadLine()) != null)
//                     {
//                         Console.WriteLine(line);
//                     }
//                 }
//             } 
//             catch (Exception e)
//             {
//                 Console.WriteLine(e.Message);
//             }
//         }
//     }
// }