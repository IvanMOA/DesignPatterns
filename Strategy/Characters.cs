using Character;
using System;
namespace Characters
{
    // More characters could be added
    public class Knight : ACharacter
    {
        public override void fight()
        {
            if (this.weapon != null)
            {
                this.weapon.useWeapon();
            }
            else
            {
                Console.WriteLine("I cannot fight without a weapon...");
            }
        }
    }
}