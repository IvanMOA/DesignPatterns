using DuckN;
using TurkeyN;

namespace TurkeyAdapterN
{
    public class TurkeyAdapter : IDuck
    {
        ITurkey turkey;
        public TurkeyAdapter(ITurkey turkey)
        {
            this.turkey = turkey;
        }

        public void fly()
        {
            for (int i = 0; i < 5; i++)
            {
                this.turkey.fly();
            }
        }

        public void quack()
        {
            this.turkey.gobble();
        }
    }
}