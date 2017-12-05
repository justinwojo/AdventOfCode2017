using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    public static class Day5
    {
        public static string GetPart1Answer()
        {
            var lines = File.ReadLines("Day5/day5input.txt").ToArray();
            var steps = 0;
            int current = 0;
            
            while(true)
            {
                if (current < 0 || current > (lines.Count() - 1)) break;

                var number = int.Parse(lines[current]);
                lines[current] = (number+1).ToString();
                current += number;
                steps++;
            }

            return steps.ToString();
        }

        public static string GetPart2Answer()
        {
            var lines = File.ReadLines("Day5/day5input.txt").ToArray();
            var steps = 0;
            int current = 0;

            while (true)
            {
                if (current < 0 || current > (lines.Count() - 1)) break;

                var number = int.Parse(lines[current]);
                lines[current] = number > 2 ? (number - 1).ToString() : (number + 1).ToString();
                current += number;
                steps++;
            }

            return steps.ToString();
        }
    }
}
