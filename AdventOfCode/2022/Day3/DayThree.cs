using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode._2022.Day3
{
    internal class DayThree
    {
        string path = "C:\\Users\\IT\\source\\repos\\AdventOfCode\\AdventOfCode\\2022\\Day3\\data.txt";
        Dictionary<char, int> lowercase = new Dictionary<char, int>();
        Dictionary<char, int> uppercase = new Dictionary<char, int>();
        int total = 0;
        public void PartOne()
        {
            for (char c = 'a'; c <= 'z'; c++)
            {
                int key = c - 'a' + 1;
                lowercase.Add(c, key);
            }
            for (char c = 'A'; c <= 'Z'; c++)
            {
                int key = 26 + c - 'Z';
                key += 26;
                uppercase.Add(c, key);
            }
            foreach (var line in File.ReadLines(path))
            {
                string first = line.Substring(0, (int)(line.Length / 2));
                string second = line.Substring((int)(line.Length / 2), (int)(line.Length / 2));

                foreach (char letter in first.ToCharArray())
                {
                    if (second.Contains(letter))
                    {
                        if(lowercase.ContainsKey(letter))
                            total += lowercase[letter];
                        else
                            total += uppercase[letter];
                        break;
                    }
                }
            }
            Console.WriteLine(total);
        }
        public void PartTwo()
        {
            for (char c = 'a'; c <= 'z'; c++)
            {
                int key = c - 'a' + 1;
                lowercase.Add(c, key);
            }
            for (char c = 'A'; c <= 'Z'; c++)
            {
                int key = 26 + c - 'Z';
                key += 26;
                uppercase.Add(c, key);
            }
            List<string> groupitems = new List<string>(); 
            foreach (var line in File.ReadLines(path))
            {
                groupitems.Add(line);
                if(groupitems.Count == 3)
                {
                    foreach (char letter in groupitems[0].ToCharArray())
                    {
                        if (groupitems[1].Contains(letter) && groupitems[2].Contains(letter))
                        {
                            if (lowercase.ContainsKey(letter))
                                total += lowercase[letter];
                            else
                                total += uppercase[letter];
                            break;
                        }
                    }
                    groupitems.Clear();
                }

            }
            Console.WriteLine(total);
        }
    }
}
