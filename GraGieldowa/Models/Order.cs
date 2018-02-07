using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GraGieldowa.Models
{


    public class Order
    {
        public Order(decimal cena, int szt, int iDGracza, TypyZlecen typ)
        {
            this.Cena = cena;
            this.Szt = szt;
            this.IDGracza = iDGracza;
            this.Typ = typ;
        }

        public enum TypyZlecen { K, S };
        public decimal Cena { get; set; }
        public int Szt { get; set; }
        public int IDGracza { get; set; }
        public TypyZlecen Typ { get; set; }


    }
}