using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDictionary;

namespace Morse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryDictionary.Morse n = new LibraryDictionary.Morse();
            string res = n.ToMorse("Hello my name is hello world");
            n.Print(res);
            string res1 = n.ToString("...._._.-.._.-.._---___--_-.--___-._.-_--_.___.._...___...._._.-.._.-.._---___.--_---_.-._.-.._-..");
            n.Print(res1);
        }
    }
}
