using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureSensor_V2_
{
    internal class Sensor
    {
        private Broker _Broker;
        public Sensor(Broker broker)
        {
            _Broker = broker;
        }
        private int CurrentTemprature { get; set; }

        public void ChangeTemprature(int NewTemprature)
        {
            CurrentTemprature = NewTemprature;
            _Broker.Publish("TempratureChanged", new TempEventArgs(NewTemprature));
        }

    }
}
