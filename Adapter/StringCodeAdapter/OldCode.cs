using System;
namespace OldCodeN
{

    public interface IOldCodeGenerator
    {
        void printCode();
    }

    // A code represented in the old way would look like this: 
    // 1 or 12 or 311
    public class OldCode : IOldCodeGenerator
    {
        public int code;
        public OldCode(int code)
        {
            this.code = code;
        }
        public void printCode(){
            Console.WriteLine(this.code);
        }
    }
}