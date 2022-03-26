using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Membuat Object Taxi
            ConsoleApp1.Taxi taxi = new ConsoleApp1.Taxi();

            // Pengesetan nilai properties
            taxi.DriverName = "Gugun";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            // Panggil Method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOfPassenger();

            Console.ReadKey();
        }
    }
}