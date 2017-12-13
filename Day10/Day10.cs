using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    class Day10
    {
        public static string GetPart1Answer()
        {
            var input = Array.ConvertAll(File.ReadLines("Day10/day10input.txt").First().Split(','), int.Parse);
            var list = GenerateList(256);
            int skipSize = 0;
            int pointer = 0;

            foreach(var lengths in input)
            {
                //for(int i=pointer; i<)
            }

            return "";
        }

        private static List<int> GenerateList(int length)
        {
            var list = new List<int>();
            for(int i=0; i<length; i++)
            {
                list.Add(i);
            }
            return list;
        }

        public static string GetPart2Answer()
        {
            var lines = File.ReadLines("Day10/day10input.txt");


            return "";
        }
    }
}
