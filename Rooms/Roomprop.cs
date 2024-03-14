using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHotel.Rooms
{
    internal interface Roomprop
    {
        string Type { get; }
        string Description { get; set; }
        decimal GetPrice();
    }
}
