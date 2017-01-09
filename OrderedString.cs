﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQfunctions
{
    class OrderedString
    {
        public void RearrangeString()
        {
            List<string> Words = new List<string>();
            Console.WriteLine("Please enter a word: ");
            string Sentance = Console.ReadLine();
            Sentance = String.Concat(Sentance.ToUpper().OrderBy(alphabetical => alphabetical));
            foreach (char Letter in Sentance)
            {
                Words.Add(Letter.ToString());
            }
            var query = Words.GroupBy(x => x[0]);
            foreach (var letter in query)
            {
                Console.Write("{0}{1} ", letter.Key, letter.Count());
            }
            Console.WriteLine();
        }
    }
}
