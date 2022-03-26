﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }



        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);
            Console.WriteLine("OnDuty : {0} ", OnDuty);
            Console.WriteLine("Number of Passenger : {0}", NumPassenger);
        }
        public void PickUpPassenger()
        {
            Console.WriteLine(DriverName + " sedang menjemput penumpang!");
        }

        public void DropOfPassenger()
        {
            Console.WriteLine(DriverName + " selesai mengatar penumpang!");
        }
    }
}
