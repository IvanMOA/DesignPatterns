using WeaponBehavior;

namespace Character {

    public abstract class ACharacter {
        public IWeaponBehavior weapon;
        public void setWeapon(IWeaponBehavior weapon){
            this.weapon = weapon;
        }

        public abstract void fight();
    }
}