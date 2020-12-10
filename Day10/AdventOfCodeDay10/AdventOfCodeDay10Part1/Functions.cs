using System;
using System.Collections.Generic;

namespace AdventOfCodeDay10Part1
{
    public class Functions
    {
        public static int Execute(List<int> joltList)
        {
            joltList.Sort();
            var ones = 0;
            var threes = 0;
            var prevJolt = 0;

            foreach (var adapter in joltList)
            {
                switch (adapter - prevJolt)
                {
                    case 1:
                        ones++;
                        prevJolt = adapter;
                        break;
                    case 3:
                        threes++;
                        prevJolt = adapter;
                        break;
                    default:
                        prevJolt = adapter;
                        break;
                }
            }

            threes++;

            return ones * threes;
        }
    }
}