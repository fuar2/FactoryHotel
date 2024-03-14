using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHotel.Rooms
{
    internal class tworooms : Roomprop
    {
        private readonly string _type;
        private readonly decimal _price;

        public tworooms(decimal price)
        {
            _type = "Two-rooms";
            _price = price;
        }

        public string Type => _type;
        public string Description { get; set; }
        public decimal GetPrice() => _price;
    }
}
