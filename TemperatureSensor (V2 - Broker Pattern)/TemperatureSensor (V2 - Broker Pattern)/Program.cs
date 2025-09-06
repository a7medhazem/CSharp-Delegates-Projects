namespace TemperatureSensor_V2_
{
    internal class Program
    {
        // Temperature Sensor System (Version 2 - Broker Pattern)

        static void Main(string[] args)
        {
            //sensor => (input temp)
            //display
            //alarm
            Broker broker = new Broker();

            //publisher
            Sensor sensor = new Sensor(broker);

            //subscribers
            Display display = new Display();
            Alarm alarm = new Alarm(30); //default temp 30 deg


            // Subscriptions
            display.Subscribe(broker);
            alarm.Subscribe(broker);


            while (true)
            {
                Console.WriteLine("\tWelcome to the Temperature Sensor System");
                Console.WriteLine("########################################################");
                Console.WriteLine("1. Set the temprature");
                Console.WriteLine("2. Set the alarm value (default 30)");
                Console.WriteLine("3. Exit");
                Console.WriteLine("");
                Console.Write("Enter your choice: ");
                bool checkChoice = int.TryParse(Console.ReadLine(), out int userChoice);
                if (checkChoice)
                {
                    switch (userChoice)
                    {
                        case 1:
                            {
                                Console.Write("Please enter the temprature value in degrees: ");
                                bool checkTemp = int.TryParse(Console.ReadLine(), out int inputTemp);
                                if (checkTemp)
                                {
                                    if (!(inputTemp < 0))
                                    {
                                        sensor.ChangeTemprature(inputTemp);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Temperature cannot be negative.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input. Please try again.");
                                }
                                break;
                            }

                        case 2:
                            {
                                Console.Write("Please enter temprature value for the alarm: ");
                                bool checkalarmValue = int.TryParse(Console.ReadLine(), out int alarmValue);
                                if (checkalarmValue)
                                {
                                    if (!(alarmValue < 0))
                                    {
                                        alarm.SetAlarmValue(alarmValue);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Temperature value cannot be negative.");
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Invalid input. Please try again.");
                                }
                                break;
                            }

                        case 3:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid choice!");
                            Console.WriteLine("========================================================");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    Console.WriteLine("========================================================");

                }

            }

        }
    }
}
