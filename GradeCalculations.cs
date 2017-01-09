using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQfunctions
{
    class GradeCalculations
    {
        public void CalculateGradeAverage()
        {
            List<int> classAverage = new List<int>();
            List<string> grades = new List<string>();
            grades.Add("59,80,67,89,100,50");
            grades.Add("99,97,89,93,97,99");
            grades.Add("85,87,88,98,100,72");
            grades.Add("68,70,98,76,56,100");
            grades.Add("92,94,99,96,91,95");
            grades.Add("81,83,40,59,64,100");

            foreach (var grade in grades)
            {
                List<int> averagePerson = new List<int>();
                string[] words = grade.Split(',');
                foreach (string number in words)
                {
                    var FixedNumber = int.Parse(number);
                    averagePerson.Add(FixedNumber);
                }
                var MinGrade = (from d in averagePerson select d).Min();
                averagePerson.Remove(MinGrade);
                var gradeCount = (from individualGrade in averagePerson select individualGrade).Count();
                var gradeSum = (from individualGrade in averagePerson select individualGrade).Sum();
                var NewAverage = (gradeSum / gradeCount);
                classAverage.Add(NewAverage);
                Console.WriteLine("Student Average Grade:");
                Console.WriteLine(NewAverage);
            }
            var ClassCount = (from counting in classAverage select counting).Count();
            var ClassSum = (from summing in classAverage select summing).Sum();
            var ClassAverage = (ClassSum / ClassCount);
            Console.WriteLine("The Classroom Grade Average Is:");
            Console.WriteLine(ClassAverage);
            Console.ReadLine();
        }
    }
}
