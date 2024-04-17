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
            try
            {
                while (slots <= 0 || slots > 10)
                {
                    Console.WriteLine("Input How Many Lots To Create");
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
                return slots;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                return 0;
            }
        }
    }
}
