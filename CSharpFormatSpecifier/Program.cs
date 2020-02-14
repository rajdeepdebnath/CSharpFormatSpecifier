using System;
using System.Globalization;

namespace CSharpFormatSpecifier
{
    class Program
    {
        static void Main(string[] args)
        {
            var ci = new CultureInfo("en-GB");
            var a = 1234.567;
            Console.WriteLine(a.ToString("C4", ci));
            Console.WriteLine(a.ToString("C0", ci));
            Console.WriteLine(a.ToString("C1", ci));
            Console.WriteLine(a.ToString("C3", ci));


            a = 3236;
            Console.WriteLine(a.ToString("E"));
            Console.WriteLine(a.ToString("E1"));
            Console.WriteLine(a.ToString("E3"));
            Console.WriteLine("done...");
        }
    }
}
