using System;
namespace DuckN {
    public interface IDuck {
        void fly();
        void quack();
    }

    public class MallardDuck : IDuck
    {
        public void fly()
        {
            Console.WriteLine("Flying like a duck !");
        }

        public void quack()
        {
            Console.WriteLine("QUACK!");
        }
    }
}