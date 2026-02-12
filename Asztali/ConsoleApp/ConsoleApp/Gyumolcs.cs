using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Gyumolcs
    {
        public int gyumolcsid { get; set; }
        public string Nev { get; set; }
        public string megjegyzes { get; set; }
        public string neveng { get; set; }
        public string altszoveg { get; set; }
        public string src { get; set; }
        public List<Erkezes> erkezesek { get; set; }
        public int osszmenyiseg 
        {
            get 
            { 
                return erkezesek.Sum(e => e.mennyiseg); 
            }
        }
        public int osszertek
        {
            get 
            {
                return (int)erkezesek.Sum(e => e.osszar);
            }
        
        }
        public double maxegysegar 
        {
            get
            { 
                return erkezesek.Max(e => e.egysegar); 
            }

        }
        public Gyumolcs(int _gyumolcsId, string _name, string _megjegyzes, string _nevEng, string _altSzoveg, string _src)
        {
            this.gyumolcsid = _gyumolcsId;
            this.Nev = _name;
            this.megjegyzes = _megjegyzes;
            this.altszoveg = _altSzoveg;
            this.src = _src;
            this.neveng = _nevEng;
            this.erkezesek = new List<Erkezes>();

        }
        

    }
}
