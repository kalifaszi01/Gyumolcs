using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Erkezes
    {
        public int gyumolcsid { get; set; }
        public int mennyiseg { get; set; }
        public double egysegar { get; set; }
        public DateTime erkezesdatum { get; set; }
        public double osszar 
        { 
            get 
            { 
                return mennyiseg * egysegar; 
            } 
        }
    }
}
