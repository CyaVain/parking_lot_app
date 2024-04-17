using ParkingLotApp.Features;
using ParkingLotApp.Models;
using System;
using System.ComponentModel.Design;

namespace ParkingLotApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int slots = CreateSlots.Slots();
            ParkingLot lot = new ParkingLot();
            for (int i = 1; i <= slots; i++)
            {
                lot.Slot.Add(i, null);
            }
            MainMenu.Menu(lot) ;
        }
    }
}
