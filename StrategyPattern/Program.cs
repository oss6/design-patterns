using StrategyPattern.Characters;
using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Character knight = new Knight();
            Character troll = new Troll();

            knight.Fight();
            troll.Fight();

            Console.ReadKey();
        }
    }
}
