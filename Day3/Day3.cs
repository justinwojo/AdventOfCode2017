using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    public static class Day3
    {
        public static string GetPart1Answer()
        {
            int input = 325489;
            var list = new List<Tuple<int, int>>();
            bool iterating = true;
            list.Add(new Tuple<int, int>(0, 0));
            int count = 1;
            bool isFirst = true;
            var holder = new Tuple<int, int>(0, 0);
            Direction next = Direction.Right;

            while(iterating)
            {
                if(next == Direction.Right)
                {
                    for(int i = 0; i<count; i++)
                    {
                        holder = new Tuple<int, int>(holder.Item1 + 1, holder.Item2);
                        list.Add(holder);

                        if (list.Count == input)
                        {
                            return ManhattanDistance(list[input-1].Item1, 0, list[input-1].Item2, 0).ToString();
                        }
                    }

                    if(isFirst)
                    {
                        isFirst = false;
                    }
                    else
                    {
                        count++;
                        isFirst = true;
                    }
                    next = Direction.Up;
                }
                else if (next == Direction.Up)
                {
                    for (int i = 0; i < count; i++)
                    {
                        holder = new Tuple<int, int>(holder.Item1, holder.Item2 + 1);
                        list.Add(holder);

                        if (list.Count == input)
                        {
                            return ManhattanDistance(list[input - 1].Item1, 0, list[input - 1].Item2, 0).ToString();
                        }
                    }

                    if (isFirst)
                    {
                        isFirst = false;
                    }
                    else
                    {
                        count++;
                        isFirst = true;
                    }
                    next = Direction.Left;
                }
                else if (next == Direction.Left)
                {
                    for (int i = 0; i < count; i++)
                    {
                        holder = new Tuple<int, int>(holder.Item1 - 1, holder.Item2);
                        list.Add(holder);

                        if (list.Count == input)
                        {
                            return ManhattanDistance(list[input - 1].Item1, 0, list[input - 1].Item2, 0).ToString();
                        }
                    }

                    if (isFirst)
                    {
                        isFirst = false;
                    }
                    else
                    {
                        count++;
                        isFirst = true;
                    }
                    next = Direction.Down;
                }
                else if(next == Direction.Down)
                {
                    for (int i = 0; i < count; i++)
                    {
                        holder = new Tuple<int, int>(holder.Item1, holder.Item2 - 1);
                        list.Add(holder);

                        if (list.Count == input)
                        {
                            return ManhattanDistance(list[input - 1].Item1, 0, list[input - 1].Item2, 0).ToString();
                        }
                    }

                    if (isFirst)
                    {
                        isFirst = false;
                    }
                    else
                    {
                        count++;
                        isFirst = true;
                    }
                    next = Direction.Right;
                }
            }

            return "";
        }

        private enum Direction
        {
            Right,
            Up,
            Left,
            Down
        }

        private static int ManhattanDistance(int x1, int x2, int y1, int y2)
        {
            return Math.Abs(x1 - x2) + Math.Abs(y1 - y2);
        }


        public static string GetPart2Answer()
        {
            int input = 325489;
            var list = new List<Tuple<int, int, int>>();
            bool iterating = true;
            list.Add(new Tuple<int, int, int>(0, 0, 1));
            int count = 1;
            bool isFirst = true;
            var holder = new Tuple<int, int, int>(0, 0, 1);
            Direction next = Direction.Right;

            while (iterating)
            {
                if (next == Direction.Right)
                {
                    for (int i = 0; i < count; i++)
                    {
                        holder = new Tuple<int, int, int>(holder.Item1 + 1, holder.Item2, 0);
                        list.Add(CalculateNext(list, holder));

                        if (list.Last().Item3 > input)
                        {
                            return list.Last().Item3.ToString();
                        }
                    }

                    if (isFirst)
                    {
                        isFirst = false;
                    }
                    else
                    {
                        count++;
                        isFirst = true;
                    }
                    next = Direction.Up;
                }
                else if (next == Direction.Up)
                {
                    for (int i = 0; i < count; i++)
                    {
                        holder = new Tuple<int, int, int>(holder.Item1, holder.Item2 + 1, 0);
                        list.Add(CalculateNext(list, holder));

                        if (list.Last().Item3 > input)
                        {
                            return list.Last().Item3.ToString();
                        }
                    }

                    if (isFirst)
                    {
                        isFirst = false;
                    }
                    else
                    {
                        count++;
                        isFirst = true;
                    }
                    next = Direction.Left;
                }
                else if (next == Direction.Left)
                {
                    for (int i = 0; i < count; i++)
                    {
                        holder = new Tuple<int, int, int>(holder.Item1 - 1, holder.Item2, 0);
                        list.Add(CalculateNext(list, holder));

                        if (list.Last().Item3 > input)
                        {
                            return list.Last().Item3.ToString();
                        }
                    }

                    if (isFirst)
                    {
                        isFirst = false;
                    }
                    else
                    {
                        count++;
                        isFirst = true;
                    }
                    next = Direction.Down;
                }
                else if (next == Direction.Down)
                {
                    for (int i = 0; i < count; i++)
                    {
                        holder = new Tuple<int, int, int>(holder.Item1, holder.Item2 - 1, 0);
                        list.Add(CalculateNext(list, holder));

                        if (list.Last().Item3 > input)
                        {
                            return list.Last().Item3.ToString();
                        }
                    }

                    if (isFirst)
                    {
                        isFirst = false;
                    }
                    else
                    {
                        count++;
                        isFirst = true;
                    }
                    next = Direction.Right;
                }
            }

            return "";
        }

        private static Tuple<int, int, int> CalculateNext(List<Tuple<int, int, int>> list, Tuple<int, int, int> coord)
        {
            int sum = 0;
            foreach(var tup in list)
            {
                if (tup.Item1 == coord.Item1 - 1 && tup.Item2 == coord.Item2 + 1) sum += tup.Item3;//up left
                if (tup.Item1 == coord.Item1 - 1 && tup.Item2 == coord.Item2) sum += tup.Item3;//left
                if (tup.Item1 == coord.Item1 - 1 && tup.Item2 == coord.Item2 - 1) sum += tup.Item3;//bottom left
                if (tup.Item1 == coord.Item1 && tup.Item2 == coord.Item2 - 1) sum += tup.Item3;//bottom center
                if (tup.Item1 == coord.Item1 + 1 && tup.Item2 == coord.Item2 - 1) sum += tup.Item3;//bottom right
                if (tup.Item1 == coord.Item1 + 1 && tup.Item2 == coord.Item2) sum += tup.Item3;//right
                if (tup.Item1 == coord.Item1 + 1 && tup.Item2 == coord.Item2 + 1) sum += tup.Item3;//up right
                if (tup.Item1 == coord.Item1 && tup.Item2 == coord.Item2 + 1) sum += tup.Item3;//up
            }

            return new Tuple<int, int, int>(coord.Item1, coord.Item2, sum);
        }
    }
}
