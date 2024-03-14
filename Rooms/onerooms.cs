using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHotel.Rooms
{
    internal class onerooms : Roomprop
    {
        private readonly string _type;
        private readonly decimal _price;

        public onerooms(decimal price)
        {
            _type = "One-room";
            _price = price;
        }

        public string Type => _type;
        public string Description { get; set; }
        public decimal GetPrice() => _price;
    }
}
