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
            PrintList list = new PrintList();
            Console.WriteLine("Return a copy of a list without duplication: ");
            list.PrintSingleList();
            Console.ReadKey();
            ; 
            Console.WriteLine("Show student grade average and overall classroom average");
            GradeCalculations grades = new GradeCalculations();
            grades.CalculateGradeAverage();
            Console.ReadKey();

            Console.WriteLine("Return a string in alphabetical order with number of letter frequency: ");
            OrderedString orderedstring = new OrderedString();
            orderedstring.RearrangeString();
            Console.ReadKey();
        }
    }
}
