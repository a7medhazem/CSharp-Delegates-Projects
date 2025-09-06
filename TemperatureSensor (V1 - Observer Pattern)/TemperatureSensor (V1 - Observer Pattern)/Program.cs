namespace TemperatureSensor_ObserverPattern_
{
    internal class Program
    {
        // Temperature Sensor System (Version 1) using Observer Pattern
        static void Main(string[] args)
        {
            //sensor => (input temp)
            //display
            //alarm

            Sensor sensor = new Sensor();
            Display display = new Display();
            Alarm alarm = new Alarm(30); //default temp 30 deg

            // Subscribe display to sensor
            sensor.SensorChanged += display.ShowTemprature;

            // Subscribe alarm to sensor
            sensor.SensorChanged += alarm.CallAlarm;


            while (true)
            {
                Console.WriteLine("\tWelcome to the Temperature Sensor System");
                Console.WriteLine("########################################################");
                Console.WriteLine("1. Set the temprature");
                Console.WriteLine("2. Set the alarm value (default 30)");
                Console.WriteLine("3. Exit");
                Console.WriteLine("");
                Console.Write("Your choice: ");
                bool checkChoice = int.TryParse(Console.ReadLine(), out int userChoice);
                if (checkChoice)
                {
                    switch (userChoice)
                    {
                        case 1:
                            {
                                Console.Write("Please enter the temprature value in degrees: ");
                                //Input validation
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
