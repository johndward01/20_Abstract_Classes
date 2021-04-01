using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExcercise
{
    public class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; }
        public int MotorcycleID { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine($"A motorcycle drives with 2 wheels and has no doors.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Overriding the DriveVirtual implementation");
        }
    }
}
