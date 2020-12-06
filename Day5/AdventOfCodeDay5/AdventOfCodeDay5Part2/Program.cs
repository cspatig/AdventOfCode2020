using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCodeDay5Part2
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

            var passList = inputString.Split("\n").ToList();
            var seatList = InitializeSeatList();

            FillSeatList(passList, seatList);

            PrintMySeat(seatList);
        }

        static void PrintMySeat(char[,] seatList)
        {
            for (int i = 0; i < 128; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (seatList[i, j] == '!')
                    {
                        if (j - 1 > 0 && seatList[i, j - 1] == '*' && j + 1 < 8 && seatList[i, j + 1] == '*')
                        {
                            Console.WriteLine($"Your seat ID is: {(i * 8) + j}");
                        }
                    }
                }
            }
        }

        static char[,] InitializeSeatList()
        {
            var seatList = new char[128, 8];
            for (int i = 0; i < 128; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    seatList[i, j] = '!';
                }
            }

            return seatList;
        }

        static void FillSeatList(List<string> passList, char[,] seatList)
        {
            foreach (var pass in passList)
            {
                var directions = pass.ToCharArray();
                var row = Enumerable.Range(0, 128).ToList();
                var col = Enumerable.Range(0, 8).ToList();
                foreach (var direction in directions)
                {
                    switch (direction)
                    {
                        case 'F':
                            row.RemoveRange((row.Count / 2), (row.Count / 2));
                            break;
                        case 'B':
                            row.RemoveRange(0, (row.Count / 2));
                            break;
                        case 'L':
                            col.RemoveRange((col.Count / 2), (col.Count / 2));
                            break;
                        case 'R':
                            col.RemoveRange(0, (col.Count / 2));
                            break;
                    }
                }

                seatList[row.First(), col.First()] = '*';
            }
        }
    }
}