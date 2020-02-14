using System;
using System.Globalization;

namespace CSharpFormatSpecifier
{
    class Program
    {
        static void Main(string[] args)
        {
            var ci = new CultureInfo("en-US");
            var a = 1234;
            Console.WriteLine(a.ToString("C", ci));
            Console.WriteLine("done...");
        }
    }
}
