using System.Collections.Generic;
using System.Linq;

namespace AdventOfCodeDay8Part1
{
    public class Functions
    {
        public static int Execute(List<string> input)
        {
            var cont = true;
            var index = 0;
            var found = new List<int>();
            var acc = 0;

            while (cont)
            {
                if (found.Contains(index))
                {
                    cont = false;
                    break;
                }
                found.Add(index);
                var cmd = input[index].Split(" ").First();
                var amount = input[index].Split(" ").Last();
                
                switch (cmd)
                {
                    case "nop":
                        index++;
                        break;
                    case "acc":
                        if (amount.First() == '+')
                        {
                            acc += int.Parse(amount.Remove(0, 1));
                        }
                        else
                        {
                            acc -= int.Parse(amount.Remove(0, 1));
                        }
                        index++;
                        break;
                    case "jmp":
                        if (amount.First() == '+')
                        {
                            index += int.Parse(amount.Remove(0, 1));
                        }
                        else
                        {
                            index -= int.Parse(amount.Remove(0, 1));
                        }
                        break;
                }
            }

            return acc;
        }
    }
}