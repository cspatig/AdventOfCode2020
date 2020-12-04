using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCodeDay3Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputString = "";
            var map = new List<char[]>();
            try
            {
                inputString = File.ReadAllText("input.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            foreach (var row in inputString.Split('\n'))
            {
                map.Add(row.ToCharArray());
            }

            var rowIndex = 1;
            var colIndex = 3;
            var count = 0;

            while (true)
            {
                if (rowIndex > map.Count - 1)
                {
                    break;
                }

                if (map[rowIndex][colIndex] == '#')
                {
                    count++;
                }
                rowIndex++;
                if (colIndex + 3 > map.First().Length - 1)
                {
                    colIndex = (colIndex + 3) - (map.First().Length);
                }
                else
                {
                    colIndex += 3;
                }
            }

            Console.WriteLine($"The count is: {count}");
        }
    }
}