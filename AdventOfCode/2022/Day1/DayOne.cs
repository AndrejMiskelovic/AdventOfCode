using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode._2022
{
    internal class DayOne
    {
        string path = "C:\\Users\\IT\\source\\repos\\AdventOfCode\\AdventOfCode\\2022\\Day1\\data.txt";
        int a = 0;
        List<int> total = new List<int>();
        public void PartOne()
        {
            foreach (string line in File.ReadLines(path))
            {
                if (!String.IsNullOrEmpty(line))
                {
                    a += Convert.ToInt32(line);
                }
                else
                {
                    total.Add(a);
                    a = 0;
                }
            }
            Console.WriteLine(total.Max());
        }
        public void PartTwo()
        {
            foreach (string line in File.ReadLines(path))
            {
                if (!String.IsNullOrEmpty(line))
                {
                    a += Convert.ToInt32(line);
                }
                else
                {
                    total.Add(a);
                    a = 0;
                }
            }
            total.Sort();
            Console.WriteLine(total.GetRange(total.Count()-3,3).Sum());
        }
    }
}
