using System;
namespace TurkeyN {
    public interface ITurkey {
        void fly();
        void gobble();
    }

    public class PolarTurkey : ITurkey
    {
        public void fly()
        {
            Console.WriteLine("Moving my wings !");
        }

        public void gobble()
        {
            Console.WriteLine("GLOGLOGLO!");
        }
    }
}