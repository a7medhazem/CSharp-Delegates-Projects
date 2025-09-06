using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureSensor_V2_
{
    internal class Broker
    {
        // Create dictionary to hold subjects & subscribers
        private Dictionary<string, List<Action<TempEventArgs>>> SubscriberList = new Dictionary<string, List<Action<TempEventArgs>>>();



        /*
          * Parameters of Subscribe:
          * - The event to subscribe to
          * - The actions to perform when this event occurs
          *
          * Example:
          * -TemepratureChanged => ShowTemperature, CallAlarm
         */
        public void Subscribe(string subject, Action<TempEventArgs> action)
        {
            if (!SubscriberList.ContainsKey(subject))
            {
                // Add new event if not found
                SubscriberList[subject] = new List<Action<TempEventArgs>>();
            }

            // Adding the action to the subscribtion list
            SubscriberList[subject].Add(action);




        }


        public void Publish(string subject, TempEventArgs msg)
        {
            if (SubscriberList.ContainsKey(subject))
            {
                var subscriberToSubject = SubscriberList[subject];
                foreach (var item in subscriberToSubject)
                {
                    item.Invoke(msg);
                }
            }


        }

    }
}
