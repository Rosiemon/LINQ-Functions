using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQfunctions
{
    class PrintList
    {
        public void PrintSingleList()
        {
            List<string> List = new List<string>();
            List.Add("Elephant");
            List.Add("Elephant");
            List.Add("Elephant");
            List.Add("Peacock");
            List.Add("Pheonix");
            List.Add("Panda");
            List.Add("Monkey");
            List.Add("Monkey");
            List.Add("Tiger");
            List.Add("Panther");
            List.Add("Koala");

            IEnumerable<string> animals = List.Distinct();

            foreach (string item in animals)
            {
                Console.WriteLine(item);
            }
        }
    }
}
