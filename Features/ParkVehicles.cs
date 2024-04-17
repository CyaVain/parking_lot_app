using ParkingLotApp.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ParkingLotApp.Features
{
    class ParkVehicles
    {
        private static string[] digits = {"0","1","2","3","4","5","6","7","8","9"};
        public static void Parks(ParkingLot lot)
        {
            try {
                Vehicles vehicle = new Vehicles();
                bool invalidInput = true;
                while (invalidInput) {
                    Console.WriteLine("Please Type The Registration Number example ('a1234XXX','ab2345yyy') \n Type 'back' to go back \n");
                    string regisNo = Console.ReadLine().ToUpper();
                    if (regisNo.Equals("BACK"))
                    {
                        Console.WriteLine("Going Back..\n");
                        return;
                    }
                    else if (regisNo.Length <= 0 && regisNo.Length < 2 && regisNo.Length > 9 || !regisNo.Any(char.IsDigit))
                    {
                        Console.WriteLine("Please Enter Valid Registration Number");
                    }
                    else
                    {
                        var firstLetter = Regex.Match(regisNo, @"[A-Z]+");
                        var numbers = Regex.Match(regisNo, @"\d+");
                        var lastLetter = Regex.Match(regisNo, @"\D+$");

                        string plateNo = string.Concat(firstLetter, '-', numbers, '-', lastLetter);
                        vehicle.RegistrationNo = plateNo;

                        Console.WriteLine("Please Type Of Vehicle example ('motor','mobil')\n Type 'back' to go back \n");
                        string type = Console.ReadLine().ToLower();
                        if (type.Equals("back"))
                        {
                            Console.WriteLine("Going Back..\n");
                            return;
                        }
                        else if (type.Length <= 0 || !type.Equals("motor") && !type.Equals("mobil"))
                        {
                            Console.WriteLine("Please Enter Valid Vehicle Type");
                        }
                        else {
                            type = char.ToUpper(type[0]) + type.Substring(1);
                            vehicle.Type = type;

                            Console.WriteLine("Please Type the Colour  example ('putih','hitam')\n Type 'back' to go back \n");
                            string colour = Console.ReadLine().ToLower();
                            if (colour.Equals("back")){
                                Console.WriteLine("Going Back..\n");
                                return;
                            }
                            else if (colour.Length <= 0 || colour.Length > 15)
                            {
                                Console.WriteLine("Please Enter Valid Colour");
                            }
                            else
                            {
                                colour = char.ToUpper(colour[0]) + colour.Substring(1);
                                vehicle.Colour = colour;

                                Console.WriteLine($"Your Vehicle: {vehicle.RegistrationNo} {vehicle.Type} {vehicle.Colour} ");

                                invalidInput = false;
                            }
                        }
                    }
                }
                // End Of Nested If For Validation
                foreach (int slotNo in lot.Slot.Keys)
                {
                    if (lot.Slot[slotNo] == null)
                    {
                        lot.Slot[slotNo] = vehicle;
                        Console.WriteLine($"Allocated slot number : {slotNo}\n");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, parking lot is full\n");
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
        }
    }
}
