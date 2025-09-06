using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureSensor_ObserverPattern_
{
    internal class Display
    {
        public void ShowTemprature(object? obj, TempEventArgs args)
        {
            Console.WriteLine($"The temperature is now set to {args.Temperature}° from display.");
            Console.WriteLine("========================================================");

        }
    }
}
