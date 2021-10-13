using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExcercise
{
    public class Motorcycle : Vehicle
    {
        public int Wheels { get; set; }
        public int Doors { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine($"A motorcycle drives with {Wheels} wheels and has {Doors} doors.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"I'm driving a {GetType().Name} in a virtual method, it is a {GetType().BaseType.Name}");
        }
    }
}

