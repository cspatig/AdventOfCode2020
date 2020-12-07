using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Channels;

namespace AdventOfCodeDay6Part1
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

            var groupAnsList = inputString.Split("\n\n").ToList();
            var sum = 0;
            
            foreach (var groupAns in groupAnsList)
            {
                var uniqueList = new List<char>();
                foreach (var character in groupAns)
                {
                    if (character != '\r' && character != '\n')
                    {
                        uniqueList.Add(character);
                    }
                }

                sum += uniqueList.Distinct().Count();
            }

            Console.WriteLine($"The sum is: {sum}");
        }
    }
}