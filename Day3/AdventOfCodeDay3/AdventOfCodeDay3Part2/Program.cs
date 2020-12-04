using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCodeDay3Part2
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

            long count1 = CalculateTrees(1, 3, map);
            long count2 = CalculateTrees(1, 1, map);
            long count3 = CalculateTrees(1, 5, map);
            long count4 = CalculateTrees(1, 7, map);
            long count5 = CalculateTrees(2, 1, map);
            
            Console.WriteLine($"Count is: {count1 * count2 * count3 * count4 * count5}");
            
        }

        public static int CalculateTrees(int rowSlope, int colSlope, List<char[]> map)
        {
            var count = 0;
            var colIndex = colSlope;
            var rowIndex = rowSlope;
            
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

                rowIndex += rowSlope;
                if (colIndex + colSlope > map.First().Length - 1)
                {
                    colIndex = (colIndex + colSlope) - (map.First().Length);
                }
                else
                {
                    colIndex += colSlope;
                }
            }

            return count;
        }
    }
}