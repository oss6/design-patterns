using System;
using StrategyPattern.Behaviours;

namespace StrategyPattern.Characters
{
    public class Knight : Character
    {
        public Knight()
        {
            weapon = new SwordBehaviour();
        }

        public override void Fight()
        {
            Console.WriteLine("Knight begin fight!");
            Console.WriteLine(weapon.UseWeapon());
        }
    }
}
