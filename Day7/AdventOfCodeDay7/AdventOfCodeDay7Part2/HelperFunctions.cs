using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCodeDay7Part2
{
    public class HelperFunctions
    {
        public static Dictionary<string, List<string>> FillRules(string[] bagRules)
        {
            var bagList = new Dictionary<string, List<string>>();

            foreach (var bagRule in bagRules)
            {
                var bag = bagRule.Split("s contain ").First();
                var rules = bagRule.Split("s contain ").Last().Split(", ").ToList();
                rules = RemovePlurals(rules);
                bagList.Add(bag, rules);
            }

            return bagList;
        }
        
        public static List<string> RemovePlurals(List<string> rules)
        {
            var tempRules = rules;
            for (var index = 0; index < rules.Count; index++)
            {
                var rule = rules[index];
                if (rule[rule.Length - 1] == 's')
                {
                    tempRules[index] = rule.Remove(rule.Length - 1, 1);
                }
            }

            return tempRules;
        }
        
        public static long RecurseBagList(string match, Dictionary<string, List<string>> bagRules)
        {
            var rulesToRecurse = bagRules.Where(x => x.Key == match).SelectMany(y => y.Value).ToList();
            long count = 0;
            foreach (var rule in rulesToRecurse)
            {
                if (rule.Contains("no other bag"))
                {
                    return 0;
                }

                var amount = (int) Char.GetNumericValue(rule[0]);
                var name = rule.Split($"{amount} ").Last();
                count += amount + amount * RecurseBagList(name, bagRules);
            }

            return count;
        }
    }
}