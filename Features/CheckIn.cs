using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotApp.Features
{
    class CheckIn
    {
        public static void CheckingIn()
        {
            bool status = true;
            while (status)
            {
                Console.WriteLine("Choose Your Option");
                Console.WriteLine("1. Park \n" +
                    "2. Back");
                int choice = Int32.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Parking The Vehicle");
                        break;
                    case 2:
                        Console.WriteLine("Going Back \n");
                        status = false;
                        break; 
                }
            }
        }
    }
}
