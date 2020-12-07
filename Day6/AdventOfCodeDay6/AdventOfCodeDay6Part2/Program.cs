using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCodeDay6Part2
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
                var group = groupAns.Split("\n").ToList();
                foreach (var character in group.First())
                {
                    var isFound = true;
                    foreach (var member in group)
                    {
                        if (!member.Contains(character))
                        {
                            isFound = false;
                        }
                    }

                    if (isFound)
                    {
                        sum++;
                    }
                }
            }

            Console.WriteLine($"The sum is: {sum}");
        }
    }
}