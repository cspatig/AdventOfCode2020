using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCodeDay4Part2
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

            var passportList = inputString.Split("\n\n");

            var count = 0;

            foreach (var passport in passportList)
            {
                if (passport.Contains("byr") && passport.Contains("iyr") && passport.Contains("eyr") &&
                    passport.Contains("hgt")
                    && passport.Contains("hcl") && passport.Contains("ecl") && passport.Contains("pid"))
                {
                    var newPassport = passport.Replace("\n", " ").Replace("\r", " ").Split(" ");
                    if (isValidPassport(newPassport))
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine($"The count is: {count}");
        }

        static bool isValidPassport(string[] passport)
        {
            foreach (var field in passport)
            {
                var title = field.Split(":").First();
                var value = field.Split(":").Last();
                switch (title)
                {
                    case "byr":
                        if (!IsValidByr(value)) return false;
                        break;
                    case "iyr":
                        if (!IsValidIyr(value)) return false;
                        break;
                    case "eyr":
                        if (!IsValidEyr(value)) return false;
                        break;
                    case "hgt":
                        if (!IsValidHgt(value)) return false;
                        break;
                    case "hcl":
                        if (!IsValidHcl(value)) return false;
                        break;
                    case "ecl":
                        if (!IsValidEcl(value)) return false;
                        break;
                    case "pid":
                        if (!IsValidPid(value)) return false;
                        break;
                    case "cid":
                        break;
                }
            }

            return true;
        }

        static bool IsValidPid(string value)
        {
            var regex = new Regex(@"^([0-9]){9}$");
            if (!regex.IsMatch(value))
            {
                return false;
            }

            return true;
        }

        static bool IsValidEcl(string value)
        {
            var colorList = new List<string> {"amb", "blu", "brn", "gry", "grn", "hzl", "oth"};
            if (!colorList.Contains(value))
            {
                return false;
            }

            return true;
        }

        static bool IsValidHcl(string value)
        {
            var rgx = new Regex(@"^#([a-f0-9]){6}$");
            if (value.StartsWith("#"))
            {
                if (value.Length == 7)
                {
                    if (!rgx.IsMatch(value))
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

            return true;
        }

        static bool IsValidHgt(string value)
        {
            if (value.Contains("cm"))
            {
                var hgtValue = int.Parse(value.Replace("cm", ""));
                if (hgtValue < 150 || hgtValue > 193)
                {
                    return false;
                }
            }
            else if (value.Contains("in"))
            {
                var hgtValue = int.Parse(value.Replace("in", ""));
                if (hgtValue < 59 || hgtValue > 76)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

            return true;
        }

        static bool IsValidEyr(string value)
        {
            if (int.Parse(value) < 2020 || int.Parse(value) > 2030)
            {
                return false;
            }

            return true;
        }

        static bool IsValidIyr(string value)
        {
            if (int.Parse(value) < 2010 || int.Parse(value) > 2020)
            {
                return false;
            }

            return true;
        }

        static bool IsValidByr(string value)
        {
            if (int.Parse(value) < 1920 || int.Parse(value) > 2002)
            {
                return false;
            }

            return true;
        }
    }
}