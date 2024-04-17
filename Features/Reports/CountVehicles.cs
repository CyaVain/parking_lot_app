using ParkingLotApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotApp.Features.Reports
{
    internal class CountVehicles
    {
        public static void Motor(ParkingLot lot)
        {
            int counter = 0;
          foreach(Vehicles v in lot.Slot.Values)
            {
                if (v != null)
                {
                    if (v.Type.Equals("Motor"))
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }

        public static void Mobil(ParkingLot lot)
        {
            int counter = 0;
            foreach (Vehicles v in lot.Slot.Values)
            {
                if(v !=null)
                {
                    if (v.Type.Equals("Mobil"))
                    {
                        counter++;
                    }
                }

            }
            Console.WriteLine(counter);
        }
    }
}
