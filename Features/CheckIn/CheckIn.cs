using ParkingLotApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotApp.Features
{
    class CheckIn
    {
        public static void CheckingIn(ParkingLot lot)
        {
            bool status = true;
            while (status)
            {
                Console.WriteLine("Type Your Option (park / back)");
                Console.WriteLine("Park\n" +
                    "Back\n");
                string choice = Console.ReadLine().ToUpper();

                switch(choice)
                {
                    case "PARK":
                        Console.WriteLine("Parking The Vehicle");
                        ParkVehicles.Parks(lot);
                        break;
                    case "BACK":
                        Console.WriteLine("Going Back \n");
                        status = false;
                        break;
                    default:
                        Console.WriteLine("\n ### Please Enter Valid Option ### \n");
                        break;
                }
            }
        }
    }
}
