using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GraGieldowa.Models
{
    public class Gracz  
    {
        public Gracz(int iD, decimal srodki, decimal iloscAkcji) 
        {
            this.ID = iD;
            this.Srodki = srodki;
            this.IloscAkcji = iloscAkcji;
        }

        public int ID { get; set; }
        public decimal Srodki { get; set; }
        public decimal IloscAkcji { get; set; }
    }
}
