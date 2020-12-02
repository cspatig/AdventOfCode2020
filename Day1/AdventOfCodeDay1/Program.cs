using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCodeDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            var intString = "";
            try
            {
                using var sr = new StreamReader("input.txt");
                intString = sr.ReadToEnd();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            var intList = intString.Split(new[] {Environment.NewLine}, StringSplitOptions.None).Select(int.Parse).ToList();

            foreach (var integer1 in intList)
            {
                foreach (var integer2 in intList)
                {
                    foreach (var integer3 in intList)
                    {
                        if ((integer1 + integer2 + integer3).Equals(2020))
                        {
                            Console.WriteLine("integer 1: " + integer1);
                            Console.WriteLine("integer 2: " + integer2);
                            Console.WriteLine("integer 3: " + integer3);
                            Console.WriteLine("answer is: " + (integer1 * integer2 * integer3));
                        }
                    }
                }
            }

        }
    }
}