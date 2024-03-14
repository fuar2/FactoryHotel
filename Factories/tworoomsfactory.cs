using FactoryHotel.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHotel.Factories
{
    internal class tworoomsfactory : Roomsfactory
    {
        private readonly decimal _price;
        private readonly string _description;

        public tworoomsfactory(decimal price, string description)
        {
            _price = price;
            _description = description;
        }

        public override Roomprop GetRoom()
        {
            tworooms room = new(_price)
            {
                Description = _description
            };

            return room;
        }
    }
}
