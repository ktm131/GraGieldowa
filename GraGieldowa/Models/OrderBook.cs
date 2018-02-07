using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GraGieldowa.Models
{
    public class OrderBook : Dictionary<Order.TypyZlecen,List<Order>>
    {
        public int KupnoSzt
        {
            get
            {
                return this[Order.TypyZlecen.K].Sum(x => x.Szt);
            }
        }

        public int SprzedazSum
        {
            get
            {
                return this[Order.TypyZlecen.S].Sum(x => x.Szt);
            }
        }
    }
}