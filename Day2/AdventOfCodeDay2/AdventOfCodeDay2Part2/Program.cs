using System;
using System.IO;
using System.Linq;

namespace AdventOfCodeDay2Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputString = "";
            try
            {
                using var sr = new StreamReader("input.txt");
                inputString = sr.ReadToEnd();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
            var stringList = inputString.Split(new[] {Environment.NewLine}, StringSplitOptions.None);
            var count = 0;
            
            foreach (var item in stringList)
            {
                var password = item.Split(':').Last();
                var charReq = item.Split(':').First().Split(' ').Last().ToCharArray().First();
                var indexOne = int.Parse(item.Split(':').First().Split(' ').First().Split('-').Last());
                var indexTwo = int.Parse(item.Split(':').First().Split(' ').First().Split('-').First());
                var indexOneFound = password[indexOne] == charReq;
                var indexTwoFound = password[indexTwo] == charReq;
                if (indexOneFound ^ indexTwoFound)
                {
                    count++;
                }
            }

            Console.WriteLine($"The count is: {count}");
        }
    }
}