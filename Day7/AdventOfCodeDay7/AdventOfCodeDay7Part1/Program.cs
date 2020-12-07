using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace AdventOfCodeDay7Part1
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

            var bagRules = inputString.Split(".\n");
            var bagMatches = InitialMatches(bagRules);

            var count = 0;

            while (bagMatches.Count != count)
            {
                var tempMatches = new List<string>();
                count = bagMatches.Count;
                foreach (var bagMatch in bagMatches)
                {
                    AddTempMatches(bagRules, bagMatch, tempMatches);
                }

                foreach (var bag in tempMatches)
                {
                    AddBagToMatches(bagMatches, bag);
                }
            }

            Console.WriteLine($"Count is: {bagMatches.Count}");
        }

        static void AddTempMatches(string[] bagRules, string bagMatch, List<string> tempMatches)
        {
            foreach (var bagRule in bagRules)
            {
                var bag = bagRule.Split(" contain ").First();
                bag = bag.Remove(bag.Length - 1, 1);
                var rule = bagRule.Split(" contain ").Last();
                if (rule.Contains(bagMatch))
                {
                    tempMatches.Add(bag);
                }
            }
        }

        static void AddBagToMatches(List<string> matchList, string bag)
        {
            if (!matchList.Contains(bag))
            {
                matchList.Add(bag);
            }
        }

        static List<string> InitialMatches(string[] bagRules)
        {
            var bagMatches = new List<string>();

            foreach (var bagRule in bagRules)
            {
                var bag = bagRule.Split(" contain ").First();
                bag = bag.Remove(bag.Length - 1, 1);
                var rules = bagRule.Split(" contain ").Last();
                if (rules.Contains("shiny gold bag"))
                {
                    bagMatches.Add(bag);
                }
            }

            return bagMatches;
        }
    }
}