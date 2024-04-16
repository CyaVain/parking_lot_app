using ParkingLotApp.Features;
using System;
using System.ComponentModel.Design;

namespace ParkingLotApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int parkingLots = 6;
            MainMenu.Menu(parkingLots);
        }
    }
}
