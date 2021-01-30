using System;
using System.Collections.Generic;
using System.Text;

namespace GamerApp.Entities
{
   public class Game
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public decimal price { get; set; }
        public int Quantity { get; set; }
    }
}
