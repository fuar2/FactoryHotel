using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryHotel.Rooms;

namespace FactoryHotel.Factories
{
    internal abstract class Roomsfactory
    {
        public abstract Roomprop GetRoom();
    }
}
