using System.Collections.Generic;
using System.Linq;

namespace AdventOfCodeDay9Part2
{
    public class Functions
    {
        public static long sumSmallLarge(List<long> longList)
        {
            return longList.Min() + longList.Max();
        }
        
        public static List<long> compute(List<long> longList, long target)
        {
            for (var index = 0; index < longList.Count; index++)
            {
                var sumList = subCompute(longList, index, target);
                if (sumList.Count > 0)
                {
                    return sumList;
                }            
            }

            return new List<long>();
        }

        public static List<long> subCompute(List<long> longList, int index, long target)
        {
            long sum = 0;
            var result = new List<long>();
            for (var i = index; i < longList.Count; i++)
            {
                sum += longList[i];
                result.Add(longList[i]);
                if (sum > target)
                {
                    break;
                }
                else if (sum == target)
                {
                    return result;
                }
            }
            
            return new List<long>();
        }
    }
}