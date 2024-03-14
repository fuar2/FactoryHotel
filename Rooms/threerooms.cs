using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHotel.Rooms
{
    internal class threerooms : Roomprop
    {
        private readonly string _type;
        private readonly decimal _price;

        public threerooms(decimal price)
        {
            _type = "Three-rooms";
            _price = price;
        }

        public string Type => _type;
        public string Description { get; set; }
        public decimal GetPrice() => _price;
    }
}
