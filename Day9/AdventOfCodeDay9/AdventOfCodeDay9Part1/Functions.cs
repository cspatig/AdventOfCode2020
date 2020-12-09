using System.Collections.Generic;

namespace AdventOfCodeDay9Part1
{
    public class Functions
    {
        public static long findValue(List<long> intList, int preamble)
        {
            for (var index = preamble; index < intList.Count; index++)
            {
                var value = intList[index];
                
                var subList = new List<long>();
                intList.ForEach(x => subList.Add(x));
                subList = subList.GetRange(index - preamble, preamble);
                
                var subListSums = getSums(subList);
                if (!subListSums.Contains(value))
                {
                    return value;
                }
            }

            return 0;
        }

        public static List<long> getSums(List<long> intList)
        {
            var sumList = new List<long>();
            foreach (var value in intList)
            {
                var newList = new List<long>();
                intList.ForEach(x => newList.Add(x));
                newList.Remove(value);
                foreach (var value2 in newList)
                {
                    var sum = value + value2;
                    if (!sumList.Contains(sum))
                    {
                        sumList.Add(sum);
                    }
                }
            }
            return sumList;
        }
    }
}