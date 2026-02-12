using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp
{
    public static class CsvReader
    {
        public static List<Gyumolcs> BetoltGyumolcsok(string fajlnev)
        {
            List<Gyumolcs> lista = new List<Gyumolcs>();
            using (var sr = new StreamReader(fajlnev, Encoding.UTF8))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    string[] adatok = sor.Replace("\"", "").Split(';');
                    lista.Add(new Gyumolcs(int.Parse(adatok[0]), adatok[1], adatok[2], adatok[3], adatok[4], adatok[5]));

                }

            }
            return lista;
        }
        public static List<Erkezes> BetoltErkezesek(string fajlnev)
        {
            List<Erkezes> lista = new List<Erkezes>();
            using (var sr = new StreamReader(fajlnev, Encoding.UTF8))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    string[] adatok = sor.Replace("\"", "").Split(';');
                    
                    lista.Add(new Erkezes
                    {
                        gyumolcsid = int.Parse(adatok[0]),
                        mennyiseg = int.Parse(adatok[1]),
                        egysegar = double.Parse(adatok[2], CultureInfo.InvariantCulture),
                        erkezesdatum = DateTime.Parse(adatok[3])

                    });

                    }

                }
                return lista;
            }
        }
    }

