using NewCodeN;
using OldCodeN;
using System;
namespace Adapter
{
    public class OldCodeAdapter : INewCode
    {
        OldCode oldCode;
        public OldCodeAdapter(OldCode oldCode)
        {
            this.oldCode = oldCode;
        }

        public void printCode()
        {
            string oldCode = this.oldCode.code.ToString();
            Console.WriteLine(this.convertToNewFormat(oldCode));
        }

        private string convertToNewFormat(string codeToFormat)
        {
            string newCode = "";
            for (int i = codeToFormat.Length; i < 5; i++)
            {
            newCode += "0";
            }
            return newCode + codeToFormat;
        }
    }

}