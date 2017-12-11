using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    class Day8
    {
        public static string GetPart1Answer()
        {
            var lines = File.ReadLines("Day8/day8input.txt");
            foreach(var line in lines)
            {
                if (ExpressionTrue(line.Substring(line.IndexOf("if") + 3)))
                {
                    Perform(line.Substring(0, line.IndexOf(" if")));
                }
            }

            return list.Values.Max().ToString();
        }

        private static bool ExpressionTrue(string exp)
        {
            int value = 0;
            list.TryGetValue(exp.Substring(0, exp.IndexOf(" ")), out value);
            string temp = exp.Substring(exp.IndexOf(" ") + 1);
            string compare = temp.Substring(0, temp.IndexOf(" "));
            int num = int.Parse(exp.Substring(exp.LastIndexOf(" ") + 1));
            switch(compare)
            {
                case ("<="): return value <= num;
                case (">="): return value >= num;
                case ("=="): return value == num;
                case ("!="): return value != num;
                case ("<"): return value < num;
                case (">"): return value > num;
                default: return false;
            }
        }

        private static void Perform(string what)
        {
            string registry = what.Substring(0, what.IndexOf(" "));
            string incdec = what.Substring(what.IndexOf(" ") + 1, 3);
            int num = int.Parse(what.Substring(what.LastIndexOf(" ") + 1));
            if (incdec == "dec") num *= -1;
            if (list.ContainsKey(registry))
            {
                list[registry] += num;
            }
            else
            {
                list.Add(registry, num);
            }

            if (list[registry] > highest) highest = list[registry];
        }

        private static Dictionary<string, int> list = new Dictionary<string, int>();
        private static int highest = 0;

        public static string GetPart2Answer()
        {//must run part 1 first
            return highest.ToString();
        }
    }
}
