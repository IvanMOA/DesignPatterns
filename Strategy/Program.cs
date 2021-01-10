using System;
using Characters;
using Weapons;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var k = new Knight();
            k.fight();
            k.setWeapon(new BowBehavior());
            k.fight();
            k.setWeapon(new KnifeBehavior());
            k.fight();
            k.setWeapon(new MageStaff());
            k.fight();
        }
    }

}
