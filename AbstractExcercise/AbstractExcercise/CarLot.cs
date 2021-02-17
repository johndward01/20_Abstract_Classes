using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExcercise
{
    public class CarLot
    {
        public List<Vehicle> List { get; set; } = new List<Vehicle>();        

        public void PrintCarList()
        {            
            foreach (var vehicle in List)
            {
                Console.WriteLine($"This vehicle has a trunk: {vehicle.HasTrunk}\n" +
                                  $"This vehicle has a side car: {vehicle.HasSideCar}\n" +
                                  $"This vehicle has {vehicle.Wheels} wheels\n" +
                                  $"This vehicle has {vehicle.Doors} doors\n");
            }
        }
    }
}
