using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    class AdventMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("D1P1 Answer: " + Day1.GetPart1Answer());
            Console.WriteLine("D1P2 Answer: " + Day1.GetPart2Answer());

            Console.WriteLine("D2P1 Answer: " + Day2.GetPart1Answer());
            Console.WriteLine("D2P2 Answer: " + Day2.GetPart2Answer());

            Console.Read();
        }
    }
}
