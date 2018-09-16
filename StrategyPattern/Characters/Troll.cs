using StrategyPattern.Behaviours;
using System;

namespace StrategyPattern.Characters
{
    public class Troll : Character
    {
        public Troll()
        {
            weapon = new KnifeBehaviour();
        }

        public override void Fight()
        {
            Console.WriteLine("Troll begin fight!");
            Console.WriteLine(weapon.UseWeapon());
        }
    }
}
