using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    public static class Day1
    {
        public static string GetPart1Answer()
        {
            var line = File.ReadLines("Day1/day1input.txt").First();
            char holder = '0';
            int sum = 0;
            foreach(var c in line)
            {
                if(holder == '0')
                {
                    holder = c;
                    continue;
                }

                if(holder == c) sum += Convert.ToInt32(holder.ToString());

                holder = c;
            }

            if(holder == line[0]) sum += Convert.ToInt32(holder.ToString());

            return sum.ToString();
        }
        
        public static string GetPart2Answer()
        {
            var line = File.ReadLines("Day1/day1input.txt").First();
            int sum = 0;
            var half = line.Length / 2;

            for(int i=0; i<line.Length; i++)
            {
                int circular = i + half >= line.Length ? (half - (line.Length - i)) : i + half;
                if(line[i] == line[circular])
                {
                    sum += Convert.ToInt32(line[i].ToString());
                }
            }

            return sum.ToString();
        }
    }
}
