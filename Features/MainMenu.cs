using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotApp.Features
{
    class MainMenu
    {
        public static void Menu(int parkingLots)
        {
            bool status = true;
            while (status)
            {
                Console.WriteLine("--- Welcome to WaterFall Parking ---");
                Console.WriteLine($"-- Available Parking Lots : {parkingLots} --\n");
                Console.WriteLine("Please Type Your Choices");
                Console.WriteLine("1. Check-In \n" +
                    "2. Check-Out \n" +
                    "3. Reports \n");
                try
                {
                    int choice = Int32.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            {
                                Console.WriteLine("Checking In");
                                CheckIn.CheckingIn();
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Checking Out");
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("Reports");
                                break;
                            }
                        default:
                            Console.WriteLine("\n ### Please Enter Valid Choice ### \n");
                            break;
                    }
                }
                catch (Exception e) { 
                    Console.WriteLine(e.Message.ToString()); 
                }

            }
        }
    }
}
