using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradingSystem
{
    internal class GradingSystem
    {
        public void DisplayGradinginfo(List<Student> students
            , Func<List<int>, double> CalculateAverage
            , Predicate<double> CheckUserPassed
            , Action<string, double, bool> DisplayResult)
        {
            foreach (var student in students)
            {
                //invoking all delegates...
                double AvgGrades = CalculateAverage(student.Grades);
                bool status = CheckUserPassed(AvgGrades);
                DisplayResult(student.Name, AvgGrades, status);

            }
        }

    }
}
