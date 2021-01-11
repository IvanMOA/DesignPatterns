using System;
namespace NewCodeN {

    public interface INewCode{
        void printCode();
    }

    // The new format for codes is:
    // 00001 or 00012 or 00311 (Yeah, 99999 is the limit)
    public class NewCode : INewCode {
        public string code ;
        public NewCode(string code){
            this.code = code;
        }

        public void printCode(){
            Console.WriteLine(this.code);
        }
    }
}