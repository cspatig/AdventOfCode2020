using System.Collections.Generic;
using System.Linq;

namespace AdventOfCodeDay8Part2
{
    public class Functions
    {
        public static int Execute(List<string> input)
        {
            var index = 0;
            var found = new List<int>();
            var acc = 0;

            while (true)
            {
                if (found.Contains(index))
                {
                    acc = 0;
                    break;
                } 
                else if (index > input.Count - 1)
                {
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
        
        public static int ExecuteReplaced(List<string> input)
        {
            for (var index = 0; index < input.Count; index++)
            {
                var newInput = new List<string>();
                input.ForEach(item => newInput.Add(item));
                var instruction = input[index];
                if (instruction.Split(" ").First() == "jmp")
                {
                    newInput[index] = newInput[index].Replace("jmp", "nop");
                }
                else if (instruction.Split(" ").First() == "nop")
                {
                    newInput[index] = newInput[index].Replace("nop", "jmp");
                }

                var result = Execute(newInput);
                if (result > 0)
                {
                    return result;
                }
            }

            return 0;
        }
    }
}