using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExcercise
{
    public class Car : Vehicle
    {
        public bool HasTrunk { get; set; }
        public int CarID { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine($"A car drives with 4 wheels and has 2 or 4 doors.");
        }

       

    }
}
