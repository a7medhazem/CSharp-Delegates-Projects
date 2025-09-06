using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureSensor_V2_
{
    internal class Alarm
    {
        private int AlarmValue { get; set; } //threshold

        public void Subscribe(Broker broker)
        {
            broker.Subscribe("TempratureChanged", CallAlarm);
        }

        // Initialize value for the alarm
        public Alarm(int alarmTemp)
        {
            AlarmValue = alarmTemp;
        }
        public void SetAlarmValue(int newAlarmValue)
        {
            AlarmValue = newAlarmValue;
        }

        public void CallAlarm(TempEventArgs args)
        {
            if (args.Temperature >= AlarmValue)
            {
                Console.WriteLine($"Take care! The temperature value ({args.Temperature}°) is greater than {AlarmValue}°.");
                Console.WriteLine("========================================================");
            }

        }
    }
}
