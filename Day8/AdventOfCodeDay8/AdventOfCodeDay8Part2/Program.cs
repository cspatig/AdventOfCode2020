using System;
using System.IO;
using System.Linq;

namespace AdventOfCodeDay8Part2
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

            var instructions = inputString.Split("\n").ToList();
            Console.WriteLine($"Count is: {Functions.ExecuteReplaced(instructions)}");
        }
    }
}