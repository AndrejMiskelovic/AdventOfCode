using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode._2022.Day4
{
    internal class DayFour
    {
        string path = "C:\\Users\\IT\\source\\repos\\AdventOfCode\\AdventOfCode\\2022\\Day4\\data.txt";
        int total = 0;
        public void PartOne()
        {
            foreach (var line in File.ReadLines(path))
            {
                List<int> leftRange = new List<int>();
                List<int> rightRange = new List<int>();
                string[] pairs = line.Split(',', 2);
                for (int i = 0; i < pairs.Count(); i++)
                {
                    if (i == 0)
                    {
                        string[] left = pairs[i].Split("-", 2);
                        for (int j = Convert.ToInt32(left[0]); j <= Convert.ToInt32(left[1]); j++)
                        {
                            leftRange.Add(j);
                        }
                    }
                    else
                    {
                        string[] right = pairs[i].Split("-", 2);
                        for (int j = Convert.ToInt32(right[0]); j <= Convert.ToInt32(right[1]); j++)
                        {
                            rightRange.Add(j);
                        }
                    }
                }
                if (leftRange.Contains(rightRange.First()) && leftRange.Contains(rightRange.Last()))
                    total += 1;
                else if (rightRange.Contains(leftRange.First()) && rightRange.Contains(leftRange.Last()))
                    total += 1;

            }
            Console.WriteLine(total);
        }
        public void PartTwo()
        {
            foreach (var line in File.ReadLines(path))
            {
                List<int> leftRange = new List<int>();
                List<int> rightRange = new List<int>();
                string[] pairs = line.Split(',', 2);
                for (int i = 0; i < pairs.Count(); i++)
                {
                    if (i == 0)
                    {
                        string[] left = pairs[i].Split("-", 2);
                        for (int j = Convert.ToInt32(left[0]); j <= Convert.ToInt32(left[1]); j++)
                        {
                            leftRange.Add(j);
                        }
                    }
                    else
                    {
                        string[] right = pairs[i].Split("-", 2);
                        for (int j = Convert.ToInt32(right[0]); j <= Convert.ToInt32(right[1]); j++)
                        {
                            rightRange.Add(j);
                        }
                    }
                }
                if (leftRange.Contains(rightRange.First()) || leftRange.Contains(rightRange.Last()))
                    total += 1;
                else if (rightRange.Contains(leftRange.First()) || rightRange.Contains(leftRange.Last()))
                    total += 1;

            }
            Console.WriteLine(total);
        }
    }
}
