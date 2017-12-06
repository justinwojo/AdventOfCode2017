using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    public static class Day6
    {
        public static string GetPart1Answer()
        {
            var lines = File.ReadLines("Day6/day6input.txt");
            var split = Array.ConvertAll(lines.First().Split('\t'), int.Parse);
            var steps = 0;
            var list = new List<int[]>();
            list.Add((int[])split.Clone());

            while (true)
            {
                int current = split.Max();
                int index = Array.IndexOf(split, current);
                split[index] = 0;
                var start = index == (split.Length-1) ? 0 : index+1;

                for(int i = start; i<split.Length; i++)
                {
                    if (current == 0) break;
                    split[i]++;
                    current--;
                    if (i == split.Length - 1) i = -1;
                }
                steps++;
                if(list.Any(p => p.SequenceEqual(split)))
                {
                    return steps.ToString();
                }
                else
                {
                    list.Add((int[])split.Clone());
                }
            }
        }

        public static string GetPart2Answer()
        {
            var lines = File.ReadLines("Day6/day6input.txt");
            var split = Array.ConvertAll(lines.First().Split('\t'), int.Parse);
            var steps = 0;
            var list = new List<int[]>();
            list.Add((int[])split.Clone());

            while (true)
            {
                int current = split.Max();
                int index = Array.IndexOf(split, current);
                split[index] = 0;
                var start = index == (split.Length - 1) ? 0 : index + 1;

                for (int i = start; i < split.Length; i++)
                {
                    if (current == 0) break;
                    split[i]++;
                    current--;
                    if (i == split.Length - 1) i = -1;
                }
                steps++;
                if (list.Any(p => p.SequenceEqual(split)))
                {
                    return (list.Count - list.FindIndex(x => x.SequenceEqual(split))).ToString();
                }
                else
                {
                    list.Add((int[])split.Clone());
                }
            }
        }
    }
}
