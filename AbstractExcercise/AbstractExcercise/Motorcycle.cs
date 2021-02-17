using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExcercise
{
    public class Motorcycle : Vehicle
    {
        
        public int Wheels { get; set; }
        public int Doors { get; set; }


        public Motorcycle()
        {            
            Wheels = 2;
            Doors = 0;
        }
        public override void Drive()
        {
            Console.WriteLine($"A motorcycle drives with {Wheels} wheels and has {Doors} doors.");
        }

        public override void Shift()
        {
            Console.WriteLine("Manual Shift");
        }
    }
}
