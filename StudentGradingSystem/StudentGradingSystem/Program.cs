namespace StudentGradingSystem
{
    internal class Program
    {
        // Delegates Exercise - Student Grading System


        static void Main(string[] args)
        {
            List<Student> Students = new List<Student>(); //list of all students in the system
            while (true)
            {
                Console.WriteLine("\tWelcome to my Student Grading System");
                Console.WriteLine("#######################################################");

                Console.Write("Enter your name (or type 'done' to finish): ");
                string StudentName = Console.ReadLine();
                Console.WriteLine("=======================================================");


                if (!string.IsNullOrEmpty(StudentName))
                {

                    // Check if user input is 'done' to exit the loop
                    if (string.Equals(StudentName, "done", StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }

                    Console.WriteLine("Please enter your grades for 6 subjects: ");
                    List<int> StudentGrades = new List<int>(); //list of all grades for specific student

                    for (int i = 0; i < 6; i++)
                    {
                        Console.Write($"Enter the grade for subject {i + 1}: ");
                        bool CheckGrade = int.TryParse(Console.ReadLine(), out int UserGrade);
                        if (CheckGrade)
                        {
                            StudentGrades.Add(UserGrade);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please try again.");
                            --i; // Decrease counter to let the user re-enter this value
                        }
                    }
                    Console.WriteLine("=======================================================");


                    Student NewStudent = new Student()
                    {
                        Name = StudentName,
                        Grades = StudentGrades
                    };



                    Students.Add(NewStudent); //adding the new student to the students list
                    Console.WriteLine($"A new student with name {StudentName} added successfully");
                    Console.WriteLine("=======================================================");

                }


                else
                {
                    Console.WriteLine("Name cannot be empty. Please try again.");
                }
            }

            GradingSystem GradingSystem = new GradingSystem();
            GradingSystem.DisplayGradinginfo(Students, CalculateAvg, CheckUserPassed, DisplayResult);

        }




        // This function must have the same signature as the delegate because it will be assigned to it
        public static double CalculateAvg(List<int> grades)
        {
            return grades.Sum() * 1.0 / grades.Count();
        }



        public static bool CheckUserPassed(double avgvalue)
        {
            // Full mark = 100, passing mark = 50

            return avgvalue >= 50;
        }



        public static void DisplayResult(string name, double avg, bool paas)
        {
            string status = paas ? "Passed" : "Failed";
            Console.WriteLine($"Student name is: {name}");
            Console.WriteLine($"Average grade: {avg:F2}");
            Console.WriteLine($"Student Status: {status}");
            Console.WriteLine("=======================================================");

        }
    }
}
