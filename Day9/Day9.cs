using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    class Day9
    {
        public static string GetPart1Answer()
        {
            var lines = File.ReadLines("Day9/day9input.txt");
            bool inGroup = false;
            int nestedLevel = 0;
            bool shouldSkip = false;
            bool takingOutTheTrash = false;
            int score = 0;
            foreach (var c in lines.First())
            {
                if (c == '{' && !inGroup)
                {
                    inGroup = true;
                    nestedLevel++;
                    continue;
                }
                if (inGroup && !shouldSkip)
                {
                    if(takingOutTheTrash)
                    {
                        if (c == '!') shouldSkip = true;
                        else if (c == '>') takingOutTheTrash = false;
                        continue;
                    }
                    else
                    {
                        switch (c)
                        {
                            case ('{'): nestedLevel++; continue;
                            case ('}'):
                                if (nestedLevel - 1 == 0)
                                {
                                    nestedLevel--;
                                    inGroup = false;
                                    score++;
                                    continue;
                                }
                                else
                                {
                                    score += nestedLevel;
                                    nestedLevel--;
                                    continue;
                                }
                            case ('<'): if (!takingOutTheTrash) takingOutTheTrash = true; continue;
                            case ('!'): shouldSkip = true; continue;
                            default: break;
                        }
                    }
                }
                else if (inGroup && shouldSkip) shouldSkip = false;
            }

            return score.ToString();
        }

        public static string GetPart2Answer()
        {
            var lines = File.ReadLines("Day9/day9input.txt");
            bool shouldSkip = false;
            bool takingOutTheTrash = false;
            int garbageCount = 0;
            foreach (var c in lines.First())
            {
                if (!shouldSkip)
                {
                    if (takingOutTheTrash)
                    {
                        if (c == '!')
                        {
                            shouldSkip = true;
                            continue;
                        }
                        else if (c == '>')
                        {
                            takingOutTheTrash = false;
                            continue;
                        }
                        garbageCount++;
                    }
                    else if (c == '<') takingOutTheTrash = true; 
                }
                else if (shouldSkip) shouldSkip = false;
            }

            return garbageCount.ToString();
        }
    }
}
