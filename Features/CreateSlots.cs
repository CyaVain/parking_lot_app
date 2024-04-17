using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace ParkingLotApp.Features
{
    class CreateSlots
    {
        public static int Slots()
        {
            int slots = 0;
            while (slots <= 0 || slots > 10)
            {
                try
                {
                    Console.WriteLine("Input How Many Slots To Create");
                    slots = Int32.Parse(Console.ReadLine());
                    if (slots == 0)
                    {
                        Console.WriteLine("Slots Can't Be 0");
                    }
                    else if (slots > 10)
                    {
                        Console.WriteLine("Slots Can't Be More Than 10");
                    }
                    else Console.WriteLine($"Created a parking lot with {slots} slots\n");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"### {e.Message.ToString()} ### \n");
                }
            }
            return slots;
        }
    }
}