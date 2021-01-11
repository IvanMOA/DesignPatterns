using System;
using NewCodeN;
using OldCodeN;
using Adapter;

namespace EnumerableAndIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            NewCode nc = new NewCode("00001");
            OldCode oc = new OldCode(12);
            OldCodeAdapter oca = new OldCodeAdapter(oc);
            oca.printCode();
        }
    }
}
