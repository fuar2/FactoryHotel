using FactoryHotel.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHotel.Factories
{
    internal class oneroomsfactory : Roomsfactory
    {
        private readonly decimal _price;
        private readonly string _description;

        public oneroomsfactory(decimal price, string description)
        {
            _price = price;
            _description = description;
        }

        public override Roomprop GetRoom()
        {
            onerooms room = new(_price)
            {
                Description = _description
            };

            return room;
        }
    }
}
