using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GUI_WinFormsListbox
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
                    string[] adatok = sor.Replace("\"","").Split(';');

                    lista.Add(new Gyumolcs(int.Parse(adatok[0]), adatok[1], adatok[2], adatok[3], adatok[4], adatok[5]));

                }
            }
            return lista;
        }
        public static List<Erkezes> BetoltErkezesek(string fajlnev)
    }
}
