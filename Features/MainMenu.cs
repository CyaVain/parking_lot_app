using ParkingLotApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotApp.Features
{
    class MainMenu
    {
        public static void Menu(ParkingLot lot)
        {
            bool status = true;
            while (status)
            {
                Console.WriteLine("--- Welcome to WaterFall Parking ---");

                int availableSlots = lot.Slot.Count(s => s.Value == null);
                Console.WriteLine($"-- Available Slots : {availableSlots} --\n");

                Console.WriteLine("Please Pick Your Choices (1 - 4)");
                Console.WriteLine("1. Check-In \n" +
                    "2. Check-Out \n" +
                    "3. Reports \n" +
                    "4. Exit \n");
                try
                {
                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            {
                                Console.WriteLine("Checking In... \n");
                                CheckIn.CheckingIn(lot);
                                break;
                            }
                        case "2":
                            {
                                Console.WriteLine("Checking Out");
                                CheckOut.CheckingOut(lot);
                                break;
                            }
                        case "3":
                            {
                                Console.WriteLine("Reports");
                                Reports.ReportMenu(lot);
                                break;
                            }
                        case "4":
                            {
                                Console.WriteLine("Exit The Program...");
                                status = false;
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
