using ParkingLotApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ParkingLotApp.Features.Reports
{
    class FindPlates
    {
        public static void Odd(ParkingLot lot)
        {
            int counter = 0;
            foreach (Vehicles v in lot.Slot.Values)
            {

                if (v != null)
                {
                    var plateDigits = Regex.Match(v.RegistrationNo, @"\d+");
                    if (plateDigits.Success)
                    {
                        int digits = int.Parse(plateDigits.Value);

                        if (digits % 2 != 0)
                        {
                            Console.WriteLine($"{v.RegistrationNo}");
                            counter++;
                        }
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("No Vehicle With Odd Plates Number Parked Here");
            }
        }

        public static void Even(ParkingLot lot)
        {
            int counter = 0;
            foreach (Vehicles v in lot.Slot.Values)
            {
                if (v != null)
                {
                    var plateDigits = Regex.Match(v.RegistrationNo, @"\d+");
                    if (plateDigits.Success)
                    {
                        int digits = int.Parse(plateDigits.Value);

                        if (digits % 2 == 0)
                        {
                            Console.WriteLine($"{v.RegistrationNo}");
                            counter++;
                        }
                    }
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("No Vehicle With Odd Plates Number Parked Here");
            }
        }

        public static void Slot(ParkingLot lot)
        {
            bool status = true;
            string input;
            bool foundVehicle = false;
            while (status)
            {
                try
                {
                    Console.WriteLine("Please Type The Plate No example ('a-1234-xxx', 'AB-2345-YYY')");
                    input = Console.ReadLine().ToUpper();
                    if (input.Length <= 0 || input.Length > 12)
                    {
                        Console.WriteLine("### Plate Number is Too Long Or Too Short (Max 12 Digits) ### \n");
                    }
                    else
                    {
                        foreach (KeyValuePair<int, Vehicles> pair in lot.Slot)
                        {
                            int slotNo = pair.Key;
                            Vehicles v = pair.Value;
                            if (v != null)
                            {
                                if (v.RegistrationNo.Equals(input))
                                {
                                    foundVehicle = true;
                                    Console.WriteLine($"Vehicle is on Slot No : {slotNo}");
                                }
                            }
                        }
                        status = false;
                        if (foundVehicle == false)
                        {
                            Console.WriteLine($"Vehicle Not Found");
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message.ToString());
                }
            }
        }

        public static void Colour(ParkingLot lot)
        {
            bool status = true;
            string input;
            bool foundVehicle = false;
            while (status)
            {
                try
                {
                    Console.WriteLine("Please Type The Colour Of Vehicle example ('Putih', 'hitam' , 'Biru muda')");
                    input = Console.ReadLine().ToUpper();
                    if (input.Length <= 0 || input.Length > 15)
                    {
                        Console.WriteLine("### The Colour Is Not Valid, Is It A Real Colour's Name ? ### \n");
                    }
                    else
                    {
                        Console.WriteLine($"Vehicle With Colour {input}");
                        foreach (KeyValuePair<int, Vehicles> pair in lot.Slot)
                        {
                            int slotNo = pair.Key;
                            Vehicles v = pair.Value;
                            if (v != null)
                            {
                                if (v.Colour.ToUpper().Equals(input))
                                {
                                    foundVehicle = true;
                                    Console.Write($"{v.RegistrationNo}, ");
                                }
                            }
                        }
                        status = false;
                        if (foundVehicle == false)
                        {
                            Console.WriteLine($"Vehicle Not Found");
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
}
