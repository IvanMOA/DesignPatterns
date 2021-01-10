using WeaponBehavior;
using System;
namespace Weapons {
    // Multiple weapons could be created by implementing IWeaponBehavior
    public class KnifeBehavior : IWeaponBehavior {
        public void useWeapon(){
            Console.WriteLine("Attacking with a KNIFE!!!");
        }
    }

    public class BowBehavior : IWeaponBehavior {
        public void useWeapon(){
            Console.WriteLine("Sending arrows into the sky with my BOW!!!");
        }
    }
    public class MageStaff : IWeaponBehavior {
        public void useWeapon(){
            Console.WriteLine("Launching firebolts with my STAFF!!!");
        }
    }
}