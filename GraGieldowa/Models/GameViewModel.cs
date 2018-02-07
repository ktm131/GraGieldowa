using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GraGieldowa.Models
{
    public class GameViewModel
    {
        public OrderBook KsiazkaZlecen { get; set; }
        public List<Gracz> Gracze { get; set; }

        public GameViewModel()
        {
            this.KsiazkaZlecen = new OrderBook();
            this.Gracze = new List<Gracz>();
        }
    }
}