using ParkingLotApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotApp.Features.Reports
{
    class LotStatus
    {
        public static void Status(ParkingLot lot)
        {
            Console.WriteLine("Slot -- Registration No -- Type -- Colour");
            foreach(KeyValuePair<int, Vehicles> pair in lot.Slot)
            {
                int slotNo = pair.Key;
                Vehicles v = pair.Value;
                if( v != null)
                {
                    Console.WriteLine($"{slotNo} {v.RegistrationNo} {v.Type} {v.Colour}");
                }
                else
                {
                    Console.WriteLine($"{slotNo} Empty Slot");
                }
            }
        }
    }
}
