using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureSensor_V2_
{
    internal class TempEventArgs
    {
        public int Temperature { get; set; }
        public TempEventArgs(int temp)
        {
            Temperature = temp;
        }
    }
}
