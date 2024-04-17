using ParkingLotApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotApp.Features
{
    class CheckOut
    {
        public static void CheckingOut(ParkingLot lot)
        {
            try
            {
                bool status = true;
                while (status) {

                    Console.WriteLine($"Please Type The Slot (1 - {lot.Slot.Count})");
                    Console.WriteLine("-- Type 'back' To Go Back --\n");

                    string input = Console.ReadLine();
                    if (input.ToLower().Equals("back"))
                    {
                        Console.WriteLine("Going Back...\n");
                        return;
                    }
                    else
                    {
                        int slot = int.Parse(input);
                        if (slot == null || slot <= 0 || !lot.Slot.ContainsKey(slot))
                        {
                            Console.WriteLine("Invalid Slot Number \n");
                        }
                        else
                        {
                            if (lot.Slot[slot] == null)
                            {
                                Console.WriteLine($"Slot is Already free");
                            }
                            else
                            {
                                lot.Slot[slot] = null;
                                Console.WriteLine($"Slot number {slot} is free");
                            }

                        }
                    }
                }
            }
            catch (Exception e) { 
                Console.WriteLine(e.Message.ToString());
            }
        }
    }
}
