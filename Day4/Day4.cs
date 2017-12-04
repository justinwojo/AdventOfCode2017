using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    class Day4
    {
        public static string GetPart1Answer()
        {
            var lines = File.ReadLines("Day4/day4input.txt");
            var sum = 0;
            var list = new List<string>();
            bool valid = true;
            foreach (var line in lines)
            {
                var split = line.Split(' ');

                foreach(var code in split)
                {
                    if(list.Contains(code))
                    {
                        valid = false;
                        break;
                    }
                    else
                    {
                        list.Add(code);
                    }
                }

                list.Clear();
                sum += valid ? 1 : 0;
                valid = true;
            }
            return sum.ToString();
        }

        public static string GetPart2Answer()
        {
            var lines = File.ReadLines("Day4/day4input.txt");
            var sum = 0;
            var list = new List<string>();
            bool valid = true;
            foreach (var line in lines)
            {
                var split = line.Split(' ');

                foreach (var code in split)
                {
                    var ordered = String.Concat(code.OrderBy(c => c));
                    if (list.Contains(ordered))
                    {
                        valid = false;
                        break;
                    }
                    else
                    {
                        list.Add(ordered);
                    }
                }

                list.Clear();
                sum += valid ? 1 : 0;
                valid = true;
            }
            return sum.ToString();
        }
    }
}
