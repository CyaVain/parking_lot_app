using System.Collections.Generic;

namespace ParkingLotApp.Models
{
    class ParkingLot
    {
        public Dictionary<int, Vehicles> Slot { get; set; } = new Dictionary<int, Vehicles>();
    }
}
