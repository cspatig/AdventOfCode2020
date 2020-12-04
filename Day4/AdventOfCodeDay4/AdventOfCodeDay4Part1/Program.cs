using System;
using System.IO;

namespace AdventOfCodeDay4Part1
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

            var passportList = inputString.Split("\n\n");

            var count = 0;

            foreach (var passport in passportList)
            {
                if (passport.Contains("byr") && passport.Contains("iyr") && passport.Contains("eyr") &&
                    passport.Contains("hgt")
                    && passport.Contains("hcl") && passport.Contains("ecl") && passport.Contains("pid"))
                {
                    count++;
                }
            }

            Console.WriteLine($"The count is: {count}");
        }
    }
}