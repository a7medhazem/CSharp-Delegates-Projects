using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureSensor_V2_
{
    internal class Display
    {
        public void Subscribe(Broker broker)
        {
            broker.Subscribe("TemepratureChanged", ShowTemprature);
        }
        public void ShowTemprature(TempEventArgs args)
        {
            Console.WriteLine($"The temprature is now set to {args.Temperature}° from display.");
            Console.WriteLine("========================================================");

        }
    }
}
