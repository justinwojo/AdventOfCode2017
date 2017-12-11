using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    class Day7
    {
        public static string GetPart1Answer()
        {
            var lines = File.ReadLines("Day7/day7input.txt");
            string store = "";
            bool searching = true;
            while (true)
            {
                searching = true;
                foreach (var line in lines)
                {
                    if (line.Contains("->"))
                    {
                        if (store == "") store = line.Substring(0, line.IndexOf("(")).Trim();
                        else
                        {
                            if (line.Substring(line.IndexOf("->") + 3).Contains(store))
                            {
                                store = line.Substring(0, line.IndexOf("(")).Trim();
                                searching = false;
                                break;
                            }
                        }
                    }
                }
                if (searching) return store;
            }
        }
        /*
pbga(66)
xhth(57)
ebii(61)
havc(66)
ktlj(57)
fwft(72) -> ktlj, cntj, xhth
qoyq(66)
padx(45) -> pbga, havc, qoyq
tknk(41) -> ugml, padx, fwft
jptl(61)
ugml(68) -> gyxo, ebii, jptl
gyxo(61)
cntj(57)
*/
        public static string GetPart2Answer()
        {
            var lines = File.ReadLines("Day7/day7input.txt");


            return "";
        }
    }
}
