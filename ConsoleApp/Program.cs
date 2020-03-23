using System;
using CSharpPlayground.Lib;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "好きな食べ物は𩸽（ほっけ）です。";
            Console.WriteLine(String.Format("text: {0}, Length: {1}, LengthInTextElements: {2}", text, text.Length, text.LengthInTextElements()));
        }
    }
}
