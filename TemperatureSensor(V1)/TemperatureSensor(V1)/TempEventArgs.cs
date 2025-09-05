using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureSensor_ObserverPattern_
{
    // used for extensibility
    internal class TempEventArgs : EventArgs
    {
        public int Temperature { get; set; }
        public TempEventArgs(int temp)
        {
            Temperature = temp;
        }
    }
}
