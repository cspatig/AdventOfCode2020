using System;
using System.IO;
using System.Linq;

namespace AdventOfCodeDay10Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "";
            try
            {
                input = File.ReadAllText("input.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            var joltList = input.Split("\n").ToList().Select(x => int.Parse(x)).ToList();
            Console.WriteLine($"Result is: {Functions.Execute(joltList)}");
        }
    }
}