using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotApp.Models
{
    class ParkingLot
    {
        public Dictionary<int, Vehicles> Slot { get; set; } = new Dictionary<int, Vehicles>();

    }
}
