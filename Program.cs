using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQfunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeCalculations grades = new GradeCalculations();
            grades.CalculateGradeAverage();
            Console.ReadKey();

            OrderedString orderedstring = new OrderedString();
            orderedstring.RearrangeString();
            Console.ReadKey();

            PrintList list = new PrintList();
            list.PrintSingleList();
            Console.ReadKey();
        }
    }
}
