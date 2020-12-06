using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCodeDay5Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputString = "";
            try
            {
                inputString = File.ReadAllText("input.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            var passList = inputString.Split("\n").ToList();
            var highId = 0;

            foreach (var pass in passList)
            {
                var directions = pass.ToCharArray();
                var row = Enumerable.Range(0, 128).ToList();
                var col = Enumerable.Range(0, 8).ToList();
                foreach (var direction in directions)
                {
                    switch (direction)
                    {
                        case 'F':
                            row.RemoveRange((row.Count / 2), (row.Count / 2));
                            break;
                        case 'B':
                            row.RemoveRange(0, (row.Count / 2));
                            break;
                        case 'L':
                            col.RemoveRange((col.Count / 2), (col.Count / 2));
                            break;
                        case 'R':
                            col.RemoveRange(0, (col.Count / 2));
                            break;
                    }
                }
                var idNum = ((row.First() * 8) + col.First());
                if (idNum > highId)
                {
                    highId = idNum;
                }
            }
            Console.WriteLine($"High Id number is {highId}");
        }
    }
}