using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureSensor_ObserverPattern_
{
    internal class Sensor
    {
        //declare event
        public event EventHandler<TempEventArgs> SensorChanged;
        private int CurrentTemprature { get; set; }

        public void ChangeTemprature(int NewTemprature)
        {
            CurrentTemprature = NewTemprature;
            //event invokation
            SensorChanged.Invoke(this, new TempEventArgs(NewTemprature));
        }

    }
}
