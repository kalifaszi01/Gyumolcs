using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static string _gyumolcsokFile = "gyumolcs.csv";
        static string _erkezesekFile = "erkezes.csv";
        static List<Gyumolcs> gyumolcsok;


        static void Main(string[] args)
        {
            Console.WriteLine("Program indul ... ");
            gyumolcsok = CsvReader.BetoltGyumolcsok(_gyumolcsokFile);
            foreach (Erkezes erkezes in CsvReader.BetoltErkezesek(_erkezesekFile))
            {
                gyumolcsok.First(g => g.gyumolcsid == erkezes.gyumolcsid).erkezesek.Add(erkezes);
            }
            
            feladat01();

            
            feladat02();

           
            feladat03();

            
            feladat04();
            
            feladat05();
       
            feladat06();
            Console.WriteLine("\nProgram vége!");
            Console.ReadKey();
        }


        private static void feladat06()
        {
            Console.WriteLine("\n6. feladat");
            Console.WriteLine($"\t2026 februárjában érkezett szállítmányok száma: {gyumolcsok.Sum(g => g.erkezesek.Count(e => e.erkezesdatum.Year == 2026 && e.erkezesdatum.Month == 2))}");
        }

        private static void feladat05()
        {
            Console.WriteLine("\n5. feladat");
            Gyumolcs legtobbszorErkezett = gyumolcsok.OrderByDescending(g => g.erkezesek.Count).FirstOrDefault();
            Console.WriteLine($"\tA legtöbbször érkezett gyümölcs neve: \"{legtobbszorErkezett.Nev}\" és érkezéseinek száma: {legtobbszorErkezett.erkezesek.Count} db");
        }

        private static void feladat04()
        {
            Console.WriteLine("\n4. feladat");
            Console.WriteLine($"\tAz eddig beérkezett \"Alma\"(gyumolcsid: 1) összértéke: {gyumolcsok.Where(a => a.gyumolcsid == 1).FirstOrDefault().osszertek}");
        }

        private static void feladat03()
        {
            Console.WriteLine("\n3. feladat");
            double maxEgysegar = gyumolcsok.Max(g => g.maxegysegar);
            Gyumolcs legdragabb = gyumolcsok.Where(g => g.maxegysegar == maxEgysegar).FirstOrDefault();
            Console.WriteLine($"\tA legdrágább gyümölcs neve: \"{legdragabb.Nev}\" és egységára: {legdragabb.maxegysegar.ToString("#,##0")} Ft/kg");
        }

        private static void feladat02()
        {
            Console.WriteLine("\n2. feladat");
            Console.WriteLine($"\tAz összes gyümölcs értéke(mennyiség * egységár): {gyumolcsok.Sum(a => a.osszertek).ToString("#,##0")} Ft");
        }

        private static void feladat01()
        {
            Console.WriteLine("\n1. feladat");
            Console.WriteLine($"\tAz összes gyümölcs mennyisége: {gyumolcsok.Sum(a => a.osszmenyiseg).ToString("#,##0")} kg");
        }
    }
}
