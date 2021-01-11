using System;
using DuckN;
using TurkeyN;
using TurkeyAdapterN;

namespace DuckTurkeyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck md = new MallardDuck();
            PolarTurkey pt = new PolarTurkey();
            TurkeyAdapter disguisedTurkey = new TurkeyAdapter(pt);
            TestDuck(md);
            TestDuck(disguisedTurkey);
        }

        public static void TestDuck(IDuck duck){
            duck.fly();
            duck.quack();
        }
    }
}
