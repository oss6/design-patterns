using StrategyPattern.Behaviours;

namespace StrategyPattern.Characters
{
    public abstract class Character
    {
        protected WeaponBehaviour weapon;

        public void SetWeapon(WeaponBehaviour weapon)
        {
            this.weapon = weapon;
        }

        public abstract void Fight();
    }
}
