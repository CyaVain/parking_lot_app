using ParkingLotApp.Features.Reports;
using ParkingLotApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotApp.Features
{
    class ReportMenu
    {
        public static void Menu(ParkingLot lot)
        {
            bool status = true;
            try
            {
                while (status)
                {
                    Console.WriteLine("\n Pick Your Option (1 - 7)");
                    Console.WriteLine("1. Status\n" +
                        "2. Type Of Vehicle : Motor\n" +
                        "3. Type Of Vehcile : Mobil\n" +
                        "4. Odd Plates \n" +
                        "5. Even Plates \n" +
                        "6. Search The Slot by Plate No \n" +
                        "7. Search Vehicle by Colour\n" +
                        "8. Back To Main Menu \n");
                    string choice = Console.ReadLine();
                    switch(choice)
                    {
                        case "1":
                            {
                                Console.WriteLine("Parking Lot Status \n");
                                LotStatus.Status(lot);
                                break;
                            }
                        case "2":
                            {
                                Console.WriteLine("Total Motor :");
                                CountVehicles.Motor(lot);
                                break;
                            }
                        case "3":
                            {
                                Console.WriteLine("Total Mobil :");
                                CountVehicles.Mobil(lot);
                                break;
                            }
                        case "4":
                            {
                                Console.WriteLine("Odd Numbered Plates :");
                                FindPlates.Odd(lot);
                                break;
                            }
                        case "5":
                            {
                                Console.WriteLine("Even Numbered Plates :");
                                FindPlates.Even(lot);
                                break;
                            }
                        case "6":
                            {
                                Console.WriteLine("Search Slot Number by Plates :");
                                FindPlates.Slot(lot);
                                break;
                            }
                        case "7":
                            {
                                Console.WriteLine("Seaching Vehicle By Colour :");
                                FindPlates.Colour(lot);
                                break;
                            }
                        case "8":
                            {
                                Console.WriteLine("Back To Main Menu...");
                                status = false;
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("### Please Enter Valid Option ### \n");
                                break;
                            }

                    }

                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
        }
    }
}
