using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode._2022.Day2
{
    internal class DayTwo
    {
        string path = "C:\\Users\\IT\\source\\repos\\AdventOfCode\\AdventOfCode\\2022\\Day2\\data.txt";
        //A,X = Rock = 1
        //B,Y = Papar = 2
        //C,Z = Scissors = 3
        //lose = 0
        //draw = 3 
        //win = 6
        //Rock > Scissors > Papar > Rock
        int total = 0;
        public void PartOne() 
        {
            foreach (string line in File.ReadLines(path))
            {
                switch (line)
                {
                    case ("A X"):
                    case ("B Y"):
                    case ("C Z"):
                        total += 3;
                        break;
                    case ("A Y"):
                    case ("B Z"):
                    case ("C X"):
                        total += 6;
                        break;
                }
                string[] a =  line.Split(new char[]{ ' ' },2);
                switch (a[1])
                {
                    case "X":
                        total += 1;
                        break;
                    case "Y":
                        total += 2;
                        break;
                    case "Z":
                        total += 3;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(total);
        }
        //A = Rock = 1
        //B = Papar = 2
        //C = Scissors = 3
        //X = Lose = 0
        //Y = Draw = 3
        //Z = Win = 6
        //Rock > Scissors > Papar > Rock
        public void PartTwo()
        {
            foreach (string line in File.ReadLines(path))
            {
                switch (line)
                {
                    case ("A Y"): 
                    case ("B Y"): 
                    case ("C Y"):
                        total += 3;
                        break;
                    case ("A Z"):
                    case ("B Z"):
                    case ("C Z"):
                        total += 6;
                        break;
                }

                switch (line)
                {
                    case ("A Y"): //rock
                    case ("B X"): //rock
                    case ("C Z"): //rock
                        total += 1;
                        break;
                    case ("A Z"): //paper
                    case ("B Y"): //paper
                    case ("C X"): //paper
                        total += 2;
                        break;
                    case ("A X"): //scissors
                    case ("B Z"): //scissors
                    case ("C Y"): //scissors
                        total += 3;
                        break;
                }
            }
            Console.WriteLine(total);
        }
    }
}
