using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCodeDay7Part2
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

            var bagRules = HelperFunctions.FillRules(inputString.Split(".\n"));
            var count = HelperFunctions.RecurseBagList("shiny gold bag", bagRules);
            Console.WriteLine($"count is: {count}");
        }
    }
}