using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    public static class Day2
    {
        public static string GetPart1Answer()
        {
            var lines = File.ReadLines("Day2/day2input.txt");
            var sum = 0;
            foreach(var line in lines)
            {
                var split = line.Split('\t').OrderBy(num => Convert.ToInt32(num));
                
                sum += Convert.ToInt32(split.Last()) - Convert.ToInt32(split.First());
            }
            return sum.ToString();
        }

        public static string GetPart2Answer()
        {
            var lines = File.ReadLines("Day2/day2input.txt");
            var sum = 0;
            foreach (var line in lines)
            {
                string[] split = line.Split('\t');
                for (int i = 0; i < split.Length - 1; i++)
                {
                    for (int j = i + 1; j < split.Length; j++)
                    {
                        int first = Convert.ToInt32(split[i]);
                        int second = Convert.ToInt32(split[j]);
                        if (IsDivisible(first, second))
                        {
                            sum += first < second ? second / first : first / second;
                            break;
                        }
                    }
                }
            }
            return sum.ToString();
        }

        private static bool IsDivisible(int x, int n)
        {
            return(x % n == 0 || n % x == 0);
        }
    }
}
