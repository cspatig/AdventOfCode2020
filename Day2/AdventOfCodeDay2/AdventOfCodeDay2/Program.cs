using System;
using System.IO;
using System.Linq;

namespace AdventOfCodeDay2
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
                var upperLimit = int.Parse(item.Split(':').First().Split(' ').First().Split('-').Last());
                var lowerLimit = int.Parse(item.Split(':').First().Split(' ').First().Split('-').First());
                var charCount = password.Count(x => x == charReq);
                if (charCount <= upperLimit && charCount >= lowerLimit)
                {
                    count++;
                }
            }

            Console.WriteLine($"The count is: {count}");
        }
    }
}