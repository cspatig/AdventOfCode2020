using System;
using System.IO;
using System.Linq;

namespace AdventOfCodeDay9Part1
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
            
            var longList = inputString.Split("\n").ToList().Select(x => long.Parse(x)).ToList();
            Console.WriteLine($"Value is: {Functions.findValue(longList, 25)}");
        }
    }
}